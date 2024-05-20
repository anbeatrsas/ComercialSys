
using System.Data;
namespace ComClassSys
{
    public class Usuario
    {
        
        // criando propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Nivel { get; set; } // suporta valor nulo com o uso de "?"
        public bool Ativo { get; set; } 


        // criando métodos construtores

        public Usuario() { }

        public Usuario(string nome, string email, string senha, string nivel)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
           
        }

        public Usuario(int id, string nome, string email, string senha, string nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
         
        // métodos da classe - Funcionalidades de Usuários

        public void Inserir()
        {
            // nosso primeiro método

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure; // O tipo de comando que vou passar pelo cmd é o StoredProcedure

            // qual storedPRocedure que vou acionar para fazer o insert na tabela de usuário
            cmd.CommandText = "sp_usuario_insert";

            // passando cada um dos parâmetros da procedure
            // spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel char(1)
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel);
            cmd.ExecuteNonQuery(); // executando do mysql (sinal de raio)

        }

        public bool Editar(int id) 
        {


            return true;
        }

        public static Usuario ObterPorId(int id) // apenas retorna o usuario com o id 
        {

            Usuario usuario = new Usuario();
            return usuario;

        }

        public static List<Usuario> ObterLista() // entrega uma lista de usuário, usando static sem criar a classe usuario
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios"; // pegando a consulta
            var dr = cmd.ExecuteReader(); // resultado da consulta mysql, guardando o resultado da consulta

            while (dr.Read()) // Read tem a função de avancar para o proximo registro
            {
                lista.Add(new Usuario(
                                     dr.GetInt32(0),
                                     dr.GetString(1),
                                     dr.GetString(2),
                                     dr.GetString(3),
                                     dr.GetString(4),
                                     dr.GetBoolean(5)
                                     ));
            } 
            return lista;
        }


    }
}
