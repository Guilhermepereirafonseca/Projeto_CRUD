namespace CidadeEstado
{
    partial class Cidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cidade));
            label1 = new Label();
            picBoxFundo1 = new PictureBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            dataGridViewCidade = new DataGridView();
            btnCadastrar = new Button();
            pictureBox2 = new PictureBox();
            bntListar = new Button();
            lblEstado = new Label();
            txtBoxEstado = new TextBox();
            txtBoxEstadoSigla = new TextBox();
            label4 = new Label();
            btnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxFundo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 29);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 0;
            label1.Text = "Cidade - Estado";
            // 
            // picBoxFundo1
            // 
            picBoxFundo1.BackColor = Color.White;
            picBoxFundo1.Location = new Point(12, 15);
            picBoxFundo1.Name = "picBoxFundo1";
            picBoxFundo1.Size = new Size(663, 532);
            picBoxFundo1.TabIndex = 1;
            picBoxFundo1.TabStop = false;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.White;
            lblCidade.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCidade.Location = new Point(19, 100);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(199, 22);
            lblCidade.TabIndex = 1;
            lblCidade.Text = "Cadastre uma Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Cursor = Cursors.IBeam;
            txtCidade.Location = new Point(32, 125);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Nome inteiro";
            txtCidade.Size = new Size(205, 23);
            txtCidade.TabIndex = 2;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // dataGridViewCidade
            // 
            dataGridViewCidade.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCidade.Location = new Point(105, 284);
            dataGridViewCidade.Name = "dataGridViewCidade";
            dataGridViewCidade.Size = new Size(439, 233);
            dataGridViewCidade.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Location = new Point(19, 206);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.photo_sistemaBR;
            pictureBox2.Location = new Point(32, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // bntListar
            // 
            bntListar.BackColor = Color.White;
            bntListar.Cursor = Cursors.Hand;
            bntListar.FlatStyle = FlatStyle.Popup;
            bntListar.Location = new Point(100, 207);
            bntListar.Name = "bntListar";
            bntListar.Size = new Size(75, 23);
            bntListar.TabIndex = 8;
            bntListar.Text = "Listar";
            bntListar.UseVisualStyleBackColor = false;
            bntListar.Click += bntListar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.White;
            lblEstado.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(19, 151);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(188, 22);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Cadastre um Estado:";
            // 
            // txtBoxEstado
            // 
            txtBoxEstado.Cursor = Cursors.IBeam;
            txtBoxEstado.Location = new Point(32, 176);
            txtBoxEstado.Name = "txtBoxEstado";
            txtBoxEstado.PlaceholderText = "Nome Inteiro";
            txtBoxEstado.Size = new Size(163, 23);
            txtBoxEstado.TabIndex = 4;
            txtBoxEstado.TextChanged += txtBoxEstado_TextChanged;
            // 
            // txtBoxEstadoSigla
            // 
            txtBoxEstadoSigla.Cursor = Cursors.IBeam;
            txtBoxEstadoSigla.Location = new Point(278, 176);
            txtBoxEstadoSigla.Name = "txtBoxEstadoSigla";
            txtBoxEstadoSigla.PlaceholderText = "2 Letras";
            txtBoxEstadoSigla.Size = new Size(61, 23);
            txtBoxEstadoSigla.TabIndex = 6;
            txtBoxEstadoSigla.TextChanged += txtBoxEstadoSigla_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(219, 175);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 5;
            label4.Text = "Sigla:";
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.White;
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.FlatStyle = FlatStyle.Popup;
            btnDeletar.Location = new Point(181, 207);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Cidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(687, 559);
            Controls.Add(btnDeletar);
            Controls.Add(label4);
            Controls.Add(txtBoxEstadoSigla);
            Controls.Add(txtBoxEstado);
            Controls.Add(lblEstado);
            Controls.Add(bntListar);
            Controls.Add(pictureBox2);
            Controls.Add(btnCadastrar);
            Controls.Add(dataGridViewCidade);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(label1);
            Controls.Add(picBoxFundo1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cidade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cidade & Estado";
            ((System.ComponentModel.ISupportInitialize)picBoxFundo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picBoxFundo1;
        private Label lblCidade;
        private TextBox txtCidade;
        private DataGridView dataGridViewCidade;
        private Button btnCadastrar;
        private PictureBox pictureBox2;
        private Button bntListar;
        private Label lblEstado;
        private TextBox txtBoxEstado;
        private TextBox txtBoxEstadoSigla;
        private Label label4;
        private Button btnDeletar;
    }
}
