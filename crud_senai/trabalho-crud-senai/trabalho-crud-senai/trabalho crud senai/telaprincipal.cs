using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_crud_senai
{
    public partial class telaprincipal : Form
    {
        public telaprincipal()
        {
            InitializeComponent();
            Carros carro = new Carros();
            datagridCarros.DataSource = new Carros().listarcarros();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCarro.Text.Equals("") && !txtMarca.Text.Equals("") && !dateTimeAno.Text.Equals("") && !txtDescriçao.Text.Equals(""))
                {
                    Carros carro = new Carros();
                    carro.Marca = txtMarca.Text;
                    carro.Modelo = txtCarro.Text;
                    carro.Ano = dateTimeAno.Value.Year;
                    carro.Descriçao = txtDescriçao.Text;
                    carro.InserirCarros();
                    MessageBox.Show("Carro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCarro.Clear();
                    txtDescriçao.Clear();
                    txtMarca.Clear();
                    dateTimeAno.ResetText();
                    datagridCarros.DataSource = carro.listarcarros();
                    datagridCarros.Refresh();
                    datagridCarros.ClearSelection();
                    datagridCarros.AllowUserToAddRows = false;
                    datagridCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    datagridCarros.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCarro.Focus();
                    txtMarca.Focus();
                    dateTimeAno.Focus();
                    txtDescriçao.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void dateTimeAno_ValueChanged(object sender, EventArgs e)
        {
            dateTimeAno.Format = DateTimePickerFormat.Custom;
            dateTimeAno.CustomFormat = "yyyy";
            dateTimeAno.ShowUpDown = true;
        }

        private void datagridCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telaprincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Carros carro = new Carros();
                datagridCarros.DataSource = carro.listarcarros();
                datagridCarros.Refresh();
                datagridCarros.ClearSelection();
                datagridCarros.AllowUserToAddRows = false;
                datagridCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridCarros.AutoResizeColumns();
                datagridCarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                datagridCarros.MultiSelect = false;
                datagridCarros.ReadOnly = true;
                datagridCarros.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a tela principal: " + ex.Message);
            }
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCarro.Text.Equals("") && !txtMarca.Text.Equals("") && !txtDescriçao.Text.Equals("") && !dateTimeAno.Text.Equals(""))
                {
                    Carros carros = new Carros();
                    carros.Marca = txtMarca.Text;
                    carros.Modelo = txtCarro.Text;
                    carros.Ano = Convert.ToInt32(dateTimeAno.Text);
                    carros.Descriçao = txtDescriçao.Text;

                    carros.AtualizarCarros();
                    MessageBox.Show("Carro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCarro.Clear();
                    txtDescriçao.Clear();
                    txtMarca.Clear();
                    dateTimeAno.ResetText();
                    datagridCarros.DataSource = carros.listarcarros();
                    datagridCarros.Refresh();
                    datagridCarros.ClearSelection();
                    datagridCarros.AllowUserToAddRows = false;
                    datagridCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    datagridCarros.AutoResizeColumns();

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCarro.Focus();
                    txtMarca.Focus();
                    dateTimeAno.Focus();
                    txtDescriçao.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void datagridCarros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = datagridCarros.Rows[e.RowIndex];
                    txtCarro.Text = row.Cells["nome"].Value.ToString();
                    txtMarca.Text = row.Cells["marca"].Value.ToString();
                    if (int.TryParse(row.Cells["ano"]?.Value?.ToString(), out int ano))
                    {
                        dateTimeAno.Value = new DateTime(ano, 1, 1);
                    }
                    txtDescriçao.Text = row.Cells["descricao"].Value.ToString();
                    datagridCarros.ClearSelection();
                    datagridCarros.AllowUserToAddRows = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar carro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagridCarros.SelectedRows.Count > 0)
                {
                    int idSelecionado = Convert.ToInt32(datagridCarros.SelectedRows[0].Cells["id"].Value);

                    DialogResult result = MessageBox.Show("Deseja realmente excluir este carro?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Carros carro = new Carros();
                        carro.Id = idSelecionado;
                        carro.DeletarCarros();
                        MessageBox.Show("Carro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagridCarros.DataSource = carro.listarcarros();
                        datagridCarros.Refresh();
                        datagridCarros.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Exclusão cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Selecione um carro para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }
    }
}
