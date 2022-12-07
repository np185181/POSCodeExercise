using Retalix.Client.Common.DataModels;
using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.DataModels
{
    /// <summary>
    /// IUserRolesDataModel interface
    /// </summary>
    interface IUserRolesDataModel : IDataModel
    {
        UserRolesLookupServiceResponse UserRolesLookupResponseType { get; set; }
    }
}
