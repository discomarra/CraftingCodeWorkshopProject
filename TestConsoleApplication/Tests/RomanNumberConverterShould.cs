using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestConsoleApplication.Tests
{
    public class ArrabicToRomanConverterShould
    {
        private ArrabicToRomanConverter arrabicToRomanConverter;

        public ArrabicToRomanConverterShould()
        {
            arrabicToRomanConverter = new ArrabicToRomanConverter();
        }

        [Fact]
        public void Convert_1_to_I()
        {
            string romanNumber = arrabicToRomanConverter.Convert(1);

            Assert.Equal("I", romanNumber);
        }

        [Fact]
        public void Convert_5_to_V()
        {
            string romanNumber = arrabicToRomanConverter.Convert(5);

            Assert.Equal("V", romanNumber);
        }

        [Fact]
        public void Convert_2_to_II()
        {
            string romanNumber = arrabicToRomanConverter.Convert(2);

            Assert.Equal("II", romanNumber);
        }

        [Fact]
        public void Convert_6_to_VI()
        {
            string romanNumber = arrabicToRomanConverter.Convert(6);

            Assert.Equal("VI", romanNumber);
        }

        [Fact]
        public void Convert_4_to_IV()
        {
            string romanNumber = arrabicToRomanConverter.Convert(4);

            Assert.Equal("IV", romanNumber);
        }

        [Theory,
            InlineData(13, "XIII"),
            InlineData(14, "XIV"),
            InlineData(16, "XVI")]
        public void Convert_Teens_to_Roman(int arrabic, string expectedRoman)
        {
            string romanNumber = arrabicToRomanConverter.Convert(arrabic);

            Assert.Equal(expectedRoman, romanNumber);
        }
    }
}
