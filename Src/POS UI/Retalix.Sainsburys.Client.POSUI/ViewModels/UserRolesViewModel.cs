using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Retalix.Client.POS.Presentation.ViewModels.ViewModels;
using Retalix.Client.Presentation.Core.Command;
using Retalix.Contracts.Generated.UserRoles;
using Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces;
using Retalix.Sainsburys.Client.POSUI.DataModels;

namespace Retalix.Sainsburys.Client.POSUI.ViewModels
{
    /// <summary>
    /// UserRolesViewModel
    /// </summary>
    public class UserRolesViewModel : PosViewModelBase
    {
        private IUserRolesDataModel _userRolesDataModel;
        public ICommand BackCommand { get; private set; }

        private List<UserRolesType> _userRolesElement;
        public List<UserRolesType> UserRolesElement
        {
            get { return _userRolesElement; }
            set { _userRolesElement = value; }
        }

        /// <summary>
        /// Calls Init & InitCommands
        /// </summary>
        public UserRolesViewModel()
        {
            Init();
            InitCommands();
        }

        /// <summary>
        /// Initializes data model
        /// </summary>
        private void Init()
        {
            _userRolesDataModel = _dataModelProvider.GetDataModel<IUserRolesDataModel>();
            var userRolesList = new List<UserRolesType>();
            var userRolesObj = _userRolesDataModel.UserRolesLookupResponseType.Response.FirstOrDefault();
            userRolesList.Add(userRolesObj);
            UserRolesElement = userRolesList;
        }
        
        /// <summary>
        /// Initializes BackCommand
        /// </summary>
        private void InitCommands()
        {
            BackCommand = new CommandAction<object>(ExecuteBackCommand, x => true);
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
        /// Executes BackCommandHandler
        /// </summary>
        protected virtual void ExecuteBackCommandHandler()
        {
            var command = CommandHandlerFactory.Create<IUserRolesBackCommandHandler>();
            ExecuteCommandHandlerAndStartFlow(command);
        }
    }
}
