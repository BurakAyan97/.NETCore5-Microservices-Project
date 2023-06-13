using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using IdentityModel.Client;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SignInInput signInInput);
        Task<TokenResponse> GetAccessTokenByRefreshToken();//TokenResponse IdentityModel paketinden geliyor.İçine bak anlarsın ne var ne yok.
        Task RevokeRefreshToken();//Kullanıcı logout olduğunda tanımlı refresh tokenı veritabanından kaldırır.

    }
}
