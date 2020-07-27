namespace Wowmaking.RNU
{
    public static class RNCommunicatorFactory
    {
        public static IRNCommunicator GetCommunicator()
        {
#if UNITY_EDITOR
            return new MockRNCommunicator();
#elif UNITY_IOS
            return new IOSRNCommunicator();
#elif UNITY_ANDROID
            return new AndroidRNCommunicator();
#endif
        }
    }
}