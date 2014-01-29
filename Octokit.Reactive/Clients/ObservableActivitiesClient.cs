﻿namespace Octokit.Reactive
{
    public class ObservableActivitiesClient : IObservableActivitiesClient
    {
        public ObservableActivitiesClient(IGitHubClient client)
        {
            Ensure.ArgumentNotNull(client, "client");

            Events = new ObservableEventsClient(client);
            Watched = new ObservableWatchedClient(client);
        }
        public IObservableEventsClient Events { get; private set; }

        public IObservableWatchedClient Watched { get; private set; }
    }
}