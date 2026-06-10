using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class Registos
    {
        Aluno[] m_alunos = new Aluno[30];

        private int m_qtdAlunos;
        private int m_dim = 30;

        public int ExisteCheck(int num)
        {
            foreach (Aluno aluno in m_alunos)
            {
                if(aluno.Numero == num)
                {
                    return -1;
                }
            }
            return 0;
        }

        public void Add(Aluno aluno)
        {
            if(m_qtdAlunos <= 29)
            {
                throw new Exception("Quantidade máxima de alunos atingida!");
            }else if(ExisteCheck(aluno.Numero) == -1)
            {
                throw new Exception("Aluno já existente");
            }else
            {
                m_alunos = m_alunos.Append(aluno).ToArray();
            }
        }


        public int Dimensao
        {
            get { return m_dim; }
        }

        public int QuantidadeAlunos
        {
            get { return m_qtdAlunos; }
            set { m_qtdAlunos = value; }
        }

    }
}