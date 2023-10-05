using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Cookerr.ViewModels.Base
{
	public partial class BaseViewModel: ObservableObject, IDisposable
	{
		public BaseViewModel()
		{
		}
		
		public virtual Task InitializeViewAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		public virtual void Dispose()
		{
		}
		
		[RelayCommand]
		private Task OnAppearingAsync(CancellationToken cancellationToken)
		{
			return InitializeViewAsync(cancellationToken);
		}

		[RelayCommand]
		private void OnDisappearing()
		{
			Dispose();
		}
	}
}

