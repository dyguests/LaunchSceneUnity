#if UNITY_ANDROID
using UnityEngine;

namespace Scenes.Samples
{
    public static class Launcher
    {
        // ReSharper disable once InconsistentNamingRE
        // ReSharper disable once InconsistentNaming
        private static AndroidJavaClass _LauncherJava;

        // ReSharper disable once InconsistentNaming
        private static AndroidJavaClass LauncherJava => _LauncherJava ??= new AndroidJavaClass("com.fanhl.launchsceneandroid.sdk.Launcher");


        public static void LaunchBActivity()
        {
            Debug.Log("Launcher LaunchBActivity");
            LauncherJava.Call("launchB", UnityPlayerAndroid.CurrentActivity);
        }
    }
}
#endif