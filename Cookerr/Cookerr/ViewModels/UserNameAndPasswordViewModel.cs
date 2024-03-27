using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Cookerr.Services;
using Cookerr.ViewModels.Base;

namespace Cookerr.ViewModels
{
	public partial class UserNameAndPasswordViewModel: BaseViewModel
	{
		private readonly INavigationService _navigationService;
		[ObservableProperty] private string _emailAddress;
		[ObservableProperty] private string _password;
		
		public UserNameAndPasswordViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		[RelayCommand]
		private Task OnLoginAsync()
		{
			return Task.CompletedTask;
		}
	}
}

