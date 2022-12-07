using System.ComponentModel.Composition;
using Retalix.Client.Common.Handlers;
using Retalix.Client.POS.BusinessObjects.Factory;
using Retalix.Client.Presentation.Core.ViewModels;
using Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces;

namespace Retalix.Sainsburys.Client.POSUI.CommandHandlers
{
    /// <summary>
    /// UserRolesExtendedCommand Class
    /// </summary>
    [Export(typeof(IExtendedCommand))]
    public class UserRolesExtendedCommand : IExtendedCommand
    {
        private const string UserRolesCommandName = "UserRolesDetails";

        [Import] private ICommandHandlerFactory _commandHandlerFactory;

        public string CommandName
        {
            get { return UserRolesCommandName; }
        }

        /// <summary>
        /// Gets CommandHandler
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public ICommandHandler GetCommandHandler(ViewModelBase viewModel)
        {
            var commandHandler = _commandHandlerFactory.Create<IUserRolesInputCommandHandler>();
            return commandHandler;
        }
    }
}
