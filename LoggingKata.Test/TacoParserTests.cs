using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", -85.499655)]
        [InlineData("59453,-86.694742,Taco Bell Birmingham...", -86.694742)]
        [InlineData("32.801186,-86.576412,Taco Bell Clanto...", -86.576412)]
        [InlineData("33.75154,-84.722356,Taco Bell Douglasville...", -84.722356)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var longTest = new TacoParser();

            //Act
            var actual = longTest.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", 34.795116)]
        [InlineData("30.448367,-86.638431,Taco Bell Fort Walton Beach...", 30.448367)]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("59453,-86.694742,Taco Bell Birmingham...", 59453)]
        [InlineData("32.801186,-86.576412,Taco Bell Clanto...", 32.801186)]
        [InlineData("33.75154,-84.722356,Taco Bell Douglasville...", 33.75154)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line).Location.Latitude;
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
