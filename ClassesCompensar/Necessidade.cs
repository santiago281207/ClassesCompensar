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
        }


        private int m_trimestre;

        public int Trimestre
        {
            get { return m_trimestre; }
        }


        private string m_anoLetivo;

        public string AnoLetivo
        {
            get { return m_anoLetivo; }
        }
        private string m_tipoCompensacao;


        public string TipoCompensacao
        {
            get { return m_tipoCompensacao; }
        }


    }
}