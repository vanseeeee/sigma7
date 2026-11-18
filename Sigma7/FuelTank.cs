namespace Sigma7
{
    public class FuelTank
    {
        public int Fuel { get; private set; }

        public FuelTank(int initialFuel)
        {
            Fuel = initialFuel;
        }

        // Контракт: amount >= 0, итоговый запас не превышает 100.
        public void Refuel(int amount)
        {
            Fuel += amount;
        }
    }
}
