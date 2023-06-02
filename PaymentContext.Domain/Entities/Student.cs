using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System.Diagnostics.Contracts;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = (document);
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            // Se já tiver uma assinatura ativa, cancela
            // Cancela todas as outras assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }

            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsFalse(
                        hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa"
                    )
            );
        }
    }
}