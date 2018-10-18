using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SunRoseWMS.MultiTenancy.Dto;

namespace SunRoseWMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
