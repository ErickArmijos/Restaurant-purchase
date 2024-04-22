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
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {

        }

        public void Seleccion(ClCompra[] compraRestaurante)
        {


            DataGridVFactura.Rows.Clear(); 

            
            foreach (ClCompra compra in compraRestaurante)
            {
                
                if(compra.plato != "" && compra.precio !=0 && compra.cantidad !=0)
                {
                    DataGridVFactura.Rows.Add();


                    DataGridVFactura.Rows[DataGridVFactura.Rows.Count - 1].Cells[0].Value = compra.plato;
                    DataGridVFactura.Rows[DataGridVFactura.Rows.Count - 1].Cells[1].Value = compra.precio.ToString();
                    DataGridVFactura.Rows[DataGridVFactura.Rows.Count - 1].Cells[2].Value = compra.cantidad.ToString();
                    DataGridVFactura.Rows[DataGridVFactura.Rows.Count - 1].Cells[3].Value = (compra.precio * compra.cantidad).ToString();

                }
                

            }

            decimal total = 0;
            decimal porcentaje = 0.12m;
            decimal valorTotal;

            foreach (DataGridViewRow row in DataGridVFactura.Rows)
            {
                total += Convert.ToDecimal(row.Cells[3].Value);
            }

            decimal iva;
            iva = total * porcentaje;
            valorTotal = total + iva;

            LblSubtotal.Text = total.ToString();
            LblIva.Text = iva.ToString();
            LblValorTotal.Text = valorTotal.ToString();



        }
    }
}
