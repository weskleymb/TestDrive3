using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive3.Models;
using TestDrive3.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive3.Views
{
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoView(Veiculo veiculo)

        {
            InitializeComponent();
            this.BindingContext = new AgendamentoViewModel(veiculo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendar", 
            (agendamento) => 
            {
                string titulo = agendamento.Veiculo.Nome;
                string mensagem = $"Nome: {agendamento.Usuario.Nome}\n"
                                + $"Fone: {agendamento.Usuario.Fone}\n"
                                + $"Email: {agendamento.Usuario.Email}\n"
                                + $"Data: {agendamento.DataAgendamento.ToString("dd/MM/yyyy")}\n"
                                + $"Hora: {agendamento.HoraAgendamento}";
                DisplayAlert(titulo, mensagem, "OK");
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendar");
        }
    }
}