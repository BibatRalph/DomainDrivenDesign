using DomainDrivenDesign.Model.Trader;
using DomainDrivenDesign.Utilities.HelperMethod;
using FluentAssertions;

namespace UnitTestProject.Trader
{
    public class NameTest
    {
        //[Fact]
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ThrowOnInvalid(string? value)
        {

            TraderName Action() => new(value);

            FluentActions.Invoking(() => value.NotNullOrEmpty("value"))
             .Should().ThrowExactly<ArgumentNullException>()
             .Which.ParamName.Should().Be("value");

        }
    }
}