using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace trabalho_crud_senai
{
    class Carros
    {
        private int id;
        private string marca;
        private string modelo;
        private int ano;
        private string descriçao;



        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Descriçao
        {
            get { return descriçao; }
            set { descriçao = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void  InserirCarros()
        {
            try {
                using (MySqlConnection conexao = new ConexaoDBcs().Conectar())
                {
                    string sql = "INSERT INTO carros (nome, marca, ano, descricao) VALUES (@nome, @marca, @ano, @descricao)";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@marca", Marca);
                    cmd.Parameters.AddWithValue("@nome", Modelo);
                    cmd.Parameters.AddWithValue("@ano", new DateTime(Ano, 1, 1));
                    cmd.Parameters.AddWithValue("@descricao", Descriçao);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        //MessageBox.Show("Usuário inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir usuário.");

                    }
                }
            } catch (Exception ex) { 
                MessageBox.Show("Erro ao inserir carro: " + ex.Message);
            }
        }
        public void DeletarCarros()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDBcs().Conectar())
                {
                    string sql = "DELETE FROM carros WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", Id);
                    int result = cmd.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        MessageBox.Show("Erro ao excluir carro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir carro: " + ex.Message);
            }
        }
        public void AtualizarCarros()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDBcs().Conectar())
                {
                    string sql = "UPDATE carros SET marca = @marca, ano = @ano, descricao = @descricao WHERE nome = @nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@marca", Marca);
                    cmd.Parameters.AddWithValue("@nome", Modelo);
                    cmd.Parameters.AddWithValue("@ano", new DateTime(Ano, 1, 1));
                    cmd.Parameters.AddWithValue("@descricao", Descriçao); // SEM ç
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        //MessageBox.Show("Usuário inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir usuário.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir carro: " + ex.Message);
            }
        }
        public DataTable listarcarros()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDBcs().Conectar())
                {
                    string sql = "SELECT * FROM carros";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar carros: " + ex.Message);
                return null;
            }
        }
    }
}
