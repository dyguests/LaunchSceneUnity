# Introduction

当 Unity 涉及 Android 原生调用时，若涉及原生Activity跳转，则会导致以下问题：

- Unity默认Activity是 UnityPlayerActivity
- 通过Android代码跳转到 BActivity
- 退出桌面
- 点击应用图标

期望：

- 回到应用，并处在 BActivity

实际：

- 回到应用，处在 UnityPlayerActivity

此项目用于研究如何保证当前Activity不变。

# Reference

- [android:LaunchMode. Why does Unity have it as singleTask?](https://forum.unity.com/threads/android-launchmode-why-does-unity-have-it-as-singletask.992683/)