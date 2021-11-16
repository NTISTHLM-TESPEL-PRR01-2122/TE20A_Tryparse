

int points = 100;
string name = "Micke";

string t = "20";

Console.WriteLine(int.MaxValue);

// Console.WriteLine(t + 90);

Console.WriteLine("Skriv in ett tal:");

string tal = Console.ReadLine();
int resultat;

// resultat = int.Parse(tal);

bool success = int.TryParse(tal, out resultat);

if (success == true)
{
  Console.WriteLine(resultat * 2);
}
else
{
  Console.WriteLine("Är du dum i huvudet!?");
}


// if (tal == "0")
// {
//   resultat = 0;
// }
// else if (tal == "1")
// {
//   resultat = 1;
// }


// int talNum = tal;



Console.ReadLine();
