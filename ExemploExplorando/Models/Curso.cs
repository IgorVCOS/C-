using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){

            console.writeLine($"Alunos do curso de: {Nome}");

             for (int count = 0; count < Alunos.Count; count++)
             {
                string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                Console.writeLine(texto);
             }


            
        }
    }
}