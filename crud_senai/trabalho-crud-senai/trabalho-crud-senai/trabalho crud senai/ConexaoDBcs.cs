using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace trabalho_crud_senai
{
    class ConexaoDBcs
    {
        private string servidor = "Server=localhost; Database=lojaDb; Uid=root; Pwd='';";

        public MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(servidor);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            return null;
        }
    }
}
