using System;
using System.Threading.Tasks;

namespace SampleDB
{
    public interface IScreenshotManager
    {
        Task<byte[]> CaptureAsync();
    }
}
