﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.New.Cms.Web.Common.Routing;

namespace Umbraco.Cms.Api.Management.Controllers.Help;

[ApiController]
[VersionedApiBackOfficeRoute("help")]
[ApiExplorerSettings(GroupName = "Help")]
[ApiVersion("1.0")]
public abstract class HelpControllerBase : ManagementApiControllerBase
{
}