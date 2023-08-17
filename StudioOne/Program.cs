using StudioOne;

Console.WriteLine(DateTime.Now);

Console.WriteLine("Enter a radius: ");
double r;
string? x = null;

string? input = Console.ReadLine();

//double i = 0.0;
//bool result = Double.TryParse(input, out i);

//or for one line use an underscore instead of a variable to store the TryParse
bool result = Double.TryParse(input, out _);
//Console.WriteLine(i);
if(input == "" || result == false)
{
    Console.WriteLine("sorry, reload");
    Environment.Exit(0);// way to exit program
    //you can use return; statement too to end program.
}
r = Double.Parse(input);



while (r < 0.0)
{
    Console.WriteLine("Enter a radius: ");
    r = Double.Parse(Console.ReadLine());
}

Console.WriteLine("You entered " + r);

Circle circle = new Circle();
double circleArea = circle.area(r);
double circleCircum = circle.circum(r);

Console.WriteLine("The area of a circle of radius " + r +": " + circleArea);

Console.WriteLine("The circumference is " +  circleCircum);

Console.WriteLine("How many miles per gallons does your car get?");
string? answer = Console.ReadLine();
double gallons = double.Parse(answer);
double milesPerCircum = Math.Round((circleCircum / gallons), 3);
Console.WriteLine("It will take you " + milesPerCircum + " gallons to drive around the circle");

Console.ReadLine();