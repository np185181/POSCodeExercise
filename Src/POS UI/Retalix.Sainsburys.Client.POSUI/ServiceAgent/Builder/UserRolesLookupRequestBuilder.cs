using System.ComponentModel.Composition;
using Retalix.Client.CommonServices.Utils;
using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
using Retalix.Contracts.Generated.Common;
using Retalix.Contracts.Generated.UserRoles;

namespace Retalix.Sainsburys.Client.POSUI.Service_Agent.Builder
{
    /// <summary>
    /// UserRoles Lookup Request Builder Class
    /// </summary>
    [Export(typeof(IUserRolesLookupRequestBuilder))]
    public class UserRolesLookupRequestBuilder : IUserRolesLookupRequestBuilder
    {
        /// <summary>
        /// UserRolesLookupServiceRequest class
        /// </summary>
        /// <param name="makerName"></param>
        /// <returns></returns>
        public UserRolesLookupServiceRequest BuildLookupRequest(string makerName)
        {
            var userRolesLookupRequest = new UserRolesLookupServiceRequest()
            {
                Header = new RetalixCommonHeaderType()
                {
                    MessageId = new RequestIDCommonData()
                    {
                        Value = MessageIdGenerator.GetId().ToString()
                    }
                }

            };

            return userRolesLookupRequest;
        }
    }
}
