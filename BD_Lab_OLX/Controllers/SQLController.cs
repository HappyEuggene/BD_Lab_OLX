using BD_Lab_OLX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.IO;

namespace BD_Lab_OLX.Controllers
{
    public class SQLController : Controller
    {
        const string controller = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BD_OLX;Integrated Security=True";
        const string way = @"Z:\Programming\!Projects\BD_OLX\BD_OLX\SQL_Quest";
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult First(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "First.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlmod.Delivery = new List<string>();
            sqlmod.DeliveryDescription = new List<string>();
            sqlmod.UserNames = new List<string>();
            sqlmod.QueryId = 1;
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                            sqlmod.Delivery.Add(reader.GetString(1));
                            sqlmod.DeliveryDescription.Add(reader.GetString(2));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Second(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "Sec.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@Delivery", sqlmod.DeliveryName.ToString());

            sqlmod.Email = new List<string>();
            sqlmod.UserNames = new List<string>();
            sqlmod.QueryId = 2;
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                            sqlmod.Email.Add(reader.GetString(1));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Third(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "Third.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@Bank", sqlmod.BankName.ToString());
            sqlmod.QueryId= 3;
            sqlmod.Bank = new List<string>();
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.Bank.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Fourth(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "Fourth.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlmod.QueryId = 4;
            sqlmod.UserNames = new List<string>();
            sqlmod.Products = new List<string>();
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                            sqlmod.Products.Add(reader.GetString(1));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Fifth(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "Fifth.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@Price", sqlmod.price.ToString());
            sqlmod.QueryId = 5;
            sqlmod.UserNames = new List<string>();
            sqlmod.Products = new List<string>();
            sqlmod.Price = new List<int>();
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                            sqlmod.Products.Add(reader.GetString(1));
                            sqlmod.Price.Add(reader.GetInt32(2));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Multiple1(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "Multiple1.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlmod.QueryId = 6;
            sqlmod.UserNames = new List<string>();
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Multiple2(SQL sqlmod)
        {
            string sqlFilePath = Path.Combine(way, "Multiple2.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlQuery = sqlQuery.Replace("@Price", sqlmod.price.ToString());
            sqlmod.QueryId = 7;
            sqlmod.UserNames = new List<string>();
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
        [HttpPost]
        public IActionResult Multiple3(SQL sqlmod)

        {
            string sqlFilePath = Path.Combine(way, "Multiple3.sql");
            string sqlQuery = System.IO.File.ReadAllText(sqlFilePath);
            sqlmod.QueryId = 8;
            sqlmod.UserNames = new List<string>();
            sqlmod.Email = new List<string>();
            using (var connection = new SqlConnection(controller))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sqlmod.UserNames.Add(reader.GetString(0));
                            sqlmod.Email.Add(reader.GetString(1));
                        }
                    }
                }
            }
            return View("Answer", sqlmod);
        }
    }
}
