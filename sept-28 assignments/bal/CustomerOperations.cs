using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataaccess;
using System.Data.Entity;
namespace bal
{
    public class CustomerOperations
    {
        public List<book> GetCustomers()
        {
            NorthwindEntities context = new NorthwindEntities();

            List<book> clist = context.books.ToList();
            List<book> cblists = new List<book>();
            foreach (var item in clist)
            {
                cblists.Add(new book { book_id = item.book_id, book_author = item.book_author, book_name = item.book_name });



            }
            return cblists;




        }
        public void Insertcustomer(book bal)
        {
          NorthwindEntities context = new NorthwindEntities();
            book c = new book();
            c.book_id = bal.book_id;
            c.book_name = bal.book_name;
            c.book_author = bal.book_author;
            context.books.Add(c);
            context.SaveChanges();

        }
        public void UpdateCustomer(book bal)
        {
            NorthwindEntities context = new NorthwindEntities();
            List<book> customers = context.books.ToList();
            book obj = customers.Find(cust => cust.book_id == bal.book_id);
            obj.book_name= bal.book_name;
            obj.book_author = bal.book_author;
            context.SaveChanges();

        }
         public void DeleteCustomer(int bookid)
         {

             NorthwindEntities context = new NorthwindEntities();
             context.sp_DeleteEmployee(bookid);
             context.SaveChanges();
         }  
        public int bookcounts()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.books.Count();
            


        }

    }
}
