using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestDrive3.Models;
using Xamarin.Forms;

namespace TestDrive3.ViewModels
{
    public class AgendamentoViewModel
    {

        public Agendamento Agendamento { get; set; }
        public ICommand AgendarCommand { get; set; }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.Agendamento = new Agendamento();
            this.Agendamento.Veiculo = veiculo;
            this.Agendamento.Usuario = new Usuario();
            this.AgendarCommand = new Command(() => 
            {
                MessagingCenter.Send<Agendamento>(this.Agendamento, "Agendar");
            });
        }

    }
}
