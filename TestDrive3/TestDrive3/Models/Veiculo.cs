using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive3.Models
{
    public class Veiculo
    {
        public const decimal FREIO_ABS = 700;
        public const decimal AR_CONDICIONADO = 1500;
        public const decimal MP3_PLAYER = 400;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }

    }
}
