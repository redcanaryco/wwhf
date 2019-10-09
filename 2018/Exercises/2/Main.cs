// ==++==
//
//   C# Workshop Wild West Hackin' Fest
//   Zac Brown & Casey Smith
//
// ==--==
/*============================================================
**
** Filename:    Main.cs
**
** Purpose:     Create and instantiate a simple class from
**              a separate binary.
**
** Compile:     csc.exe /target:exe /reference:ClassLibrary.dll Main.cs
**
===========================================================*/

public class Program
{
    // Declaration of our main method. This is always static and
    // it MUST be declared inside a class (e.g. Program above).
    public static void Main()
    {
        // Calls the static method on the WildWestHackin class.
        WildWestHackin.Exec();

        // Create an instance of the WildWestHackin class.
        WildWestHackin wwhf = new WildWestHackin();

        // Call our instance method, MyMessage, on the
        // WildWestHackin class instance.
        wwhf.MyMessage("BoomTown!");
    }
}