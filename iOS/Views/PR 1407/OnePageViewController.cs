using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;

namespace SeguePoC.iOS {
	[MvxFromStoryboard("Main")]
	public partial class OnePageViewController : MvxViewController<OnePageViewModel>, IMvxPageViewController {
		public OnePageViewController(IntPtr handle) : base(handle) { }

		// WARNING: do not mix IMvxPageViewController and IMvxPageViewModel unless necessary!
		// MvxPageViewSource check for a page index in the VM first, then in the controller
		// if not found and finally return -1 by default if none exists.
		// The index data should always be in the VM, IMvxPageViewController is here for convenience only.
		public int PageIndex => ViewModel.PageIndex;

		public override void ViewDidLoad() {
 			base.ViewDidLoad();
			TitleLabel.Text = $"{ViewModel.Title}, Index {ViewModel.PageIndex}";
		}
	}
}
