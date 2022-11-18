namespace Pomo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Sessions sessions = new Sessions(3,2);
            sessions.Progression();
        }
    }
}
