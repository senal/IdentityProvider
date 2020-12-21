using IdentityModel.Client;
using System.Threading.Tasks;

namespace web.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
