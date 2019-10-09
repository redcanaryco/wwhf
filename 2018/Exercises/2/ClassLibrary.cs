// ==++==
//
//   C# Workshop Wild West Hackin' Fest
//   Zac Brown & Casey Smith
//
// ==--==
/*============================================================
**
** Filename:    ClassLibrary.cs
**
** Purpose:     Create and instantiate a simple class from
**              a separate binary.
**
** Compile:     csc.exe /target:library ClassLibrary.cs
**
===========================================================*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

public class WildWestHackin
{
    // Default constructor. Note that there are no arguments.
    public WildWestHackin()
    {
        MessageBox.Show("We just Built a WildWestHackin Thing");
    }

    // Declaration of a static method. This can be called without
    // creating an instance of a class:
    //
    //      WildWestHackin.Exec();
    public static void Exec()
    {
        Process.Start("notepad.exe");
    }

    // Declaration of an instance method. This can only be
    // called after creating an instance of the class:
    //
    //      var test = new WildWestHackin();
    //      test.MyMessage("Hi!");
    public void MyMessage(string inputString)
    {
        MessageBox.Show(inputString);
    }

    // Internal variable. This is formally known as a "Field".
    private string _mystring;

    // Declaration of a property. The internal state
    // is kept in the _mystring field above.
    public string MyString 
    {
        get { return _mystring; }
        set { _mystring = value; }
    }
}
