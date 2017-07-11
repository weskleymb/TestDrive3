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
    }
}