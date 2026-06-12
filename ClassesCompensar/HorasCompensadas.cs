using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompensacaoHoras
{
    internal class HorasCompensadas : Aluno
    {
        private Disciplina m_discip;
        private int m_trimestre;
        private int m_ano;
        private string m_tipo;
        private DateTime m_data;
        private DateTime m_horaIniciar;
        private DateTime m_horaFinal;

        public Disciplina Disciplina
        { 
            get { return m_discip; }
            set { m_discip = value; }
        }

        public int Trimestre
        { 
            get { return m_trimestre; }
            set { m_trimestre = value; }
        }

        public int Ano
        { 
            get { return m_ano; }
            set { m_ano = value; }
        }

        public string Tipo
        { 
            get { return m_tipo; }
            set { m_tipo = value; }
        }

        public DateTime Data
        { 
            get { return m_data; }
            set { m_data = value; }
        }

        public DateTime HoraIniciar
        { 
            get { return m_horaIniciar; }
            set { m_horaIniciar = value; }
        }

        public DateTime HoraFinal
        { 
            get { return m_horaFinal; }
            set { m_horaFinal = value; }
        }
    }
}