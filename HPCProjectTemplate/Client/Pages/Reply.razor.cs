using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class Reply
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public Replies? Rep { get; set; } = new Replies();

        [Parameter]
        public string Content { get; set; } = String.Empty;
        [Parameter]
        public DateTime Time { get; set; } = DateTime.Now;
        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public string? Title { get; set; }

        protected async Task AddReply()
        {
            Rep!.Title = Title;
            Rep.Content = Content;
            Rep.Created = Time;
            Rep.PostId = Id;

            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;

            Rep.UserName = UserAuth!.Name;

            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                await Http.PostAsJsonAsync($"api/reply", Rep);
                
                //var result = await Http.GetFromJsonAsync<Replies>($"api/add-reply-to-post?rep={Rep}");
            }


            Navigation.NavigateTo("/community", forceLoad: true);
        }
    }
}
