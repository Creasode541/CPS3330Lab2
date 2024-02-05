// Michael Banko
// CPS 3330 Software Dev w/ Frameworks
// Lab 2
namespace MyPowerLibrary;
public class Class1
{
    public static double CalculateDoublePower(double baseNum, double expo)
    {
        double result = Math.Pow(baseNum, expo);
        return result;
    }
    public static double CalculateTriplePower(double baseNumber, double exponent1, double exponent2)
    {
        double result1 = Math.Pow(baseNumber, exponent1);
        double finalResult = Math.Pow(result1, exponent2);
        return finalResult;
    }
 }


