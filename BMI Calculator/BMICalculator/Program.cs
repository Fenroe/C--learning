Console.WriteLine("Welcome to the BMI Calculator");
Console.WriteLine("What is your weight in kilograms?");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is your height in meters?");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = Math.Round(weight / (height * height), 1);
Console.WriteLine($"Your BMI is {bmi}");
if (bmi < 18.5)
{
    Console.WriteLine("You are underweight");
}
else if (bmi < 25)
{
    Console.WriteLine("You are at a normal weight");
}
else if (bmi < 30)
{
    Console.WriteLine("You are slightly overweight");
}
else if (bmi < 35)
{
    Console.WriteLine("You are obese");
}
else
{
    Console.WriteLine("You are clinically obese");
}