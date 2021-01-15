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

                var resultService = JsonSerializer.Deserialize<AreaList>(stringContent);
                result = resultService.meals.Select(x => new Area { strArea = x.strArea }).Take(size).ToList();
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

                var resultService = JsonSerializer.Deserialize<categorieslst>(stringContent);
                result = resultService.meals.Select(x => new categories { strCategory = x.strCategory }).Take(size).ToList();
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

                var resultService = JsonSerializer.Deserialize<ingredientslst>(stringContent);
                result = resultService.meals.Select(x => new ingredients { id = x.idIngredient,ingredient=x.strIngredient }).Take(size).ToList();

            }
            return result;
        }

        public foodsById GetById(int id)
        {
            var httpResponse = client.GetAsync($"api/json/v1/1/lookup.php?i={id}").Result;
            httpResponse.EnsureSuccessStatusCode();
            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            foodsById result;
            using (HttpContent content = httpResponse.Content)
            {

                string stringContent = content.ReadAsStringAsync()
                    .Result;

                var serviceResult = JsonSerializer.Deserialize<FoodByIdthemealdbList>(stringContent);


                result = serviceResult.meals.Select(x => new foodsById()
                {
                    id = x.idMeal,
                    area = x.strArea,
                    instructions = x.strInstructions,
                    mealThumb = x.strMealThumb,
                    title = x.strMeal
                }).FirstOrDefault();


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
