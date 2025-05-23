using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Wafi.Abp.Workspaces.Services;
using Wafi.Abp.Workspaces.Services.Dtos;

namespace Wafi.Abp.Workspaces.Web.Pages.WorkSpaces;

public class CreateModalModel : AbpPageModel
{
    [BindProperty]
    public WorkspaceDto Workspace { get; set; }

    private readonly IWorkspaceAppService _workspaceAppService;

    public CreateModalModel(IWorkspaceAppService workspaceAppService)
    {
        _workspaceAppService = workspaceAppService;
    }

    public void OnGet()
    {
        Workspace = new WorkspaceDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _workspaceAppService.CreateAsync(Workspace.Name);
        return NoContent();
    }
} 