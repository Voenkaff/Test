using System.Collections.Generic;

namespace Server.Listener
{
    public class ListenerContainer
    {
        private static Listener _listener;

        public static void Run()
        {
            if (_listener != null)
            {
                return;
            }

            _listener = new Listener();
            _listener.Start();
        }

        public static void Close()
        {
            if (_listener == null)
            {
                return;
            }

            _listener.Interrupt();
            _listener = null;
        }

        public static void Restart()
        {
            Close();
            Run();
        }
    }
}
