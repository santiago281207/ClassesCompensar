using ClassesCompensar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class HorasACompensar : Compensacao
    {
        private int m_minutos;

        public int Minutos
        {
            get { return m_minutos; }
            set { m_minutos = value; }
        }

        public float Horas
        {
            get { return (float)m_minutos / 60; }
        }
    }
}
