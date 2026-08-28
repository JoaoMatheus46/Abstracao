namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // CRIANDO UM OBJETO (INSTANCIAÇÃO)
            Carro meuFusca = new Carro();

            meuFusca.Marca = "Volkswagen";
            meuFusca.Modelo = "Fusca";
            meuFusca.Ano = 1975;
            meuFusca.Cor = "Azul";

            Carro carroVizinho = new Carro();

            carroVizinho.Marca = "Chevrolet";
            carroVizinho.Modelo = "Corsa";
            carroVizinho.Ano = 2005;
            carroVizinho.Cor = "Prata";

            Console.WriteLine("Informações do meu carro:");
            meuFusca.ExibirInformacoes();

            Console.WriteLine("Informações do carro do vizinho");
            carroVizinho.ExibirInformacoes();

            // EXERCÍCIO 1
            Produto produto = new Produto();

            produto.Nome = "Notebook";
            produto.Preco = 3500.00;
            produto.Quantidadeemestoque = 10;

            Console.WriteLine("Produtos");
            produto.ExibirInformacoes();




            Console.ReadKey();
        }
    }
}
