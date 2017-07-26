using System;
using name_parser.App;
using Xunit;

namespace name_parser.tests
{
    public class WhenParsingNameInformation
    {
        [Fact]
        public void OneNameIsEnteredFirstNameIsPopulated()
        {
            //Arrange
            var name = "Zendaya";
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(name);
            //Assert
            Assert.Equal(result.FirstName, "Zendaya");
        }

        [Fact]
        public void TwoNamesAreEnteredFirstAndLastNameArePopulated()
        {
            //Arrange
            var name = "Steve Jones";
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(name);
            //Assert
            Assert.Equal(result.FirstName, "Steve");
            Assert.Equal(result.LastName, "Jones");
        }
    }
}
