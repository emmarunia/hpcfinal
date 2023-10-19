using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class SinglePlantDetail
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public UserDTO? User { get; set; } = null;
        //public List<PlantList> plants { get; set; } = new List<PlantList>();
        public PerenualPlantResponse plant { get; set; } = new PerenualPlantResponse();
        [Parameter]
        public string plantId { get; set; } = String.Empty;

        private readonly string perenualURL = "https://perenual.com/api/species/details/";
        private readonly string perenualKEY = "?key=sk-28QO6524572d55f2e2357"; //Emma's API Key

        protected override async Task OnInitializedAsync()
        {

            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            

                //plants = await Http.GetFromJsonAsync<List<PlantList>>($"api/plant-details?plantId={plantId}");
                
                if (Int32.Parse(plantId) >0)
                {            
                    plant = await Http.GetFromJsonAsync<PerenualPlantResponse>($"{perenualURL}{plantId}{perenualKEY}");
                          
                }
        }
        protected async Task AddFavorite(string plantId)
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            //var User = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;

            //Plant plant = new Plant { perenualId = plantId };

            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                var result = await Http.GetFromJsonAsync<Plant>($"api/add-user-plant?userName={UserAuth.Name}&plantId={plantId}");
            }


        }
    }
}
