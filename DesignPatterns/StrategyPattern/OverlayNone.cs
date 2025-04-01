namespace StrategyPattern
{
    using StrategyPattern.Contracts;

    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not applying overlay.");
        }
    }
}
