
namespace ProvedorInternet
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
            this.listacidades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.mbs1 = new System.Windows.Forms.RadioButton();
            this.mbs2 = new System.Windows.Forms.RadioButton();
            this.mbs3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simEmail = new System.Windows.Forms.CheckBox();
            this.simHosp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listacidades
            // 
            this.listacidades.FormattingEnabled = true;
            this.listacidades.ItemHeight = 15;
            this.listacidades.Items.AddRange(new object[] {
            "Rio de Janeiro - RJ",
            "Búzios - RJ",
            "São Paulo - SP",
            "Campos do Jordão - SP",
            "Ouro Preto - MG",
            "Balneáro Camboripu - SC",
            "Pomerode - SC",
            "Curitiba - PR",
            "Bento Gonçalves - RS",
            "Gramado - RS",
            "Morretes - PA",
            "Triunfo - PE",
            "Campo Grande - MS"});
            this.listacidades.Location = new System.Drawing.Point(61, 93);
            this.listacidades.Name = "listacidades";
            this.listacidades.Size = new System.Drawing.Size(163, 199);
            this.listacidades.TabIndex = 0;
            this.listacidades.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolhe a Cidade que deseja ter o provedor de Internet:";
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcular.Location = new System.Drawing.Point(264, 308);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(107, 39);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // mbs1
            // 
            this.mbs1.AutoSize = true;
            this.mbs1.Location = new System.Drawing.Point(6, 22);
            this.mbs1.Name = "mbs1";
            this.mbs1.Size = new System.Drawing.Size(64, 19);
            this.mbs1.TabIndex = 3;
            this.mbs1.TabStop = true;
            this.mbs1.Text = "10 MBS";
            this.mbs1.UseVisualStyleBackColor = true;
            // 
            // mbs2
            // 
            this.mbs2.AutoSize = true;
            this.mbs2.Location = new System.Drawing.Point(6, 47);
            this.mbs2.Name = "mbs2";
            this.mbs2.Size = new System.Drawing.Size(64, 19);
            this.mbs2.TabIndex = 4;
            this.mbs2.TabStop = true;
            this.mbs2.Text = "30 MBS";
            this.mbs2.UseVisualStyleBackColor = true;
            // 
            // mbs3
            // 
            this.mbs3.AutoSize = true;
            this.mbs3.Location = new System.Drawing.Point(6, 72);
            this.mbs3.Name = "mbs3";
            this.mbs3.Size = new System.Drawing.Size(64, 19);
            this.mbs3.TabIndex = 5;
            this.mbs3.TabStop = true;
            this.mbs3.Text = "60 MBS";
            this.mbs3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mbs1);
            this.groupBox1.Controls.Add(this.mbs3);
            this.groupBox1.Controls.Add(this.mbs2);
            this.groupBox1.Location = new System.Drawing.Point(264, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantidade de MBS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(264, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Opcional): Três e-mails fornecidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(264, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "(Opcional) Página pessoal hospedada:";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(264, 383);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(90, 21);
            this.resultado.TabIndex = 14;
            this.resultado.Text = "Resultado:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // simEmail
            // 
            this.simEmail.AutoSize = true;
            this.simEmail.Location = new System.Drawing.Point(548, 227);
            this.simEmail.Name = "simEmail";
            this.simEmail.Size = new System.Drawing.Size(46, 19);
            this.simEmail.TabIndex = 16;
            this.simEmail.Text = "Sim";
            this.simEmail.UseVisualStyleBackColor = true;
            // 
            // simHosp
            // 
            this.simHosp.AutoSize = true;
            this.simHosp.Location = new System.Drawing.Point(548, 255);
            this.simHosp.Name = "simHosp";
            this.simHosp.Size = new System.Drawing.Size(46, 19);
            this.simHosp.TabIndex = 17;
            this.simHosp.Text = "Sim";
            this.simHosp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simHosp);
            this.Controls.Add(this.simEmail);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listacidades);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Provedor de Internet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listacidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.RadioButton mbs1;
        private System.Windows.Forms.RadioButton mbs2;
        private System.Windows.Forms.RadioButton mbs3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.CheckBox simEmail;
        private System.Windows.Forms.CheckBox simHosp;
    }
}

