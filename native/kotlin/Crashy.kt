package com.brunogarcia.crashy.kotlin

//import android.util.Log
import kotlin.concurrent.thread

object Crashy {
    @JvmStatic fun `throw`() {
        try {
            throw Exception("Kotlin: throwing exception.")
        }
        catch (e: Exception) {
            //Log.e("test", "Exception thrown in Kotlin!", e)
            throw e
        }
    }
    @JvmStatic fun throwOnBackgroundThread() {
        thread(start = true) {
            throw Exception("Kotlin: throw from a background thread.")
        }
    }
}