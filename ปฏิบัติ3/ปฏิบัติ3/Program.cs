using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ปฏิบัติ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int turn = 1;


            do
            {
                for (int i= 1; turn >= i ; i++)
                {

                    if (turn % 2 != 0 )
                    { 
                        Console.WriteLine("Player A, make a move ");
                        i++;
                    }                    
                    
                    else
                    {
                        
                    }
                                            
                        do
                        {
                        Console.WriteLine("Pick pile 1, 2 or 3");

                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {

                            Console.WriteLine("how many sticks would you like to remove from 1?");
                            int.TryParse(Console.ReadLine(), out int input);
                            num1 = num1 - input;
                            Console.WriteLine("Pile A contains {0}, Pile B contains {1}, Pile C contains {2}", num1, num2, num3);
                            turn++;
                        }
                        if (choice == "2")
                        {

                            Console.WriteLine("how many sticks would you like to remove from 2?");
                            int.TryParse(Console.ReadLine(), out int input);
                            num2 = num2 - input;
                            Console.WriteLine("Pile A contains {0}, Pile B contains {1}, Pile C contains {2}", num1, num2, num3);
                            turn++;
                        }
                        if (choice == "3")
                        {

                            Console.WriteLine("how many sticks would you like to remove from 3?");
                            int.TryParse(Console.ReadLine(), out int input);
                            num3 = num3 - input;
                            Console.WriteLine("Pile A contains {0}, Pile B contains {1}, Pile C contains {2}", num1, num2, num3);
                            turn++;
                        }


                        else if (num1 == 0 && num2 == 0 && num3 == 0)
                        {
                            if (turn % 2 == 0)
                            {
                                Console.WriteLine("The winner is B");
                            }
                            else
                            {
                                Console.WriteLine("The winner is A");
                            }
                        } while (turn < i && num1 == 0 && num2 == 0 && num3 == 0) ;


                        do
                        {
                            if (turn % 2 == 0)
                            {
                                Console.WriteLine("Player B, make a move ");
                                i++;                                
                            }
                            else
                            {
                                Console.WriteLine("Player A, make a move ");
                                i++;
                            }
                            i++; ;
                            break;

                        } while (turn < i && num1 == 0 && num2 == 0 && num3 == 0);
                    } while (num1 >= 0 && num2 >= 0 && num3 >= 0 );
                }                                             
            } while (num1 != 0 && num2 != 0 && num3 != 0);
            
            Console.ReadLine();

        }
    }
}






