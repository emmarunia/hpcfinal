using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;
using System.Text;

namespace HPCProjectTemplate.Client.Pages
{
    public partial class AIHelper : ComponentBase
    {
        private string _userQuestion = string.Empty;
        private readonly List<Message> _conversationHistory = new();
        private bool _isSendingMessage;
        public UserDTO? User { get; set; } = null;
        private readonly string _chatBotKnowledgeScope = "" +
            "Your name is BioBloom Buddy. You should only answer questions about plants and how to care for them." +
            "Politely decline to answer other questions." +
            "Answer all your questions like a famous australian outback explorer";
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = null!;

        [Inject]
        public HttpClient Http { get; set; } = null!;


        public List<Message> Messages => _conversationHistory.Where(c => c.role is not "system").ToList();


        protected override Task OnInitializedAsync()
        {
            _conversationHistory.Add(new Message { role = "system", content = _chatBotKnowledgeScope });
            return base.OnInitializedAsync();
        }
        private async Task HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key is not "Enter") return;
            await SendMessage();
        }
        private async Task SendMessage()
        {
            if (string.IsNullOrWhiteSpace(_userQuestion)) return;
            AddUserQuestionToConversation();
            StateHasChanged();
            await CreateCompletion();
            ClearInput();
            StateHasChanged();
        }
        private void AddUserQuestionToConversation()
        {
            _conversationHistory.Add(new Message { role = "user", content = _userQuestion });

        }


        private async Task CreateCompletion()
        {
            var UserAuth = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.Identity;
            if (UserAuth is not null && UserAuth.IsAuthenticated)
            {
                _isSendingMessage = true;
                //var request = System.Text.Json.JsonSerializer.Serialize(_conversationHistory);
                var response = await Http.PostAsJsonAsync($"api/ai", _conversationHistory);
                if (response.IsSuccessStatusCode)
                {
                    var bob = response.Content.ReadAsStringAsync().Result;
                    Message rsp = System.Text.Json.JsonSerializer.Deserialize<Message>(bob);
                    _conversationHistory.Add(rsp);
                }
                _isSendingMessage = false;
            }
            
            
            
        }
        private void ClearInput()
        {
            _userQuestion = string.Empty;
        }
        private void ClearConversation()
        {
            ClearInput();
            _conversationHistory.Clear();
        }

        
    }
}
