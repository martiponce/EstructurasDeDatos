namespace pryPonceDeLeonMartinaEstrucDatos
{
    partial class frmDatosAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAlumno));
            this.picAlumno = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picTecno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTecno)).BeginInit();
            this.SuspendLayout();
            // 
            // picAlumno
            // 
            this.picAlumno.Image = ((System.Drawing.Image)(resources.GetObject("picAlumno.Image")));
            this.picAlumno.Location = new System.Drawing.Point(41, 50);
            this.picAlumno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picAlumno.Name = "picAlumno";
            this.picAlumno.Size = new System.Drawing.Size(467, 404);
            this.picAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlumno.TabIndex = 0;
            this.picAlumno.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARTINA\r\n\r\nPONCE DE LEÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "44 . 767 . 788";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 509);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 120);
            this.label3.TabIndex = 3;
            this.label3.Text = "♥ANALISTA EN SISTEMAS \r\n♥ESTRUCTURA DE DATOS\r\n♥TERCER SEMESTRE";
            // 
            // picTecno
            // 
            this.picTecno.Image = ((System.Drawing.Image)(resources.GetObject("picTecno.Image")));
            this.picTecno.Location = new System.Drawing.Point(601, 357);
            this.picTecno.Name = "picTecno";
            this.picTecno.Size = new System.Drawing.Size(300, 300);
            this.picTecno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTecno.TabIndex = 4;
            this.picTecno.TabStop = false;
            // 
            // frmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.picTecno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAlumno);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDatosAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.picAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTecno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picTecno;
    }
}