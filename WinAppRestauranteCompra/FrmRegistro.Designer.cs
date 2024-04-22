namespace WinAppRestauranteCompra
{
    partial class FrmRegistro
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DataGridVRestaurantesR = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPlato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPlato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPlato4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPlato5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVRestaurantesR)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(370, 93);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(269, 18);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "RESTAURANTES REGISTRADOS";
            // 
            // DataGridVRestaurantesR
            // 
            this.DataGridVRestaurantesR.AllowUserToAddRows = false;
            this.DataGridVRestaurantesR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridVRestaurantesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVRestaurantesR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Direccion,
            this.Ruc,
            this.Plato1,
            this.PrecioP1,
            this.Plato2,
            this.PrecioPlato2,
            this.Plato3,
            this.PrecioPlato3,
            this.Plato4,
            this.PrecioPlato4,
            this.Plato5,
            this.PrecioPlato5});
            this.DataGridVRestaurantesR.Location = new System.Drawing.Point(22, 146);
            this.DataGridVRestaurantesR.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridVRestaurantesR.Name = "DataGridVRestaurantesR";
            this.DataGridVRestaurantesR.RowHeadersWidth = 51;
            this.DataGridVRestaurantesR.RowTemplate.Height = 24;
            this.DataGridVRestaurantesR.Size = new System.Drawing.Size(888, 275);
            this.DataGridVRestaurantesR.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // Ruc
            // 
            this.Ruc.HeaderText = "Ruc";
            this.Ruc.MinimumWidth = 6;
            this.Ruc.Name = "Ruc";
            // 
            // Plato1
            // 
            this.Plato1.HeaderText = "Plato1";
            this.Plato1.MinimumWidth = 6;
            this.Plato1.Name = "Plato1";
            // 
            // PrecioP1
            // 
            this.PrecioP1.HeaderText = "PrecioP1";
            this.PrecioP1.MinimumWidth = 6;
            this.PrecioP1.Name = "PrecioP1";
            // 
            // Plato2
            // 
            this.Plato2.HeaderText = "Plato2";
            this.Plato2.MinimumWidth = 6;
            this.Plato2.Name = "Plato2";
            // 
            // PrecioPlato2
            // 
            this.PrecioPlato2.HeaderText = "PrecioPlato2";
            this.PrecioPlato2.MinimumWidth = 6;
            this.PrecioPlato2.Name = "PrecioPlato2";
            // 
            // Plato3
            // 
            this.Plato3.HeaderText = "Plato3";
            this.Plato3.MinimumWidth = 6;
            this.Plato3.Name = "Plato3";
            // 
            // PrecioPlato3
            // 
            this.PrecioPlato3.HeaderText = "PrecioPlato3";
            this.PrecioPlato3.MinimumWidth = 6;
            this.PrecioPlato3.Name = "PrecioPlato3";
            // 
            // Plato4
            // 
            this.Plato4.HeaderText = "Plato4";
            this.Plato4.MinimumWidth = 6;
            this.Plato4.Name = "Plato4";
            // 
            // PrecioPlato4
            // 
            this.PrecioPlato4.HeaderText = "PrecioPlato4";
            this.PrecioPlato4.MinimumWidth = 6;
            this.PrecioPlato4.Name = "PrecioPlato4";
            // 
            // Plato5
            // 
            this.Plato5.HeaderText = "Plato5";
            this.Plato5.MinimumWidth = 6;
            this.Plato5.Name = "Plato5";
            // 
            // PrecioPlato5
            // 
            this.PrecioPlato5.HeaderText = "PrecioPlato5";
            this.PrecioPlato5.MinimumWidth = 6;
            this.PrecioPlato5.Name = "PrecioPlato5";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.DataGridVRestaurantesR);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVRestaurantesR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DataGridVRestaurantesR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPlato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPlato3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPlato4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPlato5;
    }
}