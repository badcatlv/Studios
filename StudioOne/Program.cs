﻿Console.WriteLine("Enter a radius: ");
double r;
double area;

r = double.Parse(Console.ReadLine());
Console.WriteLine("You entered " + r);
area = Math.Pow(r, 2.0) * Math.PI;
Console.WriteLine("The area of a circle of radius " + r +": " + area);

/*  Things to consider---
 *  What data type should the radius be? 
 *  What is the best way to get user input into a variable radius of that type?
 *  A = pi * r * r
 *  pi = 3.14
 *  r = radius
 *  
 *  use Math.PI and Math.Pow
 *  
 * Should result in---
 * Enter a radius: 2.5
 * The area of a circle of radius 2.5 is: 19.625
 * 
 * Using the same radius, calculate the circumference (2*pi*r) 
 * and diameter of the circle (2*r).
 * 
 * Ask the user for the miles per gallon of their car.
 * If the radius that they entered is in miles, output how many gallons of gas 
 * they will use to go around this circle.
 * 
 * BONUS:
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