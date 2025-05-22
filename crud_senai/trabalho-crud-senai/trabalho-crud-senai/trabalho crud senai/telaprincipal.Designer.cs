namespace trabalho_crud_senai
{
    partial class telaprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExcluir = new Button();
            btnatualizar = new Button();
            btnCadastrar = new Button();
            txtDescriçao = new TextBox();
            txtMarca = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dateTimeAno = new DateTimePicker();
            label3 = new Label();
            txtCarro = new TextBox();
            label2 = new Label();
            datagridCarros = new DataGridView();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridCarros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 41);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(392, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 2;
            label1.Text = "Automotive Combustion";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_linha_horizontal_24;
            pictureBox2.Location = new Point(944, 8);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_excluir_24__1_;
            pictureBox1.Location = new Point(982, 8);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnatualizar);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(txtDescriçao);
            panel2.Controls.Add(txtMarca);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimeAno);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCarro);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(datagridCarros);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 41);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 540);
            panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(0, 0, 192);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(674, 414);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnatualizar
            // 
            btnatualizar.BackColor = Color.FromArgb(0, 0, 192);
            btnatualizar.Cursor = Cursors.Hand;
            btnatualizar.FlatStyle = FlatStyle.Popup;
            btnatualizar.ForeColor = SystemColors.ControlLightLight;
            btnatualizar.Location = new Point(497, 414);
            btnatualizar.Name = "btnatualizar";
            btnatualizar.Size = new Size(81, 23);
            btnatualizar.TabIndex = 11;
            btnatualizar.Text = "Atualizar";
            btnatualizar.UseVisualStyleBackColor = false;
            btnatualizar.Click += btnatualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(0, 0, 192);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(310, 414);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Adicionar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtDescriçao
            // 
            txtDescriçao.Cursor = Cursors.IBeam;
            txtDescriçao.Location = new Point(102, 124);
            txtDescriçao.Multiline = true;
            txtDescriçao.Name = "txtDescriçao";
            txtDescriçao.Size = new Size(267, 60);
            txtDescriçao.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Location = new Point(74, 94);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 26);
            txtMarca.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 127);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 7;
            label6.Text = "Descriçao:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 6;
            label5.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 68);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 5;
            label4.Text = "Ano:";
            // 
            // dateTimeAno
            // 
            dateTimeAno.Cursor = Cursors.Hand;
            dateTimeAno.CustomFormat = "yyy";
            dateTimeAno.Format = DateTimePickerFormat.Custom;
            dateTimeAno.Location = new Point(72, 62);
            dateTimeAno.Name = "dateTimeAno";
            dateTimeAno.Size = new Size(76, 26);
            dateTimeAno.TabIndex = 4;
            dateTimeAno.ValueChanged += dateTimeAno_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 35);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 3;
            label3.Text = "Carro:";
            // 
            // txtCarro
            // 
            txtCarro.Cursor = Cursors.IBeam;
            txtCarro.Location = new Point(72, 27);
            txtCarro.Margin = new Padding(4);
            txtCarro.Name = "txtCarro";
            txtCarro.Size = new Size(127, 26);
            txtCarro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(424, 4);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 18);
            label2.TabIndex = 1;
            label2.Text = "<nome de usuario>";
            // 
            // datagridCarros
            // 
            datagridCarros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridCarros.Cursor = Cursors.Cross;
            datagridCarros.Location = new Point(9, 191);
            datagridCarros.Margin = new Padding(4);
            datagridCarros.Name = "datagridCarros";
            datagridCarros.ReadOnly = true;
            datagridCarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridCarros.Size = new Size(997, 216);
            datagridCarros.TabIndex = 0;
            datagridCarros.CellContentClick += datagridCarros_CellContentClick;
            datagridCarros.CellContentDoubleClick += datagridCarros_CellContentDoubleClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_21_de_mai__de_2025__23_15_35;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1016, 540);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // telaprincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 581);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "telaprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaprincipal";
            TopMost = true;
            Load += telaprincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridCarros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private DataGridView datagridCarros;
        private Label label3;
        private TextBox txtCarro;
        private Label label4;
        private DateTimePicker dateTimeAno;
        private TextBox txtDescriçao;
        private TextBox txtMarca;
        private Label label6;
        private Label label5;
        private Button btnExcluir;
        private Button btnatualizar;
        private Button btnCadastrar;
        private PictureBox pictureBox3;
    }
}