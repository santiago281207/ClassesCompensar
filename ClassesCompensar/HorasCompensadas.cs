using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompensacaoHoras
{
    internal class HorasCompensadas : Aluno
    {
        private string m_disp;
        private int m_trimestre;
        private int m_ano;
        private string m_tipo;
        private DateTime m_data;
        private DateTime m_horaIniciar;
        private DateTime m_horaFinal;

        public string Disiplina
        { get { return m_disp; } }

        public int Trimestre
        { get { return m_trimestre; } }

        public int Ano
        { get { return m_ano; } }

        public string Tipo
        { get { return m_tipo; } }

        public DateTime Data
        { get { return m_data; } }

        public DateTime HoraIniciar
        { get { return m_horaIniciar; } }

        public DateTime HoraFinal
        { get { return m_horaFinal; } }
    }
}