//Switch expression with Tuples

Console.WriteLine(RockPaperScissors("paper", "rock"));
Console.WriteLine(RockPaperScissors("scissors", "rock"));

static string RockPaperScissors(string first, string second)
{
  return (first, second) switch 
  {
    ("rock", "paper") => "Paper wins.", 
    ("rock", "scissors") => "Rock wins.", 
    ("paper", "rock") => "Paper wins.", 
    ("paper", "scissors") => "Scissors wins.", 
    ("scissors", "rock") => "Rock wins.", 
    ("scissors", "paper") => "Scissors wins.", 
    (_, _) => "Tie.",
  };
}