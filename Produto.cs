
namespace Abstracao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidadeemestoque;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade em estoque: {Quantidadeemestoque}");
            Console.WriteLine("-----------------------");
        }
    }
}
