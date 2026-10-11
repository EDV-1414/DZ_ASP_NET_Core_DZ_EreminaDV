using System.Collections.Generic;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        int limit = 0;
        List<long> numbers = new();

        void Calculate()
        {
            numbers.Clear();
            if (limit <= 0)
            {
                return;
            }

            long a = 0;
            long b = 1;

            // Первое число — 0 (если предел позволяет)
            if (a <= limit)
            {
                numbers.Add(a);
            }

            // Дальше — 1, 1, 2, 3, 5, 8, ...
            while (b <= limit)
            {
                numbers.Add(b);
                long next = a + b;
                a = b;
                b = next;
            }
        }
    }
}