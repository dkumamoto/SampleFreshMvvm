using System;
using System.Collections.Generic;
using SampleFreshMvvm.Models;

namespace SampleFreshMvvm.PageModels
{
	public class ContactListPageModel: FreshMvvm.FreshBasePageModel
	{
		public List<Contact> ContactList { get; set; }

		public ContactListPageModel()
		{
		}

        public override void Init(object initData)
        {
            base.Init(initData);

			ContactList = new List<Contact>
			{
				new Contact{Name="Danny", Number = "12345"},
                new Contact{Name="SDG", Number = "09876"}
            };
        }

		public Contact SelectedContact
		{
			get
			{
				return null;
			}
			set
			{
				CoreMethods.PushPageModel<ContactPageModel>(value);
				RaisePropertyChanged();
			}
		}
    }
}

