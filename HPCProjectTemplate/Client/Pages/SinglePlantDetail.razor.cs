using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;
using static HPCProjectTemplate.Shared.PlantCareGuide;
//using static HPCProjectTemplate.Shared.PlantCareGuide.Data;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class SinglePlantDetail
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        public UserDTO? User { get; set; } = null;
        
        public PerenualPlantResponse plant { get; set; } = new PerenualPlantResponse();
        [Parameter]
        public string plantId { get; set; } = String.Empty;
        public bool isFavorite { get; set; } = false; 
        public bool isLoading { get; set; } = true;


        private readonly string perenualURL = "https://perenual.com/api/species/details/";
        private readonly string perenualKEY = "?key=sk-28QO6524572d55f2e2357"; //Emma's API Key

        private readonly string careURL = "https://www.perenual.com/api/species-care-guide-list";

        public string sunCareGuide { get; set; } = String.Empty;
        public string waterCareGuide { get; set; } = String.Empty;
        protected override async Task OnInitializedAsync()
        {

            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                if (Int32.Parse(plantId) > 0)
                {
                    plant = await Http.GetFromJsonAsync<PerenualPlantResponse>($"{perenualURL}{plantId}{perenualKEY}");

                }
                User = await Http.GetFromJsonAsync<UserDTO>($"api/get-user-plants?userName={UserAuth.Name}");
                if (User is not null)
                {
                    var favPlants = User.FavoritePlants;
                    foreach (var plant in favPlants)
                    {
                        if (plant.perenualId.Equals(plantId))
                        {
                            isFavorite = true;
                            break;
                        }
                    }
                }

                await GetPlantCare(plantId);

                isLoading = false;

            }
            

                //plants = await Http.GetFromJsonAsync<List<PlantList>>($"api/plant-details?plantId={plantId}");
                
               
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
        private async Task RemovePlant(string plantId)
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                var result = await Http.GetFromJsonAsync<Plant>($"api/remove-user-plant?userName={UserAuth.Name}&plantId={plantId}");
            }
        }
        private async Task GetPlantCare(string plantId)
        {
            var temp = await Http.GetFromJsonAsync<PlantCareGuide>($"{careURL}{perenualKEY}&species_id={plantId}");
            
            Section[] careGuides = temp.data[0].section;
            foreach (Section guide in careGuides)
            {
                if (guide.type.Equals("sunlight")){
                    sunCareGuide = guide.description;
                }
                if (guide.type.Equals("watering")){
                    waterCareGuide = guide.description;
                }
            }
        }
    }
}
