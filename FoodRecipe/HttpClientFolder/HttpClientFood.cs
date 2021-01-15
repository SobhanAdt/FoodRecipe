using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FoodRecipe.model;
using FoodRecipe.Models;

namespace FoodRecipe.HttpClientFolder
{
    public class HttpClientFood
    {
        private readonly HttpClient client;
        private const string BaseAddress = "https://www.themealdb.com";

        public HttpClientFood(HttpClient client)
        {
            this.client = client;
            this.client.BaseAddress = new Uri(BaseAddress);
            this.client.DefaultRequestHeaders
                       .Add("Accept", "application/json");
        }
        public List<Area> GetArea(int size)
        {
            var httpResponse = client.GetAsync("api/json/v1/1/list.php?a=list").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            List<Area> result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                result = JsonSerializer.Deserialize<List<Area>>(stringContent);
                result = result.Take(size).ToList();
            }
            return result;
        }
        public List<categories> GetCatgory(int size)
        {
            var httpResponse = client.GetAsync("api/json/v1/1/list.php?c=list").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            List<categories> result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                result = JsonSerializer.Deserialize<List<categories>>(stringContent);
                result = result.Take(size).ToList();
            }
            return result;
        }
        public List<ingredients> GetIngredient(int size)
        {
            var httpResponse = client.GetAsync("api/json/v1/1/list.php?i=list").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            List<ingredients> result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                result = JsonSerializer.Deserialize<List<ingredients>>(stringContent);

                result = result.Take(size).ToList();

            }
            return result;
        }
        public List<Food> GetFoodByIng(string query)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/filter.php?i={query}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            List<Food> result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                var resultService = JsonSerializer.Deserialize<FoodByIngredientThemealdbList>(stringContent);


                result = resultService.meals.Select(x => new Food() { food = x.strMeal, foodThumb = x.strMealThumb, id = x.idMeal }).ToList();

            }
            return result;
        }
        public List<Food> GetFoodBycat(string query)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/filter.php?c={query}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            List<Food> result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                var resultService = JsonSerializer.Deserialize<FoodByIngredientThemealdbList>(stringContent);


                result = resultService.meals.Select(x => new Food() { food = x.strMeal, foodThumb = x.strMealThumb, id = x.idMeal }).ToList();

            }
            return result;
        }
        public List<Food> GetFoodByarea(string query)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/filter.php?a={query}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            List<Food> result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                                               .Result;

                var resultService = JsonSerializer.Deserialize<FoodByIngredientThemealdbList>(stringContent);


                result = resultService.meals.Select(x => new Food() { food = x.strMeal, foodThumb = x.strMealThumb, id = x.idMeal }).ToList();

            }
            return result;
        }

    }
}
