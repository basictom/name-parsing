using System;
using name_parser.App;
using Xunit;

namespace name_parser.tests
{
    public class WhenParsingNameInformation
    {
        // [Theory]
        // [InlineData("Zojdfvoinf")]
        // public void OneNameIsEnteredFirstNameIsPopulated(string Name)
        // {
        //     //Arrange
        //     var nameParser = new Parser();
        //     //Act
        //     var result = nameParser.ParseName(Name);
        //     //Assert
        //     Assert.Equal(result.FirstName, Name);
        // }

        [Theory]
        [InlineData("Steve Jones", "Steve", "Jones")]
        [InlineData("Mary Barnes-Jones", "Mary", "Barnes-Jones")]
        public void TwoNamesAreEnteredFirstAndLastNameArePopulated(string fullName, string expectedFirstName, string expectedLastName)
        {
            //Arrange
            var nameParser = new Parser();
            //Act
            var result = nameParser.ParseName(fullName);
            //Assert
            Assert.Equal(result.FirstName, expectedFirstName);
            Assert.Equal(result.LastName, expectedLastName);
        }

            //     Scenario:
            //         Given a User registering with the name 'Steve L. Jones'
            //         When parsing the name
            //         Then the first name field should contain 'Steve'
            //             And the last name field should contain 'Jones'
            //             And the middle initial field should contain 'L'
        [Theory]
        [InlineData("Thomas P. Fitzgerald", "Thomas", "P.", "Fitzgerald")]
        [InlineData("Steve L Jones", "Steve", "L", "Jones")]
        public void FirstNameEnteredLastNameEnteredAndMiddleNameIsEntered(string fullName, string expectedFirstName, string expectedMiddleName, string expectedLastName)
        {
            var nameParser = new Parser();

            var result = nameParser.ParseName(fullName);

            Assert.Equal(result.FirstName, expectedFirstName);
            Assert.Equal(result.MiddleName, expectedMiddleName);
            Assert.Equal(result.LastName, expectedLastName);

        }

            //     Scenario:
            //         Given a User registering with the name 'Bob Marley Jr.'
            //         When parsing the name
            //         Then the first name field should contain 'Bob'
            //             And the last name field should contain 'Marley'
            //             And the suffix field should contain 'Jr.'
        [Theory]
        [InlineData("Steve Jones Jr.", "Steve", "Jones", "Jr.")]
        public void FirstNameEnteredLastNameEnteredAndSuffixEntered(string fullName, string expectedFirstName, string expectedLastName, string expectedSuffix)
        {
            var nameParser = new Parser();
            var result = nameParser.ParseName(fullName);

            Assert.Equal(result.FirstName, expectedFirstName);
            Assert.Equal(result.LastName, expectedLastName);
            Assert.Equal(result.Suffic, expectedSuffix);
        }
    }

    // Name Parser Requirements : 

    // Story:
    // As a User registering for the Stuff app
    // I want to be able to enter all of my name information into one box
    // So that I don't have to waste time hitting the tab button

    //     Scenario:
    //         Given a User registering with the name 'Zendaya'
    //         When parsing the name
    //         Then the first name field should be 'Zendaya'

    //     Scenario:
    //         Given a User registering with the name 'Steve Jones'
    //         When parsing the name
    //         Then the first name field should contain 'Steve'
    //             And the last name field should contain 'Jones'

    //     Scenario:
    //         Given a User registering with the name 'Mary Barns-Jones'
    //         When parsing the name
    //         Then the first name field should contain 'Mary'
    //             And the last name field should contain 'Barns-Jones'

    //     Scenario:
    //         Given a User registering with the name 'Steve L. Jones'
    //         When parsing the name
    //         Then the first name field should contain 'Steve'
    //             And the last name field should contain 'Jones'
    //             And the middle initial field should contain 'L'





    //     Scenario:
    //         Given a User registering with the name 'Mr. Bob Michaels'
    //         When parsing the name
    //         Then the first name field should contain 'Bob'
    //             And the last name field should contain 'Michaels'
    //             And the prefix field should contain 'Mr.'

    //     Scenario:
    //         Given a User registering with the name 'Mrs. Aunt Jemima'
    //         When parsing the name
    //         Then the first name field should contain 'Aunt'
    //             And the last name field should contain 'Jemima'
    //             And the prefix field should contain 'Mrs.'
}
