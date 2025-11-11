namespace Mediator.Before
{
    internal class Button
    {
        private readonly ITextBox _textBox;
        private readonly IDialog _dialog;

        public Button(ITextBox textBox, IDialog dialog)
        {
            this._textBox = textBox;
            this._dialog = dialog;
        }
        public void Click(string message)
        {
            _textBox.Clear();
            _dialog.Show(message);
        }
    }
}
