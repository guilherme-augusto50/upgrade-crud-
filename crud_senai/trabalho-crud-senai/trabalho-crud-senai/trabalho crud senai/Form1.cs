using System.Runtime.InteropServices;

namespace trabalho_crud_senai
{
    public partial class Login : Form
    {
        public Login()
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

        private void Cabeçalio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void Cabeçalio_Paint(object sender, PaintEventArgs e)
        {
            Cabeçalio.Dock = DockStyle.Top;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Login_Resize(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    usuarios usuario = new usuarios();
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = usuarios.CriptografarSenha(txtSenha.Text);

                    if (usuarios.verificarEmail(usuario.Email) == false)
                    {
                        MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    usuario.logarusuarios();
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Clear();
                    txtSenha.Clear();
                    telaprincipal telaprincipal = new telaprincipal();
                    telaprincipal.Show();
                    this.Hide();
                }
                else
                {
                   MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    txtSenha.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar fazer login: " + ex.Message, "Erro - Método Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void likCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

    }
}
