using Retalix.Client.Common.ServiceAgents;
using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent
{
    /// <summary>
    /// IUserRolesLookupServiceAgent interface
    /// </summary>
    public interface IUserRolesLookupServiceAgent : IServiceAgent
    {
        UserRolesLookupServiceResponse Execute(string makerName);
    }
}
