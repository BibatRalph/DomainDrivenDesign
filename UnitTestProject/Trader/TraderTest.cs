using DomainDrivenDesign.Model.Trader;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Trader
{
    public class TraderTest
    {
        [Fact]
        public void CreateTraderTesting()
        {
            var name = new TraderName("Ralph Securities");

            var user = Traders.Create(name);

            user.Should().NotBeNull();
        }

    }
}
