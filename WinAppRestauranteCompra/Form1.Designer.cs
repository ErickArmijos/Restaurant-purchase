namespace WinAppRestauranteCompra
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.GbxMenu = new System.Windows.Forms.GroupBox();
            this.LbxPlato1 = new System.Windows.Forms.ListBox();
            this.LblPrecio5 = new System.Windows.Forms.Label();
            this.LblPrecio4 = new System.Windows.Forms.Label();
            this.LblPrecio3 = new System.Windows.Forms.Label();
            this.LblPrecio2 = new System.Windows.Forms.Label();
            this.LblPrecio1 = new System.Windows.Forms.Label();
            this.ChkboxPlato5 = new System.Windows.Forms.CheckBox();
            this.ChkboxPlato4 = new System.Windows.Forms.CheckBox();
            this.ChkboxPlato3 = new System.Windows.Forms.CheckBox();
            this.ChkboxPlato2 = new System.Windows.Forms.CheckBox();
            this.ChkboxPlato1 = new System.Windows.Forms.CheckBox();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LbxPlato2 = new System.Windows.Forms.ListBox();
            this.LbxPlato4 = new System.Windows.Forms.ListBox();
            this.LbxPlato3 = new System.Windows.Forms.ListBox();
            this.LbxPlato5 = new System.Windows.Forms.ListBox();
            this.GbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(281, 14);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(187, 32);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Restaurante";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.SystemColors.GrayText;
            this.LblDireccion.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDireccion.Location = new System.Drawing.Point(243, 56);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(80, 17);
            this.LblDireccion.TabIndex = 3;
            this.LblDireccion.Text = "Dirección";
            // 
            // GbxMenu
            // 
            this.GbxMenu.Controls.Add(this.LbxPlato5);
            this.GbxMenu.Controls.Add(this.LbxPlato3);
            this.GbxMenu.Controls.Add(this.LbxPlato4);
            this.GbxMenu.Controls.Add(this.LbxPlato2);
            this.GbxMenu.Controls.Add(this.LbxPlato1);
            this.GbxMenu.Controls.Add(this.LblPrecio5);
            this.GbxMenu.Controls.Add(this.LblPrecio4);
            this.GbxMenu.Controls.Add(this.LblPrecio3);
            this.GbxMenu.Controls.Add(this.LblPrecio2);
            this.GbxMenu.Controls.Add(this.LblPrecio1);
            this.GbxMenu.Controls.Add(this.ChkboxPlato5);
            this.GbxMenu.Controls.Add(this.ChkboxPlato4);
            this.GbxMenu.Controls.Add(this.ChkboxPlato3);
            this.GbxMenu.Controls.Add(this.ChkboxPlato2);
            this.GbxMenu.Controls.Add(this.ChkboxPlato1);
            this.GbxMenu.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxMenu.Location = new System.Drawing.Point(21, 101);
            this.GbxMenu.Name = "GbxMenu";
            this.GbxMenu.Size = new System.Drawing.Size(468, 304);
            this.GbxMenu.TabIndex = 4;
            this.GbxMenu.TabStop = false;
            this.GbxMenu.Text = "Menú";
            // 
            // LbxPlato1
            // 
            this.LbxPlato1.FormattingEnabled = true;
            this.LbxPlato1.ItemHeight = 18;
            this.LbxPlato1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LbxPlato1.Location = new System.Drawing.Point(291, 50);
            this.LbxPlato1.Name = "LbxPlato1";
            this.LbxPlato1.Size = new System.Drawing.Size(113, 22);
            this.LbxPlato1.TabIndex = 10;
            // 
            // LblPrecio5
            // 
            this.LblPrecio5.AutoSize = true;
            this.LblPrecio5.BackColor = System.Drawing.SystemColors.Window;
            this.LblPrecio5.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio5.Location = new System.Drawing.Point(223, 249);
            this.LblPrecio5.Name = "LblPrecio5";
            this.LblPrecio5.Size = new System.Drawing.Size(26, 17);
            this.LblPrecio5.TabIndex = 9;
            this.LblPrecio5.Text = "$0";
            // 
            // LblPrecio4
            // 
            this.LblPrecio4.AutoSize = true;
            this.LblPrecio4.BackColor = System.Drawing.SystemColors.Window;
            this.LblPrecio4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio4.Location = new System.Drawing.Point(223, 201);
            this.LblPrecio4.Name = "LblPrecio4";
            this.LblPrecio4.Size = new System.Drawing.Size(26, 17);
            this.LblPrecio4.TabIndex = 8;
            this.LblPrecio4.Text = "$0";
            // 
            // LblPrecio3
            // 
            this.LblPrecio3.AutoSize = true;
            this.LblPrecio3.BackColor = System.Drawing.SystemColors.Window;
            this.LblPrecio3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio3.Location = new System.Drawing.Point(223, 150);
            this.LblPrecio3.Name = "LblPrecio3";
            this.LblPrecio3.Size = new System.Drawing.Size(26, 17);
            this.LblPrecio3.TabIndex = 7;
            this.LblPrecio3.Text = "$0";
            // 
            // LblPrecio2
            // 
            this.LblPrecio2.AutoSize = true;
            this.LblPrecio2.BackColor = System.Drawing.SystemColors.Window;
            this.LblPrecio2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio2.Location = new System.Drawing.Point(223, 101);
            this.LblPrecio2.Name = "LblPrecio2";
            this.LblPrecio2.Size = new System.Drawing.Size(26, 17);
            this.LblPrecio2.TabIndex = 6;
            this.LblPrecio2.Text = "$0";
            // 
            // LblPrecio1
            // 
            this.LblPrecio1.AutoSize = true;
            this.LblPrecio1.BackColor = System.Drawing.SystemColors.Window;
            this.LblPrecio1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio1.Location = new System.Drawing.Point(223, 52);
            this.LblPrecio1.Name = "LblPrecio1";
            this.LblPrecio1.Size = new System.Drawing.Size(26, 17);
            this.LblPrecio1.TabIndex = 5;
            this.LblPrecio1.Text = "$0";
            // 
            // ChkboxPlato5
            // 
            this.ChkboxPlato5.AutoSize = true;
            this.ChkboxPlato5.Location = new System.Drawing.Point(26, 249);
            this.ChkboxPlato5.Name = "ChkboxPlato5";
            this.ChkboxPlato5.Size = new System.Drawing.Size(76, 22);
            this.ChkboxPlato5.TabIndex = 4;
            this.ChkboxPlato5.Text = "Plato5";
            this.ChkboxPlato5.UseVisualStyleBackColor = true;
            this.ChkboxPlato5.CheckedChanged += new System.EventHandler(this.ChkboxPlato5_CheckedChanged);
            // 
            // ChkboxPlato4
            // 
            this.ChkboxPlato4.AutoSize = true;
            this.ChkboxPlato4.Location = new System.Drawing.Point(26, 201);
            this.ChkboxPlato4.Name = "ChkboxPlato4";
            this.ChkboxPlato4.Size = new System.Drawing.Size(76, 22);
            this.ChkboxPlato4.TabIndex = 3;
            this.ChkboxPlato4.Text = "Plato4";
            this.ChkboxPlato4.UseVisualStyleBackColor = true;
            this.ChkboxPlato4.CheckedChanged += new System.EventHandler(this.ChkboxPlato4_CheckedChanged);
            // 
            // ChkboxPlato3
            // 
            this.ChkboxPlato3.AutoSize = true;
            this.ChkboxPlato3.Location = new System.Drawing.Point(26, 150);
            this.ChkboxPlato3.Name = "ChkboxPlato3";
            this.ChkboxPlato3.Size = new System.Drawing.Size(76, 22);
            this.ChkboxPlato3.TabIndex = 2;
            this.ChkboxPlato3.Text = "Plato3";
            this.ChkboxPlato3.UseVisualStyleBackColor = true;
            this.ChkboxPlato3.CheckedChanged += new System.EventHandler(this.ChkboxPlato3_CheckedChanged);
            // 
            // ChkboxPlato2
            // 
            this.ChkboxPlato2.AutoSize = true;
            this.ChkboxPlato2.Location = new System.Drawing.Point(26, 99);
            this.ChkboxPlato2.Name = "ChkboxPlato2";
            this.ChkboxPlato2.Size = new System.Drawing.Size(76, 22);
            this.ChkboxPlato2.TabIndex = 1;
            this.ChkboxPlato2.Text = "Plato2";
            this.ChkboxPlato2.UseVisualStyleBackColor = true;
            this.ChkboxPlato2.CheckedChanged += new System.EventHandler(this.ChkboxPlato2_CheckedChanged);
            // 
            // ChkboxPlato1
            // 
            this.ChkboxPlato1.AutoSize = true;
            this.ChkboxPlato1.Location = new System.Drawing.Point(26, 50);
            this.ChkboxPlato1.Name = "ChkboxPlato1";
            this.ChkboxPlato1.Size = new System.Drawing.Size(76, 22);
            this.ChkboxPlato1.TabIndex = 0;
            this.ChkboxPlato1.Text = "Plato1";
            this.ChkboxPlato1.UseVisualStyleBackColor = true;
            this.ChkboxPlato1.CheckedChanged += new System.EventHandler(this.ChkboxPlato1_CheckedChanged);
            // 
            // BtnComprar
            // 
            this.BtnComprar.BackColor = System.Drawing.Color.Orange;
            this.BtnComprar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnComprar.Location = new System.Drawing.Point(653, 350);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(121, 46);
            this.BtnComprar.TabIndex = 7;
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Maroon;
            this.BtnSalir.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(498, 350);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(121, 46);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Cancelar";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinAppRestauranteCompra.Properties.Resources.kisspng_computer_icons_restaurant_food_dinner_restaurant_icon_png_plate_5ab074a9cd1069_89431268152151364184;
            this.pictureBox3.Location = new System.Drawing.Point(455, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinAppRestauranteCompra.Properties.Resources.pngegg;
            this.pictureBox4.Location = new System.Drawing.Point(540, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(208, 213);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // LbxPlato2
            // 
            this.LbxPlato2.FormattingEnabled = true;
            this.LbxPlato2.ItemHeight = 18;
            this.LbxPlato2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LbxPlato2.Location = new System.Drawing.Point(291, 96);
            this.LbxPlato2.Name = "LbxPlato2";
            this.LbxPlato2.Size = new System.Drawing.Size(113, 22);
            this.LbxPlato2.TabIndex = 11;
            // 
            // LbxPlato4
            // 
            this.LbxPlato4.FormattingEnabled = true;
            this.LbxPlato4.ItemHeight = 18;
            this.LbxPlato4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LbxPlato4.Location = new System.Drawing.Point(291, 201);
            this.LbxPlato4.Name = "LbxPlato4";
            this.LbxPlato4.Size = new System.Drawing.Size(113, 22);
            this.LbxPlato4.TabIndex = 12;
            // 
            // LbxPlato3
            // 
            this.LbxPlato3.FormattingEnabled = true;
            this.LbxPlato3.ItemHeight = 18;
            this.LbxPlato3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LbxPlato3.Location = new System.Drawing.Point(291, 150);
            this.LbxPlato3.Name = "LbxPlato3";
            this.LbxPlato3.Size = new System.Drawing.Size(113, 22);
            this.LbxPlato3.TabIndex = 12;
            // 
            // LbxPlato5
            // 
            this.LbxPlato5.FormattingEnabled = true;
            this.LbxPlato5.ItemHeight = 18;
            this.LbxPlato5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LbxPlato5.Location = new System.Drawing.Point(291, 249);
            this.LbxPlato5.Name = "LbxPlato5";
            this.LbxPlato5.Size = new System.Drawing.Size(113, 22);
            this.LbxPlato5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.GbxMenu);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbxMenu.ResumeLayout(false);
            this.GbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.GroupBox GbxMenu;
        private System.Windows.Forms.Label LblPrecio5;
        private System.Windows.Forms.Label LblPrecio4;
        private System.Windows.Forms.Label LblPrecio3;
        private System.Windows.Forms.Label LblPrecio2;
        private System.Windows.Forms.Label LblPrecio1;
        private System.Windows.Forms.CheckBox ChkboxPlato5;
        private System.Windows.Forms.CheckBox ChkboxPlato4;
        private System.Windows.Forms.CheckBox ChkboxPlato3;
        private System.Windows.Forms.CheckBox ChkboxPlato2;
        private System.Windows.Forms.CheckBox ChkboxPlato1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox LbxPlato1;
        private System.Windows.Forms.ListBox LbxPlato5;
        private System.Windows.Forms.ListBox LbxPlato3;
        private System.Windows.Forms.ListBox LbxPlato4;
        private System.Windows.Forms.ListBox LbxPlato2;
    }
}

