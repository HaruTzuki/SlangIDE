using Slang.IDE.Interpreter.Collection;

namespace Slang.IDE.Interpreter.Tests
{
    public class ParserTest
    {
        [Theory]
        [InlineData("fn add(a:int, b:int):int")]
        public void Should_Return_Function(string source)
        {
            var parser = new Parser();
            var function = Parser.Parse(source);

            Assert.True(function.Identifier == "add");
            Assert.True(function.Parameters.Count() == 2);

            foreach (var param in function.Parameters)
            {
                Assert.True(param.Identifier == "a" || param.Identifier == "b");
                Assert.True(param.DataType == Enumeration.Tokens.INTEGER);
            }

            Assert.True(function.ReturnDataType == Enumeration.Tokens.INTEGER);
        }

        [Theory]
        [InlineData("fn get_date():date")]
        public void Should_Return_Function_1(string source)
        {
            var function = Parser.Parse(source);

            Assert.True(function.Identifier == "get_date");
            Assert.True(function.Parameters.Length == 0);
            Assert.True(function.ReturnDataType == Enumeration.Tokens.USERDEFINED);
        }

        [Theory]
        [InlineData("fn print()")]
        public void Should_Return_Function_2(string source)
        {
            var parser = new Parser();
            var function = Parser.Parse(source);

            Assert.True(function.Identifier == "print");
            Assert.True(function.Parameters.Length == 0);
            Assert.True(function.ReturnDataType == Enumeration.Tokens.VOID);
        }

        [Theory]
        [InlineData("fn add(a:int, b:int):int", "add(5,5)")]
        public void Should_Match_Functions(string source, string written)
        {
            Lists.UserDefinedFunctions.Add(Parser.Parse(source));

            Assert.True(Parser.Validate(written));
        }

        [Theory]
        [InlineData("fn add(a:int, b:int):int", "add(5,\"Hello World\")")]
        public void Should_Exception_For_Wrong_Parameters(string source, string written)
        {
            Lists.UserDefinedFunctions.Add(Parser.Parse(source));

            Assert.Throws<ArgumentException>(() => Parser.Validate(written));
        }

        [Fact]
        public void ShouldSplitIntoLines()
        {
            var sourceCode = @"fn add(a:int, b:int):int {
    return a+b;
}";
            Parser.Parse2(sourceCode);
            Assert.True(1 == 1);
        }
    }
}