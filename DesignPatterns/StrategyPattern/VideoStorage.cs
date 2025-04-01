namespace StrategyPattern
{
    using StrategyPattern.Contracts;

    public class VideoStorage
    {
        private ICompressor compressor;
        private IOverlay overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            this.compressor = compressor;
            this.overlay = overlay;
        }

        public void SetCompressor (ICompressor compressor)
        {
            this.compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            this.overlay = overlay;
        }

        public void Store(string path)
        {
            this.compressor.Compress();
            this.overlay.Apply();
            Console.WriteLine();
            Console.WriteLine($"Storing video to {path}.{this.compressor}");
        }
    }
}
