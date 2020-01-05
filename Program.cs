using System;

namespace HwReader
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int one = 0;
            int two = 0;
            int onealt =0;
            int twoalt = 1;
            int fail = 0;
            int fail2 = 0;
            int numholder;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Julian\Desktop\CS3620_VM\SharedFolder\Q2B3output6.txt");
            while ((line = file.ReadLine()) != null)
            {

                string[] substrings = line.Split(": ");
                string a = substrings[0];
                
                if(a == "Consumer 1")
                {
                    string b = substrings[1];
                    counter++;
                    numholder = Int32.Parse(b);
                    one++;
                    onealt++;
                    if(numholder%2 != 1)
                    {
                        fail2++;
                        System.Console.ReadLine();
                    }
                    if(numholder != counter)
                    {
                        fail2++;
                        System.Console.ReadLine();
                    }
                    if(onealt>=2)
                    {
                        fail++;
                        System.Console.ReadLine();
                    }
                    twoalt = 0;
                    
                }
                if(a == "Consumer 2")
                {
                    string b = substrings[1];
                    counter++;
                    numholder = Int32.Parse(b);
                    two++;
                    twoalt++;
                    if (numholder != counter)
                    {
                        fail2++;
                        System.Console.ReadLine();
                    }
                    if (twoalt>=2)
                    {
                        fail++;
                        System.Console.ReadLine();
                    }
                    onealt = 0;
                    
                }
                System.Console.WriteLine(line);
                

            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.WriteLine("Consumer 1 printed {0} times", one);
            System.Console.WriteLine("Consumer 2 printed {0} times", two);
            if (fail > 0)
            {
                System.Console.WriteLine("Failed: Alternating");
            }
            if (fail2 > 0)
            {
                System.Console.WriteLine("Failed: Consecutive Numbers");
            }
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
