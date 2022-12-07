using System.ComponentModel.Composition;
using Retalix.Contracts.Generated.UserRoles;
using Retalix.Sainsburys.Client.POSUI.Service_Agent.Builder;
using Retalix.Sainsburys.Client.POSUI.Service_Agent.Service;
using Retalix.Sainsburys.Client.POSUI.Service_Agent.Validator;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent
{
    /// <summary>
    /// Class for UserRoles Lookup Service Agent
    /// </summary>
    public class UserRolesLookupServiceAgent : IUserRolesLookupServiceAgent
    {
        [Import]
        private IUserRolesLookupService _userRolesLookupService;

        [Import]
        private IUserRolesValidator _userRolesLookupValidator;

        [Import]
        private IUserRolesLookupRequestBuilder _userRolesLookupRequestBuilder;

        /// <summary>
        /// Execute method
        /// </summary>
        /// <param name="makerName"></param>
        /// <returns></returns>
        public UserRolesLookupServiceResponse Execute(string makerName)
        {
            var userRolesLookupRequest = _userRolesLookupRequestBuilder.BuildLookupRequest(makerName);
            var userRolesLookupResponse = _userRolesLookupService.Execute(userRolesLookupRequest);
            _userRolesLookupValidator.Validate(userRolesLookupRequest, userRolesLookupResponse);
            
            return userRolesLookupResponse;
        }
    }
}
