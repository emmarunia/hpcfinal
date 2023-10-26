using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DiscussionFix.Shared;

namespace DiscussionFix.Client.Pages
{
    public partial class CreatePost
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public Posts? Post { get; set; } = new Posts();

        [Parameter]
        public string Title { get; set; } = String.Empty;
        [Parameter]
        public string Content { get; set; } = String.Empty;
        [Parameter]
        public DateTime Time { get; set; } = DateTime.Now;
        [Parameter]
        public string Topic { get; set; } = String.Empty;

        protected async Task AddPost()
        {
            Post!.Title = Title; 
            Post.Content = Content;
            Post.Created = Time;
            
            switch (Topic)
            {
                case "Gardening":
                    Post.TopicId = 1;
                    break;
                case "Indoor Plants":
                    Post.TopicId = 2;
                    break;
                case "Outdoor Plants":
                    Post.TopicId = 3;
                    break;
                case "Regional Plants":
                    Post.TopicId = 4;
                    break;
                case "Gardening Adjacent":
                    Post.TopicId = 5;
                    break;
            }


            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;

            Post.UserName = UserAuth!.Name;

            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                await Http.PostAsJsonAsync($"api/add-post", Post);
            }

            Navigation.NavigateTo("/community", forceLoad: true);
        }
    }
}
