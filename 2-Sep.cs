using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Category
    {
        //Create a class Category with catid, catname,description
        int _catid;
        string _catname;
        string _description;

        public int CategoryID
        {
            get { return _catid; }
            set { _catid = value; }
        }

        public string CategoryName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }

        }

        public List<Product> _productlist;
        public List<Product> ProductList
        {
            get { return _productlist; }
            set { _productlist = value; }
        }

        //Write a AddCategory() in the Category Class, accepting catid, catname,description
        //and assign them to respective properties.
        public void AddCategory(int _catid, string _catname, string _description)
        {
            this.CategoryID = _catid;
            this.CategoryName = _catname;
            this.Description = _description;
        }

        

        public void DisplayDetails()
        {
            Console.WriteLine("CategoryID :", _catid);
            Console.WriteLine("CategoryName :", _catname);

            foreach (var i in ProductList)
            {
                Console.WriteLine("Product ID: " + i._pid);
                Console.WriteLine("Product Name: " + i.ProductName);

            }
        }
    }

}
//--------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        int _pid;
        string _pname;
        int _soldcount;
        int _record;

        public int ProductID
        {
            get { return _pid; }
            set { _pid = value; }
        }

        public string ProductName
        {
            get { return _pname; }
            set { _pname = value; }
        }

        public int QuantitySold
        {
            get { return _soldcount; }
            set
            {
                _soldcount = value;
            }
        }

        public int RecordLevel
        {
            get { return _record; }
            set
            {
                _record = value;
            }
        }

        public void AddProduct(int _pid, string _prodname)
        {
            this.ProductID = _pid;
            this.ProductName = _prodname;
        }

        //Add a List of products property to the Category Class and assign the products list.

        public List<Product> _prodlist;
        public List<Product> ProductsList
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }
    }



}
//-------------------------------------------------------MAIN Program-------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Sep_2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category ctg = new Category();

            ctg.CategoryID = 501;
            ctg.CategoryName = "Pens";
            ctg.Description = "Writting";

            Console.WriteLine(ctg.CategoryID);
        }
        public class Category
        {
            //Create a class Category with catid, catname,description
            int _catid;
            string _catname;
            string _description;

            public int CategoryID
            {
                get { return _catid; }
                set { _catid = value; }
            }

            public string CategoryName
            {
                get { return _catname; }
                set { _catname = value; }
            }

            public string Description
            {
                get { return _description; }
                set
                {
                    _description = value;
                }

            }
        }
    }
}