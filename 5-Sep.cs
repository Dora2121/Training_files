using Books.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Books.addition;

namespace Books
{
    public class addition
    {
        public int a, b;
        public addition()   //default contructor
        {
            a = 100;
            b = 175;
        }
        public class paraconstrctor
        {
            public int a, b;
            public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
            {
                a = x;
                b = y;
            }
        }

    }
    //------------------------------------------------------------------------------------
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
    {
        public class insert
        {

            public string title;
            public string author;
        }
    }

    //------------------------------------------------------------------------------
    using System;

public class Class1
    {
        public Class1()
        {
            public void addBook(string title, string author)
            {
                int bookQuantity;

                string btitle;
                string bauthor;

                bookQuantity = int.Parse(Console.ReadLine());

                for (int x = 0; x <= bookQuantity; x++)
                {
                    Console.WriteLine("Enter Title:");

                    btitle = Console.ReadLine();

                    Console.WriteLine("Enter Author:");
                    bauthor = Console.ReadLine();

                    books.Add(new Book(btitle, bauthor));

                }
            }
         public class Book
        {
            public string title;
            public string author;
            public int id;
            static int isbn;

            public string ID { get; set; }

            public void assignID()
            {
                id = isbn;
                isbn++;
            }

            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
            }

            public override string ToString()
            {
                return string.Format("Title: " + title, "\nAuthor: " + author, "\nISBN: " + id);

            }
        }
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
    {
        public class Class1
        {
            //class Book with Bookid, bookname, price, author as properties.
            private int _booKId;

            public int BookId
            {
                get { return _booKId; }
                set { _booKId = value; }
            }
            private string _bookname;

            public string BookName
            {
                get { return _bookname; }
                set { _bookname = value; }
            }
            private int _price;

            public int BookPrice
            {
                get { return _price; }
                set { _price = value; }
            }

            private string _authour;

            public string Author_Details
            {
                get { return _authour; }
                set { _authour = value; }
            }




        }
    }
    //--------------------------------------MAIN---------------------------------------
    using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books;

namespace Assignmets
    {
        public class Program
        {
            static void Main(string[] args)
            {
                /*Class1 b = new Class1();
                b.BookId = 12345;
                b.BookName = "Helen killer";
                b.BookPrice = 500;
                b.Author_Details = "Helen";
                Console.WriteLine("BookId:" + b.BookId);
                Console.WriteLine("BookName:" + b.BookName);
                Console.WriteLine("BookPrice:"+b.BookPrice);
                Console.WriteLine("Authour:"+b.Author_Details);*/


                addition obj = new addition(); //an object is created , constructor is called
                Console.WriteLine(obj.a);
                Console.WriteLine(obj.b);


                paraconstrctor v = new paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and ing values
                Console.WriteLine("-----------parameterized constructor example---------------");
                Console.WriteLine("\t");
                Console.WriteLine("value of a=" + v.a);
                Console.WriteLine("value of b=" + v.b);

                int nobook = 1000;
                insert[] books = new insert[nobook];
                int i, j, n = 1, k = 1;
                Console.Write("\n\nInsert the information of two books :\n");
                Console.Write("-----------------------------------------\n");
                for (j = 0; j <= n; j++)
                {
                    Console.WriteLine("Information of book {0} :", k);

                    Console.Write("Input name of the book : ");
                    books[j].title = Console.ReadLine();

                    Console.Write("Input the author : ");
                    books[j].author = Console.ReadLine();
                    k++;
                    Console.WriteLine();
                }

                for (i = 0; i <= n; i++)
                {
                    Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                    Console.WriteLine();
                }



                Console.ReadLine();


            }
        }
    }

