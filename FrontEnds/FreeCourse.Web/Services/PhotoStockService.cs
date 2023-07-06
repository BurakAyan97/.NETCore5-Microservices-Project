using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models.PhotoStocks;
using FreeCourse.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public class PhotoStockService : IPhotoStockService
    {
        private readonly HttpClient _httpClient;

        public PhotoStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> DeletePhoto(string photoUrl)
        {
            var response = await _httpClient.DeleteAsync($"photos?photoUrl={photoUrl}");
            return response.IsSuccessStatusCode;
        }

        public async Task<PhotoViewModel> UploadPhoto(IFormFile photo)
        {
            if (photo is null || photo.Length <= 0)
                return null;

            //örnek dosya ismi = 325324326745.jpg
            var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photo.FileName)}";

            using var memoryStream = new MemoryStream();
            await photo.CopyToAsync(memoryStream);

            var multiPartContent = new MultipartFormDataContent();
            //Ben sana bu resim dosyasını byte dizine çevir diye veriyorum, ismi photo olacak ve kaydedilcek ismi random olcak.
            multiPartContent.Add(new ByteArrayContent(memoryStream.ToArray()), "photo", randomFileName);

            var response = await _httpClient.PostAsync("photos", multiPartContent);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<PhotoViewModel>>();
            return responseSuccess.Data;
        }
    }
}
