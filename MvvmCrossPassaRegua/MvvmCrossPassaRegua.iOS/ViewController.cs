using System;

using UIKit;

namespace MvvmCrossPassaRegua.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
                double valorTotal = 0;
                double.TryParse(txtValorTotal.Text, out valorTotal);

                int totalPessoas = (int)sliderPessoas.Value;

                var calculadoraSerice = new CalculadoraService();

                var valorIndividual = calculadoraSerice.CalculaIndividual(valorTotal, totalPessoas);

                lblPessoas.Text = totalPessoas.ToString();
                lblValorTotal.Text = valorTotal.ToString("0.00");
                lblValorIndividual.Text = valorIndividual.ToString("0.00");
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

