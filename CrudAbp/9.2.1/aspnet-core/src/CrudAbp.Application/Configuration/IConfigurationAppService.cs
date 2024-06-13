using System.Threading.Tasks;
using CrudAbp.Configuration.Dto;

namespace CrudAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
