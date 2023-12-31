﻿using System.Threading.Tasks;
using Abp.Application.Services;
using MaidCentralInterview.Authorization.Accounts.Dto;

namespace MaidCentralInterview.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
