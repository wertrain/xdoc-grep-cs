using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XDocGrep
{
    /// <summary>
    /// 
    /// </summary>
    public class XDoc2TxtManager
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("kernel32", SetLastError = true)]
        internal static extern bool FreeLibrary(IntPtr hModule);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = false)]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ExtractText(
            [MarshalAs(UnmanagedType.BStr)] String lpFileName,
            bool bProp,
            [MarshalAs(UnmanagedType.BStr)] ref String lpFileText
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ExtractTextEx(
            [MarshalAs(UnmanagedType.BStr)] String lpFileName,
            bool bProp,
            [MarshalAs(UnmanagedType.BStr)] String lpOptions,
            [MarshalAs(UnmanagedType.BStr)] ref String lpFileText
        );

        /// <summary>
        /// 
        /// </summary>
        private class XDoc2Txt : IDisposable
        {
            private IntPtr Handle { get; set; }

            public XDoc2Txt()
            {
                Handle = LoadLibrary(@"xd2txlib.dll");
            }

            ~XDoc2Txt()
            {
                Dispose(false);
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (Handle != IntPtr.Zero)
                {
                    FreeLibrary(Handle);
                    Handle = IntPtr.Zero;
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="filePath"></param>
            /// <param name="extractedText"></param>
            /// <returns></returns>
            public int ExtractText(string filePath, ref string extractedText)
            {
                IntPtr funcPtr = GetProcAddress(Handle, "ExtractTextEx");
                ExtractTextEx extractText = (ExtractTextEx)Marshal.GetDelegateForFunctionPointer(funcPtr, typeof(ExtractTextEx));
                return extractText(filePath, false, "", ref extractedText);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="extractedText"></param>
        /// <returns></returns>
        public static int Extract(string filePath, ref string extractedText)
        {
            using (var xDoc2txt = new XDoc2Txt())
            {
                return xDoc2txt.ExtractText(filePath, ref extractedText);
            }
        }

    }
}
