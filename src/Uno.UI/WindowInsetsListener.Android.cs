#if __ANDROID_28__
using Android.Views;

namespace Windows.UI.Xaml
{
	public class WindowInsetsListener : Java.Lang.Object, View.IOnApplyWindowInsetsListener
	{
		public WindowInsets OnApplyWindowInsets(View v, WindowInsets insets)
		{
			Window.Current.LocalWindowInsets = insets;
			Window.Current.RaiseNativeSizeChanged();

			return insets.ConsumeSystemWindowInsets();
		}
	}
}
#endif
