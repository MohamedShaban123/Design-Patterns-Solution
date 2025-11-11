namespace Mediator.After
{
    internal class Mediator : IMediator
    {
        private readonly TextBox _textBox;
        private readonly Dialog _dialog;

        public Mediator(TextBox textBox, Dialog dialog)
        {
            this._textBox = textBox;
            this._dialog = dialog;
        }

        public void Notify(object Source, string eventName)
        {

            if (Source is Button btn && eventName == "Click")
            {
                _textBox.Clear();
                _dialog.Show("Button Clicked Successfully");
            }


        }
    }
}
