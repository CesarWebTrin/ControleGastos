using ControleGastos.Entidades;
using ControleGastos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos.View
{
    public partial class frmCadLanc : Form
    {

        Lancamentos obj = new Lancamentos();

        AnoModels modelA = new AnoModels();
        public frmCadLanc()
        {
            InitializeComponent();
            PreencherCB();

            dt.Value = DateTime.Now;            

            DesabilitarCampos();
            btnSalvar.Enabled = false;

            Listar();
            totalizar();
        }

        private void DesabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbTipo.Enabled = false;
            cbMes.Enabled = false;
            cbAno.Enabled = false;
            dt.Enabled = false;

        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbTipo.Enabled = true;
            cbMes.Enabled = true;
            cbAno.Enabled = true;
            dt.Enabled = true;

        }

        private void LimparCampos()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cbBuscarTipo.Text = ""; 
        }

        private void PreencherCB()
        {
            cbAno.DataSource = modelA.Listar();
            cbAno.ValueMember = "id_ano";
            cbAno.DisplayMember = "ano";
        }

        private void frmCadLanc_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbBuscarTipo_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Visible = false;
            cbBuscarTipo.Visible = true;

            
        }

        private void rbBuscarData_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Value = DateTime.Now;
            dtBuscar.Visible = true;
            dtBuscar.Enabled = true;
            cbBuscarTipo.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira um ano");
                return;
            }

            Salvar();
            LimparCampos();
            btnSalvar.Enabled = false;
            Listar();
            totalizar();
        }

        private void Salvar()
        {
            try
            {

                obj.Tipo = cbTipo.Text;
                obj.Descricao = txtDescricao.Text;
                obj.Valor = Convert.ToDecimal(txtValor.Text);
                obj.Mes = cbMes.Text;
                obj.Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.Data = Convert.ToDateTime(dt.Text);
                int x = LancModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Inserido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Inserido" + ex);
            }
        }

        private void Listar()
        {
            try
            {
                List<Lancamentos> lista = new List<Lancamentos>();
                lista = new LancModel().Listar();

                dg.DataSource = lista;
                dg.Columns[0].Visible = false;
                dg.Columns[4].Visible = false;
                dg.Columns[5].Visible = false;
                dg.Columns[1].HeaderText = "Tipo";
                dg.Columns[2].HeaderText = "Descrição";
                dg.Columns[3].HeaderText = "Valor";            
                dg.Columns[6].HeaderText = "Data";

                dg.Columns[2].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Insira um ano");
                return;
            }

            editar();
            LimparCampos();
            btnEditar.Enabled = true;
            Listar();
            totalizar();
        }

        private void editar()
        {
            try
            {

                obj.Tipo = cbTipo.Text;
                obj.Descricao = txtDescricao.Text;
                obj.Valor = Convert.ToDecimal(txtValor.Text);
                obj.Mes = cbMes.Text;
                obj.Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.Data = Convert.ToDateTime(dt.Text);
                obj.Id_lancamento = Convert.ToInt32(txtId.Text);
                int x = LancModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Editado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Inserido" + ex);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            txtId.Text = dg.CurrentRow.Cells[0].Value.ToString();
            cbTipo.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dg.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dg.CurrentRow.Cells[3].Value.ToString();
            cbMes.Text = dg.CurrentRow.Cells[4].Value.ToString();
            cbAno.SelectedItem = dg.CurrentRow.Cells[5].Value.ToString();
            dt.Text = dg.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir");
                return;
            }

            excluir();
            DesabilitarCampos();
            LimparCampos();
            Listar();

            totalizar();
        }

        private void excluir()
        {
            try
            {

                obj.Id_lancamento = Convert.ToInt32(txtId.Text);
                int x = LancModel.Deletar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Excluído com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Excluído");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Excluído" + ex);
            }
        }

        private void cbBuscarTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cbBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {            

            obj.Tipo = cbBuscarTipo.Text;
            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancModel().BuscarTipo(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;

            totalizar();
        }

        private void dtBuscar_ValueChanged(object sender, EventArgs e)
        {
            obj.Data = Convert.ToDateTime(dtBuscar.Text);
            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancModel().Buscar(obj);
            dg.AutoGenerateColumns = false;
            dg.DataSource = lista;

            totalizar();
        }

        private void totalizar()
        {
            lblTotal.Text = valorTotal().ToString();
            if (Convert.ToDecimal(lblTotal.Text) < 0)
            {
                lblTotal.ForeColor = Color.Red;
            }
            else
            {
                lblTotal.ForeColor = Color.Green;
            }
        }

        private decimal valorTotal()
        {
            decimal total = 0;
            decimal totalEntrada = 0;
            decimal totalSaida = 0;

            int i = 0;
            for(i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Cells[1].Value.ToString() == "Entrada")
                {
                    totalEntrada = totalEntrada + Convert.ToDecimal(dg.Rows[i].Cells[3].Value);
                } 
                else
                {
                    totalSaida = totalSaida + Convert.ToDecimal(dg.Rows[i].Cells[3].Value);
                }
            }
            return totalEntrada - totalSaida;
        }
    }
}
