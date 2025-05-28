namespace SistemaOdonto
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeAgenda = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEsquerdo = new System.Windows.Forms.Button();
            this.BtnDireito = new System.Windows.Forms.Button();
            this.dtDataBuscar = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarData = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.HomeAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeAgenda);
            this.tabControl1.Location = new System.Drawing.Point(26, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 376);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // HomeAgenda
            // 
            this.HomeAgenda.BackColor = System.Drawing.Color.LightGray;
            this.HomeAgenda.CausesValidation = false;
            this.HomeAgenda.Controls.Add(this.label4);
            this.HomeAgenda.Controls.Add(this.label3);
            this.HomeAgenda.Controls.Add(this.label2);
            this.HomeAgenda.Controls.Add(this.label1);
            this.HomeAgenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeAgenda.Location = new System.Drawing.Point(4, 22);
            this.HomeAgenda.Name = "HomeAgenda";
            this.HomeAgenda.Size = new System.Drawing.Size(711, 350);
            this.HomeAgenda.TabIndex = 0;
            this.HomeAgenda.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(39, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Do lado direito existem dois botões para avançar e voltar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(39, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aqui terás acesso a todas as consultas agendadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acima você poderá escolher uma data especifica para ver as consultas daquele dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Essa é a agenda de consultas";
            // 
            // btnEsquerdo
            // 
            this.btnEsquerdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsquerdo.Image = ((System.Drawing.Image)(resources.GetObject("btnEsquerdo.Image")));
            this.btnEsquerdo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsquerdo.Location = new System.Drawing.Point(751, 152);
            this.btnEsquerdo.Name = "btnEsquerdo";
            this.btnEsquerdo.Size = new System.Drawing.Size(77, 72);
            this.btnEsquerdo.TabIndex = 22;
            this.btnEsquerdo.UseVisualStyleBackColor = true;
            this.btnEsquerdo.Click += new System.EventHandler(this.btnEsquerdo_Click);
            // 
            // BtnDireito
            // 
            this.BtnDireito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDireito.Image = ((System.Drawing.Image)(resources.GetObject("BtnDireito.Image")));
            this.BtnDireito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDireito.Location = new System.Drawing.Point(751, 230);
            this.BtnDireito.Name = "BtnDireito";
            this.BtnDireito.Size = new System.Drawing.Size(77, 63);
            this.BtnDireito.TabIndex = 21;
            this.BtnDireito.UseVisualStyleBackColor = true;
            this.BtnDireito.Click += new System.EventHandler(this.BtnDireito_Click);
            // 
            // dtDataBuscar
            // 
            this.dtDataBuscar.Location = new System.Drawing.Point(333, 36);
            this.dtDataBuscar.Name = "dtDataBuscar";
            this.dtDataBuscar.Size = new System.Drawing.Size(218, 20);
            this.dtDataBuscar.TabIndex = 23;
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBuscarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarData.Location = new System.Drawing.Point(554, 28);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(110, 36);
            this.btnBuscarData.TabIndex = 24;
            this.btnBuscarData.Text = "Buscar";
            this.btnBuscarData.UseVisualStyleBackColor = false;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscarData_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.btnBuscarData);
            this.Controls.Add(this.dtDataBuscar);
            this.Controls.Add(this.btnEsquerdo);
            this.Controls.Add(this.BtnDireito);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.tabControl1.ResumeLayout(false);
            this.HomeAgenda.ResumeLayout(false);
            this.HomeAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomeAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEsquerdo;
        private System.Windows.Forms.Button BtnDireito;
        private System.Windows.Forms.DateTimePicker dtDataBuscar;
        private System.Windows.Forms.Button btnBuscarData;
    }
}