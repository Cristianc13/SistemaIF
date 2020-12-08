using System.Collections;

namespace ENT
{
    public class ENTDashboard
    {
        public ArrayList Categoria = new ArrayList();
        public ArrayList CantProd = new ArrayList();
        public ArrayList Producto = new ArrayList();
        public ArrayList Cant = new ArrayList();

        public ArrayList Cantvent = new ArrayList();
        public ArrayList Meses = new ArrayList();

        public ArrayList CantCompras = new ArrayList();
        public ArrayList MesesCompras = new ArrayList();
        public string totalVentas { get; set; }
        public string CantModelo { get; set; }
        public string CantMarcas { get; set; }
        public string CantProductos { get; set; }
        public string CantClientes { get; set; }
        public string CantCat { get; set; }
        public string CantProveedores { get; set; }

        public string CantVenta { get; set; }
        public string CantCompra { get; set; }

        //

        public ArrayList CantCompras1
        {
            get
            {
                return CantCompras;
            }
            set
            {
                CantCompras = value;
            }
        }

        public ArrayList MesesCompras1
        {
            get
            {
                return MesesCompras;
            }
            set
            {
                MesesCompras = value;
            }
        }

        //
        public ArrayList Cantvent1
        {
            get
            {
                return Cantvent;
            }
            set
            {
                Cantvent = value;
            }
        }

        public ArrayList Meses1
        {
            get
            {
                return Meses;
            }
            set
            {
                Meses = value;
            }
        }

        //
        public ArrayList Categoria1
        {
            get
            {
                return Categoria;
            }
            set
            {
                Categoria = value;
            }
        }

        public ArrayList CantProd1
        {
            get
            {
                return CantProd;
            }
            set
            {
                CantProd = value;
            }
        }

        public ArrayList Producto1
        {
            get
            {
                return Producto;
            }
            set
            {
                Producto = value;
            }
        }

        public ArrayList Cant1
        {
            get
            {
                return Cant;
            }
            set
            {
                Cant = value;
            }
        }
    }
}