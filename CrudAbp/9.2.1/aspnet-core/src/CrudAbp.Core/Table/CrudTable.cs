using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAbp.Table
{
    [Table("CrudTable")]
    public class CrudTable:Entity<int>
    {
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Quote { get; set; }
    }
}
