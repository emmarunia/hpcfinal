using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Apache.NMS.ActiveMQ.Commands;
using HPCProjectTemplate.Shared.Wrappers;
//using HPCProjectTemplate.Client.HttpRepository;
//using System.Diagnostics;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;
        //[Inject]
        //public IUserPlantsHttpRepository UserPlantsHttpRepository { get; set; } = null!;
        public UserDTO? User { get; set; } = null;
        public List<PerenualPlantResponse> plants { get; set; } = new List<PerenualPlantResponse>();
        //public bool isVisible = true;
        private readonly string perenualURL = "https://perenual.com/api/species/details/";
        private readonly string perenualKEY = "?key=sk-w8nG651f197a0954b2356"; //Cam's API Key


        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                User = await Http.GetFromJsonAsync<UserDTO>($"api/get-user-plants?userName={UserAuth.Name}");
                if (User is not null)
                {
                    foreach (var plant in User.FavoritePlants)
                    {
                        string id = plant.perenualId; //plant ID used for API call
                        PerenualPlantResponse perenualPlant = await Http.GetFromJsonAsync<PerenualPlantResponse>($"{perenualURL}{id}{perenualKEY}");
                        plants.Add(perenualPlant);
                    }
                }
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
    }
}
