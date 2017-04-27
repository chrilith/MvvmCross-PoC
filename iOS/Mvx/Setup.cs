using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;

namespace SeguePoC.iOS {

	public class Setup : MvxIosSetup {
		public Setup(MvxApplicationDelegate appDelegate, MvxIosViewPresenter presenter)
			: base(appDelegate, presenter) {
		}

		protected override void InitializeViewLookup() {
			var lookup = new Dictionary<Type, Type> {
				// PR 1404
				{ typeof(HomeViewModel), typeof(ViewController) },
				{ typeof(EmbedViewModel), typeof(EmbedViewController) },
				{ typeof(NextViewModel), typeof(NextViewController) },

				// PR 1407
				{ typeof(PageViewModel), typeof(PageViewController) },
				{ typeof(OnePageViewModel), typeof(OnePageViewController) }
			};

			var container = Mvx.Resolve<IMvxViewsContainer>();
			container.AddAll(lookup);
		}

		protected override void InitializeFirstChance() {
			base.InitializeFirstChance();
			Mvx.RegisterSingleton<IMvxAppStart>(() => new MvxAppStart<HomeViewModel>());
		}

		protected override IMvxApplication CreateApp() {
			return new App();
		}
	}
}

