using ClassesCompensar;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class HorasCompensadas : Compensacao
    {
        private DateTime m_data;
        private DateTime m_horaInicio;
        private DateTime m_horaFim;

        public DateTime Data
        {
            get { return m_data; }
            set { m_data = value; }
        }

        public DateTime HoraInicio
        {
            get { return m_horaInicio; }
            set { m_horaInicio = value; }
        }

        public DateTime HoraFim
        {
            get { return m_horaFim; }
            set { m_horaFim = value; }
        }

        public int DuracaoMinutos()
        {
            return (int)(m_horaFim - m_horaInicio).TotalMinutes;
        }

        public float DuracaoHoras()
        {
            return (float)DuracaoMinutos() / 60;
        }
    }
}
