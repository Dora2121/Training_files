using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace products
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection c=new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=kannan;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
         /*  HttpCookie cookie;
            cookie = Request.Cookies.Get("prodData");
            Products p2 = new Products();
            p2.Prodid = Convert.ToInt32(cookie["pid"]);
            p2.ProdName = cookie["pname"].ToString();
            p2.Price = Convert.ToInt32(cookie["price"]);

            ListBox1.Items.Add(p2.Prodid + " " + p2.ProdName + " " + p2.Price);   */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid.Text);
            p.ProdName = txtprodname.Text;
            p.Price = Convert.ToInt32(txtprice.Text);


            HttpCookie cookie = new HttpCookie("prodData");
            cookie.Expires = DateTime.Now.AddMinutes(10);


            cookie.Values.Add("pid", p.Prodid.ToString());
            cookie.Values.Add("pname", p.ProdName);
            cookie.Values.Add("price", p.Price.ToString());
            Response.Cookies.Add(cookie);
            Label1.Text = "cookies addede succesfully";   

          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
                 Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid0.Text);
            p.ProdName = txtprodname0.Text;
            p.Price = Convert.ToInt32(txtprice0.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into products values('"+p.Prodid+"','"+p.ProdName+"','"+p.Price+"')",c);
            cmd.ExecuteNonQuery();
            lbl0.Text = "record added succesfully";
            
            c.Close();       
        }
       
     

        protected void Button5_Click(object sender, EventArgs e)
        {
           Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid1.Text);
            //  p.ProdName = txtprodname0.Text;
            //  p.Price = Convert.ToInt32(txtprice0.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("delete from products where Prodid=' " + p.Prodid + "'", c); ;
            cmd.ExecuteNonQuery();
            lbl1.Text = "record deleted succesfully";

            c.Close();    
        } 

        protected void Button6_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid2.Text);
              p.ProdName = txtprodname2.Text;
              p.Price = Convert.ToInt32(txtprice2.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("update products set ProdName=' " + p.ProdName + "',Price='" + p.Price + "' where Prodid=' " + p.Prodid + "'", c);
            cmd.ExecuteNonQuery();
            lbl2.Text = "record update succesfully";

            c.Close();   
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("select * from products", c);
           

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            lbl3.Text = "record view succesfully"; 
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Prodid = Convert.ToInt32(txtprodid3.Text);
           
            SqlCommand cmd = new SqlCommand("select * from products where Prodid=' " + p.Prodid + "'", c);

           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            lbl4.Text = "record view succesfully";

        }
    }
}