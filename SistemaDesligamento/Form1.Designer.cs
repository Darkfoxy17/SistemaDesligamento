namespace SistemaDesligamento
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
            this.dtAgendar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txbMinutos = new System.Windows.Forms.TextBox();
            this.btnAgendarMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtAgendar
            // 
            this.dtAgendar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtAgendar.Location = new System.Drawing.Point(217, 91);
            this.dtAgendar.Name = "dtAgendar";
            this.dtAgendar.Size = new System.Drawing.Size(62, 20);
            this.dtAgendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha o horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desligar em";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(209, 117);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(85, 23);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txbMinutos
            // 
            this.txbMinutos.Location = new System.Drawing.Point(197, 236);
            this.txbMinutos.Name = "txbMinutos";
            this.txbMinutos.Size = new System.Drawing.Size(109, 20);
            this.txbMinutos.TabIndex = 4;
            // 
            // btnAgendarMin
            // 
            this.btnAgendarMin.Location = new System.Drawing.Point(207, 262);
            this.btnAgendarMin.Name = "btnAgendarMin";
            this.btnAgendarMin.Size = new System.Drawing.Size(87, 23);
            this.btnAgendarMin.TabIndex = 5;
            this.btnAgendarMin.Text = "Agendar";
            this.btnAgendarMin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Outros";
            // 
            // btnDesliga
            // 
            this.btnDesliga.Location = new System.Drawing.Point(207, 355);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(87, 23);
            this.btnDesliga.TabIndex = 7;
            this.btnDesliga.Text = "Desligar agora";
            this.btnDesliga.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SistemaDesligamento.Properties.Resources.power_off_504x512;
            this.ClientSize = new System.Drawing.Size(503, 509);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesliga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgendarMin);
            this.Controls.Add(this.txbMinutos);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtAgendar);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtAgendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txbMinutos;
        private System.Windows.Forms.Button btnAgendarMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.Button btnCancelar;
    }
}

