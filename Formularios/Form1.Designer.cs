namespace Formulario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            TelaInicial = new ToolStripMenuItem();
            cadastroDeClientes = new ToolStripMenuItem();
            agendamentoDeServiçosToolStripMenuItem = new ToolStripMenuItem();
            visualizarClienteToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TelaInicial, cadastroDeClientes, agendamentoDeServiçosToolStripMenuItem, visualizarClienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(906, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // TelaInicial
            // 
            TelaInicial.Name = "TelaInicial";
            TelaInicial.Size = new Size(74, 20);
            TelaInicial.Text = "Tela inicial";
            TelaInicial.Click += telaInicialToolStripMenuItem_Click;
            // 
            // cadastroDeClientes
            // 
            cadastroDeClientes.Name = "cadastroDeClientes";
            cadastroDeClientes.Size = new Size(125, 20);
            cadastroDeClientes.Text = "Cadastro de clientes";
            cadastroDeClientes.Click += cadastroDeClientesT;
            // 
            // agendamentoDeServiçosToolStripMenuItem
            // 
            agendamentoDeServiçosToolStripMenuItem.Name = "agendamentoDeServiçosToolStripMenuItem";
            agendamentoDeServiçosToolStripMenuItem.Size = new Size(156, 20);
            agendamentoDeServiçosToolStripMenuItem.Text = "Agendamento de serviços";
            agendamentoDeServiçosToolStripMenuItem.Click += agendamentoDeServiçosToolStripMenuItem_Click;
            // 
            // visualizarClienteToolStripMenuItem
            // 
            visualizarClienteToolStripMenuItem.Name = "visualizarClienteToolStripMenuItem";
            visualizarClienteToolStripMenuItem.Size = new Size(106, 20);
            visualizarClienteToolStripMenuItem.Text = "Visualizar cliente";
            visualizarClienteToolStripMenuItem.Click += visualizarClienteToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(669, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(237, 432);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(906, 459);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroDeClientes;
        private ToolStripMenuItem agendamentoDeServiçosToolStripMenuItem;
        private ToolStripMenuItem TelaInicial;
        private DataGridView dataGridView1;
        private ToolStripMenuItem visualizarClienteToolStripMenuItem;
    }
}
