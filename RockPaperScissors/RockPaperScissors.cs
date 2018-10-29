using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter rock, paper or scissors:");
            CompareHands();

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static void CompareHands()
        {

            
            int userChoice = 0;
            //userAnswer to convert answer to an interger
            string userAnswer = Console.ReadLine().ToLower();
            if(userAnswer == "rock"){
                userChoice = 0;
            }else if(userAnswer == "paper"){
                userChoice = 1;
            }else if(userAnswer == "scissors"){
                userChoice = 2;
            }else{
                Console.WriteLine("Invalid selection. Please choose rock, paper or scissors.");
                CompareHands();
            }

            Random r = new Random();
            int computerChoice = r.Next(0, 2);
                        
            //Case 1: computer chooses rock
            if(computerChoice == 0 && userChoice == 1){
                gameResults("rock", "You won!");
            }else if(computerChoice == 0 && userChoice == 2){
                gameResults("rock", "You lost!");
            }else if(computerChoice == 0 && userChoice == 0){
                gameResults("rock", "It's a draw!");
            }//Case 2: computer chooses paper
            else if(computerChoice == 1 && userChoice == 2){
                gameResults("paper", "You won!");
            }else if(computerChoice == 1 && userChoice == 0){
                gameResults("paper", "You lost!");
            }else if(computerChoice == 1 && userChoice == 1){
                gameResults("paper", "It's a draw!");
            }//Case 3: compuet chooses scissors
            else if(computerChoice == 2 && userChoice == 0){
                gameResults("scissors", "You won!");
            }else if(computerChoice == 2 && userChoice == 1){
                gameResults("scissors", "You lost!");
            }else if(computerChoice == 2 && userChoice == 2){
                gameResults("scissors", "It's a draw!");
            }
            
              
        }
        //Method created to simplify if statements in CompareHands method & give the outcome
        public static void gameResults(string computerChoice, string outcome){
            Console.WriteLine("The computer chose " + computerChoice);
            Console.WriteLine(outcome);
        }
    }
}
