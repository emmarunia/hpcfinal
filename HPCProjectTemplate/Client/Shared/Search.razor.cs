using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Shared
{
    public partial class Search
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;
        [Inject]
        public HttpClient Http { get; set; } = null!;

        [Parameter]
        public string SearchText { get; set; } = string.Empty;
        
        public List<PlantList> plants { get; set; } = new List<PlantList>();
        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {   
                
                //int id = plant.Id; //plant ID used for API call
                plants = await Http.GetFromJsonAsync<List<PlantList>>($"api/search-plants?searchString={SearchText}");

                
                
            }
        }
        protected async Task SearchClick()
        {
            
            plants = await Http.GetFromJsonAsync<List<PlantList>>($"api/search-plants?searchString={SearchText}");

         
        }
    }
}
