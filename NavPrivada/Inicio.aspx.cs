using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NavAdmin_Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_generar_Click(object sender, EventArgs e)
    {
        //Ean13 barcode = new Ean13("9780201734843", null);
        LabelKit.BarcodeGenerator code = new LabelKit.BarcodeGenerator();
        System.Drawing.Graphics g = Graphics.FromImage(new Bitmap(1, 1));
        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(1, 1, PixelFormat.Format32bppArgb);

        g = Graphics.FromImage(bmp);
        code.DrawCode128(g, txt_codigo.Text, 0, 0).Save(Server.MapPath("../img/barcodes/bc.png"), ImageFormat.Png);
        Image1.ImageUrl = "../img/barcodes/bc.png";
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txt_codigo.Text = GridView1.SelectedRow.Cells[1].Text;
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
            e.Row.Attributes["style"] = "cursor:pointer";
        }
    }
}