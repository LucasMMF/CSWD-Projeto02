// Localização da classe dentro do projeto
using Projeto02.Controllers;

namespace Projeto02
{
    // Definição da classe
    public class Program
    {
        // Método para executar o conteúdo da classe
        // ponto de inicialização do projeto
        public static void Main(String[] args)
        {

            // Instanciando a classe de controle
            var funcionarioController = new FuncionarioController();

            // Executando o método para cadastrar funcionário
            funcionarioController.CadastrarFuncionario();

            // Pausar o prompt
            Console.ReadKey();

        }
    }
}