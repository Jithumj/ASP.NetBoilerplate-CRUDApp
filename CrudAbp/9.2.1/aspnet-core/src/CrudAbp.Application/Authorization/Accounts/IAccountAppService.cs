using System.Threading.Tasks;
using Abp.Application.Services;
using CrudAbp.Authorization.Accounts.Dto;

namespace CrudAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
