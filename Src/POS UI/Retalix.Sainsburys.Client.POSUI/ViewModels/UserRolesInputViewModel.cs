using System.Windows.Input;
using Retalix.Client.POS.Presentation.ViewModels.ViewModels;
using Retalix.Client.Presentation.Core.Command;
using Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces;

namespace Retalix.Sainsburys.Client.POSUI.ViewModels
{
    /// <summary>
    /// UserRolesInputViewModel
    /// </summary>
    public class UserRolesInputViewModel : PosViewModelBase
    {
        public ICommand GetCommand{ get; private set; }
        public ICommand BackCommand{ get; private set; }
        
        private string _userRolesMakerName;
        public string UserRolesMakerName
        {
            get { return _userRolesMakerName; }
            set { _userRolesMakerName = value; NotifyPropertyChanged("UserRolesMakerName"); }
        }

        /// <summary>
        /// Calls Init
        /// </summary>
        public UserRolesInputViewModel()
        {
            Init();
        }

        /// <summary>
        /// Calls InitCommands
        /// </summary>
        private void Init()
        {
            InitCommands();
        }

        /// <summary>
        /// Initializes Get and Back Commands
        /// </summary>
        private void InitCommands()
        {
            GetCommand = new CommandAction<object>(ExecuteGetCommand, CanExecuteGetCommand);
            BackCommand = new CommandAction<object>(ExecuteBackCommand, x=>true);
        }

        /// <summary>
        /// Checks Can Execute GetCommand
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool CanExecuteGetCommand(object obj)
        {
            return !string.IsNullOrWhiteSpace(UserRolesMakerName);
        }

        /// <summary>
        /// Executes GetCommand
        /// </summary>
        /// <param name="obj"></param>
        protected virtual void ExecuteGetCommand(object obj)
        {
            ExecuteUserRolesLookupCommandHandler(_userRolesMakerName);
        }

        /// <summary>
        /// Executes BackCommand
        /// </summary>
        /// <param name="obj"></param>
        protected virtual void ExecuteBackCommand(object obj)
        {
            ExecuteBackCommandHandler();
        }

        /// <summary>
        /// ExecuteUserRolesLookupCommandHandler 
        /// </summary>
        /// <param name="carMakerName"></param>
        protected virtual void ExecuteUserRolesLookupCommandHandler(string userRolesMakerName)
        {
            var command = CommandHandlerFactory.Create<IUserRolesLookupCommandHandler>();
            command.Init(userRolesMakerName);
            ExecuteCommandHandlerAndStartFlow(command);
        }

        /// <summary>
        /// Executes BackCommandHandler
        /// </summary>
        protected virtual void ExecuteBackCommandHandler()
        {
            var command = CommandHandlerFactory.Create<IUserRolesBackCommandHandler>();
            ExecuteCommandHandlerAndStartFlow(command);
        }
    }
}
