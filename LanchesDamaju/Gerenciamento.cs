using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchesDamaju
{
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
        }

        private void buttonCadLanches_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string conexaoString = "Server=localhost; Port=3306; Database=db_damaju; Uid=root; Pwd=;";

            //Defina a insert de registro no DB

            string query = "INSERT INTO tb_lanches (nome, valor, descricao, categoria, imagem) VALUES (@nome, @valor, @descricao, @categoria, @imagem)";

            //Crie uma conexão com o DB

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNomeLanche.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@descricao", richTextBoxDesc.Text);
                        comando.Parameters.AddWithValue("@categoria", comboBoxCategoria.Text);
                        comando.Parameters.AddWithValue("@imagem", pictureBoxLanche.Text);

                        // Executa o comando inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Lanche inserido com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem do erro
                    MessageBox.Show("Erro: " + ex.Message);

                }
            }
        }

        private void buttonExcluirDoCardapio_Click(object sender, EventArgs e)
        {
            if (dgvLanches.SelectedRows.Count > 0)
            {
                // Pega ID do lanche da linha selecionada
                int lancheID = Convert.ToInt32(dgvLanches.SelectedRows[0].Cells["id_Lanche"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse lanche do cardapio? (esse processo é irreversível)", "Confimar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Defina sua string de conexão com o bank
                    string connectionString = "Server=localhost; Port=3306; Database=db_damaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_lanches WHERE id_Lanche = @id_Lanche";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_Lanche", lancheID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Lanche excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o lanche");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, selecione um dos lanches para excluir do cardapio");
                }
            }
        }

        private void buttonPesquisarNoCardapio_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string connectionString = "Server=localhost; Port=3306; Database=db_damaju; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados Mysql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes
                    string listagem = "SELECT id_Lanche, nome, valor, descricao, categoria, imagem FROM tb_lanches";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosLanches = new DataTable();
                        dadosLanches.Load(reader);

                        //Atribui a tabela
                        dgvLanches.DataSource = dadosLanches;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os lanches: " + ex.Message);
            }
        }

        private void LimparCamposLanches_Click(object sender, EventArgs e)
        {
            textBoxNomeLanche.Text = "";
            maskedTextBoxValor.Text = "";
            richTextBoxDesc.Text = "";
            comboBoxCategoria.Text = "";
            pictureBoxLanche.Text = "";
        }

        private void buttonCadClientes_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string conexaoString = "Server=localhost; Port=3306; Database=db_damaju; Uid=root; Pwd=;";

            //Defina a insert de registro no DB

            string query = "INSERT INTO tb_clientes (nome, senha, email, cpf, cep, numero, telefone, imagem) VALUES (@nome, @senha, @email, @cpf, @cep, @numero, @telefone, @imagem)";

            //Crie uma conexão com o DB

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNomeCli.Text);
                        comando.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                        comando.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@cep", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@numero", maskedTextBoxNum.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBoxTel.Text);
                        comando.Parameters.AddWithValue("@imagem", pictureBoxCli.Text);

                        // Executa o comando inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Cliente cadastrado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem do erro
                    MessageBox.Show("Erro: " + ex.Message);

                }
            }
        }

        private void buttonExcluirCli_Click(object sender, EventArgs e)
        {
            if (dgvLanches.SelectedRows.Count > 0)
            {
                // Pega ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(dgvLanches.SelectedRows[0].Cells["id_Cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse cliente da lista? (esse processo é irreversível)", "Confimar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Defina sua string de conexão com o bank
                    string connectionString = "Server=localhost; Port=3306; Database=db_damaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_clientes WHERE id_Cliente = @id_Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_clientes", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, selecione um dos clientes para excluir da lista");
                }
            }
        }
        private void buttonPesquisarCli_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string connectionString = "Server=localhost; Port=3306; Database=db_damaju; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados Mysql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes
                    string listagem = "SELECT id_Cliente, nome, senha, email, cpf, cep, numero, telefone, imagem FROM tb_clientes";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela
                        dgvClientes.DataSource = dadosClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar clientes: " + ex.Message);
            }
        }

        private void LimparCamposClientes_Click(object sender, EventArgs e)
        {
            textBoxNomeCli.Text = "";
            textBoxSenha.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxNum.Text = "";
            maskedTextBoxTel.Text = "";
        }

        private void buttonInserirImgLanche_Click(object sender, EventArgs e)
        {
            // Criar um OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir o filtro para apenas arquivos de imagem
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            // Se o usuário escolher um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carregar a imagem no PictureBox
                pictureBoxLanche.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }

        private void buttonInserirImgCli_Click(object sender, EventArgs e)
        {
            // Criar um OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir o filtro para apenas arquivos de imagem
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            // Se o usuário escolher um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carregar a imagem no PictureBox
                pictureBoxCli.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }
    }
}