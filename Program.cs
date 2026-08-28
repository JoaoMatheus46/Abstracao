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

            // EXERCÍCIO 2
            Aluno Informacoesaluno = new Aluno();

            Informacoesaluno.nome = "João";
            Informacoesaluno.matricula = "123456";
            Informacoesaluno.Nota1 = 8;
            Informacoesaluno.Nota2 = 7;
       

            Console.WriteLine("Informações do aluno");
            Informacoesaluno.exibirInformacoes();

            // EXERCÍCIO 3
           

            ContaBancaria conta = new ContaBancaria();

            conta.Titular = "Froés";
            conta.NumeroConta = "25";
            conta.Saldo = 750;

            Console.WriteLine("Informações da conta bancaria:");
            conta.ExibirInformacoesContaBancaria1();
            conta.Depositar(500);
            conta.ExibirInformacoesContaBancaria2();
            conta.Sacar(300);
            conta.ExibirInformacoesContaBancaria3();


            // EXERCÍCIO 4 
            Time time = new Time();

            time.NomeDoTime = "Fudidos FC";

            Jogador jogador1 = new Jogador();

            jogador1.Nome = "Gabriel Fróes";
            jogador1.Posicao = "Volante";
            jogador1.NumeroCamisa = 9;

            Jogador jogador2 = new Jogador();

            jogador2.Nome = "CR7";
            jogador2.Posicao = "Atacante";
            jogador2.NumeroCamisa = 7;

            Jogador jogador3 = new Jogador();

            jogador3.Nome = "Erik";
            jogador3.Posicao = "Lateral/Ponta";
            jogador3.NumeroCamisa = 17;

            time.AdicionarJogador(jogador1);
            time.AdicionarJogador(jogador2);
            time.AdicionarJogador(jogador3);

            time.ListarJogadores();
            Console.WriteLine("--------------------------------------");


            Console.ReadKey();
        }
    }
}
