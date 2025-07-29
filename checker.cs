using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
class Checker
{
    static bool IsparameterInRange(float parameter, float min,float max)
    {
        return parameter>=min && maxcheck(parameter,max);
    }
    static bool maxcheck(float parameter, float max)
    {
        return parameter<=max;
    }
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
        boolean tempok=IsparameterInRange(temperature,0,40);
        boolean socok=IsparameterInRange(temperature,20,80);
        boolean CRok=maxcheck(chargeRate,0.8);
            Console.WriteLine("Temperature is out of range!");            
            Console.WriteLine("State of Charge is out of range!");    
            Console.WriteLine("Charge Rate is out of range!");
    }

    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(batteryIsOk(25, 70, 0.7f));
        ExpectFalse(batteryIsOk(50, 85, 0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
    
}
}
