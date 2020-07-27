using System.Runtime.InteropServices;

namespace Wowmaking.RNU
{
    public class IOSRNCommunicator : IRNCommunicator
    {
#if UNITY_IOS
        public class NativeAPI
        {
            [DllImport("__Internal")]
            public static extern void sendMessage(string message);
        }
#endif

        public void SendMessage(string message)
        {
#if UNITY_IOS
            NativeAPI.sendMessage(message);
#endif
        }

    }
}