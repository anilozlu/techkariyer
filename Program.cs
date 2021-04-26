using System;

class Player{
    private string choice;
    private Random random;
    private string [] choices = new string [] {"rock", "paper", "scissors"};
    
    public Player(string choice){
        this.choice = choice;
        if(choice == "random"){
            this.random = new Random();
        }
    }
    
    public string play(){
        return choice == "random" ? choices[random.Next(3)] : choice;
    }
}

class Game{
    Player a, b;
    int wina = 0, winb = 0, tie = 0;
    
    public Game(string choicea, string choiceb){
        this.a = new Player(choicea);
        this.b = new Player(choiceb);
    }
    
    public void play(int rounds){
        string playa, playb;
        for(int i = 0; i < rounds; i++){
            playa = a.play();
            playb = b.play();
            
            if(playa == "rock"){            
                if(playb == "scissors")     wina++;
                else if(playb == "paper")   winb++;
                else if(playb == "rock")    tie++;
            }
            else if(playa == "paper"){            
                if(playb == "rock")         wina++;
                else if(playb == "scissors")winb++;
                else if(playb == "paper")   tie++;
            }
            else if(playa == "scissors"){            
                if(playb == "paper")        wina++;
                else if(playb == "rock")    winb++;
                else if(playb == "scissors")tie++;
            }
        }
        Console.WriteLine($"Player A wins {wina} of {rounds} games");
        Console.WriteLine($"Player B wins {winb} of {rounds} games");
        Console.WriteLine($"Tie: {tie} of {rounds} games");
    }
}
 
namespace techkariyer
{
    class rps {         
        static void Main()
        {
            Game game = new Game("paper", "random");
            game.play(100);
        }
    }
}