namespace Formulario.Formularios
{
    partial class Cadastro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            telaInicialToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClienteToolStripMenuItem = new ToolStripMenuItem();
            agendamentoDeServiçosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { telaInicialToolStripMenuItem, cadastroDeClienteToolStripMenuItem, agendamentoDeServiçosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1190, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // telaInicialToolStripMenuItem
            // 
            telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            telaInicialToolStripMenuItem.Size = new Size(91, 24);
            telaInicialToolStripMenuItem.Text = "Tela inicial";
            telaInicialToolStripMenuItem.Click += telaInicialToolStripMenuItem_Click;
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            cadastroDeClienteToolStripMenuItem.Size = new Size(149, 24);
            cadastroDeClienteToolStripMenuItem.Text = "Cadastro de cliente";
            cadastroDeClienteToolStripMenuItem.Click += cadastroDeClienteToolStripMenuItem_Click;
            // 
            // agendamentoDeServiçosToolStripMenuItem
            // 
            agendamentoDeServiçosToolStripMenuItem.Name = "agendamentoDeServiçosToolStripMenuItem";
            agendamentoDeServiçosToolStripMenuItem.Size = new Size(193, 24);
            agendamentoDeServiçosToolStripMenuItem.Text = "Agendamento de serviços";
            agendamentoDeServiçosToolStripMenuItem.Click += agendamentoDeServiçosToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(393, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 5;
            label3.Tag = "CPF";
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 76);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Cliente";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(599, 46);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "Contato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(17, 396);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 8;
            label6.Text = "Endereço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(17, 431);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 9;
            label7.Text = "Data de nascimento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(398, 438);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 10;
            label8.Text = "Cliente Ativo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(17, 360);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 11;
            label9.Text = "CEP";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(186, 43);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 27);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(186, 76);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 27);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(191, 396);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(363, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(708, 43);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 27);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(191, 360);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(153, 27);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ScrollBar;
            textBox7.Location = new Point(186, 111);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 27);
            textBox7.TabIndex = 18;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ScrollBar;
            textBox8.Location = new Point(488, 112);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(352, 27);
            textBox8.TabIndex = 19;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(191, 431);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sim", "Não" });
            comboBox1.Location = new Point(548, 431);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 28);
            comboBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(902, 479);
            button1.Name = "button1";
            button1.Size = new Size(114, 42);
            button1.TabIndex = 25;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(782, 479);
            button2.Name = "button2";
            button2.Size = new Size(114, 42);
            button2.TabIndex = 26;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(662, 479);
            button4.Name = "button4";
            button4.Size = new Size(114, 42);
            button4.TabIndex = 28;
            button4.Text = "Deletar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Cadastro
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1190, 529);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11F);
            ForeColor = SystemColors.HighlightText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cadastro";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            Load += Cadastro_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem telaInicialToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private ToolStripMenuItem agendamentoDeServiçosToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}