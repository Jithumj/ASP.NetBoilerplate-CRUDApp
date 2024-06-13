using System.Collections.Generic;
using CrudAbp.Roles.Dto;

namespace CrudAbp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}