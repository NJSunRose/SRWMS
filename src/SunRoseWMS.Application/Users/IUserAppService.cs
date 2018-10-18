using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SunRoseWMS.Roles.Dto;
using SunRoseWMS.Users.Dto;

namespace SunRoseWMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
