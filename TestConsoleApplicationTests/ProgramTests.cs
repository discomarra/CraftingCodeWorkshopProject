using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestConsoleApplicationTests
{
    public class ProgramTests
    {
        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }
    }
}
