using Microsoft.AspNetCore.Authorization;
using Mobile4MEWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mobile4MEWebApi.Authorization
{
  public class ResourceOperationRequirementHandler : AuthorizationHandler<ResourceOperationRequirement, Mobile>
  {
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ResourceOperationRequirement requirement, Mobile mobile)
    {
      if(requirement.ResourceOperation == ResourceOperation.Read ||
        requirement.ResourceOperation == ResourceOperation.Add)
      {
        context.Succeed(requirement);
      }

      var userId = context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier).Value;
      if(mobile.CreatedById == int.Parse(userId))
      {
        context.Succeed(requirement);
      }

      return Task.CompletedTask;
    }
  }
}