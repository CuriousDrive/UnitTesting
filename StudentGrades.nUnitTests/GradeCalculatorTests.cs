using NUnit.Framework;

namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;
        
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(91)]
        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreEqual("A", grade);
        }

        [TestCase(1)]
        [TestCase(45)]
        [TestCase(70)]
        [TestCase(89)]
        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreNotEqual("A", grade);
        }
    }
}