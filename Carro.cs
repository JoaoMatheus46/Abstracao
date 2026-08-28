
namespace Abstracao
{
    internal class Carro
    {
        //ATRIBUTOS (CARACTERISTICAS)
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;

        //METODOS (CORPORTAMENTO)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, {Modelo}");
            Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
            Console.WriteLine("-----------------------");
        }
    }
}
