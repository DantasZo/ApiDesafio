using ApiDesafio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace ApiDesafio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DesafioController : ControllerBase
    {
        private static string _sequenciaCorreta;
        private static readonly bool _inicializado;

        static DesafioController()
        {
            _sequenciaCorreta = GerarSequenciaAleatoria();
            _inicializado = Inicializar();
        }

        private static bool Inicializar()
        {
            try
            {
                GravarLogDaSenhaCorreta(_sequenciaCorreta);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inicializar: {ex.Message}");
                return false;
            }
        }

        [HttpPost]
        public IActionResult VerificarTentativa([FromBody] Tentativa tentativa)
        {
            if (tentativa.Key == _sequenciaCorreta)
            {
                GravarLogDaSenhaCorreta(_sequenciaCorreta);
                return Ok($"Sucesso! A sequência correta é {tentativa.Key}");
            }
            else
            {
                return Ok($"Falha. A sequência correta não é {tentativa.Key}. Tente novamente!");
            }
        }

        private static string GerarSequenciaAleatoria()
        {
            var letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var numeros = "0123456789";
            var random = new Random();
            var sequencia = new char[4];

            for (int i = 0; i < 2; i++)
            {
                sequencia[i] = letras[random.Next(letras.Length)];
            }

            for (int i = 2; i < 4; i++)
            {
                sequencia[i] = numeros[random.Next(numeros.Length)];
            }

            return new string(sequencia.OrderBy(c => random.Next()).ToArray());
        }


        private static void GravarLogDaSenhaCorreta(string senhaCorreta)
        {
            try
            {
                string caminhoArquivo = @"C:\Users\luqui\source\repos\ApiDesafio\Senha\senha.txt";

                string diretorio = Path.GetDirectoryName(caminhoArquivo);
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                System.IO.File.WriteAllText(caminhoArquivo, $"Senha correta: {senhaCorreta} - {DateTime.Now}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gravar log da senha: {ex.Message}");
                throw;
            }
        }
    }
}
