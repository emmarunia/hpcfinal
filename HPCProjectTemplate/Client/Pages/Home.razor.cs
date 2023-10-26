using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class Home
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;
        [Inject]
        public HttpClient Http { get; set; } = null!;
        [Inject]
        NavigationManager NavigationManager { get; set; }

        public List<PlantList> plants { get; set; } = new List<PlantList>();
        public string searchText { get; set; } = null!;

        public System.Security.Principal.IIdentity UserAuth { get; set; }
        protected override async Task OnInitializedAsync()
        {
            UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
           
        }
        protected async Task SearchClick()
        {
            NavigationManager.NavigateTo("/search/" + searchText);
        }
    }
}