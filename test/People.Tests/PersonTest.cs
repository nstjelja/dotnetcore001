using System;
using Xunit;
using People;

namespace Tests
{
    public class PersonTests
    {
        [Fact]
        public void Person_WithValidArguments_IsCreated() 
        {
            var person = new Person("Nikola","Stjelja", new DateTime(1981,1,12));
            Assert.Equal("Nikola Stjelja", person.ToString());
        }

        [Fact]
        public void Person_IsKilled(){
            var person = new Person("Nikola","Stjelja", new DateTime(1981,1,12));
            person.Kill();

            Assert.NotNull(person.DateOfDeath);
            Assert.Equal(DateTime.Today, person.DateOfDeath.Value.Date);
        }

        [Fact]
        public void Person_CantBe_KilledTwice(){
            var person = new Person("Nikola","Stjelja", new DateTime(1981,1,12));
            person.Kill();
            Assert.Throws<ArgumentException>(()=> person.Kill());
        }
    }
}
