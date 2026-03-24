using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pagamento
{
    internal class CartaoCredito : Pagamento
    {
        protected string NumeroCartao;
        protected int Parcelas;

        public override void Processar()
        {
            Console.WriteLine($"\nPagamento de R$ {Valor} realizado no cartão {NumeroCartao} em {Parcelas}x");
        }

        public override void PegarInformacoes()
        {
            Console.WriteLine("\nColoque as informações do cartão\n");
            Console.WriteLine("Qual o número do cartão: ");
            NumeroCartao = Console.ReadLine();
            Console.WriteLine("Qual o número de parcelas: ");
            Parcelas = int.Parse(Console.ReadLine());
        }
    }
}
