#if UNITY_STANDALONE_OSX
using System.Runtime.InteropServices;
using UnityEngine;

public class DemoCode : MonoBehaviour
{
    [DllImport("MacOSPlugin")]
    private static extern void UseDemo();

    private void Start()
    {
        UseDemo();
    }
}
#endif
