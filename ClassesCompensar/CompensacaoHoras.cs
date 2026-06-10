using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class Registos
    {
        Aluno[] alunos = new Aluno[30];

        private int m_qtdAlunos;
        private int m_dim = 30;

        public int Dimensao
        {
            get { return m_dim; }
        }

        public int QuantidadeAlunos
        {
            get { return m_qtdAlunos; }
        }

    }
}