using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAbp.CrudTable.Dto;

namespace CrudAbp.CrudTable
{
    public class CrudTableAppService : CrudAbpAppServiceBase,ICrudTableAppService
    {
        private readonly IRepository<Table.CrudTable> _repository;
        public CrudTableAppService(IRepository<CrudAbp.Table.CrudTable> CrudTableRepository)
        {
         _repository = CrudTableRepository;
        }

        public async Task Create(Dto.CrudTableDto input)
        {
            var add = ObjectMapper.Map<Table.CrudTable>(input);
            await _repository.InsertAsync(add);
        }
        //to get the quotes from the table and show in table
        public async Task<List<CrudTableDto>> GetAllAsync()
        {
            var CrudTable=await _repository.GetAllListAsync();
            return ObjectMapper.Map<List<CrudTableDto>>(CrudTable);

        }

        //Get quotes from table to update
        public async Task<CrudTableDto> GetAsync(int id)
        {
            var quotes=await _repository.GetAsync(id);  
            return ObjectMapper.Map<CrudTableDto>(quotes);
        }
        //update data from a form
        public async Task UpdateAsync(CrudTableDto input)
        {
            var quotes=await _repository.GetAsync(input.Id);
            ObjectMapper.Map(input, quotes);
            await _repository.UpdateAsync(quotes);
        }

        //Delete data from the table
        public async Task DeleteAsync(int id)
        {
            var quotes=await _repository.GetAsync(id);
            await _repository.DeleteAsync(quotes);
        }
    }
}
