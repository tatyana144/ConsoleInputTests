
using Program = ConsoleInputSample.Program;

namespace ProgramUnitTests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Test call: " + DateTime.Now.ToString());
        }

        [Test]
        public void Test_ProgramSum_TwoPositiveNumber()
        {
            // Arrange
            string input = "5 10 12";

            var writer = new StringWriter();
            Console.SetOut(writer);  // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            //Act
            Program.Main();

            // Assert
            string actualResul = writer.ToString();
            string expectedResult = 
                "The sum is:" + Environment.NewLine +
                "27" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResul);
        }

        [Test]
        public void Test_ProgramSum_TwoNegativeNumbers()
        {
            // Arrange
            string input = "-10 -12";

            var writer = new StringWriter();
            Console.SetOut(writer);  // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            //Act
            Program.Main();

            // Assert
            string actualResul = writer.ToString();
            string expectedResult =
                "The sum is:" + Environment.NewLine +
                "-22" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResul);
        }

        [Test]
        public void Test_ProgramSum_NegativePositiveNumbers()
        {
            // Arrange
            string input = "-10 12";

            var writer = new StringWriter();
            Console.SetOut(writer);  // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            //Act
            Program.Main();

            // Assert
            string actualResul = writer.ToString();
            string expectedResult =
                "The sum is:" + Environment.NewLine +
                "2" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResul);
        }
    }
}