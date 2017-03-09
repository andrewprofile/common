using Common.Application.Command;

namespace Common.Application.CommandBus
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : ICommand;
    }
}