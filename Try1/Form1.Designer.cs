namespace Try1
{
    partial class Form1
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
            this.Screen = new System.Windows.Forms.Panel();
            this.PacienteB = new System.Windows.Forms.Button();
            this.ConsultaB = new System.Windows.Forms.Button();
            this.Citasb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Screen.AutoSize = true;
            this.Screen.Location = new System.Drawing.Point(234, -1);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(773, 438);
            this.Screen.TabIndex = 0;
            // 
            // PacienteB
            // 
            this.PacienteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacienteB.Location = new System.Drawing.Point(0, 357);
            this.PacienteB.Name = "PacienteB";
            this.PacienteB.Size = new System.Drawing.Size(238, 57);
            this.PacienteB.TabIndex = 1;
            this.PacienteB.Text = "Pacientes ";
            this.PacienteB.UseVisualStyleBackColor = true;
            this.PacienteB.Click += new System.EventHandler(this.PacienteB_Click);
            // 
            // ConsultaB
            // 
            this.ConsultaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaB.Location = new System.Drawing.Point(0, 290);
            this.ConsultaB.Name = "ConsultaB";
            this.ConsultaB.Size = new System.Drawing.Size(238, 59);
            this.ConsultaB.TabIndex = 2;
            this.ConsultaB.Text = "Consulta";
            this.ConsultaB.UseVisualStyleBackColor = true;
            this.ConsultaB.Click += new System.EventHandler(this.ConsultaB_Click);
            // 
            // Citasb
            // 
            this.Citasb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citasb.Location = new System.Drawing.Point(0, 225);
            this.Citasb.Name = "Citasb";
            this.Citasb.Size = new System.Drawing.Size(238, 59);
            this.Citasb.TabIndex = 3;
            this.Citasb.Text = "Citas";
            this.Citasb.UseVisualStyleBackColor = true;
            this.Citasb.Click += new System.EventHandler(this.Citasb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ConsultaB);
            this.panel1.Controls.Add(this.Citasb);
            this.panel1.Controls.Add(this.PacienteB);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 438);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Try1.Properties.Resources.pngwing1;
            this.pictureBox1.Location = new System.Drawing.Point(48, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Try1.Properties.Resources.free_exit_logout_icon_2857_thumb;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1006, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Screen);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Button PacienteB;
        private System.Windows.Forms.Button ConsultaB;
        private System.Windows.Forms.Button Citasb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}