using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App6.Modelos;

namespace App6
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            // criar um curso
            Curso curso = new Curso("ENEL");
            // criar uma pessoa na forma de aluno
            Pessoa pessoa1 = new Aluno("josé", 1234);
            // criar um aluno
            Aluno aluno1 = new Aluno("maria", 5678);
            // fazer um downcasting de aluno
            Pessoa pessoa2 = aluno1;
            // fazer um upcasting de pessoa
            ((Aluno) pessoa2).Cursar(curso);
            // criar um contato na forma de internet
            Contato contato1 = new Internet("maria@mail.com", "www.maria.com");
            // adicionar o contato a lista de aluno
            // a lista de Contatos foi herdada da classe Pessoa pelo aluno
            aluno1.Contatos.Add(contato1);
            // criar um familiar (que também é um contato
            Familiar familiar1 = new Familiar("joão", 126);
            // criar um contato de internet
            Internet contato2 = new Internet("joao@mail.com", "www.joao.com");
            // criar um contato de endereço
            Endereco contato3 = new Endereco("Avenida Central", "Guarapari-ES");
            // adicionar os contatos
            familiar1.Contatos.Add(contato2);
            familiar1.Contatos.Add(contato3);
            // adicionar o familiar como contato do aluno
            aluno1.Contatos.Add(familiar1);
            // aluno maria
            // imprimir antes o aluno1.Nome
            foreach (Contato contato in aluno1.Contatos)
            {
                contato.Comunicar();
                // qual o resultado se eu imprimir esse método?
                // 1 [internet] - Enviar email para maria@mail.com
                // 1 [internet] - Entrar no site www.maria.com
                // 2 [familiar] - Enviar email para joao@mail.com
                // 2 [familiar] - Enviar no site para www.joao.com
                // 2 [familiar] - Enviar correio para Avenida Central de Guarapari-ES
            }
        }
	}
}
