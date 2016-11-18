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

namespace MvvmCrossPassaRegua.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPessoas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblValorIndividual { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblValorTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sliderPessoas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtValorTotal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (lblPessoas != null) {
                lblPessoas.Dispose ();
                lblPessoas = null;
            }

            if (lblValorIndividual != null) {
                lblValorIndividual.Dispose ();
                lblValorIndividual = null;
            }

            if (lblValorTotal != null) {
                lblValorTotal.Dispose ();
                lblValorTotal = null;
            }

            if (sliderPessoas != null) {
                sliderPessoas.Dispose ();
                sliderPessoas = null;
            }

            if (txtValorTotal != null) {
                txtValorTotal.Dispose ();
                txtValorTotal = null;
            }
        }
    }
}