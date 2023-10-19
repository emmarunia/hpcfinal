using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using HPCProjectTemplate.Shared;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class PersonalDetails
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public UserDTO? user { get; set; } = null;

        [Parameter]
        public string UserName { get; set; } = String.Empty;

        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                UserName = UserAuth.Name!;
                user = await Http.GetFromJsonAsync<UserDTO>($"api/personal?UserName={UserName}");
            }
        }

        [Parameter]
        public string Birthday { get; set; } = String.Empty;
        protected async Task AddBirthday()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;

            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                UserName = UserAuth.Name!;
                var result = await Http.GetFromJsonAsync<UserDTO>($"api/add-birthday?UserName={UserName}&birthday={Birthday}");
            }
        }
    }

}
