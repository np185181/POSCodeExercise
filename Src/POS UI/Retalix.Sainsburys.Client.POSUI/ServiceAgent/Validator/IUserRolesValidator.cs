using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent.Validator
{
    /// <summary>
    /// IUserRolesValidator interface
    /// </summary>
    public interface IUserRolesValidator
    {
        void Validate(UserRolesLookupServiceRequest request, UserRolesLookupServiceResponse response);
    }
}
