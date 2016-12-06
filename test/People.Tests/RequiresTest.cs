using System;
using Xunit;

namespace People.Test {

    public class RequiresTest {
        
        [Fact]
        public void Requires_Throws_ArgumentNullException_On_NullArgument(){
           Assert.Throws<ArgumentNullException>(()=> Requires.NotNull(null));
        }

        [Fact]
        public void Requires_DoesNotThrow_Exception_OnNullArgument(){
            Requires.NotNull("Nothing should happen");
        }
    }

}