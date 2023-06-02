using PaymentContext.Domain.ValueObjects;

var name = new Name("", "");
foreach (var noti in name.Notifications)
{
    Console.WriteLine("Erro - " + noti.Message);
}