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
        public int ClienteId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; } 
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string  Tipo_endereco { get; set; }

        public Endereco() { }

        public Endereco(int id, int clienteId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
        {

            Id = id;
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        
        }

        public Endereco(int clienteId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
        {

            ClienteId = clienteId;
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

            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);


            cmd.ExecuteNonQuery();

        }

        public bool Editar(int id)
        {

            bool resultado = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
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
                endereco.ClienteId = dr.GetInt32(1);
                endereco.Cep = dr.GetString(2);
                endereco.Logradouro = dr.GetString(3);
                endereco.Numero = dr.GetString(4);
                endereco.Complemento = dr.GetString(5);
                endereco.Bairro = dr.GetString(6);
                endereco.Cidade = dr.GetString(7);
                endereco.Uf = dr.GetString(8);
                endereco.Tipo_endereco = dr.GetString(9);

            }


            return endereco;
        }


        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {

            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where cliente_id = {clienteId}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                enderecos.Add(new
                    (dr.GetInt32(0), 
                    dr.GetInt32(1), 
                    dr.GetString(2), 
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9))

                    );

            }

            return enderecos;
        }

    }
}
