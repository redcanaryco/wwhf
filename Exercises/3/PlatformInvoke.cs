// ==++==
// 
//   C# Workshop Wild West Hacking Fest
//   Zac Brown & Casey Smith
// 
// ==--==
/*============================================================
**
** Filename:    PlatformInvoke
**
** Purpose:     Demonstrate unmanaged library function calls.
**              Using Platform Invoke (P/Invoke)
**
** Compile:     csc.exe /target:exe PlatformInvoke.cs
**
===========================================================*/

using System;
using System.Runtime.InteropServices;

public class Program
{
    // In this example, we will call MessageBox, using P/Invoke
    // First we need to define a mapping to the function
    // You can find this on MSDN 
    // https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-messagebox
    /* 
    int MessageBox(
      HWND hWnd, 
      LPCTSTR lpText, 
      LPCTSTR lpCaption, 
      UINT uType
    ); 
    Parameters
    hWnd
    [in] Handle to the owner window of the message box to be created. If this parameter is NULL, the message box has no owner window.
    lpText
    [in] Long pointer to a null-terminated string that contains the message to be displayed.
    lpCaption
    [in] Long pointer to a null-terminated string used for the dialog box title. If this parameter is NULL, the default title Error is used.
    uType
    [in] Specifies a set of bit flags that determine the contents and behavior of the dialog box. This parameter can be a combination of flags from the following groups of flags.
    Specify one of the following flags to indicate the buttons contained in the message box.
    */
    
    // Reference the Win32 DLL that contains the native function
    // we want to call using P/Invoke.
    [DllImport("user32.dll", SetLastError=true)]
    static extern int MessageBox(
        IntPtr hwnd, 
        string text, 
        string title, 
        uint type );
        
    // Our static main method.
    public static void Main()
    {
        // Call our P/Invoke method that we imported above.
        int result = MessageBox(IntPtr.Zero, "Boom!", "My Title", 0);
    }
}