using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Pessoa
{
    private string nome, telefone, email, cpf, senha;
    private char sexo;
    private int? codPessoa;
    private Endereco endereco;
    private DateTime dataNascimento;
    private string cidade;
    private string estado;
    private Perfil perfil;
    private Foto foto;

    public Pessoa(string nome, string telefone, string email, string cpf, char sexo, DateTime dataNascimento, int? codPessoa, Perfil perfil, Endereco endereco, Foto foto = null, string senha = null)
	{
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
        this.cpf = cpf;
        this.senha = senha;
        this.sexo = sexo;
        this.endereco = endereco;
        this.Perfil = perfil;
        this.foto = foto;
        this.codPessoa = codPessoa;
        this.dataNascimento = dataNascimento;
	}

    public Pessoa(string nome, Endereco endereco)
    {
        this.nome = nome;
        this.endereco = endereco;
    }

    public Pessoa()
    {

    }

    public Endereco Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    public int? CodPessoa
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

    public Perfil Perfil
    {
        get { return perfil; }
        set { perfil = value; }
    }

    public Foto Foto
    {
        get { return foto; }
        set { foto = value; }
    }
}