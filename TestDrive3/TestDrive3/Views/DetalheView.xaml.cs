using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive3.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive3.Views
{
    public partial class DetalheView : ContentPage
    {
        public Veiculo Veiculo { get; set; }

        public string PrecoFreioAbs
        {
            get { return string.Format("Freio ABS - R$ {0}", Veiculo.FREIO_ABS); }
        }

        public string PrecoArCondicionado
        {
            get { return string.Format("Ar Condicionado - R$ {0}", Veiculo.AR_CONDICIONADO); }
        }

        public string PrecoMp3Player
        {
            get { return string.Format("MP3 Player - R$ {0}", Veiculo.MP3_PLAYER); }
        }

        private bool temFreioAbs;
        public bool TemFreioAbs
        {
            get
            {
                return temFreioAbs;
            }
            set
            {
                temFreioAbs = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temArcondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArcondicionado;
            }
            set
            {
                temArcondicionado = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temMp3Player;
        public bool TemMp3Player
        {
            get
            {
                return temMp3Player;
            }
            set
            {
                temMp3Player = value;
                OnPropertyChanged(nameof(ValorTotal));
            }

        }

        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Veiculo.Preco); }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format
                (
                    "Valor Total: R$ {0}",
                    Veiculo.Preco
                    + (TemFreioAbs ? Veiculo.FREIO_ABS : 0)
                    + (TemArCondicionado ? Veiculo.AR_CONDICIONADO : 0)
                    + (TemMp3Player ? Veiculo.MP3_PLAYER : 0)
                );
            }
        }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = this;
            
        }
    }
}