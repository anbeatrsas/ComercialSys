using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Mysqlx.Prepare;

namespace ComClassSys
{
    public class ItemPedido
    {
        

        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public ItemPedido(int id, int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido()
        {           

        }

        public ItemPedido(int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }


        // métodos Manter
        // Inserir Item 
        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);


            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }


        // Consultar Item de pedido (Obter por id ped e id prod)
        public static ItemPedido ObterItem(int idPedido, int idProduto=0)
        {

            ItemPedido itemPedido = new();

            return itemPedido;

        }


        public static List<ItemPedido> ObterListaPorPedido(int idPedido)
        {

            List<ItemPedido> itens = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from itempedido where pedido_id = {idPedido}";
            var dr = cmd.ExecuteReader(); // resultado da consulta feita e será armazenada no data reader um leitor de dados, e no caso vai ser armazenada na variável dr

            while (dr.Read()) // percorre todas as linhas do execute reader
            {
                itens.Add(new(dr.GetInt32(0), 
                    dr.GetInt32(1), 
                    Produto.ObterPorId(dr.GetInt32(2)), 
                    dr.GetDouble(3), 
                    dr.GetDouble(4), 
                    dr.GetDouble(5)));
            }

            return itens;

        }


        // alterar item
        public bool Alterar(int id)
        {


            return true;
        }


        // Excluir
        public void Remover(int id)
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();

        }


    }
}
