namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = new YouTubeChannel();

            var sub1 = new Subscriber("Ali");
            var sub2 = new Subscriber("Sara");
            channel.Subscribers += sub1.OnVideoUploaded;
            channel.Subscribers += sub2.OnVideoUploaded;
            channel.NotifySubscribers(" New Video Uploaded ");

        }
    }
}
