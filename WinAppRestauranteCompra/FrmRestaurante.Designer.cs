namespace WinAppRestauranteCompra
{
    partial class FrmRestaurante
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GbxInfoPlatos = new System.Windows.Forms.GroupBox();
            this.TxtPrecioPlat = new System.Windows.Forms.TextBox();
            this.TxtNombrePlat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblRuta = new System.Windows.Forms.Label();
            this.GbxInfoRestaurante = new System.Windows.Forms.GroupBox();
            this.TxtRucRes = new System.Windows.Forms.TextBox();
            this.TxtDireccionRes = new System.Windows.Forms.TextBox();
            this.TxtNombreRes = new System.Windows.Forms.TextBox();
            this.TxtCodigoRes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GbxInfoPlatos.SuspendLayout();
            this.GbxInfoRestaurante.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(532, 564);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 41);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Lime;
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(343, 564);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(105, 41);
            this.BtnAceptar.TabIndex = 19;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // GbxInfoPlatos
            // 
            this.GbxInfoPlatos.Controls.Add(this.TxtPrecioPlat);
            this.GbxInfoPlatos.Controls.Add(this.TxtNombrePlat);
            this.GbxInfoPlatos.Controls.Add(this.label9);
            this.GbxInfoPlatos.Controls.Add(this.label10);
            this.GbxInfoPlatos.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxInfoPlatos.Location = new System.Drawing.Point(112, 391);
            this.GbxInfoPlatos.Margin = new System.Windows.Forms.Padding(2);
            this.GbxInfoPlatos.Name = "GbxInfoPlatos";
            this.GbxInfoPlatos.Padding = new System.Windows.Forms.Padding(2);
            this.GbxInfoPlatos.Size = new System.Drawing.Size(754, 138);
            this.GbxInfoPlatos.TabIndex = 18;
            this.GbxInfoPlatos.TabStop = false;
            this.GbxInfoPlatos.Text = "Información de los platos";
            // 
            // TxtPrecioPlat
            // 
            this.TxtPrecioPlat.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioPlat.Location = new System.Drawing.Point(129, 98);
            this.TxtPrecioPlat.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecioPlat.Name = "TxtPrecioPlat";
            this.TxtPrecioPlat.Size = new System.Drawing.Size(90, 26);
            this.TxtPrecioPlat.TabIndex = 17;
            this.TxtPrecioPlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioPlat_KeyPress);
            // 
            // TxtNombrePlat
            // 
            this.TxtNombrePlat.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrePlat.Location = new System.Drawing.Point(243, 41);
            this.TxtNombrePlat.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombrePlat.Name = "TxtNombrePlat";
            this.TxtNombrePlat.Size = new System.Drawing.Size(368, 26);
            this.TxtNombrePlat.TabIndex = 16;
            this.TxtNombrePlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombrePlat_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre del plato:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Precio:";
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRuta.Location = new System.Drawing.Point(9, 87);
            this.LblRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(257, 18);
            this.LblRuta.TabIndex = 15;
            this.LblRuta.Text = "Inicio > Ingreso Restaurantes";
            // 
            // GbxInfoRestaurante
            // 
            this.GbxInfoRestaurante.Controls.Add(this.TxtRucRes);
            this.GbxInfoRestaurante.Controls.Add(this.TxtDireccionRes);
            this.GbxInfoRestaurante.Controls.Add(this.TxtNombreRes);
            this.GbxInfoRestaurante.Controls.Add(this.TxtCodigoRes);
            this.GbxInfoRestaurante.Controls.Add(this.label6);
            this.GbxInfoRestaurante.Controls.Add(this.label5);
            this.GbxInfoRestaurante.Controls.Add(this.label3);
            this.GbxInfoRestaurante.Controls.Add(this.label4);
            this.GbxInfoRestaurante.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxInfoRestaurante.Location = new System.Drawing.Point(112, 136);
            this.GbxInfoRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.GbxInfoRestaurante.Name = "GbxInfoRestaurante";
            this.GbxInfoRestaurante.Padding = new System.Windows.Forms.Padding(2);
            this.GbxInfoRestaurante.Size = new System.Drawing.Size(754, 227);
            this.GbxInfoRestaurante.TabIndex = 17;
            this.GbxInfoRestaurante.TabStop = false;
            this.GbxInfoRestaurante.Text = "Información del restaurante";
            // 
            // TxtRucRes
            // 
            this.TxtRucRes.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRucRes.Location = new System.Drawing.Point(158, 180);
            this.TxtRucRes.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRucRes.Name = "TxtRucRes";
            this.TxtRucRes.Size = new System.Drawing.Size(179, 26);
            this.TxtRucRes.TabIndex = 15;
            this.TxtRucRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRucRes_KeyPress);
            // 
            // TxtDireccionRes
            // 
            this.TxtDireccionRes.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionRes.Location = new System.Drawing.Point(158, 130);
            this.TxtDireccionRes.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccionRes.Name = "TxtDireccionRes";
            this.TxtDireccionRes.Size = new System.Drawing.Size(536, 26);
            this.TxtDireccionRes.TabIndex = 14;
            this.TxtDireccionRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionRes_KeyPress);
            // 
            // TxtNombreRes
            // 
            this.TxtNombreRes.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreRes.Location = new System.Drawing.Point(158, 84);
            this.TxtNombreRes.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreRes.Name = "TxtNombreRes";
            this.TxtNombreRes.Size = new System.Drawing.Size(403, 26);
            this.TxtNombreRes.TabIndex = 13;
            this.TxtNombreRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreRes_KeyPress);
            // 
            // TxtCodigoRes
            // 
            this.TxtCodigoRes.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoRes.Location = new System.Drawing.Point(302, 41);
            this.TxtCodigoRes.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigoRes.Name = "TxtCodigoRes";
            this.TxtCodigoRes.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigoRes.TabIndex = 12;
            this.TxtCodigoRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoRes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "RUC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código del Restaurante: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 81);
            this.panel1.TabIndex = 16;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(302, 16);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(319, 32);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Ingreso Restaurantes";
            // 
            // FrmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 609);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.GbxInfoPlatos);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.GbxInfoRestaurante);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRestaurante";
            this.Text = "FrmRestaurante";
            this.Load += new System.EventHandler(this.FrmRestaurante_Load);
            this.GbxInfoPlatos.ResumeLayout(false);
            this.GbxInfoPlatos.PerformLayout();
            this.GbxInfoRestaurante.ResumeLayout(false);
            this.GbxInfoRestaurante.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox GbxInfoPlatos;
        private System.Windows.Forms.TextBox TxtPrecioPlat;
        private System.Windows.Forms.TextBox TxtNombrePlat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.GroupBox GbxInfoRestaurante;
        private System.Windows.Forms.TextBox TxtRucRes;
        private System.Windows.Forms.TextBox TxtDireccionRes;
        private System.Windows.Forms.TextBox TxtNombreRes;
        private System.Windows.Forms.TextBox TxtCodigoRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
    }
}