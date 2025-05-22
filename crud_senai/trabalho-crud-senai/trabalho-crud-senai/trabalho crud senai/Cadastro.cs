using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_crud_senai
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !mskTelefone.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    usuarios usuario = new usuarios();
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Telefone = mskTelefone.Text;
                    usuario.Senha = usuarios.CriptografarSenha(txtSenha.Text);
                    if (usuarios.verificarEmail(usuario.Email) == false)
                    {
                        MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    usuario.inserirusuarios();
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear();
                    txtEmail.Clear();
                    mskTelefone.Clear();
                    txtSenha.Clear();
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    txtEmail.Focus();
                    txtSenha.Focus();
                    mskTelefone.Focus();
                    txtNome.Focus();
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
