using Retalix.Client.POS.API.Infrastructure.Service;
using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent.Service
{
    /// <summary>
    /// UserRolesLookupService
    /// </summary>
    public class UserRolesLookupService : ServiceBase, IUserRolesLookupService
    {
        private const string ServiceName = "UserRolesLookup";
        public UserRolesLookupServiceResponse Execute(UserRolesLookupServiceRequest request)
        {
            return Execute<UserRolesLookupServiceRequest, UserRolesLookupServiceResponse>(request, ServiceName);
        }
    }
}
