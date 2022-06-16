using System;
Console.WriteLine("Welcome to the calculate circle area app");

Console.WriteLine("Enter a radius");
var value = Console.ReadLine();

if (string.IsNullOrEmpty(value))
{
    Console.WriteLine("Hata");
    return;
}
if(int.TryParse(value,out int x)){

}
else
{
    Console.WriteLine("Hata");
    return;
}


int radius = Convert.ToInt32(value);
double area_of_circle = (Math.PI * radius * radius);

double circum_of_circle = (2 * Math.PI * radius);

Console.WriteLine("The area of circle = " + area_of_circle);
Console.WriteLine("The circum of circle = " + circum_of_circle);