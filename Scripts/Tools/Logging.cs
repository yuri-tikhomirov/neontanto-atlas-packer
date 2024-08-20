using System.Runtime.CompilerServices;

namespace NeonTanto.Tools.AtlasPacking
{
    public static class Debug
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LogError(string message) {
#if UNITY_5_3_OR_NEWER
            UnityEngine.Debug.LogError(message);
#else
            System.Console.WriteLine(message);
#endif
        }
    }
}