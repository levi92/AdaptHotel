using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Administrador : Pessoa 
{
    private int codAdm;


    public Administrador(string nome, string telefone, string email, string cpf, string senha, char sexo, DateTime dataNascimento, int codPessoa, int codAdm, Endereco end)
        : base(nome, telefone, email, cpf, sexo, dataNascimento, codPessoa, end, senha)
	{
        this.codAdm = codAdm;
	}

    public int CodAdm
    {
        get { return codAdm; }
        set { codAdm = value; }
    }

    public string ImprimirAdministrador()
    {
        return base.ImprimirPessoa() ;
    }

}