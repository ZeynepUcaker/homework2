
Console.Write("Enter Celcius value:");

double celcius = Convert.ToDouble(Console.ReadLine());

double kelvin = celcius + 273.15;

double fahrenheit = (celcius * 9.0 / 5.0) + 32.0;

Console.WriteLine($"Kelvin: {kelvin:F2}");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");





Console.Write("Enter first exam grade: ");
double exam1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second exam grade: ");
double exam2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter third exam grade: ");
double exam3 = Convert.ToDouble(Console.ReadLine());

double sum = exam1 + exam2 + exam3;
double average = sum / 3;

bool result = average >= 60;

Console.WriteLine("Sum. : " + sum);
Console.WriteLine("Average: " + average.ToString("F2"));
Console.WriteLine("Average is 60 or higher: " + result);





Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int hundreds = number / 100;
int tens = (number / 10) % 10;
int units = number % 10;

Console.WriteLine($"Hundreds digit: {hundreds}");
Console.WriteLine($"Tens digit: {tens}");
Console.WriteLine($"Units digit: {units}");
