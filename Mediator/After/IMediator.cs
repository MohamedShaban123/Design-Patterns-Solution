namespace Mediator.After
{
    internal interface IMediator
    {
        public void Notify(object Source, string eventName);
    }
}
