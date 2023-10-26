using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DiscussionFix.Shared;

namespace DiscussionFix.Client.Pages
{
    public partial class DiscussionHome
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public TopicList? TopicList { get; set; } = null;
        public List<Topics> Topics { get; set; } = new List<Topics>();


        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                TopicList = await Http.GetFromJsonAsync<TopicList>("api/topics");

            }
            foreach (var topic in TopicList!.ListOfTopics)
            {
                Topics.Add(topic);
            }
        }
    }
}
