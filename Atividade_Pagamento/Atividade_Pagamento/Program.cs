using Atividade_Pagamento;

CartaoCredito Cartao = new CartaoCredito();
Pix Pix = new Pix();
Boleto Boleto = new Boleto();

Console.WriteLine("========= SISTEMA DE PAGAMENTO =========\n");

Console.WriteLine("Comece colocando as informações das formas de pagamento:");

Cartao.PegarInformacoes();
Pix.PegarInformacoes();
Boleto.PegarInformacoes();

Console.WriteLine("\nDigite o valor do pagamento: ");
string entrada = Console.ReadLine();
double valor;
while (!double.TryParse(entrada, out valor))
{
    Console.WriteLine("Valor inválido. Digite o valor novamente: ");
    entrada = Console.ReadLine();
}

Cartao.DefinirValor(valor);
Pix.DefinirValor(valor);
Boleto.DefinirValor(valor);

Console.WriteLine("\n========= RESULTADO DOS PAGAMENTOS =========");
Cartao.Processar();
Pix.Processar();
Boleto.Processar();
