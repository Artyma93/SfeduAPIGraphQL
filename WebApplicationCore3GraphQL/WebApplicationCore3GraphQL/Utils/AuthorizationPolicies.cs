using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore3GraphQL.Utils
{
    /// <summary>
    /// Wrapper class the contain all the authorization policies available in this application.
    /// </summary>
    public static class AuthorizationPolicies
    {
        public const string AssignmentToGroupMemberGroupRequired = "AssignmentToGroupMemberGroupRequired";
        public const string AssignmentToGroupAdminGroupRequired = "AssignmentToGroupAdminGroupRequired";
    }
}
