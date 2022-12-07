using System.ComponentModel.Composition;
using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces;

namespace Retalix.Sainsburys.Client.POSUI.CommandHandlers
{
    /// <summary>
    /// UserRolesInput CommandHandler
    /// </summary>
    [Export(typeof(IUserRolesInputCommandHandler))]

    public class UserRolesInputCommandHandler : PosCommandHandlerBase, IUserRolesInputCommandHandler
    {
        private const string UserRolesInputOutcome = "UserRolesInputOutcome";

        /// <summary>
        /// Overrides ExecuteLogic()
        /// </summary>
        /// <returns></returns>
        protected override string ExecuteLogic()
        {
            return UserRolesInputOutcome;
        }

    }
}
