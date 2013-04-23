using TorahDownloader.Core.Extensions;

namespace TorahDownloader.Extension.AutoDownloads
{
    public interface IAutoDownloadsParameters : IExtensionParameters
    {
        int MaxJobs { get; set; }

        bool WorkOnlyOnSpecifiedTimes { get; set; }

        string TimesToWork { get; set; }

        double MaxRateOnTime { get; set; }

        bool AutoStart { get; set; }
    }
}