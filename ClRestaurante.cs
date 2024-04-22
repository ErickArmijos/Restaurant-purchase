using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppRestauranteCompra
{
    public class ClRestaurante
    {
        public string codRes;
        public string nombre;
        public string direccion;
        public string ruc;
        public string nombrePlato1;
        public string nombrePlato2;
        public string nombrePlato3;
        public string nombrePlato4;
        public string nombrePlato5;
        public double precioPlato1;
        public double precioPlato2;
        public double precioPlato3;
        public double precioPlato4;
        public double precioPlato5;

        public ClRestaurante(string cod, string nom, string dir, string r, string nomp1, string nomp2, string nomp3, string nomp4, string nomp5, double preP1, double preP2, double preP3, double preP4, double preP5)
        {
            codRes = cod;
            nombre = nom;
            direccion = dir;
            ruc = r;
            nombrePlato1 = nomp1;
            nombrePlato2 = nomp2;
            nombrePlato3 = nomp3;
            nombrePlato4 = nomp4;
            nombrePlato5 = nomp5;
            precioPlato1 = preP1;
            precioPlato2 = preP2;
            precioPlato3 = preP3;
            precioPlato4 = preP4;
            precioPlato5 = preP5;
        }
        public string CodRes
        {
            get
            {
                return codRes;
            }
            set
            {
                codRes = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public string Ruc
        {
            get
            {
                return ruc;
            }
            set
            {
                ruc = value;
            }
        }

        public string NombrePlato1
        {
            get
            {
                return nombrePlato1;
            }
            set
            {
                nombrePlato1 = value;
            }
        }

        public string NombrePlato2
        {
            get
            {
                return nombrePlato2;
            }
            set
            {
                nombrePlato2 = value;
            }
        }

        public string NombrePlato3
        {
            get
            {
                return nombrePlato3;
            }
            set
            {
                nombrePlato3 = value;
            }
        }

        public string NombrePlato4
        {
            get
            {
                return nombrePlato4;
            }
            set
            {
                nombrePlato4 = value;
            }
        }

        public string NombrePlato5
        {
            get
            {
                return nombrePlato5;
            }
            set
            {
                nombrePlato5 = value;
            }
        }

        public double PrecioPlato1
        {
            get
            {
                return precioPlato1;
            }
            set
            {
                precioPlato1 = value;
            }
        }

        public double PrecioPlato2
        {
            get
            {
                return precioPlato2;
            }
            set
            {
                precioPlato2 = value;
            }
        }

        public double PrecioPlato3
        {
            get
            {

                return precioPlato3;
            }
            set
            {
                precioPlato3 = value;
            }
        }

        public double PrecioPlato4
        {
            get
            {
                return precioPlato4;
            }
            set
            {
                precioPlato4 = value;
            }
        }

        public double PrecioPlato5
        {
            get
            {
                return precioPlato5;
            }
            set
            {
                precioPlato5 = value;
            }
        }
    }

}
