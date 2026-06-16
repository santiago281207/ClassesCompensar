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

        public string NameAluno(int index)
        {
            return m_alunos[index].Nome;
        }
        public Aluno AlunoCheck(int indexAluno)
        {
            return m_alunos[indexAluno];
        }

        public int IndexPorNome(string nome)
        {
            for(int i = 0;i < m_qtdAlunos;i++)
            {
                if (m_alunos[i].Nome == nome)
                {
                    return i;
                }
            }
            return -1;
        }

        

        public int ExisteCheck(int num,string nome)
        {
            if (m_qtdAlunos == 0)
                return 0;

            for (int i = 0; i < m_qtdAlunos; i++)
            {
                if (m_alunos[i] != null && m_alunos[i].Numero == num || m_alunos[i] != null && m_alunos[i].Nome == nome)
                    return -1;
            }

            return 0;
        }

        public int Add(Aluno aluno)
        {
            if (m_qtdAlunos == m_dim)
                return 0;

            if (ExisteCheck(aluno.Numero,aluno.Nome) == -1)
                return -1;

            m_alunos[m_qtdAlunos] = aluno;
            m_qtdAlunos++;

            return 1;
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