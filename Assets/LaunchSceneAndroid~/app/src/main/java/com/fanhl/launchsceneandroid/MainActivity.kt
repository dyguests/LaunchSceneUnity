package com.fanhl.launchsceneandroid

import android.os.Bundle
import android.widget.Button
import androidx.appcompat.app.AppCompatActivity
import com.fanhl.launchsceneandroid.sdk.Launcher

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        findViewById<Button>(R.id.btn_b).setOnClickListener {
            Launcher.launchB(this)
        }
    }
}