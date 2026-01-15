namespace Formulario.Formularios
{
    partial class Agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            telaInicialToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClientesToolStripMenuItem = new ToolStripMenuItem();
            agendamentoDeServiçosToolStripMenuItem = new ToolStripMenuItem();
            visualizarInformaçõesToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(497, 34);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(33, 86);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Agendamento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cabelo (50)", "Barba (30)", "Sombrancelha (20)", "Cabelo + Barba (70)", "Cabelo + Barba + Sombrancelha (80)" });
            comboBox1.Location = new Point(261, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(181, 34);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Serviços";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(559, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 23);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(5, 424);
            button1.Name = "button1";
            button1.Size = new Size(205, 30);
            button1.TabIndex = 9;
            button1.Text = "Confirmar agendamento";
            button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { telaInicialToolStripMenuItem, cadastroDeClientesToolStripMenuItem, agendamentoDeServiçosToolStripMenuItem, visualizarInformaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1123, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // telaInicialToolStripMenuItem
            // 
            telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            telaInicialToolStripMenuItem.Size = new Size(91, 24);
            telaInicialToolStripMenuItem.Text = "Tela inicial";
            telaInicialToolStripMenuItem.Click += telaInicialToolStripMenuItem_Click;
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            cadastroDeClientesToolStripMenuItem.Size = new Size(155, 24);
            cadastroDeClientesToolStripMenuItem.Text = "Cadastro de clientes";
            cadastroDeClientesToolStripMenuItem.Click += cadastroDeClientesToolStripMenuItem_Click;
            // 
            // agendamentoDeServiçosToolStripMenuItem
            // 
            agendamentoDeServiçosToolStripMenuItem.Name = "agendamentoDeServiçosToolStripMenuItem";
            agendamentoDeServiçosToolStripMenuItem.Size = new Size(193, 24);
            agendamentoDeServiçosToolStripMenuItem.Text = "Agendamento de serviços";
            agendamentoDeServiçosToolStripMenuItem.Click += agendamentoDeServiçosToolStripMenuItem_Click;
            // 
            // visualizarInformaçõesToolStripMenuItem
            // 
            visualizarInformaçõesToolStripMenuItem.Name = "visualizarInformaçõesToolStripMenuItem";
            visualizarInformaçõesToolStripMenuItem.Size = new Size(170, 24);
            visualizarInformaçõesToolStripMenuItem.Text = "Visualizar informações";
            visualizarInformaçõesToolStripMenuItem.Click += visualizarInformaçõesToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(154, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(653, 424);
            button2.Name = "button2";
            button2.Size = new Size(184, 30);
            button2.TabIndex = 12;
            button2.Text = "Deletar agendamento";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(437, 424);
            button3.Name = "button3";
            button3.Size = new Size(196, 30);
            button3.TabIndex = 13;
            button3.Text = "Consultar agendamento";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(227, 424);
            button4.Name = "button4";
            button4.Size = new Size(193, 30);
            button4.TabIndex = 14;
            button4.Text = "Atualizar agendamento";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(843, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(285, 473);
            dataGridView1.TabIndex = 15;
            dataGridView1.Visible = false;
            // 
            // Agendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1123, 500);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Agendamento";
            Text = "Agendamento";
            Load += Agendamento_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem telaInicialToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private ToolStripMenuItem agendamentoDeServiçosToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem visualizarInformaçõesToolStripMenuItem;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}