namespace AppCenterApiClientApp.Engine
{
    using AppCenterApiClientLib.Model;
    using System;
    using System.Globalization;

    internal class BuildInfo
    {
        public BuildInfo(Build buildData, DownloadContainer downloadContainer)
        {
            var completed = buildData.Status == "completed";
            if (completed)
            {
                Successed = buildData.Result == "succeeded";

                var startTimeText = buildData.StartTime;
                var startTimeOffset = DateTimeOffset.ParseExact(startTimeText, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                var endTimeText = buildData.FinishTime;
                var endTimeOffset = DateTimeOffset.ParseExact(endTimeText, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                var buildDuration = endTimeOffset - startTimeOffset;
                Duration = buildDuration;
            }

            BranchName = buildData.SourceBranch;
            BuildId = buildData.Id.Value;
            Uri = downloadContainer.Uri;
        }
        
        public string BranchName { get; }
        public int BuildId { get; }
        public bool? Successed { get; }
        public TimeSpan Duration { get; }
        public string Uri { get; }
    }
}
