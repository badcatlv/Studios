using StudioOne;

Console.WriteLine("Enter a radius: ");
double r;

r = double.Parse(Console.ReadLine());

while (r < 0 )
{
    Console.WriteLine("Enter a radius: ");
    r = double.Parse(Console.ReadLine());
}

Console.WriteLine("You entered " + r);

Circle circle = new Circle();
double circleArea = circle.area(r);
double circleCircum = circle.circum(r);

Console.WriteLine("The area of a circle of radius " + r +": " + circleArea);

Console.WriteLine("The circumference is " +  circleCircum);


/* Ask the user for the miles per gallon of their car.
 * If the radius that they entered is in miles, output how many gallons of gas 
 * they will use to go around this circle.*/
Console.WriteLine("How many miles per gallons does your car get?");
double gallons = double.Parse(Console.ReadLine());
double milesPerCircum = Math.Round((circleCircum / gallons), 3);
Console.WriteLine("It will take you " + milesPerCircum + " gallons to drive around the circle");


 /* BONUS:
 
 * If the user enters a non-numeric character or a empty string? 
 * Print an error message and quit. 
 * You’ll need to peek ahead to learn about conditional syntax in C# .
*/