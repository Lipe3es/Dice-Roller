
namespace teste
{
    partial class Rolador_de_Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rolador_de_Dados));
            this.txt_maior = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_maior = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_r1 = new System.Windows.Forms.Label();
            this.lbl_pericia = new System.Windows.Forms.Label();
            this.txt_pericia = new System.Windows.Forms.TextBox();
            this.lbl_r4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_r5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_maior
            // 
            this.txt_maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maior.Location = new System.Drawing.Point(17, 46);
            this.txt_maior.Name = "txt_maior";
            this.txt_maior.Size = new System.Drawing.Size(139, 26);
            this.txt_maior.TabIndex = 1;
            this.txt_maior.TextChanged += new System.EventHandler(this.txt_maior_TextChanged);
            this.txt_maior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maior_KeyPress);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Salmon;
            this.btn_calcular.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(15, 175);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(85, 43);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Rolar";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_maior
            // 
            this.lbl_maior.AutoSize = true;
            this.lbl_maior.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maior.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maior.ForeColor = System.Drawing.Color.White;
            this.lbl_maior.Location = new System.Drawing.Point(12, 18);
            this.lbl_maior.Name = "lbl_maior";
            this.lbl_maior.Size = new System.Drawing.Size(249, 25);
            this.lbl_maior.TabIndex = 6;
            this.lbl_maior.Text = "Digite o número de lados:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resultado.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbl_resultado.ForeColor = System.Drawing.Color.White;
            this.lbl_resultado.Location = new System.Drawing.Point(335, 18);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(126, 27);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "Resultados:";
            // 
            // lbl_r1
            // 
            this.lbl_r1.AutoSize = true;
            this.lbl_r1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_r1.ForeColor = System.Drawing.Color.White;
            this.lbl_r1.Location = new System.Drawing.Point(577, 84);
            this.lbl_r1.Name = "lbl_r1";
            this.lbl_r1.Size = new System.Drawing.Size(0, 20);
            this.lbl_r1.TabIndex = 9;
            // 
            // lbl_pericia
            // 
            this.lbl_pericia.AutoSize = true;
            this.lbl_pericia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pericia.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pericia.ForeColor = System.Drawing.Color.White;
            this.lbl_pericia.Location = new System.Drawing.Point(12, 84);
            this.lbl_pericia.Name = "lbl_pericia";
            this.lbl_pericia.Size = new System.Drawing.Size(272, 25);
            this.lbl_pericia.TabIndex = 11;
            this.lbl_pericia.Text = "Digite o valor da sua perícia:";
            // 
            // txt_pericia
            // 
            this.txt_pericia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pericia.Location = new System.Drawing.Point(15, 112);
            this.txt_pericia.Name = "txt_pericia";
            this.txt_pericia.ReadOnly = true;
            this.txt_pericia.Size = new System.Drawing.Size(140, 26);
            this.txt_pericia.TabIndex = 12;
            this.txt_pericia.TextChanged += new System.EventHandler(this.txt_pericia_TextChanged);
            this.txt_pericia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pericia_KeyPress);
            // 
            // lbl_r4
            // 
            this.lbl_r4.AutoSize = true;
            this.lbl_r4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_r4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_r4.ForeColor = System.Drawing.Color.White;
            this.lbl_r4.Location = new System.Drawing.Point(290, 138);
            this.lbl_r4.Name = "lbl_r4";
            this.lbl_r4.Size = new System.Drawing.Size(0, 25);
            this.lbl_r4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "O valor do seu dado é:";
            // 
            // lbl_r5
            // 
            this.lbl_r5.AutoSize = true;
            this.lbl_r5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_r5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_r5.ForeColor = System.Drawing.Color.White;
            this.lbl_r5.Location = new System.Drawing.Point(290, 175);
            this.lbl_r5.Name = "lbl_r5";
            this.lbl_r5.Size = new System.Drawing.Size(0, 25);
            this.lbl_r5.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btn_calcular);
            this.panel1.Controls.Add(this.lbl_r5);
            this.panel1.Controls.Add(this.lbl_maior);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_maior);
            this.panel1.Controls.Add(this.lbl_r4);
            this.panel1.Controls.Add(this.lbl_pericia);
            this.panel1.Controls.Add(this.lbl_r1);
            this.panel1.Controls.Add(this.txt_pericia);
            this.panel1.Controls.Add(this.lbl_resultado);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 263);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(171, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Jogar com Perícia";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Rolador_de_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(711, 393);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Rolador_de_Dados";
            this.Text = "Rolador de Dados";
            this.Load += new System.EventHandler(this.Rolador_de_Dados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_maior;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_maior;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_r1;
        private System.Windows.Forms.Label lbl_pericia;
        private System.Windows.Forms.TextBox txt_pericia;
        private System.Windows.Forms.Label lbl_r4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_r5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

