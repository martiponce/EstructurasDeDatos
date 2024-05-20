namespace pryPonceDeLeonMartinaEstrucDatos
{
    partial class frmOperacionesBaseDeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperacionesBaseDeDatos));
            this.dgvBaseDaos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProyecJuntar = new System.Windows.Forms.Button();
            this.btnProyecMultiAtributo = new System.Windows.Forms.Button();
            this.btnProyecSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelecConvo = new System.Windows.Forms.Button();
            this.bnSelecSimple = new System.Windows.Forms.Button();
            this.btnSelecMuliAributo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDaos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDaos
            // 
            this.dgvBaseDaos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBaseDaos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDaos.Location = new System.Drawing.Point(14, 12);
            this.dgvBaseDaos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBaseDaos.Name = "dgvBaseDaos";
            this.dgvBaseDaos.Size = new System.Drawing.Size(907, 438);
            this.dgvBaseDaos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProyecJuntar);
            this.groupBox1.Controls.Add(this.btnProyecMultiAtributo);
            this.groupBox1.Controls.Add(this.btnProyecSimple);
            this.groupBox1.Location = new System.Drawing.Point(14, 487);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(284, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyecto - SELECT";
            // 
            // btnProyecJuntar
            // 
            this.btnProyecJuntar.Location = new System.Drawing.Point(39, 136);
            this.btnProyecJuntar.Name = "btnProyecJuntar";
            this.btnProyecJuntar.Size = new System.Drawing.Size(210, 23);
            this.btnProyecJuntar.TabIndex = 4;
            this.btnProyecJuntar.Text = "Juntar";
            this.btnProyecJuntar.UseVisualStyleBackColor = true;
            this.btnProyecJuntar.Click += new System.EventHandler(this.btnProyecJuntar_Click);
            // 
            // btnProyecMultiAtributo
            // 
            this.btnProyecMultiAtributo.Location = new System.Drawing.Point(39, 85);
            this.btnProyecMultiAtributo.Name = "btnProyecMultiAtributo";
            this.btnProyecMultiAtributo.Size = new System.Drawing.Size(210, 23);
            this.btnProyecMultiAtributo.TabIndex = 3;
            this.btnProyecMultiAtributo.Text = "Proyección multiaributo\r\n";
            this.btnProyecMultiAtributo.UseVisualStyleBackColor = true;
            this.btnProyecMultiAtributo.Click += new System.EventHandler(this.btnProyecMultiAtributo_Click);
            // 
            // btnProyecSimple
            // 
            this.btnProyecSimple.Location = new System.Drawing.Point(39, 40);
            this.btnProyecSimple.Name = "btnProyecSimple";
            this.btnProyecSimple.Size = new System.Drawing.Size(210, 23);
            this.btnProyecSimple.TabIndex = 2;
            this.btnProyecSimple.Text = "Proyección Simple";
            this.btnProyecSimple.UseVisualStyleBackColor = true;
            this.btnProyecSimple.Click += new System.EventHandler(this.btnProyecSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelecConvo);
            this.groupBox2.Controls.Add(this.bnSelecSimple);
            this.groupBox2.Controls.Add(this.btnSelecMuliAributo);
            this.groupBox2.Location = new System.Drawing.Point(328, 487);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(284, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSelecConvo
            // 
            this.btnSelecConvo.Location = new System.Drawing.Point(34, 136);
            this.btnSelecConvo.Name = "btnSelecConvo";
            this.btnSelecConvo.Size = new System.Drawing.Size(210, 23);
            this.btnSelecConvo.TabIndex = 5;
            this.btnSelecConvo.Text = "Selección por Convolución";
            this.btnSelecConvo.UseVisualStyleBackColor = true;
            this.btnSelecConvo.Click += new System.EventHandler(this.btnSelecConvo_Click);
            // 
            // bnSelecSimple
            // 
            this.bnSelecSimple.Location = new System.Drawing.Point(34, 40);
            this.bnSelecSimple.Name = "bnSelecSimple";
            this.bnSelecSimple.Size = new System.Drawing.Size(210, 23);
            this.bnSelecSimple.TabIndex = 6;
            this.bnSelecSimple.Text = "Selección Simple";
            this.bnSelecSimple.UseVisualStyleBackColor = true;
            this.bnSelecSimple.Click += new System.EventHandler(this.bnSelecSimple_Click);
            // 
            // btnSelecMuliAributo
            // 
            this.btnSelecMuliAributo.Location = new System.Drawing.Point(34, 87);
            this.btnSelecMuliAributo.Name = "btnSelecMuliAributo";
            this.btnSelecMuliAributo.Size = new System.Drawing.Size(210, 21);
            this.btnSelecMuliAributo.TabIndex = 7;
            this.btnSelecMuliAributo.Text = "Selección multiatributo";
            this.btnSelecMuliAributo.UseVisualStyleBackColor = true;
            this.btnSelecMuliAributo.Click += new System.EventHandler(this.btnSelecMuliAributo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Location = new System.Drawing.Point(637, 487);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(284, 201);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebráicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(36, 136);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(210, 23);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(36, 40);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(210, 23);
            this.btnUnion.TabIndex = 9;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(36, 87);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(210, 21);
            this.btnInterseccion.TabIndex = 10;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // frmOperacionesBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDaos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmOperacionesBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmOperacionesBaseDeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDaos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDaos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProyecJuntar;
        private System.Windows.Forms.Button btnProyecMultiAtributo;
        private System.Windows.Forms.Button btnProyecSimple;
        private System.Windows.Forms.Button btnSelecConvo;
        private System.Windows.Forms.Button bnSelecSimple;
        private System.Windows.Forms.Button btnSelecMuliAributo;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInterseccion;
    }
}