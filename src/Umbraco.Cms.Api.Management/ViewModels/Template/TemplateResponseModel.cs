﻿using Umbraco.Cms.Core;

namespace Umbraco.Cms.Api.Management.ViewModels.Template;

public class TemplateResponseModel : TemplateModelBase, INamedEntityPresentationModel
{
    public Guid Id { get; set; }

    public Guid? MasterTemplateId { get; set; }
    public string Type => Constants.UdiEntityType.Template;
}
