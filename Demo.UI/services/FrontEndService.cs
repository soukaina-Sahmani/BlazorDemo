using Demo.DataModels.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Demo.UI.services
{
    public class FrontEndService : IFrontEndService
    {
        private readonly HttpClient _httpClient = null;

        public FrontEndService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<List<Produit>> GetProduits()
        {
            return await _httpClient.GetJsonAsync<List<Produit>>("api/Product/GetProduits");
        }
    }
}
