using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pagamento
{
    internal class Boleto : Pagamento
    {
        protected string CodigoBarras;
        protected DateTime DataVencimento;

        public override void Processar()
        {
            Console.WriteLine($"\nBoleto gerado com sucesso. Vencimento para o dia {DataVencimento}.");
        }

        public override void PegarInformacoes()
        {
            Console.WriteLine("\nColoque as informações do boleto\n");
            Console.WriteLine("Qual o código de barras: ");
            CodigoBarras = Console.ReadLine();
        }

        public Boleto()
        {
            DataVencimento = Data.AddDays(7);
        }

    }
}
