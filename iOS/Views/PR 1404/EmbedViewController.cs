using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;

namespace SeguePoC.iOS {
	[MvxFromStoryboard("Main")]
	public partial class EmbedViewController : MvxViewController<EmbedViewModel> {
		public EmbedViewController(IntPtr handle) : base(handle) { }

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			TimeLabel.Text = ViewModel.EmbedTime.ToString();
		}
	}
}
