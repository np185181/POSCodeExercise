using System.ComponentModel.Composition;
using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Contracts.Generated.UserRoles;
using Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces;
using Retalix.Sainsburys.Client.POSUI.DataModels;
using Retalix.Sainsburys.Client.POSUI.Service_Agent;

namespace Retalix.Sainsburys.Client.POSUI.CommandHandlers
{
    /// <summary>
    /// UserRolesLookupCommandHandler Class
    /// </summary>
    [Export(typeof(IUserRolesLookupCommandHandler))]

    public class UserRolesLookupCommandHandler : PosCommandHandlerBase, IUserRolesLookupCommandHandler
    {
        private string _userRolesMakerName;
        private const string _userRolesLookupOutcome = "UserRolesLookupOutcome";

        public void Init(string userRolesMakerName)
        {
            _userRolesMakerName = userRolesMakerName;
        }

        /// <summary>
        /// Overrides ExecuteLogic()
        /// </summary>
        /// <returns></returns>
        protected override string ExecuteLogic()
        {
            var userRolesLookupResponse = ExecuteUserRolesLookupServiceAgent();
            SetupUserRolesDataModel(userRolesLookupResponse);
            return _userRolesLookupOutcome;
        }

        /// <summary>
        /// Setup UserRoles Data Model
        /// </summary>
        /// <param name="userRolesLookupResponse"></param>
        private void SetupUserRolesDataModel(UserRolesLookupServiceResponse userRolesLookupResponse)
        {
            var userRolesDataModel = GetDataModel<IUserRolesDataModel>();
            userRolesDataModel.UserRolesLookupResponseType = userRolesLookupResponse;
        }

        /// <summary>
        /// Executes UserRoles Lookup Service Agent
        /// </summary>
        /// <returns></returns>
        private UserRolesLookupServiceResponse ExecuteUserRolesLookupServiceAgent()
        {
            var userRolesLookupServiceAgent = GetServiceAgent<IUserRolesLookupServiceAgent>();
            return userRolesLookupServiceAgent.Execute(_userRolesMakerName);
        }
    }
}
