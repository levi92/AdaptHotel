using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Funcionario : Pessoa 
{
    private string cargo, numeroCnt;
    private double salario;
    private int codFuncionario;
    private DateTime dataAdmissao;


    public Funcionario(string nome, string telefone, string email, string cpf, char sexo, DateTime dataNascimento, int codPessoa, Endereco end,
        string cargo, string numeroCnt, double salario, DateTime dataAdmissao, int codFuncionario, string senha = null) : base(nome, telefone, email, cpf, sexo, dataNascimento, codPessoa, end, senha)
	{
        this.cargo = cargo;
        this.numeroCnt = numeroCnt;
        this.salario = salario;
        this.dataAdmissao = dataAdmissao;
	}

    public int CodFuncionario
    {
        get { return codFuncionario; }
        set { codFuncionario = value; }
    }

    public DateTime DataAdmissao
    {
        get { return dataAdmissao; }
        set { dataAdmissao = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }

    public string NumeroCnt
    {
        get { return numeroCnt; }
        set { numeroCnt = value; }
    }

    public string Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public string ImprimirFuncionario()
    {
        return base.ImprimirPessoa() + "CARGO: " + Cargo + "NUMERO CNT: " + NumeroCnt + "SALARIO: " + Salario + "DATA DE ADMISSÃO: " + DataAdmissao;
    }


}