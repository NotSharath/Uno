﻿using System.Windows.Input;
using Windows.UI.Core;
using Windows.UI.Xaml.Data;
using Uno.UI.Samples.UITests.Helpers;

namespace SamplesApp.Windows_UI_Xaml_Controls.Models
{
	[Bindable]
	public class ComboBoxViewModel : ViewModelBase
	{
		private string _header;
		private const string HeaderText = "Please select:";

		public ComboBoxViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
			ToggleHeader = CreateCommand(ExecuteToggleHeader);
		}

		public string Header
		{
			get => _header;
			set
			{
				_header = value;
				RaisePropertyChanged();
			}
		}

		public ICommand ToggleHeader { get; }

		private void ExecuteToggleHeader()
		{
			Header = Header == null ? HeaderText : null;
		}
	}
}
