using System.Threading.Tasks;
using Abp.Application.Services;
using SunRoseWMS.Authorization.Accounts.Dto;

namespace SunRoseWMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
