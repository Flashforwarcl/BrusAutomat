namespace InputHandler
{
    public class Checks
    {
        public static bool IsRunning { get; set; } = true;

        public static void Running(bool running)
        {
            IsRunning = running;
        }
    }
}