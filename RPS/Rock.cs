using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Rock
    {
        string onename;
        string twoname;
        int computerChoice;
        public string Body()
        {
            int onescore = 0;
            int twoscore = 0;
           
           

            Console.WriteLine("How many players? one or two?");
            string playernumber = Console.ReadLine();
            if (playernumber == "one")
            {
                Console.WriteLine("Player Name");
                onename = Console.ReadLine();
                twoname = ("the computer");
               
            }
            else if (playernumber == "two")
            {
                Console.WriteLine("Player One Name");
                onename = Console.ReadLine();
                Console.WriteLine("Player Two Name");
                twoname = Console.ReadLine();
               
            }
            else
            {
                Console.WriteLine("Error");
                return "you dunce";

            }
            
            bool keepPlaying = true;
            while (keepPlaying)
            {
               
                Console.WriteLine("Do you choose rock, paper, spock, lizzard or scissors");
                string userChoice = Console.ReadLine();
                

                
                if (twoname == "the computer")
                 {
                    int comp;
                    Random r = new Random();
                    comp = r.Next(5);
                    computerChoice = comp;
                    
                    }
                else
                 {
                   string human = Console.ReadLine();

                    if (human == "rock")
                    {
                        computerChoice = 0;
                        
                    }
                    else if (human == "paper")
                    {
                        computerChoice = 1;
                        
                    }
                    else if (human == "scissors")
                    {
                        computerChoice = 2;
                        
                    }
                    else if (human == "lizzard")
                    {
                        computerChoice = 3;
                        
                    }
                    else if (human == "spock")
                    {
                        computerChoice = 4;
                        
                    }
                    else
                            {
                        Console.WriteLine("you chose poorly");
                    }
                     }
                    
                    
            
                
                if (computerChoice == 0) 
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine( twoname + " chose Rock");
                        Console.WriteLine("It is a tie ");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ "chose Rock");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ "chose Rock");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;
                    }

                    else if (userChoice == "lizzard")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ "chose Rock");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;
                    }

                    else if (userChoice == "spock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ "chose Rock");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;
                    }

                    else
                    {
                        Console.WriteLine("You must choose rock+paper or scissors!");

                    }
                    
                    }
                
                else if (computerChoice == 1) 
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine(onename + " chose "+ userChoice);
                        Console.WriteLine(twoname + " chose Paper");
                        Console.WriteLine(twoname + " Wins");
                        twoscore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Paper");
                        Console.WriteLine("It's a tie");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Paper");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;
                    }

                    else if (userChoice == "lizzard")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Paper");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;
                    }

                    else if (userChoice == "spock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Paper");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;
                    }

                    else
                    {

                        Console.WriteLine("You must choose rock+paper or scissors!");

                    }
                   
                }

                else if (computerChoice == 2) 
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Scissors");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Scissors");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Scissors");
                        Console.WriteLine("It's a tie");
                    }

                    else if (userChoice == "lizzard")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Scissors");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;
                    }

                    else if (userChoice == "spock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Scissors");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;
                    }

                    else
                    {
                        Console.WriteLine("You must choose rock+paper or scissors!");

                    }

                    ;
                }

                if (computerChoice == 3) 
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Lizzard");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Lizzard");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Lizzard");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;
                    }

                    else if (userChoice == "lizzard")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Lizzard");
                        Console.WriteLine("It's a tie");
                    }

                    else if (userChoice == "spock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Lizzard");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;
                    }

                    else
                    {
                        Console.WriteLine("You must choose rock+ paper+ spock+ lizzard or scissors!");

                    }
                }
                if (computerChoice == 4) 
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Spock");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Spock");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Spock");
                        Console.WriteLine(twoname+ " Wins");
                        twoscore++;
                    }

                    else if (userChoice == "lizzard")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Spock");
                        Console.WriteLine(onename+ " Wins");
                        onescore++;
                    }

                    else if (userChoice == "spock")
                    {
                        Console.WriteLine(onename+ " chose "+ userChoice);
                        Console.WriteLine(twoname+ " chose Spock");
                        Console.WriteLine("It's a tie");
                    }

                    else
                    {
                        Console.WriteLine("You must choose rock+paper or scissors!");

                    }
                    
                }

                
                keepPlaying = ((onescore < 3) && (twoscore < 3));

            }
            return "hi";
        }


    }
    }
