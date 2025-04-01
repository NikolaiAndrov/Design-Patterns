namespace StrategyPattern
{
    using StrategyPattern.Contracts;

    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying blur overlay.");
        }
    }
}
