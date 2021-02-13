using System.Diagnostics;

namespace App1
{
    public static class Jobs
    {
        public static void Job1()
        {
            Debug.WriteLine($"{typeof(Jobs)}.{nameof(Job1)} running");
        }
    }
}
