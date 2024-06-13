using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Runtime.Validation;

namespace CrudAbp.CrudTable.Dto
{
    [AutoMapFrom(typeof(Table.CrudTable))]
    public class CrudTableDto :Entity<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quote { get; set; }

      
    }
}
