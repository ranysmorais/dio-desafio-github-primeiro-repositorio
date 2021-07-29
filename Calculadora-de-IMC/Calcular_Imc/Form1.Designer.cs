
namespace Calcular_Imc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntVerificar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.textImc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULO IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE SEU PESO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE SUA ALTURA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(146, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEU IMC É:";
            // 
            // bntVerificar
            // 
            this.bntVerificar.BackColor = System.Drawing.Color.Silver;
            this.bntVerificar.FlatAppearance.BorderSize = 0;
            this.bntVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.bntVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bntVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntVerificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntVerificar.Location = new System.Drawing.Point(35, 510);
            this.bntVerificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntVerificar.Name = "bntVerificar";
            this.bntVerificar.Size = new System.Drawing.Size(123, 85);
            this.bntVerificar.TabIndex = 4;
            this.bntVerificar.Text = "Verificar";
            this.bntVerificar.UseVisualStyleBackColor = false;
            this.bntVerificar.Click += new System.EventHandler(this.bntVerificar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.Color.Silver;
            this.bntLimpar.FlatAppearance.BorderSize = 0;
            this.bntLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bntLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bntLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntLimpar.Location = new System.Drawing.Point(165, 510);
            this.bntLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(123, 85);
            this.bntLimpar.TabIndex = 5;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Silver;
            this.bntSair.FlatAppearance.BorderSize = 0;
            this.bntSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bntSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntSair.Location = new System.Drawing.Point(295, 510);
            this.bntSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(123, 85);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // textPeso
            // 
            this.textPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPeso.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textPeso.Location = new System.Drawing.Point(232, 101);
            this.textPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(174, 29);
            this.textPeso.TabIndex = 7;
            this.textPeso.Text = " ";
            this.textPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAltura
            // 
            this.textAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAltura.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textAltura.Location = new System.Drawing.Point(232, 145);
            this.textAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(174, 29);
            this.textAltura.TabIndex = 8;
            this.textAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textImc
            // 
            this.textImc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textImc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textImc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textImc.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textImc.Location = new System.Drawing.Point(232, 186);
            this.textImc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textImc.Name = "textImc";
            this.textImc.ReadOnly = true;
            this.textImc.Size = new System.Drawing.Size(174, 36);
            this.textImc.TabIndex = 9;
            this.textImc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(146, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.calculoimc.com.br/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fonte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 614);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textImc);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntVerificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo IMC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntVerificar;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textImc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}

