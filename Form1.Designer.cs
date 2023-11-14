namespace PryTpLab2
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
            this.BarraInferior = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDatosProductos = new System.Windows.Forms.DataGridView();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.BarraInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraInferior
            // 
            this.BarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.BarraInferior.Location = new System.Drawing.Point(0, 428);
            this.BarraInferior.Name = "BarraInferior";
            this.BarraInferior.Size = new System.Drawing.Size(520, 22);
            this.BarraInferior.TabIndex = 0;
            this.BarraInferior.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(12, 17);
            this.lblEstadoConexion.Text = "-";
            // 
            // dgvDatosProductos
            // 
            this.dgvDatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProductos.Location = new System.Drawing.Point(15, 21);
            this.dgvDatosProductos.Name = "dgvDatosProductos";
            this.dgvDatosProductos.Size = new System.Drawing.Size(475, 305);
            this.dgvDatosProductos.TabIndex = 1;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(296, 345);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(134, 57);
            this.btnGuardarProducto.TabIndex = 2;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.dgvDatosProductos);
            this.Controls.Add(this.BarraInferior);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico Laboratorio 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraInferior.ResumeLayout(false);
            this.BarraInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarraInferior;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.DataGridView dgvDatosProductos;
        private System.Windows.Forms.Button btnGuardarProducto;
    }
}

