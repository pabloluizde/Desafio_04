using System;
using System.Collections.Generic;
using System.Text;
namespace desafio_04
{
    class AlunosList
    {
        static void Main(string[] args)
        {        
            
            List<string> aluno = new List<string>();

            aluno.Add("Maria");
            aluno.Add("Claudio");
            aluno.Add("Paulo");
            aluno.Add("Pedro");

            foreach(string obj in aluno)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
