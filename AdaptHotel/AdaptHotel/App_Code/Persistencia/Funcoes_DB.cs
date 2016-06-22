using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Funcoes_DB
{
    public static object ValidarLogin(string email, string senha)
    {
        int retorno = 0;

        try
        {
            SqlConnection objconexao = Mapped.Connection();
            string sql = "select * from perfis per " +
                            "inner join pessoas pes on per.cod_perfil = pes.cod_perfil " +
                            "left join enderecos e on e.cod_endereco = pes.cod_pessoa " +
                            "left join fotos f on f.cod_foto = pes.cod_foto " +
                            "left join administradores adm on adm.cod_pessoa = pes.cod_pessoa " +
                            "left join funcionarios fun on fun.cod_pessoa = pes.cod_pessoa " +
                            "left join hospedes h on h.cod_pessoa = pes.cod_pessoa where pes.email like @email and " +
                            "pes.senha like @senha;";
            SqlCommand objCommand = Mapped.Command(sql, objconexao);
            objCommand.Parameters.Add(Mapped.Parameter("@email", email));
            objCommand.Parameters.Add(Mapped.Parameter("@senha", senha));
            SqlDataReader objDataReader = objCommand.ExecuteReader();

            while (objDataReader.Read())
            {
                int nulo;

                Perfil perfil = new Perfil(objDataReader["tipo"].ToString());
                Foto foto = new Foto(objDataReader["endereco_foto"].ToString(), int.TryParse(objDataReader["endereco_foto"].ToString(), out nulo) ? (int?)nulo : null);
                Endereco endereco = new Endereco(objDataReader["rua"].ToString(), objDataReader["numero"].ToString(),
                    objDataReader["complemento"].ToString(), objDataReader["bairro"].ToString(), objDataReader["cep"].ToString(),
                    objDataReader["cidade"].ToString(), objDataReader["estado"].ToString());

                if (perfil.getTipo() == "hospede")
                {
                    Hospede hospede = new Hospede(objDataReader["nome"].ToString(), objDataReader["telefone"].ToString(),
                        objDataReader["email"].ToString(), objDataReader["cpf"].ToString(), Convert.ToChar(objDataReader["sexo"]),
                        Convert.ToDateTime(objDataReader["data_nasc"]), perfil, endereco, objDataReader["placa_carro"].ToString(),
                        objDataReader["cidade_origem"].ToString(), Convert.ToInt32(objDataReader["cod_pessoa"]), foto, null);

                    objDataReader.Close();
                    objconexao.Close();
                    objconexao.Dispose();
                    objCommand.Dispose();
                    objDataReader.Dispose();

                    return hospede;

                }
                else if (perfil.getTipo() == "gerente" || perfil.getTipo() == "recepcionista")
                {
                    Funcionario funcionario = new Funcionario(objDataReader["nome"].ToString(), objDataReader["telefone"].ToString(),
                        objDataReader["email"].ToString(), objDataReader["cpf"].ToString(), Convert.ToChar(objDataReader["sexo"]),
                        Convert.ToDateTime(objDataReader["data_nasc"].ToString()), perfil, endereco, objDataReader["cargo"].ToString(),
                        objDataReader["numero_cnt"].ToString(), Convert.ToDouble(objDataReader["salario"]),
                        Convert.ToDateTime(objDataReader["data_admissao"]), Convert.ToInt32(objDataReader["cod_funcionario"]),
                        Convert.ToInt32(objDataReader["cod_pessoa"]), foto, null);

                    objDataReader.Close();
                    objconexao.Close();
                    objconexao.Dispose();
                    objCommand.Dispose();
                    objDataReader.Dispose();

                    return funcionario;
                }
                else
                {
                    Administrador administrador = new Administrador(objDataReader["nome"].ToString(), objDataReader["telefone"].ToString(),
                        objDataReader["email"].ToString(), objDataReader["cpf"].ToString(), Convert.ToChar(objDataReader["sexo"]),
                        Convert.ToDateTime(objDataReader["data_nasc"]), perfil, endereco, Convert.ToInt32(objDataReader["cod_administrador"]),
                        Convert.ToInt32(objDataReader["cod_pessoa"]), foto, null);

                    objDataReader.Close();
                    objconexao.Close();
                    objconexao.Dispose();
                    objCommand.Dispose();
                    objDataReader.Dispose();

                    return administrador;
                }
            }
        }
        catch (Exception)
        {
            return retorno = -2;
        }

        return retorno;
    }
}
