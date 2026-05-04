namespace CGB
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DataTemp.InitAll();
            Application.Run(new Main());
        }
    }
}
