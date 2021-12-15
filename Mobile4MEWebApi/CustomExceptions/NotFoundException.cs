using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile4MEWebApi.CustomExceptions
{
  public class NotFoundException : Exception
  {
    public NotFoundException(string message) : base(message)
    { }
  }
}
