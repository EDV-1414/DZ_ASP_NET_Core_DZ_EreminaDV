namespace Converter.Components.Pages
{
    public partial class Hex2Dec
    {
        string hexInput = "";
        string result = "";

        void Calculate()
        {
            result = "";

            if (string.IsNullOrWhiteSpace(hexInput))
            {
                return;
            }

            long value = 0;

            foreach (char c in hexInput.ToUpper())
            {
                int digit;

                if (c >= '0' && c <= '9')
                {
                    digit = c - '0';
                }
                else if (c >= 'A' && c <= 'F')
                {
                    digit = c - 'A' + 10;
                }
                else
                {
                    result = "Ошибка: допустимы только 0–9 и A–F";
                    return;
                }

                value = value * 16 + digit;
            }

            result = value.ToString();
        }
    }
}
