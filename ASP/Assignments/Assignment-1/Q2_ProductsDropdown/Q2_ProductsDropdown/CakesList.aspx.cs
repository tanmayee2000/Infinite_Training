using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2_ProductsDropdown
{
    public partial class Cakes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CakeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string img_path;
            switch (id.SelectedValue)
            {
                case "Caramel Crunch":
                    img_path = @"D:\Training_June\ASP\Assignments\Assignment-1\Q2_ProductsDropdown\Q2_ProductsDropdown\Images\Caramel Crunch.jpg";
                    break;
                case "Chocolate Truffle":
                    img_path = @"D:\Training_June\ASP\Assignments\Assignment-1\Q2_ProductsDropdown\Q2_ProductsDropdown\Images\Chocolate Truffle.jpg";
                    break;
                case "Fruit n Nut":
                    img_path = @"D:\Training_June\ASP\Assignments\Assignment-1\Q2_ProductsDropdown\Q2_ProductsDropdown\Images\Fruit n Nut.jpg";
                    break;
                case "Macaron Rush":
                    img_path = @"D:\Training_June\ASP\Assignments\Assignment-1\Q2_ProductsDropdown\Q2_ProductsDropdown\Images\Macaron Rush.jpg";
                    break;
                case "Red Velvet":
                    img_path = @"D:\Training_June\ASP\Assignments\Assignment-1\Q2_ProductsDropdown\Q2_ProductsDropdown\Images\Red Velvet.jpg";
                    break;
                default:
                    img_path = string.Empty;
                    break;
            }

            //img.ImageUrl = $"~/{img_path}";
            img.ImageUrl = $"~/Images/{Path.GetFileName(img_path)}";
        }

        protected void Btn_GetPrice_Click(object sender, EventArgs e)
        {
            string cake = id.SelectedValue;
            double price;

            switch (cake)
            {
                case "Caramel Crunch":
                    price = 650.00;
                    break;
                case "Chocolate Truffle":
                    price = 550.00;
                    break;
                case "Fruit n Nut":
                    price = 700.00;
                    break;
                case "Macaron Rush":
                    price = 900.00;
                    break;
                case "Red Velvet":
                    price = 800.00;
                    break;
                default:
                    price = 0;
                    break;
            }
            if (price != 0)
            {
                label1.Text = $"Price : {price}";
            }
            else
            {
                label1.Text = "Select a cake.";
            }
        }
    }
}