using System.ComponentModel.Composition;
using Retalix.Client.POS.BusinessObjects.ServiceAgents.Validations;
using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent.Validator
{
    /// <summary>
    /// UserRolesValidator Class
    /// </summary>
    public class UserRolesValidator : RetalixValidatorBase, IUserRolesValidator
    {
        /// <summary>
        /// Validate method to validate response error
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        [Export(typeof(IUserRolesValidator))]
        public void Validate(UserRolesLookupServiceRequest request, UserRolesLookupServiceResponse response)
        {
            ValidateResponseError(response.Header);
        }
    }
}
