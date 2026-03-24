using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pagamento
{
    internal class Pagamento
    {
        protected double Valor;
        protected DateTime Data;

        public void DefinirValor(double valor)
        {
            Valor = valor;
        }

        public virtual void Processar()
        {
            Console.WriteLine("Iniciando pagamento...");
        }

        public virtual void PegarInformacoes()
        {

        }

        public Pagamento()
        {
            Data = DateTime.Now;
        }
    }
}
