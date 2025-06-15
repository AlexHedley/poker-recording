using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Shared.Services
{
    public class PokerService : IPokerService
    {
        private readonly HttpClient _httpClient;

        public PokerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5174/api/Poker");
        }

        public async Task<string> GetVersionAsync()
        {
            var response = await _httpClient.GetAsync("");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<string>();
        }

        public async Task PutPlayerAndCardAsync(int player, string card)
        {
            var response = await _httpClient.PutAsync($"?player={player}&text={card}", null);
            response.EnsureSuccessStatusCode();
            //return await response.Content.ReadAsStringAsync();
        }

        public async Task DeleteAsync()
        {
            var response = await _httpClient.DeleteAsync("");
            response.EnsureSuccessStatusCode();
            //return await response.Content.ReadAsStringAsync();
        }
    }
}
