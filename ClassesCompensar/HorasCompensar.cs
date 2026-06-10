using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class HorasACompensar : Aluno
    {
        private string m_disp;
        private int m_trimestre;
        private int m_ano;
        private string m_tipo;
        private int m_compensar;

        public string Disciplina
        { get { return m_disp; } }

        public int Trimestre
        { get { return m_trimestre; } }

        public int Ano
        { get { return m_ano; } }

        public string Tipo
        { get { return m_tipo; } }

        public int Compensar
        { get { return m_compensar; } }

    }
}