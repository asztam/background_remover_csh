namespace BackgroundRemover.Core.Models;

public class SegmentationRequest
{
    public byte[] ImageBytes { get; set; } = Array.Empty<byte>();
}
