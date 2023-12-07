namespace FinalProjectAPI.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string command);
    }
}
