namespace Common.Application.Command
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        void Handle(T command);
    }
}