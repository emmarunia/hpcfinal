//using HPCProjectTemplate.Shared;
//using HPCProjectTemplate.Shared.Wrappers;
//using System.Net.Http.Json;
//using System.Net;


//namespace HPCProjectTemplate.Client.HttpRepository;

//public class UserPlantsHttpRepository : IUserPlantsHttpRepository
//{
//    public readonly HttpClient _httpClient;
//    private readonly string perenualURL = "https://perenual.com/api/species/details/";
//    private readonly string perenualKEY = "?key=sk-28QO6524572d55f2e2357"; //Emma's API Key
//    public UserPlantsHttpRepository(HttpClient httpClient)
//    {
//        _httpClient = httpClient;
//    }

//    // wrapper pattern
//    public async Task<DataResponse<List<PlantList>>> GetPlants(string userName)
//    {
//        try
//        {
//            var PlantDetails = new List<PlantList>();
//            UserDTO? user = await _httpClient.GetFromJsonAsync<UserDTO>($"api/get-user-plants?userName={userName}");
//            if (user?.FavoritePlants?.Any() ?? false)
//            {
//                foreach (Plant plant in user.FavoritePlants)
//                {
//                    var plantDetails = from p in _context.PlantList

//                                       select p;

//                    PlantDetails.Add(plantDetails);
//                }
//            }
//            return new DataResponse<List<PlantList>>()
//            {
//                Data = PlantDetails,
//                Message = "Success",
//                Success = true
//            };
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e);
//            return new DataResponse<List<PlantList>>()
//            {
//                Data = new List<PlantList>(),
//                Message = e.Message,
//                Success = false,
//                Errors = new Dictionary<string, string[]> { { e.Message, new string[] { e.Message } } }
//            };
//        }
//    }



//    public async Task<bool> RemovePlant(string plantId, string userName)
//    {
//        Plant newPlant = new Plant { perenualId = plantId };
//        var res = await _httpClient.PostAsJsonAsync<Plant>($"api/remove-user-plant?username={userName}&plantId=plantId", newPlant);
//        if (!res.IsSuccessStatusCode)
//        {
//            throw new ApplicationException(await res.Content.ReadAsStringAsync());
//        }
//        return true;
//    }

//}