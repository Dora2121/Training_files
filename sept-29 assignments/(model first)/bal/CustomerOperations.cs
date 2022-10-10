using data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace bal
{
    public class CustomerOperations
    {
        /*  public void Insertcustomer(borrow bal)
          {
              modelfirstContainer context = new modelfirstContainer();
              borrow c = new borrow();
            //  c.borrow_id = bal.borrow_id;
              c.borrow_name = bal.borrow_name;

              c.state = bal.state;
              c.country = bal.country;
              c.city = bal.city;
              c.street = bal.street;
              c.company_name = bal.company_name;
              c.jobname = bal.jobname;
              context.borrows.Add(c);
              context.SaveChanges();

          } */
        modelfirstContainer context = new modelfirstContainer();
        public List<book> GetCustomers()
        {
            modelfirstContainer context = new modelfirstContainer();

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
            modelfirstContainer context = new modelfirstContainer();
            book c = new book();
            c.book_id = bal.book_id;
            c.book_name = bal.book_name;
            c.book_author = bal.book_author;
            context.books.Add(c);
            context.SaveChanges();

        }
        public void UpdateCustomer(book bal)
        {
            modelfirstContainer context = new modelfirstContainer();
            List<book> customers = context.books.ToList();
            book obj = customers.Find(cust => cust.book_id == bal.book_id);
            obj.book_name = bal.book_name;
            obj.book_author = bal.book_author;
            context.SaveChanges();

        }
       /* public void DeleteCustomer(int bookid)
        {

            modelfirstContainer context = new modelfirstContainer();
            context.sp_DeleteEmployee(bookid);
            context.SaveChanges();
        } */
        public int bookcounts()
        {
            modelfirstContainer context = new modelfirstContainer();
            return context.books.Count();



        }
    }
}
