using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace sept_23_assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            Class1 obj=new Class1();
          //  Console.WriteLine("enter the product key to search");
           // obj.ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount to search");
            obj.Price=Convert.ToInt32(Console.ReadLine());
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=kannan; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("select * from product where unitprice='" + obj.Price + "'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["productid"] + " " + sdr["productname"] + " " + sdr["unitprice"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
