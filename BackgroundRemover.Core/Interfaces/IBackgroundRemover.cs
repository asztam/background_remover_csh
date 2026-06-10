using BackgroundRemover.Core.Models;

namespace BackgroundRemover.Core.Interfaces;

public interface IBackgroundRemover : IDisposable
{
    Task<SegmentationResult> ProcessAsync(SegmentationRequest request);
}