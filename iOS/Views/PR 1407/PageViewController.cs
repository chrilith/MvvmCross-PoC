using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace SeguePoC.iOS {
	[MvxFromStoryboard("Main")]
	public partial class PageViewController : MvxPageViewController<PageViewModel> {
		public PageViewController(IntPtr handle) : base(handle) { }

		public override void ViewDidLoad() {
			base.ViewDidLoad();

			var source = new PageViewDataSource(this);
			var bindings = this.CreateBindingSet<PageViewController, PageViewModel>();
			bindings.Bind(source).To(vm => vm.Titles);
			bindings.Apply();

			DataSource = source;

			// Refresh button
			var change = new UIBarButtonItem(UIBarButtonSystemItem.Edit, (sender, e) => {
				ViewModel.Change();
			});
			NavigationItem.RightBarButtonItem = change;
		}
	}
}