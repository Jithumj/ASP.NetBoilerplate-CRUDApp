﻿using System.Threading.Tasks;
using Abp.Application.Services;
using CrudAbp.Sessions.Dto;

namespace CrudAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
