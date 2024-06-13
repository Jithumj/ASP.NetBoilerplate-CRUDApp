using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAbp.CrudTable.Dto
{
    public class CrudTableMap:AutoMapper.Profile
    {
        public CrudTableMap()
        {
            CreateMap<CrudTableDto, Table.CrudTable>();
        }
    }
}
