using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive3.Models;
using Xamarin.Forms;

namespace TestDrive3.ViewModels
{
    class ListagemViewModel
    {

        public List<Veiculo> Veiculos { get; set; }

        private Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if (value != null)
                {
                    MessagingCenter.Send<Veiculo>(value, "VeiculoSelecionado");
                }
            }
        }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }

    }
}
