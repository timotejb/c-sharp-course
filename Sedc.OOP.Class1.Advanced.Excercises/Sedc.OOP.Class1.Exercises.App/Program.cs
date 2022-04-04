#region excercise 1
List<string> Names = new List<string>()
{
    "Timotej",
    "Matej",
    "jETTOTO",
    "test ime"
};
//Console.WriteLine("Napishi neshto");
//string str = Console.ReadLine();
string str = string.Empty;
str = str.ToLower();
List<string> list = new List<string>(); 
foreach (string name in Names)
{
    string[] string1 = str.Split(name.ToLower());
    for (int i = 0; i < string1.Length - 1; i++) {
        list.Add(string1[i]);
    }
}
Console.WriteLine(list.Count);
#endregion

#region exercise 3
int Game = 0;
int UserScore = 0;
int ComputerScore = 0;


Console.WriteLine("==== Main Menu ====");
Console.WriteLine("Play, Stats, Exit");
string input = Console.ReadLine();


while (input == "Play")
{
    Random random = new Random();

    int number = random.Next(1, 3);
    string computerInput = string.Empty;
    switch (number)
    {
        case 1:
            computerInput = "Rock";
            break;
        case 2:
            computerInput = "Paper";
            break;
        case 3:
            computerInput = "Scissors";
            break;
        default:
            break;
    }

    Console.WriteLine("Rock Papers Scissors: ");
    input = Console.ReadLine();

        switch (input)
        {
            case "Rock":
                if (computerInput == "Paper")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("Computer is winner");
                Game++;
                ComputerScore++;
                    
                }
                else if (computerInput == "Scissors")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("Player won");
                Game++;
                UserScore++;
                }
                else if (computerInput == "Rock")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("It was a tie");
                Game++;
            }
            break;

            case "Paper":
                if (computerInput == "Paper")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("It was a tie");
                Game++;

            }
            else if (computerInput == "Scissors")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("Computer won");
                Game++;
                ComputerScore++;

            }
            else if (computerInput == "Rock")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("Player won");
                Game++;
                UserScore++;

            }
            break;
            case "Scissors":
                if (computerInput == "Paper")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("Player won");
                Game++;
                UserScore++;

            }
            else if (computerInput == "Scissors")
                {
                    Console.WriteLine("It was a tie");
                Game++;

            }
            else if (computerInput == "Rock")
                {
                    Console.WriteLine($"Player picked {input}, pc picked {computerInput}");
                    Console.WriteLine("Computer won");
                Game++;
                ComputerScore++;

            }
            break;
                Console.WriteLine("Play again?");
                input = Console.ReadLine();
    }
    Console.WriteLine("Play again?");
input = Console.ReadLine();
}
if (input == "Stats")
{
    Console.WriteLine($"Games played {Game}");
    Console.WriteLine($"User scored: {UserScore}");
    Console.WriteLine($"PC scored: {ComputerScore}");


}
#endregion