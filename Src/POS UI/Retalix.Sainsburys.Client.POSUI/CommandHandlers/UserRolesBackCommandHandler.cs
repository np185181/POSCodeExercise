using System.ComponentModel.Composition;
using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces;

namespace Retalix.Sainsburys.Client.POSUI.CommandHandlers
{
    /// <summary>
    /// UserRolesBackCommandHandler
    /// </summary>
    [Export(typeof(IUserRolesBackCommandHandler))]

    public class UserRolesBackCommandHandler : PosCommandHandlerBase, IUserRolesBackCommandHandler
    {
        private const string UserRolesBackOutcome = "UserRolesBackOutcome";

        /// <summary>
        /// Overrides ExecuteLogic()
        /// </summary>
        /// <returns></returns>
        protected override string ExecuteLogic()
        {
            return UserRolesBackOutcome;
        }

    }
}
