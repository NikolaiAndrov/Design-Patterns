namespace StrategyPattern
{
    using StrategyPattern.Contracts;

    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying black and white overlay.");
        }
    }
}
