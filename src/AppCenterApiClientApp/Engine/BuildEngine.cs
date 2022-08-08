namespace AppCenterApiClientApp.Engine
{
    using AppCenterApiClientLib.Api;
    using AppCenterApiClientLib.Model;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    internal class BuildEngine
    {
        private readonly string ownerName;
        private readonly string appName;
        private readonly BuildApi buildApi;

        public BuildEngine(string ownerName, string appName)
        {
            this.ownerName = ownerName;
            this.appName = appName;
            
            buildApi = new BuildApi();
        }

        public void Run()
        {
            Console.WriteLine("Getting branches to build...");
            var configuredBranches = GetConfiguredBranches();
            var branchNames = configuredBranches.Select(v => v.Name).ToArray();
            Console.WriteLine($"Queue to build: {string.Join(", ", branchNames)}");

            Console.WriteLine("Starting build branches...");
            var builds = StartBuilds(branchNames);
            var buildIds = builds.Select(v => v.Id.Value).ToArray();
            Console.WriteLine($"Build ids to check: {string.Join(", ", buildIds)}");

            //var buildIds = new[] { 1, 2 };

            BuildInfo[] buildInfoArray;
            while (true)
            {
                buildInfoArray = GetBuildInfoArray(buildIds);
                if (buildInfoArray.All(v => v.Successed.HasValue == true))
                {
                    break;
                }

                Thread.Sleep(30000);
            }

            Console.WriteLine("\r\n" +
                              "ALL builds finished\r\n" +
                              "\r\n" +
                              "---------------------------------------------------\r\n" +
                              "\r\n");

            foreach (var buildInfo in buildInfoArray)
            {
                var buildStatusText = buildInfo.Successed.Value ? "COMPLETED" : "FAILED";
                var buildTimeInSeconds = (int)buildInfo.Duration.TotalSeconds;
                Console.WriteLine($"Branch \"{buildInfo.BranchName}\" build {buildStatusText} in {buildTimeInSeconds} seconds.\r\n" +
                                  $"Link to build logs:\r\n" +
                                  $"{buildInfo.Uri}\r\n" +
                                  $"\r\n" +
                                  $"---------------------------------------------------\r\n" +
                                  $"\r\n");
            }
        }

        private BuildInfo[] GetBuildInfoArray(int[] buildIds)
        {
            var buildInfoList = new List<BuildInfo>();

            foreach (var buildId in buildIds)
            {
                var buildInfo = GetBuildInfo(buildId);
                buildInfoList.Add(buildInfo);
            }

            return buildInfoList.ToArray();
        }

        private BuildInfo GetBuildInfo(int buildId)
        {
            var buildData = GetBuildData(buildId);
            var downloadContainer = GetDownloadUri(buildId, "logs");

            var buildInfo = new BuildInfo(buildData, downloadContainer);
            return buildInfo;
        }

        private DownloadContainer GetDownloadUri(int buildId, string downloadType)
        {
            var result = buildApi.BuildsGetDownloadUri(buildId, downloadType, ownerName, appName);
            var downloadUriObject = result as JObject;
            if (downloadUriObject == null)
            {
                throw new Exception("downloadUriObject == null");
            }

            var downloadContainer = downloadUriObject.ToObject<DownloadContainer>();
            return downloadContainer;
        }

        private BuildLog GetBuildLogs(int buildId)
        {
            var result = buildApi.BuildsGetLog(buildId, ownerName, appName);
            var buildLogObject = result as JObject;
            if (buildLogObject == null)
            {
                throw new Exception("buildLogObject == null");
            }

            var buildLog = buildLogObject.ToObject<BuildLog>();
            return buildLog;
        }

        private Build GetBuildData(int buildId)
        {
            var result = buildApi.BuildsGet(buildId, ownerName, appName);
            var buildObject = result as JObject;
            if (buildObject == null)
            {
                throw new Exception("buildObject == null");
            }

            var build = buildObject.ToObject<Build>();
            return build;
        }

        private Build[] StartBuilds(string[] branchNames)
        {
            var buildList = new List<Build>();
            foreach (var branchName in branchNames)
            {
                var build = StartBuild(branchName);
                buildList.Add(build);
            }

            return buildList.ToArray();
        }

        private Build StartBuild(string branchName)
        {
            var body = new BranchBuildsBody(); // BranchBuildsBody | Parameters of the build (optional) 
            var result = buildApi.BuildsCreate(branchName, ownerName, appName, body);
            var buildObject = result as JObject;
            if (buildObject == null)
            {
                throw new Exception("buildObject == null");
            }

            var build = buildObject.ToObject<Build>();
            return build;
        }

        private List<Branch> GetConfiguredBranches()
        {
            const string KeyBranchConfigured = "configured";
            const string KeyBranchObject = "branch";

            var configuredBranchesList = new List<Branch>();
            var branchesList = buildApi.BuildsListBranches(ownerName, appName);
            foreach (var item in branchesList)
            {
                if (item.ContainsKey(KeyBranchConfigured) == false)
                {
                    throw new Exception($"item.ContainsKey(KeyBranchConfigured[={KeyBranchConfigured}]) == false");
                }

                var isConfigured = item["configured"] as bool?;
                if (isConfigured == false)
                {
                    continue;
                }

                if (item.ContainsKey(KeyBranchObject) == false)
                {
                    throw new Exception($"item.ContainsKey(KeyBranchObject[={KeyBranchObject}]) == false");
                }

                var branchObject = item[KeyBranchObject] as JObject;
                if (branchObject == null)
                {
                    throw new Exception("branchObject == null");
                }

                var branch = branchObject.ToObject<Branch>();
                configuredBranchesList.Add(branch);
            }

            return configuredBranchesList;
        }
    }
}
