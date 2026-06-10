using BackgroundRemover.Core.Models;

namespace BackgroundRemover.Core.Interfaces;

public interface IImageSegmenter : IDisposable
{
    // segmentation model's input size
    int InputWidth { get; }
    int InputHeight { get; }
    Task<byte[]> GenerateMaskAsync(SegmentationRequest request);
}
