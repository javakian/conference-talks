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

namespace HelloEvolve
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton evolveButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton helloButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel helloLabel { get; set; }

        [Action ("helloAction:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void helloAction (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (evolveButton != null) {
                evolveButton.Dispose ();
                evolveButton = null;
            }

            if (helloButton != null) {
                helloButton.Dispose ();
                helloButton = null;
            }

            if (helloLabel != null) {
                helloLabel.Dispose ();
                helloLabel = null;
            }
        }
    }
}