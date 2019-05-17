namespace WINDBA
{
    partial class Filtros
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
            this.empleadosTableAdapter1 = new WINDBA.EmpresaTableAdapters.EmpleadosTableAdapter();
            this.tDatoFiltro = new System.Windows.Forms.TextBox();
            this.bFiltroSueldo = new System.Windows.Forms.Button();
            this.dgwFiltros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadosTableAdapter1
            // 
            this.empleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // tDatoFiltro
            // 
            this.tDatoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDatoFiltro.Location = new System.Drawing.Point(135, 76);
            this.tDatoFiltro.Name = "tDatoFiltro";
            this.tDatoFiltro.Size = new System.Drawing.Size(251, 29);
            this.tDatoFiltro.TabIndex = 0;
            // 
            // bFiltroSueldo
            // 
            this.bFiltroSueldo.Location = new System.Drawing.Point(441, 72);
            this.bFiltroSueldo.Name = "bFiltroSueldo";
            this.bFiltroSueldo.Size = new System.Drawing.Size(172, 36);
            this.bFiltroSueldo.TabIndex = 1;
            this.bFiltroSueldo.Text = "FILTRO SUELDO";
            this.bFiltroSueldo.UseVisualStyleBackColor = true;
            this.bFiltroSueldo.Click += new System.EventHandler(this.BFiltroSueldo_Click);
            // 
            // dgwFiltros
            // 
            this.dgwFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFiltros.Location = new System.Drawing.Point(135, 133);
            this.dgwFiltros.Name = "dgwFiltros";
            this.dgwFiltros.Size = new System.Drawing.Size(478, 223);
            this.dgwFiltros.TabIndex = 2;
            // 
            // Filtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwFiltros);
            this.Controls.Add(this.bFiltroSueldo);
            this.Controls.Add(this.tDatoFiltro);
            this.Name = "Filtros";
            this.Text = "Filtros";
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiltros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmpresaTableAdapters.EmpleadosTableAdapter empleadosTableAdapter1;
        private System.Windows.Forms.TextBox tDatoFiltro;
        private System.Windows.Forms.Button bFiltroSueldo;
        private System.Windows.Forms.DataGridView dgwFiltros;
    }
}