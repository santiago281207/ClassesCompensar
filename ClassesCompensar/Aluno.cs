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

        private HorasACompensar[] m_compensar;
        private int m_qtdCompensar;

        public int ACompensar
        {
            get { return m_qtdCompensar; }
            set { m_qtdCompensar = value; }
        }

        private HorasCompensadas[] m_compensadas;
        private int m_qtdCompensadas;

        public int  Compensadas
        {
            get { return m_qtdCompensadas; }
            set { m_qtdCompensadas = value; }
        }


    }
}
