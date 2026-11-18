namespace Sigma7
{
    public static class Airlock
    {
        public static bool CanOpen(bool validBadge, bool validPin)
        {
            return validBadge && validPin;
        }
    }
}
