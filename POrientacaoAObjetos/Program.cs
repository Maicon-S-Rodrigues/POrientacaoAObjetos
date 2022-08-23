using System;

namespace POrientacaoAObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa1 = new Pessoa();
            Pessoa p3;
            //p3 = new Pessoa();
            p3 = pessoa1;

            Console.WriteLine("Nome (pessoa): " + pessoa.getNome());

            pessoa.setNome("MARIA");
            pessoa1.setNome("ANA MARIA");

            Console.WriteLine("Novo nome (pessoa): " + pessoa1.getNome());
            Console.WriteLine(p3.getNome());
            


        }
    }
}
