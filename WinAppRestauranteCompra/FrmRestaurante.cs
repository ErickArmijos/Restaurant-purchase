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
    public partial class FrmRestaurante : Form
    {

        ClRestaurante[] restaurantes = new ClRestaurante[100];

        //posicion del siguiente restaurante a agregar
        int posicion = 1;
        //

        int i = 1;
        string codRes;
        string Nombre;
        string Direccion;
        string ruc;
        string nombreP, nombreP1, nombreP2, nombreP3, nombreP4, nombreP5;
        double precioP1, precioP2, precioP3, precioP4, precioP5;

        private void TxtPrecioPlat_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)Keys.Enter)
            {

                string precioPlato = TxtPrecioPlat.Text;




                if (!string.IsNullOrWhiteSpace(precioPlato))

                {
                    if (precioPlato.Contains(" "))
                    {
                        MessageBox.Show("El precio ingresado ingresado no debe contener espacios en blanco.\nIngrese nuevamente.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtPrecioPlat.Clear();
                        TxtPrecioPlat.Focus();
                    }
                    else
                    {

                        double pPlato = double.Parse(precioPlato);
                        string conv = pPlato.ToString("F2");
                        pPlato = double.Parse(conv);
                        if (pPlato < 1)
                        {
                            MessageBox.Show("Recuerde que el precio es una cantidad positiva mayor a cero con dos decimales máximos (centavos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtPrecioPlat.Clear();
                            TxtPrecioPlat.Focus();
                        }

                        switch (i)
                        {
                            case 1:
                                {
                                    nombreP1 = nombreP;
                                    precioP1 = pPlato;
                                    TxtNombrePlat.Clear();
                                    TxtNombrePlat.Focus();
                                    break;
                                }
                            case 2:
                                {
                                    nombreP2 = nombreP;
                                    precioP2 = pPlato;
                                    TxtNombrePlat.Clear();
                                    TxtNombrePlat.Focus();
                                    break;
                                }
                            case 3:
                                {
                                    nombreP3 = nombreP;
                                    precioP3 = pPlato;
                                    TxtNombrePlat.Clear();
                                    TxtNombrePlat.Focus();
                                    break;
                                }
                            case 4:
                                {
                                    nombreP4 = nombreP;
                                    precioP4 = pPlato;
                                    TxtNombrePlat.Clear();
                                    TxtNombrePlat.Focus();
                                    break;
                                }
                            case 5:
                                {
                                    nombreP5 = nombreP;
                                    precioP5 = pPlato;
                                    TxtNombrePlat.Clear();
                                    TxtNombrePlat.Focus();
                                    break;
                                }

                        }
                        i++;
                        TxtNombrePlat.Clear();
                        TxtPrecioPlat.Clear();
                        TxtNombrePlat.Focus();

                        if (i > 5)
                        {
                            BtnAceptar.Focus();
                         }
                    }
                }
                else
                {
                    MessageBox.Show("El campo Precio es obligatorio. \nIngrese nuevamente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtPrecioPlat.Clear();
                    TxtPrecioPlat.Focus();
                }
            }

        }

        private void TxtNombrePlat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                string plato = TxtNombrePlat.Text;
                if (!string.IsNullOrWhiteSpace(plato))
                {
                    nombreP = TxtNombrePlat.Text;
                    TxtPrecioPlat.Focus();
                }
                else
                {
                    MessageBox.Show("El campo Nombre del plato es obligatorio. \nIngrese nuevamente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNombrePlat.Clear();
                    TxtNombrePlat.Focus();
                }
            }
        }

        private void TxtRucRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                string rucR = TxtRucRes.Text;
                if (!string.IsNullOrWhiteSpace(rucR))
                {
                    if (rucR.Length != 13)
                    {
                        MessageBox.Show("Recuerde que el RUC está compuesto por 13 dígitos. \nIngrese nuevamente.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtRucRes.Clear();
                        TxtRucRes.Focus();
                    }
                    else
                    {
                        if (rucR.Contains(" "))
                        {
                            MessageBox.Show("El número de RUC ingresado no debe contener espacios en blanco. Ingrese nuevamente \nIngrese nuevamente.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtRucRes.Clear();
                            TxtRucRes.Focus();
                        }
                        else
                        {
                            ruc = rucR;
                            TxtNombrePlat.Focus();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El campo RUC es obligatorio. \nIngrese nuevamente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtRucRes.Clear();
                    TxtRucRes.Focus();
                }

            }
        }

        private void TxtDireccionRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                string direccionR = TxtDireccionRes.Text;
                if (!string.IsNullOrWhiteSpace(direccionR))
                {

                    Direccion = direccionR;
                    TxtRucRes.Focus();
                }
                else
                {
                    MessageBox.Show("El campo Dirección es obligatorio. \nIngrese nuevamente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtDireccionRes.Clear();
                    TxtDireccionRes.Focus();
                }

            }
        }

        private void TxtNombreRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                string nombreR = TxtNombreRes.Text;
                if (!string.IsNullOrWhiteSpace(nombreR))
                {
                    Nombre = nombreR;
                    TxtDireccionRes.Focus();
                }
                else
                {
                    MessageBox.Show("El campo Nombre es obligatorio. \nIngrese nuevamente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNombreRes.Clear();
                    TxtNombreRes.Focus();
                }

            }
        }




        private void FrmRestaurante_Load(object sender, EventArgs e)
        {
            TxtCodigoRes.Focus();

            restaurantes[0] = new ClRestaurante("RES-001", "Sabrosa comida", "Av. Cevallos", "1023456321896", "Encebollado", "Seco de Chivo", "Guatita", "Llapingacho", "Arroz con chuleta", 25.50, 10.50, 10, 16, 12.75);


            //=========
            restaurantes[1] = new ClRestaurante("RES-002", "Delicias del mar", "Av. 12 de noviembre", "1234567891234", "Ceviche de pescado", "Encebollado", "Arroz marinero", "Ceviche mixto", "Ensalada Cesar", 60.75, 18, 20, 35, 42.50);

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public FrmRestaurante()
        {
            InitializeComponent();
        }

        private void TxtCodigoRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                string codigoR = TxtCodigoRes.Text;

                if (codigoR.Length == 6)
                {
                    if (codigoR.Contains(" "))
                    {
                        MessageBox.Show("El código del restaurante ingresado no debe contener espacios en blanco.\nIngrese nuevamente.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigoRes.Clear();
                        TxtCodigoRes.Focus();
                    }
                    else
                    {
                        codRes = codigoR;
                        TxtNombreRes.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Recuerde que el código debe tener 6 caracteres. \nIngrese nuevamente.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigoRes.Clear();
                    TxtCodigoRes.Focus();
                }

            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {


                posicion++;
                restaurantes[posicion] = new ClRestaurante(codRes, Nombre, Direccion, ruc, nombreP1, nombreP2, nombreP3, nombreP4, nombreP5, precioP1, precioP2, precioP3, precioP4, precioP5);

                //Frm___.recogerRestaurante(restaurantes);

                i = 1;
                TxtCodigoRes.Clear();
                TxtNombreRes.Clear();
                TxtDireccionRes.Clear();
                TxtRucRes.Clear();
                TxtNombrePlat.Clear();
                TxtPrecioPlat.Clear();
                TxtCodigoRes.Focus();
                FrmRegistro objRegistro = new FrmRegistro();
                objRegistro.RegistroRestaurante(restaurantes,posicion+1);
            objRegistro.Show();

        }
    }
}
