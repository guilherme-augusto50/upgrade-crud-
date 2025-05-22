using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace trabalho_crud_senai
{
    class usuarios
    {
        private int id;
        private string nome;
        private string senha;
        private string email;
        private string telefone;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }
        public bool EmailExiste(string email)
        {
            try
            {
                ConexaoDBcs conn = new ConexaoDBcs();
                string sql = "SELECT 1 FROM clientes WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(sql, conn.Conectar());
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar email: " + ex.Message);
                return false;
            }
        }
        public bool inserirusuarios()
        {
            try {
                ConexaoDBcs conn = new ConexaoDBcs();
                string sql = "INSERT INTO clientes (nome, senha, email, telefone) VALUES (@nome, @senha, @email, @telefone)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.Conectar());
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha", CriptografarSenha(Senha));
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@telefone", Telefone);
               int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    //MessageBox.Show("Usuário inserido com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao inserir usuário.");
                    return false;
                }
            } catch (Exception ex) { 
                MessageBox.Show("Erro ao inserir usuário: " + ex.Message);
                return false;
            }
        }
        public void logarusuarios() {
            try {
                using (MySqlConnection conexao = new ConexaoDBcs().Conectar())
                {
                    string sql = "SELECT * FROM clientes WHERE email = @Email AND senha = @Senha";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", CriptografarSenha(Senha));

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        //MessageBox.Show("Login realizado com sucesso!");
                        // Aqui você pode redirecionar o usuário para outra tela ou realizar outras ações
                    }
                    else
                    {
                        //MessageBox.Show("Email ou senha inválidos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar usuário: " + ex.Message);
            }

        }

    }
}
