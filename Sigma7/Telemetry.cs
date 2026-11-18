namespace Sigma7
{
    public static class Telemetry
    {
        // Контракт: непустой массив, не более 20 целых чисел от -100 до 100.
        public static double Average(int[] readings)
        {
            int sum = 0;
            foreach (int reading in readings)
                sum += reading;

            return (double)sum / readings.Length;
        }

        public static int CountAlarms(int[] readings, int threshold)
        {
            int count = 0;
            foreach (int reading in readings)
            {
                if (reading >= threshold)
                    count++;
            }
            return count;
        }

        public static int Minimum(int[] readings)
        {
            int minimum = readings[0];
            for (int i = 1; i < readings.Length; i++)
            {
                if (readings[i] < minimum)
                    minimum = readings[i];
            }
            return minimum;
        }
    }
}
