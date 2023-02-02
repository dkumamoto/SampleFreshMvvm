using System;
using PropertyChanged;

namespace SampleFreshMvvm.Models
{
	[AddINotifyPropertyChangedInterface]
	public class Contact
	{
		public string Name { get; set; }
		public string Number { get; set; }
	}
}

