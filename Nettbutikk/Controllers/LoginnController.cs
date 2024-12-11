using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.SqlClient;
using Nettbutikk.Models;

namespace Nettbutikk.Controllers
{
    public class LoginnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Loginn()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Loginn(LoginnModel objLoginnModel)
        {

            string conStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=Nettbutikk; Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string qury = "select id from logininfo where brukernavn = '" + objLoginnModel.Username + "' and passord = '" + objLoginnModel.Password + "'";
            SqlCommand cmd = new SqlCommand(qury, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(Convert.ToInt32(dr.GetValue(0)) >= 1)
                {
                    ViewBag.msg = "<script>alert('Login er korrekt')</script>";
                 
                    return View();
                }
                else
                {
                    ViewBag.msg = ("<script>alert('Login er feilet')</script>");
                    //ViewBag.msg = "loginn feilet";
                }
            }

            return View(objLoginnModel);
        }


    }
}
