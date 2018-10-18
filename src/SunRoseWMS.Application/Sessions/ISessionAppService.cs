using System.Threading.Tasks;
using Abp.Application.Services;
using SunRoseWMS.Sessions.Dto;

namespace SunRoseWMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
