using System;

namespace assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var name=String.Empty;
            var n = 0;
            var h = true;
            decimal unitPrice = 0.0m;
            var c = 'y';
            
            Console.WriteLine("Do you like to watch movie ? \n\ty for yes or n for no");
            var ch = Console.ReadLine();
            c = Convert.ToChar(ch);

            if(c == 'y'){
                while(h){
                Console.WriteLine("Please,Enter your name");
                name = Console.ReadLine();
                Console.WriteLine("Please,Enter total no of tickets you want to purchase.");
                var num = Console.ReadLine();
                n = Convert.ToInt16(num);
                if(n>4){Console.WriteLine("Sorry! You can purchase only 4 tickets at a time.");}
                else
                {
 
                switch (n)
                {
                    case 1 : unitPrice=15.0m;
                                 cost(n, unitPrice);
                                 break;
                    case 2 : unitPrice = 12.0m;
                                          cost(n, unitPrice);
                                          break;
                    case 3 : unitPrice = 10.0m;
                                cost(n, unitPrice);
                                break;
                    case 4 : unitPrice = 8.0m;
                             cost(n, unitPrice);
                    break;
                    
                    default:    break;
                }

                void cost(int i, decimal uPrice){
                    var unit = Convert.ToDecimal(i);
                    Console.WriteLine($"Total price of tickets for {i} persons is {unit*uPrice}.");
                    Console.WriteLine($"Thank you for purchasing {name}.");
                }
            }
            h=false;

        }
        }
        }
    }
}
