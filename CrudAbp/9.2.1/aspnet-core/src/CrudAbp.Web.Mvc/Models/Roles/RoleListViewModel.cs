using System.Collections.Generic;
using CrudAbp.Roles.Dto;

namespace CrudAbp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
