using System;
using Xunit;
using People;

namespace Tests
{
    public class PersonTests
    {
        [Fact]
        public void Test1() 
        {
            var person = new Person("Nikola","Stjelja");
            Assert.Equal("Nikola Stjelja", person.ToString());
        }
    }
}
