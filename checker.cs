using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
class Checker
{
    static bool IsparameterInRange(float parameter, float min, float max, string parameterName)
    {
        bool result = parameter >= min && parameter <= max;
        if (!result)
        {
            Console.WriteLine($"{parameterName} is out of range");
        }
        return result;
    }

    static bool maxcheck(float parameter, float max, string parameterName)
    {
        bool result = parameter <= max;
        if (!result)
        {
            Console.WriteLine($"{parameterName} is out of range");
        }
        return result;
    }
    static bool batteryIsOk(float temperature, float soc, float chargeRate,) {
        bool tempok=IsparameterInRange(temperature,0,40,"Temperature");
        bool socok=IsparameterInRange(soc,20,80"soc");
        bool CRok=maxcheck(chargeRate,0.8f,"chargerate");
        bool allok= tempok && socok && CRok;
        return allok;
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
