using System;
using System.Linq;
using System.Reflection;
using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace SeguePoC.iOS {
	[MvxFromStoryboard("Main")]
	public partial class ViewController : MvxViewController<HomeViewModel>, IMvxIosViewSegue {

		public ViewController(IntPtr handle) : base(handle) { }

		public object PrepareViewModelParametersForSegue(UIStoryboardSegue segue, NSObject sender) {
			if (segue.Identifier == "NextView") {
				return new { seconds = DateTime.Now.Second };
			}
			if (segue.Identifier == "OneView") {
				return new { title = "Standalone" };
			}
			return null;
		}

		/*
		 * Here we are overriding PrepareForSegue() inorder to instantiate le view model
		 * only if it is a IMvxIosView, classic controllers are not affected.
		 * 
		 * Like this, we can use segue for both embedded controller using a "container" and navigation segue.
		 * The developer will still have the opportunity to set parameters in its own overrided method if required.
		 */
		/*		public override void PrepareForSegue(UIKit.UIStoryboardSegue segue, Foundation.NSObject sender) {
					base.PrepareForSegue(segue, sender);

					var view = segue.DestinationViewController as IMvxIosView;
					if (view != null && view.Request == null) {
						var type = GetViewModelType(view);
						if (type != null) {
							var by = new MvxRequestedBy(MvxRequestedByType.Other, $"Segue: {segue.Identifier}");
							view.Request = new MvxViewModelRequest(type, null, null, by);
						}
					}
				}
		*/

		/*
		 * We must know the type of the view model in order to pass it to MvxViewModelRequest()
		 * We make it internal because it is only usefull in the library and not in the client code.
		 * An attribute will simply duplicate the view model declaration subclassing MvxViewController<T>
		 * and add useless extra complexity to the client code.
		 */
		/*		internal Type GetViewModelType(IMvxView view) {
					var viewType = view.GetType();
					var props = viewType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
					var prop = props.Where(p => p.Name == "ViewModel").FirstOrDefault();
					return prop?.PropertyType;
				}
		*/
	}
}
