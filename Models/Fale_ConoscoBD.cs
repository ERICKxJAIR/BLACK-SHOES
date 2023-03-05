using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySqlConnector;
using System.Linq;

namespace black_shoes.Models
{
    public class Fale_ConoscoBD    
    {

        private static string dadosConexao = "Database=fale_conosco; Data Source=localhost; User id=root;";
        
        public static String TesteConexao(){
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            conexao.Close();
            string mensagem = "Conectado";
            return mensagem;
       
        }
 
        public static void Inserir(Fale_Conosco fale_Conosco){
           MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "INSERT INTO atendimento (Nome, Endereco, Email, Assunto) VALUES (@Nome,@Endereco,@Email,@assunto);";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@Nome", fale_Conosco.Nome);
            comando.Parameters.AddWithValue("@Endereco", fale_Conosco.Endereco);
            comando.Parameters.AddWithValue("@Email",fale_Conosco.Email);
            comando.Parameters.AddWithValue("@Assunto", fale_Conosco.Assunto);
            comando.ExecuteNonQuery();
            conexao.Close(); 
        }
     
        public static List<Fale_Conosco> Listar() {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "SELECT * FROM atendimento;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            List<Fale_Conosco> lista = new List<Fale_Conosco>();
        
          while (leitor.Read()) {
                Fale_Conosco fale_Conosco= new Fale_Conosco();

                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    fale_Conosco.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Nome")))
                    fale_Conosco.Nome = leitor.GetString("Nome");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Endereco")))
                    fale_Conosco.Endereco = leitor.GetString("Endereco");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Email")))
                    fale_Conosco.Email = leitor.GetString("Email");
                if (!leitor.IsDBNull(leitor.GetOrdinal("assunto")))
                    fale_Conosco.Assunto = leitor.GetString("Assunto");      

                lista.Add(fale_Conosco);
            }

            conexao.Close();
            return lista;
        }
        
        public static void Atualizar (Fale_Conosco fale_Conosco) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "UPDATE atendimento SET marca=@Nome,@Endereco,@Email,@Assunto WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@Nome", fale_Conosco.Nome);
            comando.Parameters.AddWithValue("@Endereco", fale_Conosco.Endereco);
            comando.Parameters.AddWithValue("@Email", fale_Conosco.Email);
            comando.Parameters.AddWithValue("@Assunto", fale_Conosco.Assunto);
            comando.Parameters.AddWithValue("@id", fale_Conosco.id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }        
    
         public static void Remover (int id) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "DELETE FROM atendimento WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }        
        public static Fale_Conosco BuscarPorId(int id) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "SELECT * FROM atendimento WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            Fale_Conosco fale_Conosco = new Fale_Conosco();

            if (leitor.Read()) {
                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    fale_Conosco.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Nome")))
                    fale_Conosco.Nome = leitor.GetString("Nome");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Endereco")))
                    fale_Conosco.Endereco = leitor.GetString("Endereco");
                if (!leitor.IsDBNull(leitor.GetOrdinal("Email")))
                    fale_Conosco.Email = leitor.GetString("Email");
                if (!leitor.IsDBNull(leitor.GetOrdinal("assunto")))
                    fale_Conosco.Assunto = leitor.GetString("Assunto"); 
            }

            conexao.Close();
            return fale_Conosco;
        }
    }
}