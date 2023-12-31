﻿using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class PlantProducts
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;
        [Inject]
        public HttpClient Http { get; set; } = null!;

        [Parameter]
        public string SearchText { get; set; } = string.Empty;

        public List<Product> products { get; set; } = new List<Product>();
        protected override async Task OnInitializedAsync()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {

                //int id = plant.Id; //plant ID used for API call
                products = await Http.GetFromJsonAsync<List<Product>>($"api/products");

            }
        }
    }
}
