namespace Converter.Components.Pages
{
    public partial class Dec2Bin
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
            string binary = "";

            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }

            result = binary;
        }
    }
}