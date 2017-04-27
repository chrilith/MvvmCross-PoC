using System;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using UIKit;

namespace SeguePoC.iOS {
	public class PageViewDataSource : MvxPageViewSource {

		public PageViewDataSource(UIPageViewController pageView) : base(pageView) { }

		public override bool CanLoop => true;

		protected override UIViewController GetInitialViewController() {
			return GetViewControllerAtIndex(0);
		}

		public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController) {
			var a = base.GetNextViewController(pageViewController, referenceViewController);
			return a;
		}

		public override UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController) {
			var a = base.GetPreviousViewController(pageViewController, referenceViewController);
			return a;
		}

		public override int GetPageIndexForController(UIViewController referenceViewController) {
			var a = base.GetPageIndexForController(referenceViewController);
			return a;
		}

		protected override UIViewController GetViewControllerAtIndex(int index) {
			if (index < 0 || index >= ItemSource.Count()) {
				return null;
			}
			// Here, you can choose to use the built-in CreateViewController()
			// or instanciate your own view controllers
			var parameters = new { index = index, title = ItemSource.ElementAt(index) as string };
			// If your controller is a IMvxPageViewController, you can also pass the index, and then PageIndex will be set automatically
			// For VM with CreateViewController() the controller will be constructed late, there is no way to set it directly excepted passing it as Init() parameter
			// For instance:
			// var vm = Mvx.IocConstruct<OnePageViewModel>();
			// vm.Init(index, ItemSource.ElementAt(index) as string);
			// var viewController = (PageView as IMvxIosView).CreateViewControllerFor(vm) as UIViewController;
			var viewController = this.CreateViewController<OnePageViewModel>(parameters);

			return viewController;
		}
	}
}
