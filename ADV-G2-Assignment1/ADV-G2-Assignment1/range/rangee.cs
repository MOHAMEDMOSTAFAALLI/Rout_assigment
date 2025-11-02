using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_G2_Assignment1.range
{

    public class Range<T> where T : IComparable<T>
    {
        // Properties
        public T Minimum { get; private set; }
        public T Maximum { get; private set; }

        // Constructor
        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum cannot be greater than Maximum!");
            }

            Minimum = minimum;
            Maximum = maximum;
        }

        // Check if a value is within the range
        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        // Calculate the length of the range
        public dynamic Length()
        {
            if (typeof(T) == typeof(int))
            {
                int min = (int)(object)Minimum;
                int max = (int)(object)Maximum;
                return max - min;
            }
            else if (typeof(T) == typeof(double))
            {
                double min = (double)(object)Minimum;
                double max = (double)(object)Maximum;
                return max - min;
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal min = (decimal)(object)Minimum;
                decimal max = (decimal)(object)Maximum;
                return max - min;
            }
            else if (typeof(T) == typeof(float))
            {
                float min = (float)(object)Minimum;
                float max = (float)(object)Maximum;
                return max - min;
            }
            else if (typeof(T) == typeof(long))
            {
                long min = (long)(object)Minimum;
                long max = (long)(object)Maximum;
                return max - min;
            }
            else if (typeof(T) == typeof(DateTime))
            {
                DateTime min = (DateTime)(object)Minimum;
                DateTime max = (DateTime)(object)Maximum;
                return (max - min).TotalDays;
            }
            else if (typeof(T) == typeof(char))
            {
                char min = (char)(object)Minimum;
                char max = (char)(object)Maximum;
                return max - min;
            }
            else
            {
                throw new NotSupportedException($"Length calculation is not supported for type {typeof(T).Name}");
            }
        }

        public override string ToString()
        {
            return $"Range[{Minimum} - {Maximum}]";
        }
    }
}
