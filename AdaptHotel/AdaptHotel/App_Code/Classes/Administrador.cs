using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Administrador : Pessoa
{
    private int? cod_administrador;
    private int? cod_pessoa;

    public Administrador(string nome, string telefone, string email, string cpf, char sexo, DateTime dataNascimento, Perfil perfil, Endereco endereco, int cod_administrador, int? codPessoa = null, Foto foto = null, string senha = null)
        : base(nome, telefone, email, cpf, sexo, dataNascimento, codPessoa, perfil, endereco, foto, senha)
    {
        this.cod_administrador = cod_administrador;
    }

    public int? Cod_administrador
    {
        get { return cod_administrador; }
        set { cod_administrador = value; }
    }

    public int? Cod_pessoa
    {
        get { return cod_pessoa; }
        set { cod_pessoa = value; }
    }
}