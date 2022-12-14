using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string> { };
            myList.Add("ismail");
            Console.WriteLine(myList.Length);
            myList.Add("melis");
            Console.WriteLine(myList.Length);
            myList.Add("kaplan");

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
