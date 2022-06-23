Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine ("Hey Masha!");
}
else
{
    Console.WriteLine ("Hey ");
    Console.WriteLine (username);
}