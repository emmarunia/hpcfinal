using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

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
        public PlantSearchResult plantResult { get; set; } = new PlantSearchResult();
        public int currPage = 1;
        public int pageSize = 10;
        public int totalCount = 0;
        public int totalPages = 0;

        public bool isSearching = true;
        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {

                //int id = plant.Id; //plant ID used for API call
                this.SearchPlantAPI((currPage - 1) * pageSize, pageSize);



            }
        }
        protected async void PageSizeChange(ChangeEventArgs args)
        {
            pageSize = Int32.Parse(args.Value.ToString());
            this.SearchClick();
        }
        protected async Task SearchClick()
        {
            currPage = 1;
            this.SearchPlantAPI((currPage-1)*pageSize, pageSize);

         
        }
        protected async void SearchPlantAPI(int skip, int take)
        {
            isSearching = true;
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            plantResult = await Http.GetFromJsonAsync<PlantSearchResult>($"api/search-plants?searchString={SearchText}&userName={UserAuth.Name}&skip={skip}&take={take}");
            plants = plantResult.results;
            totalCount = plantResult.totalResults;
            totalPages = (int)Math.Ceiling((double)totalCount / (double)pageSize);
            isSearching = false;
            StateHasChanged();
        }
        
        protected async Task AddFavorite(string plantId)
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            //var User = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;

            //Plant plant = new Plant { perenualId = plantId };

            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                try
                {
                    var result = await Http.GetFromJsonAsync<Plant>($"api/add-user-plant?userName={UserAuth.Name}&plantId={plantId}");
                    plants.Where(m => m.id.ToString() == plantId).FirstOrDefault().isFavorite = true;
                    StateHasChanged();
                }
                catch(Exception ex)
                {
                    throw new Exception("You already have this plant in favorites!", ex);
                }
            }

            
        }
        private async Task RemovePlant(string plantId)
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                var result = await Http.GetFromJsonAsync<Plant>($"api/remove-user-plant?userName={UserAuth.Name}&plantId={plantId}");
                plants.Where(m => m.id.ToString() == plantId).FirstOrDefault().isFavorite = false;
                StateHasChanged();
            }
        }
        private async Task NextPage()
        {
            currPage++;

            this.SearchPlantAPI((currPage - 1) * pageSize, pageSize);
        }
        private async Task PrevPage()
        {
            currPage--;
            this.SearchPlantAPI((currPage - 1) * pageSize, pageSize);
        }
    }
}
