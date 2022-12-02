﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Api.Management.Services.Paging;
using Umbraco.Cms.Api.Management.ViewModels.Pagination;
using Umbraco.Cms.Api.Management.ViewModels.Tree;

namespace Umbraco.Cms.Api.Management.Controllers.Dictionary.Tree;

public class RootDictionaryTreeController : DictionaryTreeControllerBase
{
    public RootDictionaryTreeController(IEntityService entityService, ILocalizationService localizationService)
        : base(entityService, localizationService)
    {
    }

    [HttpGet("root")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(PagedViewModel<EntityTreeItemViewModel>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedViewModel<EntityTreeItemViewModel>>> Root(int skip = 0, int take = 100)
    {
        if (PaginationService.ConvertSkipTakeToPaging(skip, take, out var pageNumber, out var pageSize, out ProblemDetails? error) == false)
        {
            return BadRequest(error);
        }

        IDictionaryItem[] dictionaryItems = PaginatedDictionaryItems(
            pageNumber,
            pageSize,
            LocalizationService.GetRootDictionaryItems(),
            out var totalItems);

        EntityTreeItemViewModel[] viewModels = MapTreeItemViewModels(null, dictionaryItems);

        PagedViewModel<EntityTreeItemViewModel> result = PagedViewModel(viewModels, totalItems);
        return await Task.FromResult(Ok(result));
    }
}