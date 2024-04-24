namespace pryPonceDeLeonMartinaEstrucDatos
{
    partial class frmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.radInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.radPreOrden = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.rdPostOrden = new System.Windows.Forms.RadioButton();
            this.grillaArbolBinario = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArbolBinario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radInOrdenAsc
            // 
            this.radInOrdenAsc.AutoSize = true;
            this.radInOrdenAsc.Location = new System.Drawing.Point(81, 65);
            this.radInOrdenAsc.Name = "radInOrdenAsc";
            this.radInOrdenAsc.Size = new System.Drawing.Size(162, 19);
            this.radInOrdenAsc.TabIndex = 7;
            this.radInOrdenAsc.TabStop = true;
            this.radInOrdenAsc.Text = "In-Orden-Ascendente";
            this.radInOrdenAsc.UseVisualStyleBackColor = true;
            // 
            // radPreOrden
            // 
            this.radPreOrden.AutoSize = true;
            this.radPreOrden.Location = new System.Drawing.Point(81, 152);
            this.radPreOrden.Name = "radPreOrden";
            this.radPreOrden.Size = new System.Drawing.Size(92, 19);
            this.radPreOrden.TabIndex = 8;
            this.radPreOrden.TabStop = true;
            this.radPreOrden.Text = "Pre-Orden";
            this.radPreOrden.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radInOrdenAsc);
            this.groupBox3.Controls.Add(this.rdInOrdenDesc);
            this.groupBox3.Controls.Add(this.rdPostOrden);
            this.groupBox3.Controls.Add(this.radPreOrden);
            this.groupBox3.Controls.Add(this.grillaArbolBinario);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 268);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado del Árbol";
            // 
            // rdInOrdenDesc
            // 
            this.rdInOrdenDesc.AutoSize = true;
            this.rdInOrdenDesc.Location = new System.Drawing.Point(81, 108);
            this.rdInOrdenDesc.Name = "rdInOrdenDesc";
            this.rdInOrdenDesc.Size = new System.Drawing.Size(171, 19);
            this.rdInOrdenDesc.TabIndex = 8;
            this.rdInOrdenDesc.TabStop = true;
            this.rdInOrdenDesc.Text = "In-Orden-Descendente";
            this.rdInOrdenDesc.UseVisualStyleBackColor = true;
            this.rdInOrdenDesc.CheckedChanged += new System.EventHandler(this.rdInOrdenDesc_CheckedChanged);
            // 
            // rdPostOrden
            // 
            this.rdPostOrden.AutoSize = true;
            this.rdPostOrden.Location = new System.Drawing.Point(81, 198);
            this.rdPostOrden.Name = "rdPostOrden";
            this.rdPostOrden.Size = new System.Drawing.Size(98, 19);
            this.rdPostOrden.TabIndex = 8;
            this.rdPostOrden.TabStop = true;
            this.rdPostOrden.Text = "Post-Orden";
            this.rdPostOrden.UseVisualStyleBackColor = true;
            // 
            // grillaArbolBinario
            // 
            this.grillaArbolBinario.AllowUserToAddRows = false;
            this.grillaArbolBinario.AllowUserToDeleteRows = false;
            this.grillaArbolBinario.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grillaArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.grillaArbolBinario.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grillaArbolBinario.Location = new System.Drawing.Point(390, 31);
            this.grillaArbolBinario.Name = "grillaArbolBinario";
            this.grillaArbolBinario.ReadOnly = true;
            this.grillaArbolBinario.Size = new System.Drawing.Size(460, 220);
            this.grillaArbolBinario.TabIndex = 1;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 200;
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Trámite";
            this.clmTramite.Name = "clmTramite";
            this.clmTramite.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboCodigo);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(675, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // cboCodigo
            // 
            this.cboCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(92, 51);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(115, 23);
            this.cboCodigo.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(55, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 39);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTramite);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(419, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 350);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(107, 179);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 23);
            this.txtTramite.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(52, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 39);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView.Location = new System.Drawing.Point(27, 23);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(350, 350);
            this.treeView.TabIndex = 12;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEquilibrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(711, 281);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(155, 39);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = false;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 701);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEquilibrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArbolBinario";
            this.Text = "Árbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArbolBinario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radInOrdenAsc;
        private System.Windows.Forms.RadioButton radPreOrden;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grillaArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.RadioButton rdPostOrden;
        private System.Windows.Forms.ComboBox cboCodigo;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton rdInOrdenDesc;
    }
}