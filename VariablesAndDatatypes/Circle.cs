using System.Net.NetworkInformation;

namespace VariablesAndDatatypes
{
    public class Circle
    {
        // TODO 1: declare a constant named PI, initialised to 3.14.
        //         A constant needs the keyword const and the type double.
        public const double PI = 3.14;

        public double Area(double radius)
        {
            return PI * radius* radius;   
        }

        // Stretch: add a method Area that takes one double radius and
        // returns PI * radius * radius.
        // Stretch: add a method Perimeter that takes one double radius and
        // returns 2 * PI * radius.
    }
}