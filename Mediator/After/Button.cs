namespace Mediator.After
{
    internal class Button
    {
        private readonly IMediator _mediator;

        public Button(IMediator mediator)
        {
            this._mediator = mediator;
        }


        public void Click()
        {
            _mediator.Notify(this, "Click");
        }
    }
}
