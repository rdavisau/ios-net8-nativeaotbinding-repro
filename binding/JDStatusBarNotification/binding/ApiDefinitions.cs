using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace JDStatusBarNotification
{
	// @interface JDStatusBarNotificationStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface JDStatusBarNotificationStyle : INSCopying
	{
		// @property (nonatomic, strong) JDStatusBarNotificationTextStyle * _Nonnull textStyle;
		[Export ("textStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationTextStyle TextStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationTextStyle * _Nonnull subtitleStyle;
		[Export ("subtitleStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationTextStyle SubtitleStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationBackgroundStyle * _Nonnull backgroundStyle;
		[Export ("backgroundStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationBackgroundStyle BackgroundStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationProgressBarStyle * _Nonnull progressBarStyle;
		[Export ("progressBarStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationProgressBarStyle ProgressBarStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationLeftViewStyle * _Nonnull leftViewStyle;
		[Export ("leftViewStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationLeftViewStyle LeftViewStyle { get; set; }

		// @property (assign, nonatomic) JDStatusBarNotificationSystemBarStyle systemStatusBarStyle;
		[Export ("systemStatusBarStyle", ArgumentSemantic.Assign)]
		JDStatusBarNotificationSystemBarStyle SystemStatusBarStyle { get; set; }

		// @property (assign, nonatomic) JDStatusBarNotificationAnimationType animationType;
		[Export ("animationType", ArgumentSemantic.Assign)]
		JDStatusBarNotificationAnimationType AnimationType { get; set; }

		// @property (assign, nonatomic) BOOL canSwipeToDismiss;
		[Export ("canSwipeToDismiss")]
		bool CanSwipeToDismiss { get; set; }

		// @property (assign, nonatomic) BOOL canTapToHold;
		[Export ("canTapToHold")]
		bool CanTapToHold { get; set; }

		// @property (assign, nonatomic) BOOL canDismissDuringUserInteraction;
		[Export ("canDismissDuringUserInteraction")]
		bool CanDismissDuringUserInteraction { get; set; }
	}

	// @interface JDStatusBarNotificationLeftViewStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface JDStatusBarNotificationLeftViewStyle : INSCopying
	{
		// @property (assign, nonatomic) CGFloat spacing;
		[Export ("spacing")]
		nfloat Spacing { get; set; }

		// @property (assign, nonatomic) CGFloat offsetX __attribute__((deprecated("deprecated, use .offset.x instead")));
		[Export ("offsetX")]
		nfloat OffsetX { get; set; }

		// @property (assign, nonatomic) CGPoint offset;
		[Export ("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable tintColor;
		[NullAllowed, Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (assign, nonatomic) JDStatusBarNotificationLeftViewAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		JDStatusBarNotificationLeftViewAlignment Alignment { get; set; }
	}

	// @interface JDStatusBarNotificationTextStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface JDStatusBarNotificationTextStyle : INSCopying
	{
		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull font;
		[Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) __deprecated_msg("deprecated, use .shadowColor instead") UIColor * textShadowColor __attribute__((deprecated("deprecated, use .shadowColor instead")));
		[Export ("textShadowColor", ArgumentSemantic.Strong)]
		UIColor TextShadowColor { get; set; }

		// @property (assign, nonatomic) CGSize textShadowOffset __attribute__((deprecated("deprecated, use .shadowOffset instead")));
		[Export ("textShadowOffset", ArgumentSemantic.Assign)]
		CGSize TextShadowOffset { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable shadowColor;
		[NullAllowed, Export ("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (assign, nonatomic) CGPoint shadowOffset;
		[Export ("shadowOffset", ArgumentSemantic.Assign)]
		CGPoint ShadowOffset { get; set; }

		// @property (assign, nonatomic) CGFloat textOffsetY;
		[Export ("textOffsetY")]
		nfloat TextOffsetY { get; set; }
	}

	// @interface JDStatusBarNotificationPillStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface JDStatusBarNotificationPillStyle : INSCopying
	{
		// @property (assign, nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; set; }

		// @property (assign, nonatomic) CGFloat topSpacing;
		[Export ("topSpacing")]
		nfloat TopSpacing { get; set; }

		// @property (assign, nonatomic) CGFloat minimumWidth;
		[Export ("minimumWidth")]
		nfloat MinimumWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable borderColor;
		[NullAllowed, Export ("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable shadowColor;
		[NullAllowed, Export ("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (assign, nonatomic) CGFloat shadowRadius;
		[Export ("shadowRadius")]
		nfloat ShadowRadius { get; set; }

		// @property (assign, nonatomic) CGSize shadowOffset __attribute__((deprecated("deprecated, use .shadowOffsetXY instead")));
		[Export ("shadowOffset", ArgumentSemantic.Assign)]
		CGSize ShadowOffset { get; set; }

		// @property (assign, nonatomic) CGPoint shadowOffsetXY;
		[Export ("shadowOffsetXY", ArgumentSemantic.Assign)]
		CGPoint ShadowOffsetXY { get; set; }
	}

	// @interface JDStatusBarNotificationBackgroundStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface JDStatusBarNotificationBackgroundStyle : INSCopying
	{
		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (assign, nonatomic) JDStatusBarNotificationBackgroundType backgroundType;
		[Export ("backgroundType", ArgumentSemantic.Assign)]
		JDStatusBarNotificationBackgroundType BackgroundType { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationPillStyle * _Nonnull pillStyle;
		[Export ("pillStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationPillStyle PillStyle { get; set; }
	}

	// @interface JDStatusBarNotificationProgressBarStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface JDStatusBarNotificationProgressBarStyle : INSCopying
	{
		// @property (nonatomic, strong) UIColor * _Nullable barColor;
		[NullAllowed, Export ("barColor", ArgumentSemantic.Strong)]
		UIColor BarColor { get; set; }

		// @property (assign, nonatomic) CGFloat barHeight;
		[Export ("barHeight")]
		nfloat BarHeight { get; set; }

		// @property (assign, nonatomic) JDStatusBarNotificationProgressBarPosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		JDStatusBarNotificationProgressBarPosition Position { get; set; }

		// @property (assign, nonatomic) CGFloat horizontalInsets;
		[Export ("horizontalInsets")]
		nfloat HorizontalInsets { get; set; }

		// @property (assign, nonatomic) CGFloat offsetY;
		[Export ("offsetY")]
		nfloat OffsetY { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }
	}

	// typedef JDStatusBarNotificationStyle * _Nonnull (^JDStatusBarNotificationPresenterPrepareStyleBlock)(JDStatusBarNotificationStyle * _Nonnull);
	delegate JDStatusBarNotificationStyle JDStatusBarNotificationPresenterPrepareStyleBlock (JDStatusBarNotificationStyle arg0);

	// typedef NS_SWIFT_NAME(NotificationPresenterCompletion) void (^)(JDStatusBarNotificationPresenter * _Nonnull) JDStatusBarNotificationPresenterCompletionBlock;
	delegate void JDStatusBarNotificationPresenterCompletionBlock (JDStatusBarNotificationPresenter arg0);

	// @interface JDStatusBarNotificationPresenter : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface JDStatusBarNotificationPresenter
	{
		// +(instancetype _Nonnull)sharedPresenter;
		[Static]
		[Export ("sharedPresenter")]
		JDStatusBarNotificationPresenter SharedPresenter ();

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text __attribute__((swift_name("present(text:)")));
		[Export ("presentWithText:")]
		UIView PresentWithText (string text);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(text:completion:)")));
		[Export ("presentWithText:completion:")]
		UIView PresentWithText (string text, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(UIView * _Nonnull)presentWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(title:subtitle:completion:)")));
		[Export ("presentWithTitle:subtitle:completion:")]
		UIView PresentWithTitle (string title, [NullAllowed] string subtitle, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text dismissAfterDelay:(NSTimeInterval)delay __attribute__((swift_name("present(text:dismissAfterDelay:)")));
		[Export ("presentWithText:dismissAfterDelay:")]
		UIView PresentWithText (string text, double delay);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text customStyle:(NSString * _Nullable)styleName __attribute__((swift_name("present(text:customStyle:)")));
		[Export ("presentWithText:customStyle:")]
		UIView PresentWithText (string text, [NullAllowed] string styleName);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text customStyle:(NSString * _Nullable)styleName completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(text:customStyle:completion:)")));
		[Export ("presentWithText:customStyle:completion:")]
		UIView PresentWithText (string text, [NullAllowed] string styleName, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(UIView * _Nonnull)presentWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle customStyle:(NSString * _Nullable)styleName completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(title:subtitle:customStyle:completion:)")));
		[Export ("presentWithTitle:subtitle:customStyle:completion:")]
		UIView PresentWithTitle (string title, [NullAllowed] string subtitle, [NullAllowed] string styleName, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text dismissAfterDelay:(NSTimeInterval)delay customStyle:(NSString * _Nullable)styleName __attribute__((swift_name("present(text:dismissAfterDelay:customStyle:)")));
		[Export ("presentWithText:dismissAfterDelay:customStyle:")]
		UIView PresentWithText (string text, double delay, [NullAllowed] string styleName);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text includedStyle:(JDStatusBarNotificationIncludedStyle)includedStyle __attribute__((swift_name("present(text:includedStyle:)")));
		[Export ("presentWithText:includedStyle:")]
		UIView PresentWithText (string text, JDStatusBarNotificationIncludedStyle includedStyle);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text includedStyle:(JDStatusBarNotificationIncludedStyle)includedStyle completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(text:includedStyle:completion:)")));
		[Export ("presentWithText:includedStyle:completion:")]
		UIView PresentWithText (string text, JDStatusBarNotificationIncludedStyle includedStyle, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(UIView * _Nonnull)presentWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle includedStyle:(JDStatusBarNotificationIncludedStyle)includedStyle completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(title:subtitle:includedStyle:completion:)")));
		[Export ("presentWithTitle:subtitle:includedStyle:completion:")]
		UIView PresentWithTitle (string title, [NullAllowed] string subtitle, JDStatusBarNotificationIncludedStyle includedStyle, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)text dismissAfterDelay:(NSTimeInterval)delay includedStyle:(JDStatusBarNotificationIncludedStyle)includedStyle __attribute__((swift_name("present(text:dismissAfterDelay:includedStyle:)")));
		[Export ("presentWithText:dismissAfterDelay:includedStyle:")]
		UIView PresentWithText (string text, double delay, JDStatusBarNotificationIncludedStyle includedStyle);

		// -(UIView * _Nonnull)presentWithCustomView:(UIView * _Nonnull)customView styleName:(NSString * _Nullable)styleName completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("present(customView:style:completion:)")));
		[Export ("presentWithCustomView:styleName:completion:")]
		UIView PresentWithCustomView (UIView customView, [NullAllowed] string styleName, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();

		// -(void)dismissWithCompletion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("dismiss(completion:)")));
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion (JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(void)dismissAnimated:(BOOL)animated __attribute__((swift_name("dismiss(animated:)")));
		[Export ("dismissAnimated:")]
		void DismissAnimated (bool animated);

		// -(void)dismissAfterDelay:(NSTimeInterval)delay __attribute__((swift_name("dismiss(afterDelay:)")));
		[Export ("dismissAfterDelay:")]
		void DismissAfterDelay (double delay);

		// -(void)dismissAfterDelay:(NSTimeInterval)delay completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("dismiss(afterDelay:completion:)")));
		[Export ("dismissAfterDelay:completion:")]
		void DismissAfterDelay (double delay, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(void)updateDefaultStyle:(JDStatusBarNotificationPresenterPrepareStyleBlock _Nonnull)prepareBlock;
		[Export ("updateDefaultStyle:")]
		void UpdateDefaultStyle (JDStatusBarNotificationPresenterPrepareStyleBlock prepareBlock);

		// -(NSString * _Nonnull)addStyleNamed:(NSString * _Nonnull)styleName prepare:(JDStatusBarNotificationPresenterPrepareStyleBlock _Nonnull)prepareBlock __attribute__((swift_name("addStyle(styleName:prepare:)")));
		[Export ("addStyleNamed:prepare:")]
		string AddStyleNamed (string styleName, JDStatusBarNotificationPresenterPrepareStyleBlock prepareBlock);

		// -(NSString * _Nonnull)addStyleNamed:(NSString * _Nonnull)styleName basedOnStyle:(JDStatusBarNotificationIncludedStyle)basedOnStyle prepare:(JDStatusBarNotificationPresenterPrepareStyleBlock _Nonnull)prepareBlock __attribute__((swift_name("addStyle(styleName:basedOnIncludedStyle:prepare:)")));
		[Export ("addStyleNamed:basedOnStyle:prepare:")]
		string AddStyleNamed (string styleName, JDStatusBarNotificationIncludedStyle basedOnStyle, JDStatusBarNotificationPresenterPrepareStyleBlock prepareBlock);

		// -(void)displayProgressBarWithPercentage:(CGFloat)percentage __attribute__((swift_name("displayProgressBar(percentage:)")));
		[Export ("displayProgressBarWithPercentage:")]
		void DisplayProgressBarWithPercentage (nfloat percentage);

		// -(void)animateProgressBarToPercentage:(CGFloat)percentage animationDuration:(CGFloat)animationDuration completion:(JDStatusBarNotificationPresenterCompletionBlock)completion __attribute__((swift_name("animateProgressBar(toPercentage:animationDuration:completion:)")));
		[Export ("animateProgressBarToPercentage:animationDuration:completion:")]
		void AnimateProgressBarToPercentage (nfloat percentage, nfloat animationDuration, JDStatusBarNotificationPresenterCompletionBlock completion);

		// -(void)displayActivityIndicator:(BOOL)show;
		[Export ("displayActivityIndicator:")]
		void DisplayActivityIndicator (bool show);

		// -(void)displayLeftView:(UIView * _Nullable)leftView;
		[Export ("displayLeftView:")]
		void DisplayLeftView ([NullAllowed] UIView leftView);

		// -(void)updateText:(NSString * _Nonnull)text;
		[Export ("updateText:")]
		void UpdateText (string text);

		// -(void)updateSubtitle:(NSString * _Nullable)subtitle;
		[Export ("updateSubtitle:")]
		void UpdateSubtitle ([NullAllowed] string subtitle);

		// -(BOOL)isVisible;
		[Export ("isVisible")]
		bool IsVisible { get; }

		// -(void)setWindowScene:(UIWindowScene * _Nullable)windowScene;
		[Export ("setWindowScene:")]
		void SetWindowScene ([NullAllowed] UIWindowScene windowScene);
	}
}
