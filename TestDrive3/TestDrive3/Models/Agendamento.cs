using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive3.Models
{
    public class Agendamento
    {

        public Usuario Usuario { get; set; }
        public Veiculo Veiculo { get; set; }

        private DateTime dataAgendamento = DateTime.Now;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento { get; set; }

    }
}
