using ClassesCompensar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompensacaoHoras
{
    public class Aluno
    {
        private int m_numero;
        private string m_nome;
        private string m_turma;

        private HorasACompensar[] m_compensar = new HorasACompensar[100];
        private HorasCompensadas[] m_compensadas = new HorasCompensadas[100];

        private int m_qtdCompensar;
        private int m_qtdCompensadas;

        public int Numero
        {
            get { return m_numero; }
            set { m_numero = value; }
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

        public int QtdCompensar
        {
            get { return m_qtdCompensar; }
        }

        public int QtdCompensadas
        {
            get { return m_qtdCompensadas; }
        }


        // ADD COMPENSAR

        public int AddCompensar(HorasACompensar horas)
        {
            if (ExisteCompensar(horas.Disciplina, horas.Trimestre, horas.AnoLetivo, horas.Tipo) == true)
                return 0;
            m_compensar[m_qtdCompensar++] = horas;
            return 1;
        }


        // ADD COMPENSADAS

        public bool AddCompensadas(HorasCompensadas horas)
        {
            
            if (horas.Data > DateTime.Now)
                return false;

            // validar duração mínima (30 minutos)
            int duracao = (int)(horas.HoraFim - horas.HoraInicio).TotalMinutes;

            if (duracao < 30)
                return false;

            // validar se existe registo a compensar
            bool existeRegisto = false;

            for (int i = 0; i < m_qtdCompensar; i++)
            {
                if (m_compensar[i].Disciplina == horas.Disciplina &&
                    m_compensar[i].Trimestre == horas.Trimestre &&
                    m_compensar[i].AnoLetivo == horas.AnoLetivo)
                {
                    existeRegisto = true;
                    break;
                }
            }

            if (!existeRegisto)
                return false;

            // validar sobreposição de horários
            for (int i = 0; i < m_qtdCompensadas; i++)
            {
                bool sobrepoe =
                    horas.HoraInicio < m_compensadas[i].HoraFim &&
                    horas.HoraFim > m_compensadas[i].HoraInicio;

                if (sobrepoe)
                    return false;
            }

            // inserir registo
            m_compensadas[m_qtdCompensadas++] = horas;
            return true;
        }


        // VALIDAR DUPLICADO

        public bool ExisteCompensar(Disciplina disciplina, int trimestre, string ano, string tipo)
        {
            for (int i = 0; i < m_qtdCompensar; i++)
            {
                if (m_compensar[i].Disciplina == disciplina &&
                    m_compensar[i].Trimestre == trimestre &&
                    m_compensar[i].AnoLetivo == ano &&
                    m_compensar[i].Tipo == tipo)
                {
                    return true;
                }
            }
            return false;
        }


        // TOTAL MINUTOS A COMPENSAR

        public float TotalHorasCompensar(int trimestre, string anoLetivo)
        {
            float total = 0;

            for (int i = 0; i < m_qtdCompensar; i++)
            {
                if (m_compensar[i].Trimestre == trimestre &&
                    m_compensar[i].AnoLetivo == anoLetivo)
                {
                    total += m_compensar[i].Horas;
                }
            }

            return total;
        }


        // TOTAL MINUTOS COMPENSADOS
  
        public float TotalHorasCompensados(int trimestre, string ano)
        {
            float total = 0;

            for (int i = 0; i < m_qtdCompensadas; i++)
            {
                if (m_compensadas[i].Trimestre == trimestre &&
                    m_compensadas[i].AnoLetivo == ano)
                {
                    total += m_compensadas[i].DuracaoHoras();
                }
            }

            return total;
        }


        // SALDO EM MINUTOS

        public float SaldoMinutos(int trimestre, string ano)
        {
            return TotalHorasCompensar(trimestre, ano)
                 - TotalHorasCompensados(trimestre, ano);
        }


        // SALDO EM HORAS (UI)

        public float SaldoHoras(int trimestre, string ano)
        {
            return (float)SaldoMinutos(trimestre, ano) / 60;
        }
    }
}
