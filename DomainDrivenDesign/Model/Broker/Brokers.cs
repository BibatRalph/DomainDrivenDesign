using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Model.Broker
{
    public sealed class Brokers
    {
        public BrokerCode BrokerCode { get; private set; }

        public string BrokerName { get; private set; } = string.Empty;

    }

    public record BrokerCode
    {
        private BrokerCode(string value) => Value = value;

        public string Value { get; init; }

        public const int MinimumLenght = 3;

        public static BrokerCode? Create (string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value, nameof(value));
            ArgumentException.ThrowIfNullOrWhiteSpace (value, nameof(value));

            if (value.Length != MinimumLenght)
            {
                throw new ArgumentNullException("value");
            }

            return new BrokerCode(value);
        }
    }
}
