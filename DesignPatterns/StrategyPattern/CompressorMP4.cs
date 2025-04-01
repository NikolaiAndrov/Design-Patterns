﻿namespace StrategyPattern
{
    using StrategyPattern.Contracts;

    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MP4.");
        }
    }
}
