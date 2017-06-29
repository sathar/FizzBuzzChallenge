namespace FizzBuzzChallenge
{
    public interface ICommandHandler<TType>
    {
        bool CanHandle(TType target);
        void Handle(TType target);
    }
}