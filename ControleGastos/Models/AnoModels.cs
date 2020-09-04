using ControleGastos.Controllers;
using ControleGastos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Models
{
    public class AnoModels

    {
        public static int Inserir(Anos obj)
        {
            return new AnoController().Inserir(obj);
        }

        public static int Editar(Anos obj)
        {
            return new AnoController().Editar(obj);
        }

        public static int Deletar(Anos obj)
        {
            return new AnoController().Deletar(obj);
        }

        public List<Anos> Buscar(Anos obj)
        {
            return new AnoController().Buscar(obj);
        }

        public List<Anos> Listar()
        {
            return new AnoController().Listar();
        }
    }
}
