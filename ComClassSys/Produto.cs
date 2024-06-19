using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Produto
    {
        public int Id { get; set; }
        public string Cod_barras { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor_unit { get; set; }
        public string Unidade_venda { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Estoque_minimo { get; set; }
        public decimal Classe_desconto { get; set; }
        public string? Imagem { get; set; }
        public DateTime Data_cad {  get; set; }


        public Produto()
            {

           

            }


        public Produto(string cod_barras, string descricao, decimal valor_unit, string unidade_venda, Categoria categoria, decimal estoque_minimo, decimal classe_desconto, string imagem, DateTime data_cad)
            {

                Cod_barras = cod_barras;
                Descricao = descricao;
                Valor_unit = valor_unit;
                Unidade_venda = unidade_venda;
                Categoria = categoria;
                Estoque_minimo = estoque_minimo;
                Classe_desconto = classe_desconto;
                Imagem = imagem;
                Data_cad = data_cad;

            }


        public Produto(int id, string cod_barras, string descricao, decimal valor_unit, string unidade_venda, Categoria categoria, decimal estoque_minimo, decimal classe_desconto, string imagem, DateTime data_cad)
        {

                Id = id;
                Cod_barras = cod_barras;
                Descricao = descricao;
                Valor_unit = valor_unit;
                Unidade_venda = unidade_venda;
                Categoria = categoria;
                Estoque_minimo = estoque_minimo;
                Classe_desconto = classe_desconto;
                Imagem = imagem;
                Data_cad = data_cad;

        }


        public Produto(int id, string cod_barras, string descricao, decimal valor_unit, string unidade_venda, Categoria categoria, decimal estoque_minimo, decimal classe_desconto, DateTime data_cad)
        {

            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Data_cad = data_cad;

        }

        public Produto(int id, string cod_barras, string descricao, decimal valor_unit, string unidade_venda, Categoria categoria, decimal estoque_minimo, decimal classe_desconto)
        {

            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;

        }


        public Produto(string cod_barras, string descricao, decimal valor_unit, string unidade_venda, Categoria categoria, decimal estoque_minimo, decimal classe_desconto)
        {

            
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;

        }


        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";

            cmd.Parameters.AddWithValue("spcod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);

            cmd.ExecuteNonQuery();

        }

        public static Produto ObterPorId(int id)
        {

            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                produto.Id = dr.GetInt32(0);
                produto.Cod_barras = dr.GetString(1);
                produto.Descricao = dr.GetString(2);
                produto.Valor_unit = dr.GetDecimal(3);
                produto.Unidade_venda = dr.GetString(4);
                produto.Categoria = Categoria.ObterPorId(dr.GetInt32(5));
                produto.Estoque_minimo = dr.GetDecimal(6);
                produto.Classe_desconto = dr.GetDecimal(7);
                //produto.Imagem = dr.GetString(8);
                produto.Data_cad = dr.GetDateTime(9);

            }

            return produto;

        }

        public bool Editar(int id)
        {

            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);

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

        public static List<Produto> ObterLista()
        {

            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                produto.Add(new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetDecimal(3),
                dr.GetString(4),
                Categoria.ObterPorId(dr.GetInt32(5)),
                dr.GetDecimal(6),
                dr.GetDecimal(7),
                //dr.GetString(8),
                dr.GetDateTime(9))
                );

            }



            return produto;
        }
        
    }


}
