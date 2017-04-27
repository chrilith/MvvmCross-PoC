using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace SeguePoC.iOS {
	public class PageViewModel : MvxViewModel {

		public List<string> Titles { get; private set; } = new List<string> {
				"Page One",
				"Page Two",
				"Page Tree"
			};

		public void Change() {
			Titles = new List<string> {
				"Next One",
				"Next Two",
				"Next Tree"
			};
			RaisePropertyChanged(() => Titles);
		}
	}
}
