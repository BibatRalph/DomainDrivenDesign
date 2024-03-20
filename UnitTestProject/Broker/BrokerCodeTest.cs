using DomainDrivenDesign.Model.Broker;
using DomainDrivenDesign.Model.Trader;
using DomainDrivenDesign.Utilities.HelperMethod;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Broker
{
    public class BrokerCodeTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ThrowOnInvalidBroker(string? value)
        {
            TraderName Action() => new(value);

            FluentActions.Invoking(() => value.NotNullOrEmpty("value"))
             .Should().ThrowExactly<ArgumentNullException>()
             .Which.ParamName.Should().Be("value");
        }

        [Theory]
        [InlineData("2131")]
        [InlineData("001")]
        [InlineData("01")]
        [InlineData("1")]
        public void CheckValueLength(string value)
        {
            string normalizeStringValue = value.Replace("\"", "");

            Action action = () => BrokerCode.Create(value);

            if (normalizeStringValue.Length != BrokerCode.MinimumLenght)
            {
                action.Should().Throw<ArgumentNullException>();
            }
            else
            {
                action.Should().NotThrow();
            }
        }
    }
}
