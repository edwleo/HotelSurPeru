namespace DESIGNER.Mantenimientos
{
    partial class frmPruebas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtValorBuscado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optRUC = new System.Windows.Forms.RadioButton();
            this.optRazonSocial = new System.Windows.Forms.RadioButton();
            this.gridEmpresas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtValorBuscado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optRUC);
            this.groupBox1.Controls.Add(this.optRazonSocial);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador de empresas";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(752, 58);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(172, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(752, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(172, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtValorBuscado
            // 
            this.txtValorBuscado.Location = new System.Drawing.Point(196, 58);
            this.txtValorBuscado.Name = "txtValorBuscado";
            this.txtValorBuscado.Size = new System.Drawing.Size(528, 23);
            this.txtValorBuscado.TabIndex = 2;
            this.txtValorBuscado.TextChanged += new System.EventHandler(this.txtValorBuscado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese valor buscado";
            // 
            // optRUC
            // 
            this.optRUC.AutoSize = true;
            this.optRUC.Location = new System.Drawing.Point(32, 58);
            this.optRUC.Name = "optRUC";
            this.optRUC.Size = new System.Drawing.Size(53, 21);
            this.optRUC.TabIndex = 0;
            this.optRUC.Text = "RUC";
            this.optRUC.UseVisualStyleBackColor = true;
            this.optRUC.CheckedChanged += new System.EventHandler(this.optRUC_CheckedChanged);
            // 
            // optRazonSocial
            // 
            this.optRazonSocial.AutoSize = true;
            this.optRazonSocial.Checked = true;
            this.optRazonSocial.Location = new System.Drawing.Point(32, 31);
            this.optRazonSocial.Name = "optRazonSocial";
            this.optRazonSocial.Size = new System.Drawing.Size(107, 21);
            this.optRazonSocial.TabIndex = 0;
            this.optRazonSocial.TabStop = true;
            this.optRazonSocial.Text = "Razon social";
            this.optRazonSocial.UseVisualStyleBackColor = true;
            this.optRazonSocial.CheckedChanged += new System.EventHandler(this.optRazonSocial_CheckedChanged);
            // 
            // gridEmpresas
            // 
            this.gridEmpresas.AllowUserToAddRows = false;
            this.gridEmpresas.AllowUserToDeleteRows = false;
            this.gridEmpresas.AllowUserToResizeRows = false;
            this.gridEmpresas.BackgroundColor = System.Drawing.Color.White;
            this.gridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpresas.Location = new System.Drawing.Point(27, 145);
            this.gridEmpresas.MultiSelect = false;
            this.gridEmpresas.Name = "gridEmpresas";
            this.gridEmpresas.ReadOnly = true;
            this.gridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpresas.Size = new System.Drawing.Size(1084, 408);
            this.gridEmpresas.TabIndex = 1;
            this.gridEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpresas_CellClick);
            this.gridEmpresas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridEmpresas_CellPainting);
            // 
            // frmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 608);
            this.Controls.Add(this.gridEmpresas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPruebas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de empresas";
            this.Load += new System.EventHandler(this.frmPruebas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtValorBuscado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optRUC;
        private System.Windows.Forms.RadioButton optRazonSocial;
        private System.Windows.Forms.DataGridView gridEmpresas;
    }
}