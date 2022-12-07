using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent.Builder
{
    /// <summary>
    /// IUserRolesLookupRequestBuilder interface
    /// </summary>
    interface IUserRolesLookupRequestBuilder 
    {
        UserRolesLookupServiceRequest BuildLookupRequest(string makerName);
    }
}
