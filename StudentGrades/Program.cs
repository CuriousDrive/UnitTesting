using StudentGrades;

// Get percentage
var gradeCalculator = new GradeCalculator();

Console.Write("Enter the percentage : ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(percentage);

// Print grade
Console.WriteLine($"Student Grade : {grade}");