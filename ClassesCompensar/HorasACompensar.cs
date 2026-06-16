using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class HorasACompensar : Aluno
    {
        private Disciplina m_discip;
        private int m_trimestre;
        private string m_anoLetivo;
        private string m_tipo;
        private int m_compensar;

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

        public string Ano
        { 
            get { return m_anoLetivo; }
            set { m_anoLetivo  = value; }
        }

        public string Tipo
        { 
            get { return m_tipo; }
            set { m_tipo = value; }
        }

        public int Compensar
        { 
            get { return m_compensar; } //Em minutos
            set { m_compensar = value * 60; }
        }

    }
}