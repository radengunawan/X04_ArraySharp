using System;

namespace X04_ArraySharp
{

    class Gajah
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }

        public void DengerSuara(string chat, Gajah dariSiapa)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(dariSiapa.Name + " ngomong gini: " + chat);
        }

        public void ngomongKe(Gajah keSiapa)
        {
            //keSiapa.DengerSuara(pesan, this);
            Console.WriteLine("Hallo, this is " + this.Name);
            Console.WriteLine("I am talking to " + keSiapa.Name);
            Console.WriteLine("My ear size is " + this.EarSize + " while yours is " + keSiapa.EarSize);

            if (this.EarSize > keSiapa.EarSize)
            {
                Console.WriteLine("My ear size is " + Math.Abs(this.EarSize - keSiapa.EarSize) + " more than you");
            }
            else if (this.EarSize < keSiapa.EarSize)
            {
                Console.WriteLine("My ear size is " + Math.Abs(this.EarSize - keSiapa.EarSize) + " less than you");
            }

            else
            {
                Console.WriteLine("we have the same ear size, i.e."+this.EarSize);
            }
        }

    } // end of class




    class Program
    {

        static void Main(string[] args)
        {

            //START HERE
            Console.WriteLine("Hello World!");
        }

    } //end of Main program
} //end of namespace
