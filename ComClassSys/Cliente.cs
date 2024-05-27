using Mysqlx.Prepare;
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
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }




        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string telefone, string email, DateTime data_nasc) 
        {

            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
        
        }

        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime data_nasc, bool ativo)
        {

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Ativo = ativo;

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

            cmd.ExecuteNonQuery();

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

            }


            return cliente;


        }




    }       
}
