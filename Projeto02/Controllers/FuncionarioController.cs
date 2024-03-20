using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIO *** \n");

                #region Capturar os dados do funcionário

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("NOME DO FUNCIONÁRIO.....: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("DATA DE NASCIMENTO......: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("CPF.....................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("MATRÍCULA...............: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("DATA DE ADMISSÃO........: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadastrar: {e.Message}");
            }
        }
    }
}
