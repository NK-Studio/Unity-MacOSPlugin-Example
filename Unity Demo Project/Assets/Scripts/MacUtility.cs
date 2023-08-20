using System.Runtime.InteropServices;
namespace NKStudio
{
    public static class MacUtility
    {
        [DllImport("MacOSPlugin")]
        public static extern void UseDemo();
    }
}
