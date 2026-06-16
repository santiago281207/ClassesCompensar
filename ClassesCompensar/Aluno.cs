using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace CompensacaoHoras
{
    public enum Disciplina
    {
        PSI, //0
        PT,
        ING,
        RC,
        AC,
        MAT,
        TIC,
        FQ,
        SO //8
    }
    public class Aluno
    {
        private HorasACompensar[] m_compensar = new HorasACompensar[100];
        private HorasCompensadas[] m_compensadas = new HorasCompensadas[100];
        private int dim = 100;
        private int m_num;
        private string m_nome;
        private string m_turma;
        private int m_qtdCompensar;
        private int m_qtdCompensadas;

        public int CheckRegistoCompensar(int indexAluno,Disciplina disciplina,int trimestre,string anoLetivo,string tipo)
        {
            for(int i = 0;i < m_qtdCompensar;i++)
            {
                if(i == indexAluno)
                {
                    continue;
                }else
                {
                    if (m_compensar[i].Disciplina == m_compensar[indexAluno].Disciplina && 
                        m_compensar[i].Trimestre == m_compensar[indexAluno].Trimestre && 
                        m_compensar[i].Ano   == m_compensar[indexAluno].Ano &&
                        m_compensar[i].Tipo == m_compensar[indexAluno].Tipo)
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }

        internal HorasACompensar CheckCompensar(int index)
        {
            return m_compensar[index];
        }

        internal HorasCompensadas CheckCompensadas(int index)
        {
            return m_compensadas[index];
        }
        
        public int Numero
        {
            get { return m_num; }
            set { m_num = value; }
        }
        
        public string Nome
        {
            get { return m_nome; }
            set { m_nome = value; }
        }

        
        public string Turma
        {
            get { return m_turma; }
            set { m_turma = value; }
        }

        public void CriarCompensar(int index)
        {
            if(CheckCompensar(index) == null)
            {
                HorasACompensar horasCompensar = new HorasACompensar();
                m_compensar[index] = horasCompensar;
            }
        }

        public void CriarCompensadas(int index)
        {
            if (CheckCompensadas(index) == null)
            {
                HorasCompensadas horasCompensadas = new HorasCompensadas();
                m_compensadas[index] = horasCompensadas;
            }
        }

        public int AddCompensar(int index, Disciplina disciplina, string tipo)
        {
            if (index >= dim || Enum.IsDefined(typeof(Disciplina), disciplina) == false)
            {
                CriarCompensar(index);
                return 0;
            }else
            {
                m_compensar[index].Disciplina = disciplina;
                m_compensar[index].Tipo = tipo;
            }

            return 1;
        }
        public int AddCompensar(int index, int trimestre, string anoLetivo, int horas)
        {
            if (index >= dim)
            {
                CriarCompensar(index);
                return 0;
            }

            m_compensar[index].Trimestre = trimestre;
            m_compensar[index].Ano = anoLetivo;
            m_compensar[index].Compensar = horas;

            return 1;
        }
        

        public int QtdCompensar
        {
            get { return m_qtdCompensar; }
            set { m_qtdCompensar = value; }
        }

        public int AddCompensadas(int index,DateTime data,DateTime horaIniciar,DateTime horaFinal)
        {
            if (index >= dim)
            {
                CriarCompensadas(index);
                return 0;
            }

            m_compensadas[index].Data = data;
            m_compensadas[index].HoraIniciar = horaIniciar;
            m_compensadas[index].HoraFinal = horaFinal;

            return 1;
        }

        public int AddCompensadas(int index, Disciplina disciplina, string tipo)
        {
            if (index >= dim || Enum.IsDefined(typeof(Disciplina),disciplina) == false)
            {
                CriarCompensadas(index);
                return 0;
            }

            m_compensadas[index].Disciplina = disciplina;
            m_compensadas[index].Tipo = tipo;

            return index + 1;
        }

        public int AddCompensadas(int index, int trimestre, int ano)
        {
            if (index >= dim)
            {
                CriarCompensadas(index);
                return 0;
            }

            m_compensadas[index].Trimestre = trimestre;
            m_compensadas[index].Ano = ano;

            return index + 1;
        }

        

        public int  QtdCompensadas
        {
            get { return m_qtdCompensadas; }
            set { m_qtdCompensadas = value; }
        }


    }
}
