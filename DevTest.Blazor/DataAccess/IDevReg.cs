using DevTest.Blazor.Models;
using Microsoft.Extensions.Primitives;
using Refit;

namespace DevTest.Blazor.DataAccess
{
    public interface IDevReg
    {
        [Post("/auth/UserLogin")]
        Task<AuthModel> GetUserLogin([Body] UserLoginModel userLoginModel);

        [Get("/Profile")]
		[Headers("Authorization: Bearer")]
		Task<ProfileModel> GetProfile();

		[Put("/Profile")]
		[Headers("Authorization: Bearer")]
		Task<ProfileModel> PutProfile(ProfileModel profileModel);
		}
}
