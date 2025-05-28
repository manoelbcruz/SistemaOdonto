namespace SistemaOdonto
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAGPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAGConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAGDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.anot = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1392, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPaciente,
            this.MenuConsulta,
            this.MenuDentista});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // MenuPaciente
            // 
            this.MenuPaciente.Name = "MenuPaciente";
            this.MenuPaciente.Size = new System.Drawing.Size(121, 22);
            this.MenuPaciente.Text = "Paciente";
            this.MenuPaciente.Click += new System.EventHandler(this.MenuPaciente_Click);
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(121, 22);
            this.MenuConsulta.Text = "Consulta";
            this.MenuConsulta.Click += new System.EventHandler(this.MenuConsulta_Click);
            // 
            // MenuDentista
            // 
            this.MenuDentista.Name = "MenuDentista";
            this.MenuDentista.Size = new System.Drawing.Size(121, 22);
            this.MenuDentista.Text = "Dentista";
            this.MenuDentista.Click += new System.EventHandler(this.MenuDentista_Click);
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAGPacientes,
            this.MenuAGConsultas,
            this.MenuAGDentistas});
            this.agendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendasToolStripMenuItem.Image")));
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.agendasToolStripMenuItem.Text = "Agendas";
            // 
            // MenuAGPacientes
            // 
            this.MenuAGPacientes.Name = "MenuAGPacientes";
            this.MenuAGPacientes.Size = new System.Drawing.Size(126, 22);
            this.MenuAGPacientes.Text = "Pacientes";
            this.MenuAGPacientes.Click += new System.EventHandler(this.MenuAGPacientes_Click);
            // 
            // MenuAGConsultas
            // 
            this.MenuAGConsultas.Name = "MenuAGConsultas";
            this.MenuAGConsultas.Size = new System.Drawing.Size(126, 22);
            this.MenuAGConsultas.Text = "Consultas";
            this.MenuAGConsultas.Click += new System.EventHandler(this.MenuAGConsultas_Click);
            // 
            // MenuAGDentistas
            // 
            this.MenuAGDentistas.Name = "MenuAGDentistas";
            this.MenuAGDentistas.Size = new System.Drawing.Size(126, 22);
            this.MenuAGDentistas.Text = "Dentistas";
            this.MenuAGDentistas.Click += new System.EventHandler(this.MenuAGDentistas_Click);
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAjuda});
            this.MAjuda.Image = ((System.Drawing.Image)(resources.GetObject("MAjuda.Image")));
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(66, 20);
            this.MAjuda.Text = "Ajuda";
            // 
            // MenuAjuda
            // 
            this.MenuAjuda.Name = "MenuAjuda";
            this.MenuAjuda.Size = new System.Drawing.Size(105, 22);
            this.MenuAjuda.Text = "Ajuda";
            this.MenuAjuda.Click += new System.EventHandler(this.MenuAjuda_Click);
            // 
            // MSair
            // 
            this.MSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSair});
            this.MSair.Image = ((System.Drawing.Image)(resources.GetObject("MSair.Image")));
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(54, 20);
            this.MSair.Text = "Sair";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(93, 22);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas do dia:";
            // 
            // cbDentista
            // 
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(199, 38);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(161, 21);
            this.cbDentista.TabIndex = 2;
            this.cbDentista.SelectionChangeCommitted += new System.EventHandler(this.cbDentista_SelectionChangeCommitted);
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Hora,
            this.Paciente,
            this.Status,
            this.CodigoPaciente});
            this.dg.Location = new System.Drawing.Point(16, 77);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(344, 1080);
            this.dg.TabIndex = 3;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 75;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 75;
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.Name = "CodigoPaciente";
            this.CodigoPaciente.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(392, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 300);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anotações";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(463, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anot
            // 
            this.anot.Location = new System.Drawing.Point(392, 390);
            this.anot.Name = "anot";
            this.anot.Size = new System.Drawing.Size(850, 650);
            this.anot.TabIndex = 7;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.anot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.cbDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "principal";
            this.Text = "SistemaOdonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem MenuPaciente;
        private System.Windows.Forms.ToolStripMenuItem MenuConsulta;
        private System.Windows.Forms.ToolStripMenuItem MenuDentista;
        private System.Windows.Forms.ToolStripMenuItem MenuAGPacientes;
        private System.Windows.Forms.ToolStripMenuItem MenuAGConsultas;
        private System.Windows.Forms.ToolStripMenuItem MenuAGDentistas;
        private System.Windows.Forms.ToolStripMenuItem MenuAjuda;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDentista;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewLinkColumn Paciente;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel anot;
    }
}