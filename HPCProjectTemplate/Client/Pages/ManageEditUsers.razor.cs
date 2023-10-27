using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class ManageEditUsers
    {
        [Inject]
        HttpClient Http { get; set; }
        [Parameter]
        public string userId { get; set; }
        EditUser EditUser { get; set; } = new EditUser();


        protected override async Task OnInitializedAsync()
        {
            EditUser = await Http.GetFromJsonAsync<EditUser>($"api/admin/{userId}");
        }

        private async Task UpdateUser()
        {
            await Http.PutAsJsonAsync("api/admin", EditUser);
            Navigation.NavigateTo("/admin");
        }
    }
}
