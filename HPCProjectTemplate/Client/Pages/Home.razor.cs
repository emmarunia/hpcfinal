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
        //protected override async Task OnInitializedAsync()
        //{
        //    var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
        //    if (UserAuth is not null && UserAuth.IsAuthenticated)
        //    {

        //        //int id = plant.Id; //plant ID used for API call
        //        plants = await Http.GetFromJsonAsync<List<PlantList>>($"api/search-plants?searchString={searchText}");



        //    }
        //}
        protected async Task SearchClick()
        {
            NavigationManager.NavigateTo("/search/" + searchText);
        }
    }
}