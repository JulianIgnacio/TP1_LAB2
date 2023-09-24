namespace Ejercicio3
{
    partial class Form2
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
            this.lprecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lfechaCompra = new System.Windows.Forms.Label();
            this.ltipoProducto = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.lCantidadProducto = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtFechaC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lprecio.Location = new System.Drawing.Point(23, 88);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(146, 20);
            this.lprecio.TabIndex = 0;
            this.lprecio.Text = "Precio del Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(230, 88);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(288, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion de Producto";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(230, 28);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcionProducto.TabIndex = 1;
            // 
            // lfechaCompra
            // 
            this.lfechaCompra.AutoSize = true;
            this.lfechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfechaCompra.Location = new System.Drawing.Point(23, 138);
            this.lfechaCompra.Name = "lfechaCompra";
            this.lfechaCompra.Size = new System.Drawing.Size(136, 20);
            this.lfechaCompra.TabIndex = 0;
            this.lfechaCompra.Text = "Fecha de Compra";
            // 
            // ltipoProducto
            // 
            this.ltipoProducto.AutoSize = true;
            this.ltipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltipoProducto.Location = new System.Drawing.Point(23, 190);
            this.ltipoProducto.Name = "ltipoProducto";
            this.ltipoProducto.Size = new System.Drawing.Size(129, 20);
            this.ltipoProducto.TabIndex = 0;
            this.ltipoProducto.Text = "Tipo de Producto";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(230, 192);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(288, 20);
            this.txtTipoProducto.TabIndex = 1;
            // 
            // lCantidadProducto
            // 
            this.lCantidadProducto.AutoSize = true;
            this.lCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidadProducto.Location = new System.Drawing.Point(23, 243);
            this.lCantidadProducto.Name = "lCantidadProducto";
            this.lCantidadProducto.Size = new System.Drawing.Size(163, 20);
            this.lCantidadProducto.TabIndex = 0;
            this.lCantidadProducto.Text = "Cantidad de Producto";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(230, 243);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(288, 20);
            this.txtCantidadProducto.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(418, 310);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(163, 43);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar Datos";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtFechaC
            // 
            this.txtFechaC.Location = new System.Drawing.Point(230, 138);
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.Size = new System.Drawing.Size(288, 20);
            this.txtFechaC.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 393);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaC);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lCantidadProducto);
            this.Controls.Add(this.ltipoProducto);
            this.Controls.Add(this.lfechaCompra);
            this.Controls.Add(this.lprecio);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lfechaCompra;
        private System.Windows.Forms.Label ltipoProducto;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Label lCantidadProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtFechaC;
    }
}