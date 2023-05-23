using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            if (string.IsNullOrEmpty(FirstName))
                throw new ArgumentException("First name cannot be null or empty", nameof(FirstName));
            if (string.IsNullOrEmpty(LastName))
                throw new ArgumentException("Last name cannot be null or empty", nameof(LastName));
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
