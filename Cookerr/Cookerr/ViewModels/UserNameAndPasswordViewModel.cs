using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Cookerr.ViewModels.Base;

namespace Cookerr.ViewModels
{
	public partial class UserNameAndPasswordViewModel: BaseViewModel
	{
		[ObservableProperty] private string _emailAddress;
		[ObservableProperty] private string _password;
		
		public UserNameAndPasswordViewModel()
		{
		}

		[RelayCommand]
		private Task OnLoginAsync()
		{
			return Task.CompletedTask;
		}
	}
}

