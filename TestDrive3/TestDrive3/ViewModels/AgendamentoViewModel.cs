using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive3.Models;

namespace TestDrive3.ViewModels
{
    public class AgendamentoViewModel
    {

        public Agendamento Agendamento { get; set; }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.Agendamento.Veiculo = veiculo;
            this.Agendamento.Usuario = new Usuario();
        }

    }
}
