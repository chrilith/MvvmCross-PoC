using System;
using MvvmCross.Core.ViewModels;

namespace SeguePoC.iOS {
	public class EmbedViewModel : MvxViewModel {

		public DateTime EmbedTime { get; set; }

		public override void Start() {
			base.Start();
			EmbedTime = DateTime.Now;
		}
	}
}
