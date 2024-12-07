using System;
using System.Runtime.InteropServices;

namespace PasswordEncrypt.CryptoBranch.LibSodiumBranch.InteropBranch
{
    public class Core
    {
        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int sodium_init();

        [DllImport(Libraries.Libsodium, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int sodium_set_misuse_handler(
            Action handler);
    }
}
