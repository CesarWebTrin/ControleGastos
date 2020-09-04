namespace ControleGastos.Report
{
    partial class frmRelMensal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lancamentoanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosDataSet = new ControleGastos.gastosDataSet();
            this.entradaValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosDataSet1 = new ControleGastos.gastosDataSet();
            this.saidaValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaValorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.entradaValorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentoTableAdapter = new ControleGastos.gastosDataSetTableAdapters.lancamentoTableAdapter();
            this.lancamento_anoTableAdapter = new ControleGastos.gastosDataSetTableAdapters.lancamento_anoTableAdapter();
            this.entradaValorTableAdapter = new ControleGastos.gastosDataSetTableAdapters.entradaValorTableAdapter();
            this.saidaValorTableAdapter = new ControleGastos.gastosDataSetTableAdapters.saidaValorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaValorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lancamentoanoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.entradaValorBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.saidaValorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleGastos.Report.RelMensal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(778, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(82, 20);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 22;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.SelectionChangeCommitted += new System.EventHandler(this.cbMes_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mês:";
            // 
            // lancamentoanoBindingSource
            // 
            this.lancamentoanoBindingSource.DataMember = "lancamento_ano";
            this.lancamentoanoBindingSource.DataSource = this.gastosDataSet;
            // 
            // gastosDataSet
            // 
            this.gastosDataSet.DataSetName = "gastosDataSet";
            this.gastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradaValorBindingSource
            // 
            this.entradaValorBindingSource.DataMember = "entradaValor";
            this.entradaValorBindingSource.DataSource = this.gastosDataSet1;
            // 
            // gastosDataSet1
            // 
            this.gastosDataSet1.DataSetName = "gastosDataSet";
            this.gastosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saidaValorBindingSource
            // 
            this.saidaValorBindingSource.DataMember = "saidaValor";
            this.saidaValorBindingSource.DataSource = this.gastosDataSet;
            // 
            // entradaValorBindingSource3
            // 
            this.entradaValorBindingSource3.DataMember = "entradaValor";
            this.entradaValorBindingSource3.DataSource = this.gastosDataSet;
            // 
            // entradaValorBindingSource2
            // 
            this.entradaValorBindingSource2.DataMember = "entradaValor";
            this.entradaValorBindingSource2.DataSource = this.gastosDataSet;
            this.entradaValorBindingSource2.CurrentChanged += new System.EventHandler(this.entradaValorBindingSource2_CurrentChanged);
            // 
            // lancamentoBindingSource
            // 
            this.lancamentoBindingSource.DataMember = "lancamento";
            this.lancamentoBindingSource.DataSource = this.gastosDataSet;
            // 
            // lancamentoTableAdapter
            // 
            this.lancamentoTableAdapter.ClearBeforeFill = true;
            // 
            // lancamento_anoTableAdapter
            // 
            this.lancamento_anoTableAdapter.ClearBeforeFill = true;
            // 
            // entradaValorTableAdapter
            // 
            this.entradaValorTableAdapter.ClearBeforeFill = true;
            // 
            // saidaValorTableAdapter
            // 
            this.saidaValorTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 425);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelMensal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRelMensal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaValorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private gastosDataSet gastosDataSet;
        private System.Windows.Forms.BindingSource lancamentoBindingSource;
        private gastosDataSetTableAdapters.lancamentoTableAdapter lancamentoTableAdapter;
        private System.Windows.Forms.BindingSource lancamentoanoBindingSource;
        private gastosDataSetTableAdapters.lancamento_anoTableAdapter lancamento_anoTableAdapter;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label4;
        private gastosDataSet gastosDataSet1;
        private System.Windows.Forms.BindingSource entradaValorBindingSource;
        private System.Windows.Forms.BindingSource entradaValorBindingSource2;
        private System.Windows.Forms.BindingSource entradaValorBindingSource3;
        private gastosDataSetTableAdapters.entradaValorTableAdapter entradaValorTableAdapter;
        private System.Windows.Forms.BindingSource saidaValorBindingSource;
        private gastosDataSetTableAdapters.saidaValorTableAdapter saidaValorTableAdapter;
    }
}