namespace WinAppRestauranteCompra
{
    partial class FrmFactura
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
            this.DataGridVFactura = new System.Windows.Forms.DataGridView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblTValorT = new System.Windows.Forms.Label();
            this.LblTIva = new System.Windows.Forms.Label();
            this.LblTSubtotal = new System.Windows.Forms.Label();
            this.Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVFactura
            // 
            this.DataGridVFactura.AllowUserToAddRows = false;
            this.DataGridVFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plato,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.DataGridVFactura.Location = new System.Drawing.Point(184, 125);
            this.DataGridVFactura.Name = "DataGridVFactura";
            this.DataGridVFactura.RowHeadersVisible = false;
            this.DataGridVFactura.RowHeadersWidth = 51;
            this.DataGridVFactura.RowTemplate.Height = 24;
            this.DataGridVFactura.Size = new System.Drawing.Size(540, 237);
            this.DataGridVFactura.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(277, 41);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(355, 26);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "FACTURACIÓN ELECTÓNICA";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Location = new System.Drawing.Point(738, 480);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(25, 16);
            this.LblValorTotal.TabIndex = 18;
            this.LblValorTotal.Text = "......";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Location = new System.Drawing.Point(687, 440);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(25, 16);
            this.LblIva.TabIndex = 17;
            this.LblIva.Text = "......";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(687, 402);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(25, 16);
            this.LblSubtotal.TabIndex = 16;
            this.LblSubtotal.Text = "......";
            // 
            // LblTValorT
            // 
            this.LblTValorT.AutoSize = true;
            this.LblTValorT.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTValorT.Location = new System.Drawing.Point(569, 480);
            this.LblTValorT.Name = "LblTValorT";
            this.LblTValorT.Size = new System.Drawing.Size(154, 21);
            this.LblTValorT.TabIndex = 15;
            this.LblTValorT.Text = "VALOR TOTAL:";
            // 
            // LblTIva
            // 
            this.LblTIva.AutoSize = true;
            this.LblTIva.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTIva.Location = new System.Drawing.Point(569, 435);
            this.LblTIva.Name = "LblTIva";
            this.LblTIva.Size = new System.Drawing.Size(94, 21);
            this.LblTIva.TabIndex = 14;
            this.LblTIva.Text = "IVA 12% :";
            // 
            // LblTSubtotal
            // 
            this.LblTSubtotal.AutoSize = true;
            this.LblTSubtotal.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTSubtotal.Location = new System.Drawing.Point(569, 397);
            this.LblTSubtotal.Name = "LblTSubtotal";
            this.LblTSubtotal.Size = new System.Drawing.Size(103, 21);
            this.LblTSubtotal.TabIndex = 13;
            this.LblTSubtotal.Text = "Subtotal : ";
            // 
            // Plato
            // 
            this.Plato.HeaderText = "Plato";
            this.Plato.MinimumWidth = 6;
            this.Plato.Name = "Plato";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 578);
            this.Controls.Add(this.LblValorTotal);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.LblTValorT);
            this.Controls.Add(this.LblTIva);
            this.Controls.Add(this.LblTSubtotal);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.DataGridVFactura);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVFactura;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblTValorT;
        private System.Windows.Forms.Label LblTIva;
        private System.Windows.Forms.Label LblTSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}