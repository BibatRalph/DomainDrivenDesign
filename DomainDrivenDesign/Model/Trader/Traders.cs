using DomainDrivenDesign.HelperMethods;
using DomainDrivenDesign.Model.Broker;
using DomainDrivenDesign.Utilities.HelperMethod;
using static DomainDrivenDesign.Events.ITraderEvent;

namespace DomainDrivenDesign.Model.Trader
{
    public sealed class Traders : Entity
    {
        private Traders(Guid id, TraderName name) : base(id)
        {
            TraderName = name;
        }
        public BrokerCode BrokerCode { get; private set; }
        public TraderId TraderId { get; private set; }
        public TraderName TraderName { get; private set; }
        public bool EnableTrade { get; private set; } = false;
        public bool EnableLogin { get; private set; } = false;

        // Factory Pattern to create Traders
        public static Traders Create(TraderName name)
        {
            var user = new Traders(Guid.NewGuid(), name);

            user.RaiseEvent(new TraderCreatedEvent(user.Id));

            return user;
        }

    }

    // Value Obj
    public record TraderName
    {
        public TraderName(string? name)
        {
            //Extension method to for null checks

            Ensure.NotNullOrEmpty(name);

            //Does the same as the extension method above

            //if (string.IsNullOrEmpty(name))
            //{
            //    throw new ArgumentNullException("value");
            //}

            //if (string.IsNullOrEmpty(name))
            //{
            //    throw new ArgumentNullException("value");
            //}

            Name = name;
        }

        public string Name { get; }
    }
    public record TraderId
    {
        private TraderId(string value) => Value = value;

        public string Value { get; init; }

        public const int MinimumLenght = 9;

        public static TraderId? Create(string value)
        {
            if (string.IsNullOrEmpty == null)
            {
                throw new ArgumentNullException("value");
            }

            if (value.Length != MinimumLenght)
            {
                throw new ArgumentNullException("value");
            }

            return new TraderId(value);
        }
    }

}
