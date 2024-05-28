using Mysqlx.Prepare;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }




        public Cliente()
        {

            Id = 0;

        }

        public Cliente(string nome, string cpf, string telefone, string email, DateTime data_nasc) 
        {

            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
        
        }

        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime data_nasc, DateTime data_cad, bool ativo)
        {

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;

        }


        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime data_nasc, DateTime data_cad, bool ativo, List<Endereco> enderecos)
        {

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            Enderecos = enderecos;

        }


        public void Inserir()
        {


            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insere_cliente";

            cmd.Parameters.AddWithValue("sp_nome", Nome);
            cmd.Parameters.AddWithValue("sp_cpf", Cpf);
            cmd.Parameters.AddWithValue("sp_telefone", Telefone);
            cmd.Parameters.AddWithValue("sp_email", Email);
            cmd.Parameters.AddWithValue("sp_data_nasc", Data_nasc);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
           

        }

        public static Cliente ObterPorId(int id)
        {

            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Telefone = dr.GetString(3);
                cliente.Email = dr.GetString(4);
                cliente.Data_nasc = dr.GetDateTime(5);
                cliente.Data_cad = dr.GetDateTime(6);
                cliente.Ativo = dr.GetBoolean(7);
                Endereco.ObterListaPorCliente(dr.GetInt32(0));



            }

            return cliente;

        }

        public static List<Cliente> ObterLista()
        {

            List<Cliente> cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes order by nome";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cliente.Add(new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetDateTime(5),
                dr.GetDateTime(6),
                dr.GetBoolean(7),
                Endereco.ObterListaPorCliente(dr.GetInt32(0))
                )
            );

            }

            return cliente;

        }

        public bool Editar(int id)
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);

            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }



    }       
}
