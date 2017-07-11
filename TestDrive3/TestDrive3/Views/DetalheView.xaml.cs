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
    public partial class DetalheView : ContentPage
    {
        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.BindingContext = new DetalheViewModel(veiculo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "Agendamento", 
            (veiculo) => 
            {
                Navigation.PushAsync(new AgendamentoView(veiculo));
                //DisplayAlert(veiculo.Nome, veiculo.PrecoFormatado, "OK");
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
