using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exa1
{
    class Global
    {
        private int productocod;
        private string productonombre;
        private string productotipo;
        
        public double size;
        private int vencimiento;
        private string productoprovee;
        private double productoprecio;
        private int productoes;


        private struct producto
        {
            public int productocod;
            public string productonombre;
            public string productotipo;
           
            public int productovencimiento;
            public string productoprovee;
            public double productoprecio;
            public int productoes;
        };

        private static producto[] productos;

        //constructor
        public Global()
        {
            productocod = 0;
            productonombre = "";
            productotipo = "";
            bookvencimiento = 0;
            productoprovee = "";
            productoprecio = 0.0;
            productoes = 0;
        }

        //contructor con parámetros
        public Global(int id, string name, string author, int vencimiento, string provee, double precio, int es)
        {
            productocod = id;
            productonombre = name;
            productotipo = author;
            
            bookvencimiento = vencimiento;
            productoprovee = provee;
            productoprecio = precio;
            productoes = es;
        }

        //propiedades 
        public int ProductoCod
        {
            get { return productocod; }
            set { productocod = value; }
        }
        public string ProductoName
        {
            get { return productonombre; }
            set { productonombre = value; }
        }

        //propiedades 
        public void SetProductoCod(int cod)
        {
            productocod = cod;
        }

        public int GetProductoCod()
        {
            return productocod;
        }

        public void SetProductoNombre(string nombre)
        {
            productonombre = nombre;
        }

        public string GetProductoNombre()
        {
            return productonombre;
        }
        public void SetProductoTipo(string tipo)
        {
            productotipo = tipo;
        }
        public string GetProductoTipo()
        {
            return productotipo;
        }

        public void SetSize(int Size)
        {
            size = Size;
            productos = new producto[Size];
        }
        public void SetBookVencimiento(int vencimiento)
        {
            bookvencimiento = vencimiento;
        }

        public int GetBookVencimiento()
        {
            return bookvencimiento;
        }
         public void SetBookProvee(string provee)
        {
            productoprovee = provee;
        }

         public string GetBookProvee()
         {
             return productoprovee;
         }
         public void SetBookPrecio(double precio)
         {
             productoprecio = precio;
         }
         public double GetBookPrecio()
         {
             return productoprecio;
         }
         public void SetBookEs(int es)
         {
             productoes = es;
         }

         public int GetBookEs()
         {
             return productoes;
         }
        public void Initdata()
        {
           
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i].productocod = 0;
                productos[i].productonombre = "";
                productos[i].productotipo = "";
                
                productos[i].productovencimiento = 0;
                productos[i].productoprovee = "";
                productos[i].productoprecio = 0;
                productos[i].productoes = 0;
            }
        }

        public bool AddData(Global Book)
        {

            int i;
            for (i = 0; i < productos.Length; i++)
            {
                if (productos[i].productocod == 0)
                {
                    break;
                }
            }

            if (i < productos.Length)
            {
                productos[i].productocod = Book.productocod;
                productos[i].productonombre = Book.productonombre;
                productos[i].productotipo = Book.productotipo;
               
                productos[i].productovencimiento = Book.bookvencimiento;
                productos[i].productoprovee = Book.productoprovee;
                productos[i].productoprecio = Book.productoprecio;
                productos[i].productoes = Book.productoes;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SeekData(int record)
        {
            
            int i;
            for (i = 0; i < productos.Length; i++)
            {
                if (productos[i].productocod == record)
                {
                    break;
                }
            }

            if (i < productos.Length)
            {
                productocod = productos[i].productocod;
                productonombre = productos[i].productonombre;
                productotipo = productos[i].productotipo;
               
                bookvencimiento = productos[i].productovencimiento;
                productoprovee = productos[i].productoprovee;
                productoprecio = productos[i].productoprecio;
                productoes = productos[i].productoes;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateData(Global Book, int record)
        {
         
            int i;
            for (i = 0; i < productos.Length; i++)
            {
                if (productos[i].productocod == record)
                {
                    break;
                }
            }

            if (i < productos.Length)
            {
                productos[i].productocod = Book.productocod;
                productos[i].productonombre = Book.productonombre;
                productos[i].productotipo = Book.productotipo;
                
                productos[i].productovencimiento = Book.bookvencimiento;
                productos[i].productoprovee = Book.productoprovee;
                productos[i].productoprecio = Book.productoprecio;
                productos[i].productoes = Book.productoes;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteData(int record)
        {
           
            int i;
            for (i = 0; i < productos.Length; i++)
            {
                if (productos[i].productocod == record)
                {
                    break;
                }
            }

            if (i < productos.Length)
            {
                productos[i].productocod = 0;
                productos[i].productonombre = "";
                productos[i].productotipo = "";
              
                productos[i].productovencimiento = 0;
                productos[i].productoprovee = "";
                productos[i].productoprecio = 0;
                productos[i].productoes = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintData(int pos)
        {
            
            productocod = productos[pos].productocod;
            productonombre = productos[pos].productonombre;
            productotipo = productos[pos].productotipo;
          
            bookvencimiento = productos[pos].productovencimiento;
            productoprovee = productos[pos].productoprovee;
            productoprecio = productos[pos].productoprecio;
            productoes = productos[pos].productoes;
        }

       
        ~Global()
        {

        }

        public int bookvencimiento { get; set; }

        internal void SetBookVencimiento(string p) 
        

       
        {
            
        }
    }
}