using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Pessoa
{
    private string nome, telefone, email, cpf, senha;
    private char sexo;
    private int codPessoa;
    private Endereco end;
    private DateTime dataNascimento;



    public Pessoa(string nome, string telefone, string email, string cpf, char sexo, DateTime dataNascimento, int codPessoa, Endereco end, string senha = null)
	{
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
        this.cpf = cpf;
        this.senha = senha;
        this.sexo = sexo;
        this.end = end;
	}


    public Endereco End
    {
        get { return end; }
        set { end = value; }
    }

    public int CodPessoa
    {
      get { return codPessoa; }
      set { codPessoa = value; }
    }

    public DateTime DataNascimento
    {
      get { return dataNascimento.Date; }
      set { dataNascimento = value; }
    }

    public char Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public string Senha
    {
        get { return senha; }
        set { senha = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }


    public string ImprimirPessoa()
    {
        return "NOME: " + Nome + "SEXO: " + Sexo + "TELEFONE: " + Telefone + "DATA DE NASCIMENTO: " + DataNascimento + "CPF: " + Cpf + "EMAIL: " + Email + "SENHA: " + Senha + End.Imprimir();
    }

}