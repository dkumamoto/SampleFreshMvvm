using System;
using SampleFreshMvvm.Models;

namespace SampleFreshMvvm.PageModels
{
	public class ContactPageModel : FreshMvvm.FreshBasePageModel
	{

		public Contact Contact { get; set; }
		public ContactPageModel()
		{
		}

        public override void Init(object initData)
        {
            base.Init(initData);
			Contact = initData as Contact;
        }
    }
}

