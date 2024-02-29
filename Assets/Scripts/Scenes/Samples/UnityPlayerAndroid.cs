#if UNITY_ANDROID
using System;
using UnityEngine;

namespace Scenes.Samples
{
    internal static class UnityPlayerAndroid
    {
        // ReSharper disable once InconsistentNaming
        private static AndroidJavaClass _UnityPlayerJava;
        private static AndroidJavaClass UnityPlayerJava => _UnityPlayerJava ??= new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        public static AndroidJavaObject CurrentActivity
        {
            get
            {
                // var unityPlayerJava = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                // Log.N($"unityPlayerJava:{unityPlayerJava}");
                var unityActivity = UnityPlayerJava.GetStatic<AndroidJavaObject>("currentActivity");
                // Log.N($"unityActivity:{unityActivity}");
                return unityActivity;
            }
        }

        public static void RunOnUiThread(Action action)
        {
            CurrentActivity.Call("runOnUiThread", new AndroidJavaRunnable(action.Invoke));
        }
    }
}
#endif