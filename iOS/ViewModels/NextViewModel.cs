using System;
using MvvmCross.Core.ViewModels;

namespace SeguePoC.iOS {
	public class NextViewModel : MvxViewModel {

		private int Parameter { get; set; }

		public string SomeText { get; set; }

		public void Init(int seconds) {
			Parameter = seconds;
		}

		public override void Start() {
			base.Start();
			SomeText = $"Lorem Ipsum: {Parameter}";
		}
	}
}
