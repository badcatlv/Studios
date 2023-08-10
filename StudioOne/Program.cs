Console.WriteLine("Enter a radius: ");
double r;
double area;
double circum;
//return the area of a circle
r = double.Parse(Console.ReadLine());
Console.WriteLine("You entered " + r);
area = Math.Pow(r, 2.0) * Math.PI;
area = Math.Round(area, 3);
Console.WriteLine("The area of a circle of radius " + r +": " + area);
//return the circumference of the same circle
circum = Math.PI * 2 * r;
circum = Math.Round(circum, 3);
Console.WriteLine("THe circumference is " +  circum);


/* Ask the user for the miles per gallon of their car.
 * If the radius that they entered is in miles, output how many gallons of gas 
 * they will use to go around this circle.*/
Console.WriteLine("How many miles per gallons does your car get?");
double gallons = double.Parse(Console.ReadLine());
double milesPerCircum = gallons / circum;
Console.WriteLine(milesPerCircum);


 /* BONUS:
 * Think about how we could make this program more modular by 
 * breaking out some of the code into a separate class. 
 * For example, we could pull out the circle information into a 
 * Circle class and leave the user questions and console messages in Program. 
 * Take a look at the using statement for a refresher on how to reference 
 * another class file.
 * Extend your program further by using a while or do-while loop , 
 * so that when the user enters a negative number they are re-prompted for a radius.
 * Add additional validation to your program. 
 * If the user enters a non-numeric character or a empty string? 
 * Print an error message and quit. 
 * You’ll need to peek ahead to learn about conditional syntax in C# .
*/