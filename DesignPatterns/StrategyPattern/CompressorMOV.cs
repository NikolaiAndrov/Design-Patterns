namespace StrategyPattern
{
    using StrategyPattern.Contracts;
    
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MOV.");
        }
    }
}
