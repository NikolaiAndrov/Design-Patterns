namespace StrategyPattern
{
    using StrategyPattern.Contracts;

    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using WEBM.");
        }
    }
}
