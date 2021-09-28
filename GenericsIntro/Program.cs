using System;

namespace GenericsIntro
{
    class Program
    {

        string[] items;

        static void Main(string[] args)
        {
            MyList <string> isimler = new MyList<string>();
            isimler.Add("Musa");

        }
    }
}
