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
        private string m_nome;
        private string m_turma;
        private HorasACompensar[] m_compensar;
        private HorasCompensadas[] m_compensadas;


    }
}
