using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Power
    {
        int number = 0;
        int exponent = 0;
        BigInteger result = 1;

        void Calculate()
        {
            result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= number;
            }
        }
    }
}
