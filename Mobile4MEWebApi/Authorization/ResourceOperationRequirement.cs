using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile4MEWebApi.Authorization
{
  public enum ResourceOperation
  {
    Add,
    Read,
    Update,
    Delete
  }
  public class ResourceOperationRequirement : IAuthorizationRequirement
  {
    public ResourceOperationRequirement(ResourceOperation resourceOperation)
    {
      ResourceOperation = resourceOperation;
    }
    public ResourceOperation ResourceOperation { get; }
  }
}
