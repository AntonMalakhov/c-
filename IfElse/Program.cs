Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("Привет, Машенька, родненькая");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}