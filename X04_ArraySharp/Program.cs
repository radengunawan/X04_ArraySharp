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



    // BEGIN of Main Class
    class Program
    {
        static void Main(string[] args)
        {    //---------START AFTER THIS LINE-------------START AFTER THIS LINE------------START AFTER THIS LINE--------------------

            Gajah[] list1 = new Gajah[7];


            list1[0] = new Gajah() { Name = "Lloyd", EarSize = 40 };
            list1[1] = new Gajah() { Name = "Lucinda", EarSize = 33 };
            list1[2] = new Gajah() { Name = "Larry", EarSize = 42 };
            list1[3] = new Gajah() { Name = "Lucille", EarSize = 32 };
            list1[4] = new Gajah() { Name = "Lars", EarSize = 44 };
            list1[5] = new Gajah() { Name = "Linda", EarSize = 37 };
            list1[6] = new Gajah() { Name = "Humphrey", EarSize = 45 };

            Gajah telingaPalingGede = list1[0];
            
            for (int i = 1; i < list1.Length; i++)
            {
                Console.WriteLine("Iteration #" + i);
                if (list1[i].EarSize > telingaPalingGede.EarSize)
                {
                    telingaPalingGede = list1[i];
                }
                Console.WriteLine(telingaPalingGede.EarSize.ToString());
            }

            int j = 0;
           foreach (var item in list1)
            {
                Console.WriteLine("Index = "+ j.ToString()+" | "+item.Name+" | "+item.EarSize.ToString());
                j++;
            }

            //char input = Console.ReadKey(true).KeyChar;







            // ----DO NOT WRITE BEYOND THIS LINE-----------DON'T WRITE BEYOND THIS LINE-------DO NOT WRITE BEYOND THIS LINE------------
        }// END of Main program

} //END of Main class
} //END of namespace
