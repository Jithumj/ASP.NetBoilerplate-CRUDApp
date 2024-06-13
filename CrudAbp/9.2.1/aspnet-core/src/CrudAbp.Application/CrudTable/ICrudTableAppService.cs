using CrudAbp.CrudTable.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAbp.CrudTable
{
    public interface ICrudTableAppService
    {
        Task Create(CrudTableDto input);
        Task<List<CrudTableDto>>GetAllAsync();
        Task<CrudTableDto> GetAsync(int id);
        Task UpdateAsync(CrudTableDto input);
        Task DeleteAsync(int id);
    }
}
