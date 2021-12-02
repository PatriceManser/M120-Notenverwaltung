using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using Notenverwaltung;
namespace Notenverwaltung
{
  public class AuthorizeRoles : AuthorizeAttribute
  {
    public AuthorizeRoles(params Role[] allowedRoles)
    {
      var allowedRolesAsStrings = allowedRoles.Select(x => Enum.GetName(typeof(Role), x));
      Roles = string.Join(",", allowedRolesAsStrings);
    }
  }
}