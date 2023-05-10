// See https://aka.ms/new-console-template for more information
using Notify;

Account account = new Account(100);
account.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
account.Put(20);    // добавляем на счет 20
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(70);   // пытаемся снять со счета 70
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(180);  // пытаемся снять со счета 180
Console.WriteLine($"Сумма на счете: {account.Sum}");

void DisplayMessage(string message) => Console.WriteLine(message);
