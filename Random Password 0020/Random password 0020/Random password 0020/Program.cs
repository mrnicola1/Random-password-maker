using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Threading;

namespace Random_password_0020
{
    internal class Program
    {
        static int numbersofar;
        static string complex;
        static int lonng=10;
        static string Hard;
        static void Main(string[] args)
        {
            start:
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("long?");
                int.TryParse(Console.ReadLine(), out lonng);


                if (lonng < 0)
                {
                    Console.Clear();
                }

                if (lonng > 0)
                {
                    break;
                }


            }
            

            while (true)
            {
                Console.WriteLine("How hard? Easy? Medium? Hard");

                Hard= Console.ReadLine();

                if (Hard == "Easy")
                {
                    break;
                }

                if (Hard == "Medium")
                {
                    break;
                }

                if (Hard == "Hard")
                {
                    break;
                }
                Console.Clear();
            }

        randomstart:
            while (lonng >= numbersofar)
            {
                Console.Write("vddgdgdgddggd");
                
                Console.Clear();
                Random rnd = new Random();
                int number = rnd.Next(1, 30);

                if (number == 1)
                {

                    File.AppendAllText("Password.txt", "1");
                    numbersofar++;
                }

                if (number == 2)
                {

                    File.AppendAllText("Password.txt", "2");
                    numbersofar++;
                }

                if (number == 3)
                {

                    File.AppendAllText("Password.txt", "3");
                    numbersofar++;

                }

                if (number == 4)
                {

                    File.AppendAllText("Password.txt", "4");
                    numbersofar++;

                }

                if (number == 5)
                {


                    File.AppendAllText("Password.txt", "5");
                    numbersofar++;

                }

                if (number == 6)
                {

                    File.AppendAllText("Password.txt", "6");
                    numbersofar++;



                }

                if (number == 7)
                {

                    File.AppendAllText("Password.txt", "7");
                    numbersofar++;

                }

                if (number == 8)
                {

                    File.AppendAllText("Password.txt", "8");
                    numbersofar++;

                }

                if (number == 9)
                {

                    File.AppendAllText("Password.txt", "9");
                    numbersofar++;


                }

                if (number == 10)
                {

                    File.AppendAllText("Password.txt", "10");
                    numbersofar++;

                }







                if (number == 11)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "1");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "H");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "h");
                        numbersofar++;
                    }

                }

                if (number == 12)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "2");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "P");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "p");
                        numbersofar++;
                    }


                }

                if (number == 13)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "3");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "T");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "t");
                        numbersofar++;
                    }


                }




                if (number == 14)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "4");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1,3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "X");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "x");
                        numbersofar++;
                    }


                }

                if (number == 15)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "5");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "K");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "k");
                        numbersofar++;
                    }


                }

                if (number == 16)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "6");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "Y");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "y");
                        numbersofar++;
                    }


                }

                if (number == 17)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "7");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "Q");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "q");
                        numbersofar++;
                    }


                }

                if (number == 18)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "8");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "F");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "f");
                        numbersofar++;
                    }


                }

                if (number == 19)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "9");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "M");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "m");
                        numbersofar++;
                    }


                }

                if (number == 20)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "10");
                        numbersofar++;
                        goto randomstart;
                    }
                    Random rnd2 = new Random();
                    int number3 = rnd.Next(1, 3);
                    if (number3 == 1)
                    {
                        File.AppendAllText("Password.txt", "V");
                        numbersofar++;
                    }
                    else
                    {
                        File.AppendAllText("Password.txt", "v");
                        numbersofar++;
                    }


                }











                if (number == 21)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "1");
                        numbersofar++;
                        goto randomstart;
                    }

                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "A");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "a");
                            numbersofar++;
                            goto randomstart;
                        }


                    }
                    File.AppendAllText("Password.txt", "!");
                    numbersofar++;

                }

                if (number == 22)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "2");
                        numbersofar++;
                        goto randomstart;
                    }

                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "G");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "g");
                            numbersofar++;
                            goto randomstart;
                        }

                    }
                    File.AppendAllText("Password.txt", "#");
                    numbersofar++;

                }

                if (number == 23)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "3");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "E");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "e");
                            numbersofar++;
                            goto randomstart;
                        }

                    }

                
                  File.AppendAllText("Password.txt", "£");
                  numbersofar++;
                } 
 

                

                if (number == 24)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "4");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "O");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "o");
                            numbersofar++;
                            goto randomstart;


                        }
                    }
                        File.AppendAllText("Password.txt", "&");
                        numbersofar++;
                    
                }

                if (number == 25)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "5");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "Q");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "q");
                            numbersofar++;
                            goto randomstart;
                        }
                        
                    }
                    File.AppendAllText("Password.txt", ")");
                    numbersofar++;

                }

                if (number == 26)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "6");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "B");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "b");
                            numbersofar++;
                            goto randomstart;
                        }
                        
                    }
                    File.AppendAllText("Password.txt", "=");
                    numbersofar++;

                }

                if (number == 27)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "7");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "Z");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "z");
                            numbersofar++;
                            goto randomstart;
                        }
                       
                    }
                    File.AppendAllText("Password.txt", "@");
                    numbersofar++;

                }

                if (number == 28)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "8");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "C");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "c");
                            numbersofar++;
                            goto randomstart;
                        }
                       
                    }
                    File.AppendAllText("Password.txt", "$");
                    numbersofar++;

                }

                if (number ==29)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "9");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "D");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "d");
                            numbersofar++;
                            goto randomstart;
                        }
                        
                    }
                    File.AppendAllText("Password.txt", "{");
                    numbersofar++;

                }

                if (number == 30)
                {
                    if (Hard == "Easy")
                    {
                        File.AppendAllText("Password.txt", "10");
                        numbersofar++;
                        goto randomstart;
                    }
                    if (Hard == "Medium")
                    {
                        Random rnd2 = new Random();
                        int number3 = rnd.Next(1, 3);
                        if (number3 == 1)
                        {
                            File.AppendAllText("Password.txt", "N");
                            numbersofar++;
                            goto randomstart;
                        }
                        else
                        {
                            File.AppendAllText("Password.txt", "n");
                            numbersofar++;
                            goto randomstart;
                        }
                        
                    }
                    File.AppendAllText("Password.txt", "?");
                    numbersofar++;

                }











            }

            string password2 = File.ReadAllText("Password.txt");
            Console.WriteLine(password2);
            File.WriteAllText  ("Password.txt","");
            
            while (true)
            {
                Console.WriteLine("Again?");
                string again = Console.ReadLine();
                if (again == "1")
                {
                    numbersofar = 0;
                    goto start;
                }
            }
          


            
            


            
            
            




        }
        
    }  
}
