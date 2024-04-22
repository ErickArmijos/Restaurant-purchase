using Microsoft.Win32;
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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        public void RegistroRestaurante(ClRestaurante[] restaurantes,int pos)
        {
            string codigo;
            bool encontrado = false;
            int renglon;
            for(int i = 0;i <pos;i++) {
                renglon = DataGridVRestaurantesR.Rows.Add();
                DataGridVRestaurantesR.Rows[renglon].Cells["Codigo"].Value = restaurantes[i].codRes;
                DataGridVRestaurantesR.Rows[renglon].Cells["Nombre"].Value = restaurantes[i].nombre;
                DataGridVRestaurantesR.Rows[renglon].Cells["Direccion"].Value = restaurantes[i].direccion;
                DataGridVRestaurantesR.Rows[renglon].Cells["Ruc"].Value = restaurantes[i].ruc;
                DataGridVRestaurantesR.Rows[renglon].Cells["Plato1"].Value = restaurantes[i].nombrePlato1;
                DataGridVRestaurantesR.Rows[renglon].Cells["PrecioP1"].Value = restaurantes[i].precioPlato1;
                DataGridVRestaurantesR.Rows[renglon].Cells["Plato2"].Value = restaurantes[i].nombrePlato2;
                DataGridVRestaurantesR.Rows[renglon].Cells["PrecioPlato2"].Value = restaurantes[i].precioPlato2;
                DataGridVRestaurantesR.Rows[renglon].Cells["Plato3"].Value = restaurantes[i].nombrePlato3;
                DataGridVRestaurantesR.Rows[renglon].Cells["PrecioPlato3"].Value = restaurantes[i].precioPlato3;
                DataGridVRestaurantesR.Rows[renglon].Cells["Plato4"].Value = restaurantes[i].nombrePlato4;
                DataGridVRestaurantesR.Rows[renglon].Cells["PrecioPlato4"].Value = restaurantes[i].precioPlato4;
                DataGridVRestaurantesR.Rows[renglon].Cells["Plato5"].Value = restaurantes[i].nombrePlato5;
                DataGridVRestaurantesR.Rows[renglon].Cells["PrecioPlato5"].Value = restaurantes[i].precioPlato5;
            }
           
            }
        }

    }

