// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LizApp.iOS
{
    [Register ("NoCaptureController")]
    partial class NoCaptureController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView status { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (status != null) {
                status.Dispose ();
                status = null;
            }
        }
    }
}