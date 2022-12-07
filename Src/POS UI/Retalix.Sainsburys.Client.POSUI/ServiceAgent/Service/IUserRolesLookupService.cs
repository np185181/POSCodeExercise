using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent.Service
{
    /// <summary>
    /// IUserRolesLookupService interface
    /// </summary>
    public interface IUserRolesLookupService
    {
        UserRolesLookupServiceResponse Execute(UserRolesLookupServiceRequest request);
    }
}
