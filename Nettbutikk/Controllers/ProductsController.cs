using Microsoft.AspNetCore.Mvc;
using Nettbutikk.Models;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Nettbutikk.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Products(List<ProductsModel> objProductModel)
        {
            string conStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=Nettbutikk; Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string qury = "select id, price from products";
            SqlCommand cmd = new SqlCommand(qury, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var productModel = new ProductsModel();
                productModel.ProductId = Convert.ToInt32(dr.GetValue(0));
                productModel.ProductPrice = Convert.ToInt32(dr.GetValue(1));
                objProductModel.Add(productModel);
            }

            return View(objProductModel);
        }

        public ActionResult GetImage(int id)
        {
            string conStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=Nettbutikk; Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string qury = "select picture from products where id = " + id;
            SqlCommand cmd = new SqlCommand(qury, con);

            SqlDataReader dr = cmd.ExecuteReader();

            Byte[] data = new Byte[0];
            data = (Byte[])(dr.GetValue(0));
            while (dr.Read())
            {
                data = (Byte[])(dr.GetValue(0));
            }
            return File(data, "image/jpg");
        }

        [HttpPost]
        public IActionResult Products()
        {
            return View();
        }
    }
}
