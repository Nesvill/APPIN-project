namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVIN = new System.Windows.Forms.Button();
            this.btnPronun = new System.Windows.Forms.Button();
            this.btnInmat = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(470, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIENVENIDO!!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnVIN);
            this.flowLayoutPanel1.Controls.Add(this.btnPronun);
            this.flowLayoutPanel1.Controls.Add(this.btnInmat);
            this.flowLayoutPanel1.Controls.Add(this.btnAcerca);
            this.flowLayoutPanel1.Controls.Add(this.btnSalir);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 749);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProyectoFinal.Properties.Resources._170742420_445504813211480_2652268775977943356_n1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(206, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1144, 746);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 132);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnVIN
            // 
            this.btnVIN.BackColor = System.Drawing.Color.White;
            this.btnVIN.BackgroundImage = global::ProyectoFinal.Properties.Resources.vin;
            this.btnVIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIN.Location = new System.Drawing.Point(3, 141);
            this.btnVIN.Name = "btnVIN";
            this.btnVIN.Size = new System.Drawing.Size(197, 137);
            this.btnVIN.TabIndex = 2;
            this.btnVIN.UseVisualStyleBackColor = false;
            this.btnVIN.Click += new System.EventHandler(this.btnVIN_Click);
            // 
            // btnPronun
            // 
            this.btnPronun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPronun.BackgroundImage")));
            this.btnPronun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPronun.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronun.Location = new System.Drawing.Point(3, 284);
            this.btnPronun.Name = "btnPronun";
            this.btnPronun.Size = new System.Drawing.Size(197, 124);
            this.btnPronun.TabIndex = 1;
            this.btnPronun.UseVisualStyleBackColor = true;
            this.btnPronun.Click += new System.EventHandler(this.btnPronun_Click);
            // 
            // btnInmat
            // 
            this.btnInmat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInmat.BackgroundImage")));
            this.btnInmat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInmat.Location = new System.Drawing.Point(3, 414);
            this.btnInmat.Name = "btnInmat";
            this.btnInmat.Size = new System.Drawing.Size(197, 111);
            this.btnInmat.TabIndex = 3;
            this.btnInmat.UseVisualStyleBackColor = true;
            this.btnInmat.Click += new System.EventHandler(this.btnInmat_Click);
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackgroundImage = global::ProyectoFinal.Properties.Resources.botonA1;
            this.btnAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcerca.Font = new System.Drawing.Font("Snap ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAcerca.Location = new System.Drawing.Point(3, 531);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(197, 103);
            this.btnAcerca.TabIndex = 0;
            this.btnAcerca.Text = "Acerca de nosotros";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(3, 640);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(197, 97);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "APPIN";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnPronun;
        private System.Windows.Forms.Button btnVIN;
        private System.Windows.Forms.Button btnInmat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

