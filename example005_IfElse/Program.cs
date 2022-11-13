Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")// ToLower перевод в нижний регистр
{
    Console.WriteLine("Ура это же Маша");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
