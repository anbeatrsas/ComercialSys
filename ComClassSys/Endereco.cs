using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Endereco
    {

        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; } 
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string  Tipo_endereco { get; set; }

        public Endereco() { }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf)
        {

            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        
        }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
        {

            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";

            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);


            cmd.ExecuteNonQuery();

        }

        public bool Editar(int id)
        {

            bool resultado = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);

            try
            {

                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public static Endereco ObterPorId(int id)
        {

            Endereco endereco = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                endereco.Id = dr.GetInt32(0);
                endereco.Cep = dr.GetString(1);
                endereco.Logradouro = dr.GetString(2);
                endereco.Numero = dr.GetString(3);
                endereco.Complemento = dr.GetString(4);
                endereco.Bairro = dr.GetString(5);
                endereco.Cidade = dr.GetString(6);
                endereco.Uf = dr.GetString(7);
                endereco.Tipo_endereco = dr.GetString(6);

            }


            return endereco;
        }


    }
}
