namespace Converter.Components.Pages
{
    public partial class Bin2Dec
    {
        string binaryInput = "";
        string result = "";

        void Calculate()
        {
            result = "";

            if (string.IsNullOrWhiteSpace(binaryInput))
            {
                return;
            }

            long value = 0;

            foreach (char c in binaryInput)
            {
                if (c != '0' && c != '1')
                {
                    result = "Ошибка: допустимы только 0 и 1";
                    return;
                }

                value = value * 2 + (c - '0');
            }

            result = value.ToString();
        }
    }
}