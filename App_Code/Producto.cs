using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SistemaNA
{

    public class Producto
    {
        Conexion sql = new Conexion();

        public int Id { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }

        public Producto(int pId)
        {
            SqlDataReader Prod = sql.consulta("SELECT * FROM Productos WHERE IdProducto = '" + pId + "'");
            if (Prod.Read())
            {
                Id = Convert.ToInt32(Prod[0].ToString());
                Descripcion = Prod[2].ToString();
                Precio = Convert.ToInt32(Prod[3].ToString());
            }
            /*
            Id = pId;
            //esta ser la lista de productos y precios
            switch (pId)
            {
                case 1:
                    Descripcion = "Zapatos Deportivos";
                    //lo puedo convertir para que me lo tome como decimal
                    Precio = Convert.ToDecimal(50.90);
                    break;
                case 2:
                    Descripcion = "Camisas Deportivas";
                    //es igual que convertirlo solo que le estoy diciendo que es decimal
                    Precio = 15.50m;
                    break;
                case 3:
                    Descripcion = "Pantalones Cortos";
                    Precio = 12.50m;
                    break;
                case 4:
                    Descripcion = "Sandalias";
                    Precio = 5m;
                    break;
                case 5:
                    Descripcion = "Bxer";
                    Precio = 2.75m;
                    break;
            }
            */
        }
    }
}