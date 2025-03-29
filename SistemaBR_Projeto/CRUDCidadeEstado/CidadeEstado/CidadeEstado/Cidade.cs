using System.Data;
using System.Data.SqlClient;

namespace CidadeEstado
{
    public partial class Cidade : Form
    {
        private string connectionString = @"Server=DESKTOP-60P28C8\SQLEXPRESS;Database=Cadastro_Cidade_Estado;Integrated Security=True;";
        private string nomecidade;
        private string nomeestado;
        private string estadosigla;
        public Cidade()
        {
            InitializeComponent();
            TestarConexao();
        }

        private void TestarConexao()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // MessageBox.Show("O banco está conectado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            nomecidade = txtCidade.Text;
        }

        private void txtBoxEstado_TextChanged(object sender, EventArgs e)
        {
            nomeestado = txtBoxEstado.Text;
        }

        private void txtBoxEstadoSigla_TextChanged(object sender, EventArgs e)
        {
            estadosigla = txtBoxEstadoSigla.Text.ToUpper();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nomecidade) && !string.IsNullOrWhiteSpace(nomeestado) && !string.IsNullOrWhiteSpace(estadosigla))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();

                        try
                        {
                            int idestado;

                            // Verifica se o estado já existe no banco
                            string queryCheckEstado = "SELECT idestado FROM Estado WHERE nomeestado = @nomeestado AND sigla = @estadosigla";
                            using (SqlCommand commandCheckEstado = new SqlCommand(queryCheckEstado, connection, transaction))
                            {
                                commandCheckEstado.Parameters.AddWithValue("@nomeestado", nomeestado);
                                commandCheckEstado.Parameters.AddWithValue("@estadosigla", estadosigla);
                                var result = commandCheckEstado.ExecuteScalar();

                                if (result != null)
                                {
                                    idestado = Convert.ToInt32(result); // Estado já existe, pega o ID
                                }
                                else
                                {
                                    // Insere o estado e recupera o ID gerado
                                    string queryInsertEstado = "INSERT INTO Estado (nomeestado, sigla) VALUES (@nomeestado, @estadosigla); SELECT SCOPE_IDENTITY();";
                                    using (SqlCommand commandInsertEstado = new SqlCommand(queryInsertEstado, connection, transaction))
                                    {
                                        commandInsertEstado.Parameters.AddWithValue("@nomeestado", nomeestado);
                                        commandInsertEstado.Parameters.AddWithValue("@estadosigla", estadosigla);
                                        idestado = Convert.ToInt32(commandInsertEstado.ExecuteScalar());
                                    }
                                }
                            }

                            // Insere a cidade associando ao idestado
                            string queryInsertCidade = "INSERT INTO Cidade (nomecidade, idestado) VALUES (@nomecidade, @idestado)";
                            using (SqlCommand commandInsertCidade = new SqlCommand(queryInsertCidade, connection, transaction))
                            {
                                commandInsertCidade.Parameters.AddWithValue("@nomecidade", nomecidade);
                                commandInsertCidade.Parameters.AddWithValue("@idestado", idestado);
                                commandInsertCidade.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Cidade & Estado cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpa os campos após o cadastro
                            txtCidade.Text = "";
                            txtBoxEstado.Text = "";
                            txtBoxEstadoSigla.Text = "";
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao cadastrar cidade: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bntListar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT C.nomecidade, C.idestado, E.nomeestado, E.sigla 
                FROM Cidade C
                INNER JOIN Estado E ON C.idestado = E.idestado;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCidade.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar cidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lblCidade.Text != "Deletar Cidade" && lblEstado.Text != "Deletar Estado")
            {
                // Primeira vez que clica: altera os labels e armazena os valores dos TextBox
                lblCidade.Text = "Deletar Cidade";
                lblEstado.Text = "Deletar Estado";

                nomecidade = txtCidade.Text;
                nomeestado = txtBoxEstado.Text;
                estadosigla = txtBoxEstadoSigla.Text;
            }
            else
            {
                // Segunda vez que clica: deleta do banco de dados
                if (!string.IsNullOrWhiteSpace(nomecidade) && !string.IsNullOrWhiteSpace(nomeestado) && !string.IsNullOrWhiteSpace(estadosigla))
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlTransaction transaction = connection.BeginTransaction();

                            try
                            {
                                // Deleta TODAS as cidades associadas ao estado
                                string queryDeleteCidades = "DELETE FROM Cidade WHERE idestado IN (SELECT idestado FROM Estado WHERE nomeestado = @nomeestado AND sigla = @estadosigla)";
                                using (SqlCommand cmdDeleteCidades = new SqlCommand(queryDeleteCidades, connection, transaction))
                                {
                                    cmdDeleteCidades.Parameters.AddWithValue("@nomeestado", nomeestado);
                                    cmdDeleteCidades.Parameters.AddWithValue("@estadosigla", estadosigla);
                                    cmdDeleteCidades.ExecuteNonQuery();
                                }

                                // Agora que não há cidades, deleta o estado
                                string queryDeleteEstado = "DELETE FROM Estado WHERE nomeestado = @nomeestado AND sigla = @estadosigla";
                                using (SqlCommand cmdDeleteEstado = new SqlCommand(queryDeleteEstado, connection, transaction))
                                {
                                    cmdDeleteEstado.Parameters.AddWithValue("@nomeestado", nomeestado);
                                    cmdDeleteEstado.Parameters.AddWithValue("@estadosigla", estadosigla);
                                    cmdDeleteEstado.ExecuteNonQuery();
                                }

                                string resetQuery = "DBCC CHECKIDENT ('Estado', RESEED, 0)";
                                using (SqlCommand resetCommand = new SqlCommand(resetQuery, connection, transaction))
                                {
                                    resetCommand.ExecuteNonQuery();
                                }

                                // Reinicia o contador de identidade para a tabela de Cidade (caso seja necessário)
                                string resetQueryCidade = "DBCC CHECKIDENT ('Cidade', RESEED, 0)";
                                using (SqlCommand resetCommandCidade = new SqlCommand(resetQueryCidade, connection, transaction))
                                {
                                    resetCommandCidade.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Cidade(s) e Estado deletados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Limpa os labels e variáveis
                    lblCidade.Text = "Cadastre uma Cidade: ";
                    lblEstado.Text = "Cadastre um Estado: ";
                    nomecidade = "";
                    nomeestado = "";
                    estadosigla = "";
                    txtCidade.Clear();
                    txtBoxEstado.Clear();
                    txtBoxEstadoSigla.Clear();
                }
                else
                {
                    MessageBox.Show("Nenhum dado foi armazenado para deletar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
