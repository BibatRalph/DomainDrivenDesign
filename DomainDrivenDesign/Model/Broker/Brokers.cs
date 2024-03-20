using DomainDrivenDesign.Model.Trader;
using DomainDrivenDesign.Utilities.HelperMethod;

namespace DomainDrivenDesign.Model.Broker
{
    public sealed class Brokers
    {
        public BrokerCode BrokerCode { get; private set; }

        public string BrokerName { get; private set; } = string.Empty;

        public List<Traders> BrokerTraderList { get; private set; } 

    }

    public record BrokerCode
    {
        public BrokerCode(string value) => Value = value;

        public string Value { get; init; }

        public const int MinimumLenght = 3;

        public static BrokerCode? Create (string value)
        {
            Ensure.NotNullOrEmpty(value);

            if (value.Length != MinimumLenght)
            {
                throw new ArgumentNullException("value");
            }

            return new BrokerCode(value);
        }
    }
}
