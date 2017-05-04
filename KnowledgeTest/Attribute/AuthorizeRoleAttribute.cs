using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public enum UserRole
{
    Student = 1,
    Teacher = 2,
    Admin = 3
}

public static class UserRoleHelper
{
    private static readonly IDictionary<UserRole, string> UserRoleDictionary = new Dictionary<UserRole, string>()
    {
        {UserRole.Admin, nameof(UserRole.Admin) },
        {UserRole.Student, nameof(UserRole.Student) },
        {UserRole.Teacher, nameof(UserRole.Teacher) }
    };
    public static string AsString(this UserRole role)
    {
        return UserRoleDictionary[role];
    }
}

namespace SomeProducts.Attribute
{
    public class AuthorizeRoleAttribute : AuthorizeAttribute
    {
        private readonly UserRole[] _userRoles;

        public AuthorizeRoleAttribute()
        {
            _userRoles = null;
        }

        public AuthorizeRoleAttribute(params UserRole[] userRoles)
        {
            _userRoles = userRoles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var isAuthorized = base.AuthorizeCore(httpContext);
            return _userRoles?.Any(role => httpContext.User.IsInRole(role.AsString()))
                ?? isAuthorized;
        }
    }
}