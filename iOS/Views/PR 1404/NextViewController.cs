using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;

namespace SeguePoC.iOS {
	public partial class NextViewController : MvxViewController<NextViewModel> {
		public NextViewController(IntPtr handle) : base(handle) { }

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			SomeLabel.Text = ViewModel.SomeText;
		}
	}
}
