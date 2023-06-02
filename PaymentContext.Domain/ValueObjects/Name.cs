using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flunt;
using Flunt.Validations;
using Flunt.Notifications;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            if (string.IsNullOrEmpty(FirstName))
                AddNotification("Name.FirstName", "Nome inválido");
            if (string.IsNullOrEmpty(LastName))
                AddNotification("Name.LastName", "Sobrenome inválido");
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
