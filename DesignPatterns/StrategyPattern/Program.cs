namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoStorage videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
            videoStorage.Store("some/file/path");
        }
    }
}
