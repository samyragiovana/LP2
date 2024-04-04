using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    internal class Conexao
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=root;database=dreamfit";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddCliente(Cliente std)
        {
            string sql = "INSERT INTO Cliente VALUES (NULL, @ClienteNome, @ClienteEndereco, @ClienteTelefone, @ClientePlano)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteNome", MySqlDbType.VarChar).Value = std.Nome;
            cmd.Parameters.Add("@ClienteEndereco", MySqlDbType.VarChar).Value = std.Endereco;
            cmd.Parameters.Add("@ClienteTelefone", MySqlDbType.VarChar).Value = std.Telefone;
            cmd.Parameters.Add("@ClientePlano", MySqlDbType.VarChar).Value = std.Plano;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente não foi inserido. \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateStudent(Cliente std, string id)
        {
            string sql = "UPDATE Cliente SET Nome = @ClienteNome, Endereco = @ClienteEndereco, Telefone = @ClienteTelefone, Plano = @ClientePlano WHERE id = @Clienteid";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Clienteid", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ClienteNome", MySqlDbType.VarChar).Value = std.Nome;
            cmd.Parameters.Add("@ClienteEndereco", MySqlDbType.VarChar).Value = std.Endereco;
            cmd.Parameters.Add("@ClienteTelefone", MySqlDbType.VarChar).Value = std.Telefone;
            cmd.Parameters.Add("@ClientePlano", MySqlDbType.VarChar).Value = std.Plano;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente atualizado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente não foi atualizado. \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM Cliente WHERE ID = @ClienteID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado com Sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente não foi deletado. \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayStudentAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
