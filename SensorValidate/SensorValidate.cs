using System.Collections.Generic;
namespace SensorValidate
{
    public class SensorValidator
    {
        public static bool IsValueGreaterThanMaxDelta(double value, double maxDelta) 
        {
            return value > maxDelta;
        }
        public static bool validateSOCreadings(List<double> values, double maxDelta) 
        {
            if(AreValuesValid(values))
                return AreConsecutiveValuesGreaterThanMaxDelta(values, maxDelta);
            return false;
        }
        public static bool validateCurrentreadings(List<double> values, double maxDelta) 
        {
            if (AreValuesValid(values))
                return AreConsecutiveValuesGreaterThanMaxDelta(values, maxDelta);
            return false;
        }

        private static bool AreConsecutiveValuesGreaterThanMaxDelta(List<double> values, double maxDelta)
        {
            for (int i = 0; i < (values.Count - 1); i++)
            {
                if (IsValueGreaterThanMaxDelta(values[i + 1] - values[i], maxDelta))
                    return false;
            }
            return true;
        }

        private static bool AreValuesValid(List<double> values)
        {
            if (values != null && values.Count > 0)
                return true;
            return false;
        }
    }
}
