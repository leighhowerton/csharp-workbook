using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter hand 1:");
            CompareHands();

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static void CompareHands()
        {

            
            int userChoice = 0;
            string userAnswer = Console.ReadLine().ToLower();
            if(userAnswer == "rock"){
                userChoice = 0;
            }else if(userAnswer == "paper"){
                userChoice = 1;
            }else if(userAnswer == "scissors"){
                userChoice = 2;
            }else{
                Console.WriteLine("Invalid selection.");
                CompareHands();
            }

            Random r = new Random();
            int computerChoice = r.Next(0, 2);
                        
            //Case 1: user chooses rock
            if(computerChoice == 0 && userChoice == 1){
                gameResults("paper", "lose");
            }else if(computerChoice == 0 && userChoice == 2){
                gameResults("scissors", "won");
            }else if(computerChoice == 0 && userChoice == 0){
                gameResults("rock", "draw");
            }//Case 2: user chooses paper
            else if(computerChoice == 1 && userChoice == 2){
                gameResults("scissors", "lose");
            }else if(computerChoice == 1 && userChoice == 0){
                gameResults("rock", "won");
            }else if(computerChoice == 1 && userChoice == 1){
                gameResults("paper", "draw");
            }//Case 3: user chooses scissors
            else if(computerChoice == 2 && userChoice == 0){
                gameResults("rock", "won");
            }else if(computerChoice == 2 && userChoice == 1){
                gameResults("paper", "lose");
            }else if(computerChoice == 2 && userChoice == 2){
                gameResults("scissors", "draw");
            }
            
              
        }public static void gameResults(string computerChoice, string outcome){
            Console.WriteLine("The computer chose " + computerChoice);
            Console.WriteLine(outcome);
        }
    }
}
