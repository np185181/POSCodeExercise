using Retalix.Client.Common.Handlers;

namespace Retalix.Sainsburys.Client.POSUI.CommandHandlerInterfaces
{
    /// <summary>
    /// IUserRolesLookupCommandHandler interface
    /// </summary>
    interface IUserRolesLookupCommandHandler : ICommandHandler
    {
        void Init(string carMakerName);
    }
}
