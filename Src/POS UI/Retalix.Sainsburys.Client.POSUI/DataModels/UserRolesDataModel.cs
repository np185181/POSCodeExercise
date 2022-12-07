using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.DataModels
{
    /// <summary>
    /// UserRolesDataModel Class
    /// </summary>
    public class UserRolesDataModel
    {
        public UserRolesLookupServiceResponse userRolesLookupResponseType { get; set; }

        public void Clear()
        {
            userRolesLookupResponseType = null;
        }
    }
}
