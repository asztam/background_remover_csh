namespace BackgroundRemover.Core;

public class SegmentationResult
{
    public byte[] MaskBytes { get; set; } = Array.Empty<byte>();
    public byte[] ProcessedImageBytes { get; set; } = Array.Empty<byte>();
    public long InferenceTimeMilliseconds { get; set; }
}