using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using HPCProjectTemplate.Shared;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages;
public partial class Enroll
{
    [Inject]
    public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

    [Inject]
    private HttpClient Http { get; set; }
    private UserDTO? User { get; set; }

    [Parameter]
    public string UserName { get; set; } = String.Empty;
    protected async Task becomePremiumMember(string UserName)
    {
        var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;

        if (UserAuth is not null && UserAuth.IsAuthenticated)
        {
            UserName = UserAuth.Name!;
            var result = await Http.GetFromJsonAsync<UserDTO>($"api/become-premium-member?UserName={UserName}");
        }
        Navigation.NavigateTo("/", forceLoad: true);
    }
}
