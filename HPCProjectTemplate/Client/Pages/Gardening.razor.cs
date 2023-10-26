using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DiscussionFix.Shared;
using System.Collections.Immutable;

namespace DiscussionFix.Client.Pages
{
    public partial class Gardening
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public PostsList? PostList { get; set; } = null;
        public List<Posts> Posts { get; set; } = new List<Posts>();
        //public ReplyList? ReplyList { get; set; } = null;
        public List<Replies> Replies { get; set; } = new List<Replies>();


        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                PostList = await Http.GetFromJsonAsync<PostsList>($"api/get-posts");
                //ReplyList = await Http.GetFromJsonAsync<PostsList>($"api/get-replies");
            }
            foreach (var post in PostList!.ListOfPosts)
            {
                if (post.TopicId == 1)
                {
                    Posts.Add(post);
                }
            }
        }
    }
}
