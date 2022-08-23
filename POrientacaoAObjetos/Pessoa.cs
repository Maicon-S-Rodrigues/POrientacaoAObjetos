using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POrientacaoAObjetos
{
    internal class Pessoa
    {
        //ATRIBUTOS DECLARADOS: (obs:Atributos de uma classe são praticamente dizendo "iguais" a variaveis
        String nome;
        int idade;
        public String cidade; // modificou a restrição de acesso para público


        ///classe/ métodos construtores: <summary>
        ///métodos construtores SEMPRE tem o mesmo nome da classe, eles são executados quando o objeto é instânciado (criado)
        public Pessoa()
        {
            this.nome = "Zé Ninguém";
            this.idade = 0;
            this.cidade = "Araraquara";
        }

        ///neste método construtor ele será executado na criação do objeto e irá receber os valores por parâmetros para preencher seus atributos
        public Pessoa(string nome, int idade, string cidade)
        {
            this.nome=nome;
            this.idade = idade;
            this.cidade = cidade;
        }

        public override string ToString()
        {
            return "Nome : " + nome + "\nIdade: " + idade + "\nCidade: " + cidade;
        }


        public void setNome (String nome) /// Método SET para receber o nome
        {
           this.nome = nome;
        }
        public void setIdade (int idade) // Método SET para receber a idade
        {
            this.idade = idade;
        }

        public String getNome () // Método GET para retornar o valor do atributo nome
        {
            return nome;
        }
        public int getIdade () // Método GE para retornar o valor do atributo idade
        {
            return idade;
        }
    }
}
