using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using Restoran.models;
using Restoran.dto;

namespace Restoran.db
{
    class DBRestoran
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        public static Employee GetEmployedByNameAndPass(string user, string password)
        {
            Employee employed = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `zaposleni` where KorisnickoIme=@user AND Lozinka=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", password);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employed = (new Employee()
                {
                    Id= reader.GetInt32(0),
                    JMB = reader.GetString(1),
                    Name = reader.GetString(2),
                    Surename = reader.GetString(3),
                    DateOfBirth = reader.GetDateTime(4),
                    DateOfEmployment = reader.GetDateTime(5),
                    UserName = reader.GetString(6),
                    Password = reader.GetString(7),
                    Type = reader.GetString(8),
                    Address = reader.GetString(9),
                    BanckAccaunt = reader.GetString(10),
                    Pay = reader.GetDecimal(11),
                    Phone = reader.GetString(12)
                });

            }
            reader.Close();
            conn.Close();
            return employed;
        }

        public static int InsertEmployee(Employee employee)
        {
            int lastIndex = -1;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO zaposleni
             VALUES (@Id,@JMB, @FirstName, @LastName, @DateOfBirth, @DateOfEmployment, @UserName , @Password, @Type, @Address, @BanckAccaunt, @Pay, @Phone)";
            cmd.Parameters.AddWithValue("@Id", employee.Id);
            cmd.Parameters.AddWithValue("@JMB", employee.JMB);
            cmd.Parameters.AddWithValue("@FirstName", employee.Name);
            cmd.Parameters.AddWithValue("@LastName", employee.Surename);
            cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@DateOfEmployment", employee.DateOfEmployment.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@UserName", employee.UserName);
            cmd.Parameters.AddWithValue("@Password", employee.Password);
            cmd.Parameters.AddWithValue("@Type", employee.Type);
            cmd.Parameters.AddWithValue("@Address", employee.Address);
            cmd.Parameters.AddWithValue("@BanckAccaunt", employee.BanckAccaunt);
            cmd.Parameters.AddWithValue("@Pay", employee.Pay);
            cmd.Parameters.AddWithValue("@Phone", employee.Phone);
            cmd.ExecuteNonQuery();
            lastIndex = (int)cmd.LastInsertedId;
            conn.Close();
            return lastIndex;
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `zaposleni`";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee()
                {
                    Id = reader.GetInt32(0),
                    JMB = reader.GetString(1),
                    Name = reader.GetString(2),
                    Surename = reader.GetString(3),
                    DateOfBirth = reader.GetDateTime(4),
                    DateOfEmployment = reader.GetDateTime(5),
                    UserName = reader.GetString(6),
                    Password = reader.GetString(7),
                    Type = reader.GetString(8),
                    Address = reader.GetString(9),
                    BanckAccaunt = reader.GetString(10),
                    Pay = reader.GetDecimal(11),
                    Phone = reader.GetString(12)
                });

            }
            reader.Close();
            conn.Close();
            return employees;
        }

        public static Employee GetEmployedByJMB(string jmb)
        {
            Employee employed = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `zaposleni` where JMB=@jmb";
            cmd.Parameters.AddWithValue("@jmb", jmb);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employed = (new Employee()
                {
                    Id=reader.GetInt32(0),
                    JMB = reader.GetString(1),
                    Name = reader.GetString(2),
                    Surename = reader.GetString(3),
                    DateOfBirth = reader.GetDateTime(4),
                    DateOfEmployment = reader.GetDateTime(5),
                    UserName = reader.GetString(6),
                    Password = reader.GetString(7),
                    Type = reader.GetString(8),
                    Address = reader.GetString(9),
                    BanckAccaunt = reader.GetString(10),
                    Pay = reader.GetDecimal(11),
                    Phone = reader.GetString(12)
                });

            }
            reader.Close();
            conn.Close();
            return employed;
        }
        public static void DeleteEmployeeByJMB(string jmb)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM `zaposleni` WHERE JMB=@jmb";
            cmd.Parameters.AddWithValue("@jmb", jmb);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpDateEmployee() { }

        public static List<Table> GetTables()
        {
            List<Table> tables = new List<Table>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `sto`";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tables.Add(new Table
                {
                    Id = reader.GetInt32(0),
                    TableNumber = reader.GetInt32(1),
                    NumberOfSeats = reader.GetInt32(2)

                });

            }
            reader.Close();
            conn.Close();
            return tables;
        }

        public static List<Article> GetArticlesForOrder()
        {
            List<Article> articles = new List<Article>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `artikal` WHERE DaLiSeProdaje=1 ";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                articles.Add(new Article
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),

                    SalePrice = reader.GetDecimal(4),
                    IsItForSale = Convert.ToBoolean(reader.GetByte(5)),
                    IsItToOrder = Convert.ToBoolean(reader.GetByte(6)),





                });



            }
            reader.Close();
            conn.Close();
            return articles;


        }
        public static List<Article> GetArticlesForSuppliers()
        {
            List<Article> articles = new List<Article>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `artikal` WHERE DaLiSeNarucuje=1";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                articles.Add(new Article
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Quantity = reader.GetInt32(3),
                    SalePrice = reader.GetDecimal(4),
                    IsItForSale = reader.GetBoolean(5),
                    IsItToOrder = reader.GetBoolean(6),
                    PurchasePrice = reader.GetDecimal(7),
                    Kilograms = reader.GetDecimal(8)

                });


            }
            reader.Close();
            conn.Close();
            return articles;


        }

        public static int InsertOrder(string jmb, int tableId)
        {
            int lastIndex = -1;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO narudzba (Zaposleni_JMB,Sto_IdSto)
             VALUES (@Employee_JMB,@Table_Id)";
            cmd.Parameters.AddWithValue("@Employee_JMB", jmb);
            cmd.Parameters.AddWithValue("@Table_Id", tableId);
            cmd.ExecuteNonQuery();
            lastIndex = (int)cmd.LastInsertedId;
            conn.Close();
            return lastIndex;
        }

        public static void InsertOrderArticle(OrderArticle orderArticle)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO narudzba_artikal (Narudzba_IdNarudzba,Artikal_IdArtikal,Cijena, Kolicina)
             VALUES (@Order_Id, @Article_Id, @Price, @Quantity)";
            cmd.Parameters.AddWithValue("@Order_Id", orderArticle.Order_Id);
            cmd.Parameters.AddWithValue("@Article_Id", orderArticle.Article_Id);
            cmd.Parameters.AddWithValue("@Price", orderArticle.Price);
            cmd.Parameters.AddWithValue("@Quantity", orderArticle.Quantity);
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public static List<OrderDto> GetWaiterOrders(string jmb)
        {
            List<OrderDto> orders = new List<OrderDto>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT n.IdNarudzba,s.Broj,na.Cijena,na.Kolicina,a.Naziv FROM narudzba n "
                + "JOIN sto s ON n.Sto_IdSto = s.IdSto "
                + "JOIN narudzba_artikal na on n.IdNarudzba = na.Narudzba_IdNarudzba "
                + "JOIN artikal a on na.Artikal_IdArtikal = a.IdArtikal "

                + "order by IdNarudzba ";
          //  cmd.Parameters.AddWithValue("@jmb", jmb);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                orders.Add(new OrderDto
                {
                    Id = reader.GetInt32(0),
                    TableNumber= reader.GetInt32(1),
                    Price = reader.GetDecimal(2),
                    Quantity = reader.GetInt32(3),
                    Name = reader.GetString(4)
                });


            }
            return orders;

        }




    }
}
