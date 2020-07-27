namespace Wowmaking.RNU
{
    public static class RNCommunicatorFactory
    {
        private static IRNCommunicator mockCommunicator;
        public static void SetMockCommunicator(IRNCommunicator mock)
        {
            mockCommunicator = mock;
        }
        public static IRNCommunicator GetCommunicator()
        {
#if UNITY_EDITOR
            return mockCommunicator;
#elif UNITY_IOS
            return new IOSRNCommunicator();
#elif UNITY_ANDROID
            return new AndroidRNCommunicator();
#endif
        }
    }
}