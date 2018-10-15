using System;
using System.Threading;

namespace week1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(3000);

            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [Y/N}");
            String ch1 = Console.ReadLine();
            bool stick = true;

            // I wanted to account for all options as user input is often unpredictable
            if(ch1 == "y" || ch1 == "Y" || ch1 == "Yes" || ch1 == "yes" || ch1 =="YES"){
                Console.WriteLine("You pick up the stick!");
                Thread.Sleep(2000);
                stick = true;
                
            }else{
                Console.WriteLine("You didn't pick up the stick...");
                Thread.Sleep(2000);
                stick = false;
            }

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object...");
            Console.WriteLine("Do you approach the object? [Y/N]");
            String ch2 = Console.ReadLine();

             if(ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "yes" || ch2 =="YES"){
                 Console.WriteLine("You approach the object...");
                 Thread.Sleep(2000);
                 Console.WriteLine("As you draw closer, you begin to make out the object as an eye.");
                 // I decided to increase the wait time to build suspense.
                 Thread.Sleep(4000);
                 Console.WriteLine("The eye belongs to a giant spider!!");

                 Console.WriteLine("Do you try to fight it? [Y/N]");
                 String ch3 = Console.ReadLine();

                 if(ch3 == "y" || ch3 == "Y" || ch3 == "Yes" || ch3 == "yes" || ch3 =="YES"){
                     if (stick == true){
                         Console.WriteLine("You only have a stick to fight with!");
                         Console.WriteLine("You quickly jab the spider in its eye and gain an advantage!");
                         Thread.Sleep(2000);
                         Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                         Console.WriteLine("                  Fighting...                   ");
                         Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                         Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                         Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                         Thread.Sleep(2000);
                         
                         Random fdmg1 = new Random();
                         Random edmg1 = new Random();
                         Console.WriteLine("You hit a {0}", fdmg1.Next(1, 10));
                         Console.WriteLine("The spider hits a {0}", edmg1.Next(1, 10));
                         Thread.Sleep(2000);
                         int fdmgint = fdmg1.Next();
                         int edmgint = edmg1.Next();
                         if(fdmgint > edmgint){
                             Console.WriteLine("You killed the spider, now get out of there!");
                         }else if(edmgint > fdmgint){
                             Console.WriteLine("The spider was much stronger. RIP.");
                         }

                         }
                    // I wanted to add a couple of no options so that the user would have an ending regardless.
                     }else if(ch3 == "n" || ch3 == "N" || ch3 == "No" || ch3 == "no" || ch3 =="No"){
                         Console.WriteLine("You froze in fear and were eaten slowly by the spider. RIP.");
                     }
                 
                 }else if(ch2 == "n" || ch2 == "N" || ch2 == "No" || ch2 == "no" || ch2 =="No"){
                     Console.WriteLine("You ran out of the cave and lived. Wise choice.");
                 }
             

            



        }
    }
}
