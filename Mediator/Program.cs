namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before using Mediator
            //Before.Button button = new Before.Button(new Before.TextBox(), new Before.Dialog());
            //button.Click("Button Clicked Successfully");


            /*
            /⚠️ Why Interface Alone Isn’t Enough
            (If you add another element (like a Label or Logger), Button needs to be updated again.)
            ✅ Better than direct dependency
            ❌ Still — Button knows who to call and when.
             If you add another element(like a Label or Logger), Button needs to be updated again.
            */
            #endregion



            #region After Using Mediator
            //After.TextBox textBox = new After.TextBox();
            //After.Dialog dialog = new After.Dialog();
            //After.Mediator mediator = new After.Mediator(textBox, dialog);
            //After.Button button = new After.Button(mediator);
            //button.Click();
            #endregion


        }
    }
}
