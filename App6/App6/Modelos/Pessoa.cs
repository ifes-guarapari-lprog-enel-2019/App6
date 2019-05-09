using System;
using System.Collections.Generic;
using System.Text;

namespace App6.Modelos
{
    abstract class Pessoa
    {

        // lista de contatos
        private List<Contato> contatos;

        public List<Contato> Contatos
        {
            get
            {
                return this.contatos;
            }
            set
            {
                this.contatos = value;
            }
        }

        // atributo nome
        private String nome;

        public String Nome
        {

            get
            {
                return this.nome;
            }

        }

        // atributo cpf
        private int cpf;

        public int Cpf
        {

            get
            {
                return this.cpf;
            }

        }

        // construtor da classe
        public Pessoa(String nome, int cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

    }

}
