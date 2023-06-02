using Flunt;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string adress)
        {
            Adress = adress;
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsEmail(Adress, "Email", "O e-mail é inválido")
            );
        }

        public string Adress { get; private set; }
    }
}
