using DomainDrivenDesign.Model.Broker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Model.Client
{
    public sealed class Clients
    {
        public AccountCode AccountCode { get; private set; }

        public ClientCode ClientCode { get; private set; }
    }

    public record AccountCode
    {
        private AccountCode(string value) => Value = value;

        public string Value { get; init; }

        public const int MinimumLenght = 14;

        public static AccountCode? Create(string value)
        {
            if (string.IsNullOrEmpty == null)
            {
                throw new ArgumentNullException("value");
            }

            if (value.Length != MinimumLenght)
            {
                throw new ArgumentNullException("value");
            }

            return new AccountCode(value);
        }
    }

    public record ClientCode
    {
        private ClientCode(string value) => Value = value;

        public string Value { get; init; }
        public static ClientCode? Create(string value)
        {
            if (string.IsNullOrEmpty == null)
            {
                throw new ArgumentNullException("value");
            }

            return new ClientCode(value);
        }
    }
}
