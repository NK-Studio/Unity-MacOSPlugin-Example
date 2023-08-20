using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace NKStudio
{
    public class NSUnityLog
    {
        private delegate void UnityLogCallback(IntPtr log);

        [DllImport("MacOSPlugin")]
        private static extern void NSUnityLogCallback([MarshalAs(UnmanagedType.FunctionPtr)] UnityLogCallback callback);

        [RuntimeInitializeOnLoadMethod]
        private static void Init()
        {
            NSUnityLogCallback(log => {
                string message = Marshal.PtrToStringAuto(log);
                Debug.Log(message);
            });
        }
    }
}
