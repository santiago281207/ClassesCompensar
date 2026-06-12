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
        private int dim = 100;
        private int m_num;

        public int Numero
        {
            get { return m_num; }
            set { m_num = value; }
        }
        private string m_nome;
        public string Nome
        {
            get { return m_nome; }
            set { m_nome = value; }
        }

        private string m_turma;
        public string Turma
        {
            get { return m_turma; }
            set { m_turma = value; }
        }

        private HorasACompensar[] m_compensar = new HorasACompensar[100];

        public int AddCompensar(int index, Disciplina disciplina, string tipo)
        {
            if (index >= dim || Enum.IsDefined(typeof(Disciplina), disciplina) == false)
            {
                return 0;
            }else
            {
                m_compensar[index].Disciplina = disciplina;
                m_compensar[index].Tipo = tipo;
            }

            return 1;
        }
        public int AddCompensar(int index, int trimestre, int ano, int horas)
        {
            if (index >= dim)
            {
                return 0;
            }

            m_compensar[index].Trimestre = trimestre;
            m_compensar[index].Ano = ano;
            m_compensar[index].Compensar = horas;

            return 1;
        }
        private int m_qtdCompensar;

        public int ACompensar
        {
            get { return m_qtdCompensar; }
            set { m_qtdCompensar = value; }
        }

        private HorasCompensadas[] m_compensadas = new HorasCompensadas[100];

        public int AddCompensadas(int index,DateTime data,DateTime horaIniciar,DateTime horaFinal)
        {
            if (index >= dim)
            {
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
                return 0;
            }

            m_compensadas[index].Trimestre = trimestre;
            m_compensadas[index].Ano = ano;

            return index + 1;
        }

        private int m_qtdCompensadas;

        public int  Compensadas
        {
            get { return m_qtdCompensadas; }
            set { m_qtdCompensadas = value; }
        }


    }
}
