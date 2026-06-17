using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCompensar
{
    public enum Disciplina
    {
        PSI,
        PT,
        ING,
        RC,
        AC,
        MAT,
        SO,
        TIC,
        FQ
    }

    public abstract class Compensacao
    {
        private Disciplina m_disciplina;
        private int m_trimestre;
        private string m_anoLetivo;
        private string m_tipo;

        public Disciplina Disciplina
        {
            get { return m_disciplina; }
            set { m_disciplina = value; }
        }

        public int Trimestre
        {
            get { return m_trimestre; }
            set { m_trimestre = value; }
        }

        public string AnoLetivo
        {
            get { return m_anoLetivo; }
            set { m_anoLetivo = value; }
        }

        public string Tipo
        {
            get { return m_tipo; }
            set { m_tipo = value; }
        }
    }
}
