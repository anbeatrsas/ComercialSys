using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Categoria
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }


    public Categoria()
        {

        }

    public Categoria(string nome, string sigla)
        {

            Nome = nome;
            Sigla = sigla;

        }

    public Categoria(int id, string nome, string sigla)
        {

            Id = id;
            Nome = nome;
            Sigla = sigla;

        }

        // métodos da classe - Inserir

        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            cmd.ExecuteNonQuery();

        }

        public static List<Categoria> ObterLista(string nome = null)
        {

            List<Categoria> lista = new List<Categoria>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;  
            if(nome == null)
            {
                cmd.CommandText = "select * from categorias";

            }
           else
            {
                cmd.CommandText = $"select * from categorias where nome like '%{nome}%' order by nome";
            }

            //cmd.CommandText = "select * from categorias";
            var dr = cmd.ExecuteReader(); // armazenar o resultado na consulta em dr

      


            while (dr.Read())
            {

                lista.Add(new Categoria(
                    
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                    
                    ));

            }

            return lista;

        }

        public static Categoria ObterPorId(int id)
        {

            Categoria categoria = new Categoria();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                categoria.Id = dr.GetInt32(0);
                categoria.Nome = dr.GetString(1);
                categoria.Sigla = dr.GetString(2);


            }

            return categoria;


        }

        public bool Editar(int id)
        {

            bool resultado = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

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


    }

    
}
