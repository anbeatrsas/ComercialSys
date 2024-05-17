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
            return lista;
        }


    }
}
