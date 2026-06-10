using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public abstract class Necessidade
    {

        private Disciplina m_disciplina;

        public Disciplina Disciplina
        {
            get { return m_disciplina; }
            set { m_disciplina = value; }
        }


        private int m_trimestre;

        public int Trimestre
        {
            get { return m_trimestre; }
            set { m_trimestre = value; }
        }


        private string m_anoLetivo;

        public string AnoLetivo
        {
            get { return m_anoLetivo; }
            set { m_anoLetivo = value; }
        }

        private string m_tipoCompensacao;

        public string TipoCompensacao
        {
            get { return m_tipoCompensacao; }
            set { m_tipoCompensacao = value; }
        }


    }
}