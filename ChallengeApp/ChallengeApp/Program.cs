string name = "Kasia";
string gender = "kobieta";
int age = 29;

if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}  
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}