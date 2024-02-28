package com.fanhl.launchsceneandroid.sdk;

import android.content.Context;
import android.content.Intent;
import android.util.Log;

public class Launcher {
    private static final String TAG = "Launcher";

    public static void launchB(Context context) {
        Log.d(TAG, "android Launcher launchB");
        context.startActivity(new Intent(context, BActivity.class));
    }
}
