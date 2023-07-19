namespace Jogo_da_cobrinha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.Fundo = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Recorde = new System.Windows.Forms.Label();
            this.Tempodejogo = new System.Windows.Forms.Timer(this.components);
            this.Barra = new System.Windows.Forms.ProgressBar();
            this.Barratxt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Atalhos = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nivel1 = new System.Windows.Forms.CheckBox();
            this.Nivel2 = new System.Windows.Forms.CheckBox();
            this.Nivel3 = new System.Windows.Forms.CheckBox();
            this.Velocidde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fundo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(12, 22);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(125, 37);
            this.start.TabIndex = 0;
            this.start.TabStop = false;
            this.start.Text = "Começar";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start);
            // 
            // Fundo
            // 
            this.Fundo.BackColor = System.Drawing.Color.Gray;
            this.Fundo.Enabled = false;
            this.Fundo.Location = new System.Drawing.Point(12, 66);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(477, 288);
            this.Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Fundo.TabIndex = 1;
            this.Fundo.TabStop = false;
            this.Fundo.UseWaitCursor = true;
            this.Fundo.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateJogo);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(143, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(79, 15);
            this.Score.TabIndex = 2;
            this.Score.Text = "Pontuação: 0";
            // 
            // Recorde
            // 
            this.Recorde.AutoSize = true;
            this.Recorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recorde.Location = new System.Drawing.Point(143, 34);
            this.Recorde.Name = "Recorde";
            this.Recorde.Size = new System.Drawing.Size(67, 15);
            this.Recorde.TabIndex = 3;
            this.Recorde.Text = "Recorde: 0";
            // 
            // Tempodejogo
            // 
            this.Tempodejogo.Interval = 40;
            this.Tempodejogo.Tick += new System.EventHandler(this.Tempodejogo_Tick);
            // 
            // Barra
            // 
            this.Barra.Location = new System.Drawing.Point(352, 9);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(137, 23);
            this.Barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Barra.TabIndex = 4;
            this.Barra.Visible = false;
            // 
            // Barratxt
            // 
            this.Barratxt.AutoSize = true;
            this.Barratxt.Location = new System.Drawing.Point(349, 36);
            this.Barratxt.Name = "Barratxt";
            this.Barratxt.Size = new System.Drawing.Size(102, 13);
            this.Barratxt.TabIndex = 5;
            this.Barratxt.Text = "Distancia ate record";
            this.Barratxt.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atalhos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Atalhos
            // 
            this.Atalhos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarESCToolStripMenuItem,
            this.reiniciarRToolStripMenuItem});
            this.Atalhos.Name = "Atalhos";
            this.Atalhos.Size = new System.Drawing.Size(59, 20);
            this.Atalhos.Text = "Atalhos";
            // 
            // finalizarESCToolStripMenuItem
            // 
            this.finalizarESCToolStripMenuItem.Name = "finalizarESCToolStripMenuItem";
            this.finalizarESCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finalizarESCToolStripMenuItem.Text = "Finalizar \"ESC\"";
            this.finalizarESCToolStripMenuItem.Click += new System.EventHandler(this.finalizarESCToolStripMenuItem_Click);
            // 
            // reiniciarRToolStripMenuItem
            // 
            this.reiniciarRToolStripMenuItem.Name = "reiniciarRToolStripMenuItem";
            this.reiniciarRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reiniciarRToolStripMenuItem.Text = "Reiniciar \"R\"";
            this.reiniciarRToolStripMenuItem.Click += new System.EventHandler(this.reiniciarRToolStripMenuItem_Click);
            // 
            // Nivel1
            // 
            this.Nivel1.AutoSize = true;
            this.Nivel1.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nivel1.Location = new System.Drawing.Point(243, 7);
            this.Nivel1.Name = "Nivel1";
            this.Nivel1.Size = new System.Drawing.Size(69, 18);
            this.Nivel1.TabIndex = 10;
            this.Nivel1.Text = "Nivel Facil";
            this.Nivel1.UseVisualStyleBackColor = true;
            this.Nivel1.Click += new System.EventHandler(this.Facil);
            // 
            // Nivel2
            // 
            this.Nivel2.AutoSize = true;
            this.Nivel2.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nivel2.Location = new System.Drawing.Point(243, 27);
            this.Nivel2.Name = "Nivel2";
            this.Nivel2.Size = new System.Drawing.Size(78, 18);
            this.Nivel2.TabIndex = 11;
            this.Nivel2.Text = "Nivel Medio";
            this.Nivel2.UseVisualStyleBackColor = true;
            this.Nivel2.Click += new System.EventHandler(this.Medio);
            // 
            // Nivel3
            // 
            this.Nivel3.AutoSize = true;
            this.Nivel3.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nivel3.Location = new System.Drawing.Point(243, 46);
            this.Nivel3.Name = "Nivel3";
            this.Nivel3.Size = new System.Drawing.Size(73, 18);
            this.Nivel3.TabIndex = 12;
            this.Nivel3.Text = "Nivel Dificil";
            this.Nivel3.UseVisualStyleBackColor = true;
            this.Nivel3.Click += new System.EventHandler(this.Dificil);
            // 
            // Velocidde
            // 
            this.Velocidde.AutoSize = true;
            this.Velocidde.Location = new System.Drawing.Point(12, 28);
            this.Velocidde.Name = "Velocidde";
            this.Velocidde.Size = new System.Drawing.Size(63, 13);
            this.Velocidde.TabIndex = 13;
            this.Velocidde.Text = "Velocidade:";
            this.Velocidde.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 367);
            this.Controls.Add(this.Velocidde);
            this.Controls.Add(this.Nivel3);
            this.Controls.Add(this.Nivel2);
            this.Controls.Add(this.Nivel1);
            this.Controls.Add(this.Barratxt);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.Recorde);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Fundo);
            this.Controls.Add(this.start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jogo da cobrinha feito por Gabriel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.Fundo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox Fundo;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Recorde;
        private System.Windows.Forms.Timer Tempodejogo;
        private System.Windows.Forms.ProgressBar Barra;
        private System.Windows.Forms.Label Barratxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Atalhos;
        private System.Windows.Forms.CheckBox Nivel1;
        private System.Windows.Forms.CheckBox Nivel2;
        private System.Windows.Forms.CheckBox Nivel3;
        private System.Windows.Forms.ToolStripMenuItem finalizarESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarRToolStripMenuItem;
        private System.Windows.Forms.Label Velocidde;
    }
}

