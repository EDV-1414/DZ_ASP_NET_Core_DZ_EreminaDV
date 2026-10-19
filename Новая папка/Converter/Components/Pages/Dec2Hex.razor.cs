namespace Converter.Components.Pages
{
    public partial class Dec2Hex
    {
        int number = 0;
        string result = "";

        void Calculate()
        {
            if (number == 0)
            {
                result = "0";
                return;
            }

            int n = number;
            string hex = "";
            string digits = "0123456789ABCDEF";

            while (n > 0)
            {
                hex = digits[n % 16] + hex;
                n /= 16;
            }

            result = hex;
        }
    }
}
