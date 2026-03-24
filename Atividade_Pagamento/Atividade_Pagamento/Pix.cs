using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pagamento
{
    internal class Pix : Pagamento
    {
        protected string ChavePix;
        protected string CodigoCopiaECola;

        public override void Processar()
        {
            Console.WriteLine($"\nChave Pix {ChavePix} validada. Aguardando recebimento instantâneo.");
        }

        public override void PegarInformacoes()
        {
            Console.WriteLine("\nColoque as informações do Pix\n");
            Console.WriteLine("Qual a chave Pix: ");
            ChavePix = Console.ReadLine();
            Console.WriteLine("Qual o codigo Copia e Cola: ");
            CodigoCopiaECola = Console.ReadLine();
        }
    }
}
