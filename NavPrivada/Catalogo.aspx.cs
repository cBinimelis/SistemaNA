using SistemaNA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NavPrivada_Catalogo : System.Web.UI.Page
{
    BDConxDataContext bdc;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    private void BindGrid()
    {
        bdc = new BDConxDataContext();
        GrillaProductos.DataSource = from vProductos in bdc.vProductos select vProductos;
        GrillaProductos.DataBind();
    }
    protected void lbZapatos_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(1);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbCamisas_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(2);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbPantalones_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(3);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbSandalias_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(4);
        Response.Redirect("VerCarrito.aspx");
    }
    protected void lbBoxer_Click(object sender, EventArgs e)
    {
        CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
        carrito.Agregar(5);
        Response.Redirect("VerCarrito.aspx");
    }
}