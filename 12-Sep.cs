using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double _num;

        public double Num
        {
            get { return _num; }
            set { _num = value; }
        }
        public double Cube(double No)
        {
            double n = Num * Num * Num;
            return n;
        }
        public double Sqrt(double number)
        {
            double res = Math.Sqrt(number);
            return res;
        }
    }


}
//-----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    public class SteroDisc
    {

        public class DeveloperAttribute : Attribute
        {

            private string song;
            private string language;
            private string lyrics;


            public DeveloperAttribute(string song, string language, string lyrics)
            {
                this.song = song;
                this.language = language;
                this.lyrics = lyrics;
            }



            public virtual string songName
            {
                get { return song; }
            }


            public virtual string Language
            {
                get { return language; }
            }


            public virtual string Lyrics
            {
                get { return lyrics; }

            }
        }
    }
}

//-----------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    public class song
    {

        public class DeveloperAttribute : Attribute
        {

            private string class_song;

            public DeveloperAttribute(string class_song)
            {
                this.class_song = class_song;

            }



            public virtual string Class_song
            {
                get { return class_song; }
            }




        }
    }
}
