using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {

        public class Movie
        {
            private string _name;
            private string _language;
            private string _genre;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Language
            {
                get { return _language; }
                set { _language = value; }
            }
            public string Genre
            {
                get { return _genre; }
                set { _genre = value; }
            }
            public int stock
            {
                get;
                set;
            }
            public Movie(string name, string language, string genre, int stock)
            {
                _name = name;
                _language = language;
                _genre = genre;
                this.stock = stock;

            }
            public Movie()
            {

            }

        }

        public class User : Movie
        {

            public User()
            {

            }
            public string Username
            {
                get;
                set;
            }
            public string Type
            {
                get;
                set;
            }
            public List<Movie> rented
            {
                get;
                set;
            }
            public DateTime rentaldate
            {
                get;
                set;
            }
            public DateTime releasingdate
            {
                get;
                set;
            }
            public int Cost
            {
                get;
                set;
            }
            public List<Movie> dbmovies = new List<Movie>();



            public void initiate()
            {
                Movie m = new Movie("AVENGERS", "English", "Action", 60);
                dbmovies.Add(m);
                Movie k = new Movie("SitaRamam", "telugu", "Romance", 30);
                dbmovies.Add(k);
                Movie t = new Movie("Bramastra", "Hindi", "Action", 30);
                dbmovies.Add(t);
                Movie n = new Movie("KGF", "Kannada", "Action", 30);
                dbmovies.Add(n);
                foreach (var item in dbmovies)
                {
                    Console.WriteLine($"{item.Name}  {item.Language} {item.Genre} {item.stock}");
                }



            }

            public void Addition(Movie p)
            {
                dbmovies.Add(p);
            }
            public void Removing(Movie p)
            {
                dbmovies.Remove(p);
            }
            public void Display()
            {
                foreach (var item in dbmovies)
                {
                    Console.WriteLine($"{item.Name}  {item.Language} {item.Genre} {item.stock}");
                }
            }




            public List<Movie> adding(List<Movie> rented1, string Type1)
            {
                string s = Console.ReadLine();
                if (Type1.Equals("Gold") && rented1.Count > 3)
                {
                    Console.WriteLine("You cannot add");
                    return rented1;
                }
                else if (Type1.Equals("Silver") && rented1.Count > 1)
                {
                    Console.WriteLine("You cannot add");
                    return rented1;
                }
                else if (Type1.Equals("Platinum") && rented1.Count > 5)
                {
                    Console.WriteLine("You cannot add");
                    return rented1;
                }
                else
                {

                    var pi = dbmovies.Where(p => p.Name == s).ToList();
                    if (pi != null)
                    {
                        foreach (Movie item in pi)
                        {

                            Console.WriteLine(item.Name);

                            dbmovies.Remove(item);
                            item.stock = item.stock - 1;
                            rented1.Add(item);

                            dbmovies.Add(item);


                        }
                        return rented1;
                    }
                    else
                    {
                        Console.WriteLine("Asked one is not available");
                        return rented1;
                    }


                }


            }
            public List<Movie> releasing(List<Movie> rented1)
            {

                string cp = Console.ReadLine();
                var po = dbmovies.Where(p => p.Name == cp).ToList();

                foreach (var item in po)
                {
                    dbmovies.Remove(item);
                    item.stock = item.stock + 1;
                    rented1.Remove(item);
                    dbmovies.Add(item);

                }
                return rented1;

            }
            public double TotalCost()
            {
                TimeSpan ts = releasingdate - rentaldate;
                int to = ts.Days;
                double k = 0.18 * Cost;
                double ty = to * 0.01 * Cost;
                double yt = k + ty + Cost;
                Console.WriteLine($"GST is {k}");
                Console.WriteLine($"Bluray cost is {ty}");
                Console.WriteLine("Total cost is" + " " + yt);
                return yt;
            }
        }
    }

    static void Main(string[] args)
    {
    testc:
        Console.WriteLine("Enter the username as user");
        string p = Console.ReadLine();
        Console.WriteLine("Enter the password as pass");
        string ps = Console.ReadLine();
        Tuple<string, string> t = Tuple.Create<string, string>(p, ps);

        Predicate<Tuple<string, string>> ki = (i) =>
        {
            if (i.Item1 == "user" && i.Item2 == "pass")
            {

                return true;
            }
            else
            {
                return false;
            }

        };
        bool ko = ki.Invoke(t);
        if (ko)
        {
            Console.WriteLine("Logged in successfully");
            User u = new User();
            Console.WriteLine("Enter user");
            p = Console.ReadLine();
            u.Username = p;
            Console.WriteLine("Enter type");
            u.Type = Console.ReadLine();
            u.initiate();
            List<Movie> s = new List<Movie>();
            double total = 0;
            int Count1 = 0;
        sed:
            Console.WriteLine("Adding");
            s = u.adding(s, u.Type);
            Count1++;
            u.rented = s;
            if (s.Count == Count1)
            {
                Console.WriteLine("Enter the rental year");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the rental month");
                int mi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the rental date");
                int min = Convert.ToInt32(Console.ReadLine());
                DateTime top = new DateTime(m, mi, min);
                u.rentaldate = top;
                Console.WriteLine("Enter the releasing year");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the releasing month");
                int im = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the releasing date");
                int imn = Convert.ToInt32(Console.ReadLine());
                DateTime pot = new DateTime(i, im, imn);
                u.releasingdate = pot;
                Console.WriteLine("Enter the cost");
                u.Cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total cost for this movie", +u.TotalCost());
                total += u.TotalCost();
                Console.WriteLine("Enter Yes to further rental");
                string u1 = Console.ReadLine();
                if (u1 == "Yes")
                {
                    goto sed;
                }
            }
            Console.WriteLine("Stocks after rented");

            foreach (var item in u.dbmovies)
            {
                Console.WriteLine($"{item.Name} {item.stock}");
            }

            s = u.releasing(s);
            u.rented = s;
            Console.WriteLine("Total cost" + total);
            foreach (var item in u.rented)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Try again");
            goto testc;
        }
    }
}
}