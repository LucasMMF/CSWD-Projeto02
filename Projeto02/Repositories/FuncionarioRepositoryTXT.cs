﻿using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTXT : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o nome e local do arquivo

            var path = "D:\\temp\\csharp\\webdeveloper\\funcionarios.txt";

            #endregion

            #region Gravando o conteúdo do arquivo

            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine($"ID DO FUNCIONÁRIO....: {funcionario.Id}");

                streamWriter.WriteLine($"NOME.................: {funcionario.Nome}");

                streamWriter.WriteLine($"DATA DE NASCIMENTO...: {funcionario.DataNascimento.ToString("dd/MM/yyyy")}");

                streamWriter.WriteLine($"CPF..................: {funcionario.Cpf}");

                streamWriter.WriteLine($"MATRÍCULA............: {funcionario.Matricula}");

                streamWriter.WriteLine($"DATA DE ADMISSÃO.....: {funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");

                streamWriter.WriteLine($"ID DO SETOR..........: {funcionario.Setor.Id}");

                streamWriter.WriteLine($"SIGLA DO SETOR.......: {funcionario.Setor.Sigla}");

                streamWriter.WriteLine($"DESCRIÇÃO DO SETOR...: {funcionario.Setor.Descricao}");

                streamWriter.WriteLine("\n");
            }

            #endregion
        }
    }
}
