using System;
using MvvmCross.Binding.iOS.ViewModels;
using MvvmCross.Core.ViewModels;

namespace SeguePoC.iOS {
	public class OnePageViewModel : MvxViewModel, IMvxPageViewModel {

		public int PageIndex { get; private set; }

		public string Title { get; private set; }

		public void Init(int index, string title) {
			PageIndex = index;
			Title = title;
		}
	}
}
