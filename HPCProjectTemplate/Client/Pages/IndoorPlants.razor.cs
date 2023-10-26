using DiscussionFix.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DiscussionFix.Client.Pages
{
    public partial class IndoorPlants
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public PostsList? PostList { get; set; } = null;
        public List<Posts> Posts { get; set; } = new List<Posts>();


        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                PostList = await Http.GetFromJsonAsync<PostsList>($"api/get-posts");

            }
            foreach (var post in PostList!.ListOfPosts)
            {
                if (post.TopicId == 2)
                {
                    Posts.Add(post);
                }
            }
        }
    }
}
