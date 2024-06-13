using Abp.Application.Services;
using CrudAbp.MultiTenancy.Dto;

namespace CrudAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

