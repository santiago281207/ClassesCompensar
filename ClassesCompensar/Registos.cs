using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class Sistema
    {
        private Aluno[] m_alunos = new Aluno[30];
        private int m_qtdAlunos;


        // ADICIONAR ALUNO

        public bool AddAluno(Aluno aluno)
        {
            if (ProcurarAluno(aluno.Numero) != null)
                return false;

            m_alunos[m_qtdAlunos++] = aluno;
            return true;
        }


        // PROCURAR ALUNO POR NUMERO

        public Aluno ProcurarAluno(int numero)
        {
            for (int i = 0; i < m_qtdAlunos; i++)
            {
                if (m_alunos[i].Numero == numero)
                    return m_alunos[i];
            }
            return null;
        }


        // APAGAR ALUNO (SÓ SE NÃO TIVER COMPENSAR)

        public bool ApagarAluno(int numero)
        {
            for (int i = 0; i < m_qtdAlunos; i++)
            {
                if (m_alunos[i].Numero == numero)
                {
                    if (m_alunos[i].QtdCompensar > 0)
                        return false;

                    for (int j = i; j < m_qtdAlunos - 1; j++)
                    {
                        m_alunos[j] = m_alunos[j + 1];
                    }

                    m_qtdAlunos--;
                    return true;
                }
            }
            return false;
        }

        public int QtdAlunos
        {
            get { return m_qtdAlunos; }
        }

        public Aluno GetAluno(int i)
        {
            return m_alunos[i];
        }
    }
}
