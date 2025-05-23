﻿using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Wafi.Abp.Workspaces.Services.Dtos;

namespace Wafi.Abp.Workspaces.Services;

public interface IWorkspaceAppService : IApplicationService
{
    Task<WorkspaceDto> CreateAsync(string name);
    Task<WorkspaceDto> UpdateAsync(Guid id, string name);
    Task<WorkspaceDto> GetAsync(Guid id);
    Task<PagedResultDto<WorkspaceDto>> GetAllAsync(PagedAndSortedResultRequestDto filter);
    Task DeleteAsync(Guid id);
}
