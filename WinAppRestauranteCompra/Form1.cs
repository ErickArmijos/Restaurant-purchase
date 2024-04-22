using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRestauranteCompra
{
    public partial class Form1 : Form
    {
        ClRestaurante restaurante;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            LbxPlato1.Enabled = false;
            LbxPlato2.Enabled = false;
            LbxPlato3.Enabled = false;
            LbxPlato4.Enabled = false;
            LbxPlato5.Enabled = false;
        }

        public void datosRestaurante(ClRestaurante[] nuevoRestaurante, int i)
        {
            restaurante = nuevoRestaurante[i];

            LblNombre.Text = restaurante.nombre;
            LblDireccion.Text = restaurante.direccion;

            ChkboxPlato1.Text = restaurante.nombrePlato1;
            ChkboxPlato2.Text = restaurante.nombrePlato2;
            ChkboxPlato3.Text = restaurante.nombrePlato3;
            ChkboxPlato4.Text = restaurante.nombrePlato4;
            ChkboxPlato5.Text = restaurante.nombrePlato5;

            LblPrecio1.Text = restaurante.precioPlato1.ToString()+" $";
            LblPrecio2.Text = restaurante.precioPlato2.ToString() + " $";
            LblPrecio3.Text = restaurante.precioPlato3.ToString() + " $";
            LblPrecio4.Text = restaurante.precioPlato4.ToString() + " $";
            LblPrecio5.Text = restaurante.precioPlato5.ToString() + " $";
        }

        private void ChkboxPlato1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkboxPlato1.Checked)
            {
                LbxPlato1.Enabled = true;
            }
            else
            {
                LbxPlato1.Enabled = false;
            }
        }

        private void ChkboxPlato2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkboxPlato2.Checked)
            {
                LbxPlato2.Enabled = true;
            }
            else
            {
                LbxPlato2.Enabled = false;
            }
        }

        private void ChkboxPlato3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkboxPlato3.Checked)
            {
                LbxPlato3.Enabled = true;
            }
            else
            {
                LbxPlato3.Enabled = false;
            }
        }

        private void ChkboxPlato4_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkboxPlato4.Checked)
            {
                LbxPlato4.Enabled = true;
            }
            else
            {
                LbxPlato4.Enabled = false;
            }
        }

        private void ChkboxPlato5_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkboxPlato5.Checked)
            {
                LbxPlato5.Enabled = true;
            }
            else
            {
                LbxPlato5.Enabled = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LbxPlato1.Text);
            
            this.Close();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            ClCompra[] objCompra = new ClCompra[5];
            int cantidad;
            double precio;

            if (LbxPlato1.Enabled || LbxPlato2.Enabled || LbxPlato3.Enabled || LbxPlato4.Enabled || LbxPlato5.Enabled)
            {
                //Plato 1
                if (ChkboxPlato1.Checked)
                {
                    cantidad=int.Parse(LbxPlato1.SelectedItem.ToString());
                    precio = restaurante.precioPlato1;
                    objCompra[0] = new ClCompra(ChkboxPlato1.Text,precio,cantidad);
                }
                else
                {
                    objCompra[0] = new ClCompra("",0,0);
                }
                //Plato 2
                if (ChkboxPlato2.Checked)
                {
                    precio = restaurante.PrecioPlato2;
                    cantidad = Convert.ToInt32(LbxPlato1.SelectedItem);
                    objCompra[1] = new ClCompra(ChkboxPlato2.Text,precio, cantidad);
                }
                else
                {

                    objCompra[1] = new ClCompra("", 0,0);
                }
                //Plato 3
                if (ChkboxPlato3.Checked)
                {
                    precio = restaurante.PrecioPlato3;

                    cantidad = Convert.ToInt32(LbxPlato1.SelectedItem);
                    objCompra[2] = new ClCompra(ChkboxPlato3.Text,precio, cantidad);
                }
                else
                {
                    objCompra[2] = new ClCompra("", 0,0);
                }
                //Plato 4
                if (ChkboxPlato4.Checked)
                {
                    precio = restaurante.PrecioPlato4;

                    cantidad = Convert.ToInt32(LbxPlato1.SelectedItem);
                    objCompra[3] = new ClCompra(ChkboxPlato4.Text, precio,cantidad);
                }
                else
                {
                    objCompra[3] = new ClCompra("",0, 0);
                }
                //Plato 5
                if (ChkboxPlato5.Checked)
                {
                    precio = restaurante.PrecioPlato5;
                    cantidad = Convert.ToInt32(LbxPlato1.SelectedItem);
                    objCompra[4] = new ClCompra(ChkboxPlato5.Text,precio, cantidad);
                }
                else
                {
                    objCompra[4] = new ClCompra("",0, 0);
                }

                FrmFactura objFactura = new FrmFactura();
                objFactura.Seleccion(objCompra);

            }
            else
            {
                MessageBox.Show("No se ha comprado ningún plato, intentelo otra vez", "Error");
            }
        }
    }
}
