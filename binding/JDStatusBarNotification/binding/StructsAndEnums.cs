using ObjCRuntime;

namespace JDStatusBarNotification
{
	[Native]
	public enum JDStatusBarNotificationIncludedStyle : long
	{
		DefaultStyle,
		Light,
		Dark,
		Success,
		Warning,
		Error,
		Matrix
	}

	[Native]
	public enum JDStatusBarNotificationBackgroundType : long
	{
		FullWidth,
		Pill
	}

	[Native]
	public enum JDStatusBarNotificationAnimationType : long
	{
		Move,
		Bounce,
		Fade
	}

	[Native]
	public enum JDStatusBarNotificationProgressBarPosition : long
	{
		Bottom,
		Center,
		Top
	}

	[Native]
	public enum JDStatusBarNotificationSystemBarStyle : long
	{
		DefaultStyle,
		LightContent,
		DarkContent
	}

	[Native]
	public enum JDStatusBarNotificationLeftViewAlignment : long
	{
		Left,
		CenterWithText
	}
}
