using UnityEngine;

namespace Wowmaking.RNU
{
    public class AndroidRNCommunicator : IRNCommunicator
    {
        public void SendMessage(string message)
        {
            try
            {
                AndroidJavaClass jc = new AndroidJavaClass("com.wowmaking.rnunity.UnityReactActivity");
                AndroidJavaObject unityReactActivity = jc.GetStatic<AndroidJavaObject>("instance");
                unityReactActivity.Call("sendMessage", message);
            }
            catch (System.Exception e)
            {
                Debug.Log("Exception during sendMessage to UnityReactActivity");
                Debug.Log(e.Message);
            }
        }
    }
}
