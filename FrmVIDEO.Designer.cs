namespace ProyectoFinal
{
    partial class FrmVIDEO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVIDEO));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(44, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(575, 296);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonA;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.Location = new System.Drawing.Point(12, 366);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(159, 54);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonA;
            this.btnParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParar.FlatAppearance.BorderSize = 0;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParar.Location = new System.Drawing.Point(410, 364);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(161, 58);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonA;
            this.btnReproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReproducir.FlatAppearance.BorderSize = 0;
            this.btnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReproducir.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReproducir.Location = new System.Drawing.Point(201, 362);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(188, 58);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonA;
            this.btnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausa.FlatAppearance.BorderSize = 0;
            this.btnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausa.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPausa.Location = new System.Drawing.Point(593, 366);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(161, 58);
            this.btnPausa.TabIndex = 3;
            this.btnPausa.Text = "PAUSAR";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(79, 325);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // FrmVIDEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "FrmVIDEO";
            this.Text = "FrmVIDEO";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}