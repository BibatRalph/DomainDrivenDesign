using DomainDrivenDesign.Model.Broker;
using DomainDrivenDesign.Model.Trader;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Broker
{
    public class BrokersListOfTrader
    {
        [Theory]
        [InlineData("12101456")] // Trader Id
        [InlineData("94101456")]
        [InlineData("12139471")]
        public void CheckIfTraderFirstThreeCharacterIsEqualToBroker(string value)
        {
            string normalizeStringValue = value.Replace("\"", "");

            string traderFirstThreeChars = normalizeStringValue.Substring(0, 3);
            Assert.Equal(traderFirstThreeChars, "121");
        }
    }
}
