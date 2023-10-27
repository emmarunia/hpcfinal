using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class Admin
    {
        
    [Inject]
        private HttpClient Http { get; set; }
        private List<UserRoles> Users { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Users = await Http.GetFromJsonAsync<List<UserRoles>>("api/admin");
        }

        private async Task UpdateAdmin(ChangeEventArgs args, string userId)
        {
            await Http.PostAsJsonAsync("api/toggle-admin-role", userId);
        }
    }
}

