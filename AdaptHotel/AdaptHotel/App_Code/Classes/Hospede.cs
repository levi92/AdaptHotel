using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hospede
/// </summary>
public class Hospede : Pessoa
{
    private string placaCarro, cidadeOrigem;
    private int codHospede;


    public Hospede(string nome, string telefone, string email, string cpf, char sexo, DateTime dataNascimento, Perfil perfil, Endereco endereco, string placaCarro, string cidadeOrigem, int? codPessoa = null, Foto foto = null, string senha = null)
        : base(nome, telefone, email, cpf, sexo, dataNascimento, codPessoa, perfil, endereco, foto, senha)
    {
        this.placaCarro = placaCarro;
        this.cidadeOrigem = cidadeOrigem;
        

    }

    public Hospede(string nome, Endereco end) : base(nome, end)
    {
    }

    public Hospede()
    {

    }

    public string CidadeOrigem
    {
        get { return cidadeOrigem; }
        set { cidadeOrigem = value; }
    }

    public string PlacaCarro
    {
        get { return placaCarro; }
        set { placaCarro = value; }
    }


    public int CodHospede
    {
        get { return codHospede; }
        set { codHospede = value; }
    }

    
}