namespace trabalho_crud_senai
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Cabeçalio = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            btnLogin = new Button();
            likCadastro = new LinkLabel();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            Cabeçalio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Cabeçalio
            // 
            Cabeçalio.BackColor = Color.DarkBlue;
            Cabeçalio.Controls.Add(label1);
            Cabeçalio.Controls.Add(pictureBox2);
            Cabeçalio.Controls.Add(pictureBox1);
            Cabeçalio.Dock = DockStyle.Top;
            Cabeçalio.Location = new Point(0, 0);
            Cabeçalio.Name = "Cabeçalio";
            Cabeçalio.Size = new Size(816, 43);
            Cabeçalio.TabIndex = 2;
            Cabeçalio.Paint += Cabeçalio_Paint;
            Cabeçalio.MouseDown += Cabeçalio_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(362, 2);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_linha_horizontal_24;
            pictureBox2.Location = new Point(750, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_excluir_24__1_;
            pictureBox1.Location = new Point(780, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 42, 56);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 447);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(likCadastro);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtSenha);
            panel3.Location = new Point(23, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 392);
            panel3.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(97, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(152, 109);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 156);
            label3.Name = "label3";
            label3.Size = new Size(45, 16);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 0, 192);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(116, 287);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // likCadastro
            // 
            likCadastro.ActiveLinkColor = Color.DarkMagenta;
            likCadastro.AutoSize = true;
            likCadastro.Cursor = Cursors.Hand;
            likCadastro.LinkColor = Color.FromArgb(0, 0, 192);
            likCadastro.Location = new Point(126, 351);
            likCadastro.Name = "likCadastro";
            likCadastro.Size = new Size(85, 16);
            likCadastro.TabIndex = 5;
            likCadastro.TabStop = true;
            likCadastro.Text = "Cadastre-se";
            likCadastro.VisitedLinkColor = Color.FromArgb(64, 0, 64);
            likCadastro.LinkClicked += likCadastro_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(97, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(149, 201);
            label4.Name = "label4";
            label4.Size = new Size(52, 16);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Location = new Point(97, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 23);
            txtSenha.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox3);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 447);
            panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._14bcaf57_4598_4a95_a1af_763dae195732;
            pictureBox3.Location = new Point(407, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(409, 447);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 489);
            Controls.Add(Cabeçalio);
            Controls.Add(panel1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tela de login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            Resize += Login_Resize;
            Cabeçalio.ResumeLayout(false);
            Cabeçalio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Cabeçalio;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Button btnLogin;
        private LinkLabel likCadastro;
        private Panel panel3;
        private PictureBox pictureBox4;
    }
}
