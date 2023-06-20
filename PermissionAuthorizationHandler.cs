using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace intellicode_bug;

public class PermissionRequirement : IAuthorizationRequirement
{
}

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    override Ha
}