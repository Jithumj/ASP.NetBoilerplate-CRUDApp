using System.Collections.Generic;
using CrudAbp.Roles.Dto;

namespace CrudAbp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
