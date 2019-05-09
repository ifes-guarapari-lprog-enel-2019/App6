using System;
using System.Collections.Generic;
using System.Text;

namespace App6.Modelos
{
    class Disciplina
    {

        // lista de cursos
        private List<Curso> cursos;

        public List<Curso> Cursos
        {
            get
            {
                return this.cursos;
            }
            set
            {
                this.cursos = value;
            }
        }

        // atributo requisito
        private Disciplina requisito;

        public Disciplina Requisito
        {
            get
            {
                return this.requisito;
            }
            set
            {
                this.requisito = value;
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

        // atributo horas
        private int horas;

        public int Horas
        {
            get
            {
                return this.horas;
            }
            set
            {
                if (value > 0)
                {
                    this.horas = value;
                }
            }
        }

        public Disciplina(String nome)
        {
            this.nome = nome;
        }

    }
}
