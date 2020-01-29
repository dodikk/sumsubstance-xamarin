using System;
using Foundation;
using ObjCRuntime;
using SumSubstanceKYC_Liveness3D;
using UIKit;

namespace SumSubstance.Liveness3D.iOS
{
	// @protocol SSLiveness3DThemeProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SSLiveness3DThemeProtocol
	{
		// @optional -(UIColor *)mainBgColor;
		[Export ("mainBgColor")]
		[Verify (MethodToProperty)]
		UIColor MainBgColor { get; }

		// @optional -(UIColor *)titleColor;
		[Export ("titleColor")]
		[Verify (MethodToProperty)]
		UIColor TitleColor { get; }

		// @optional -(UIColor *)statusColor;
		[Export ("statusColor")]
		[Verify (MethodToProperty)]
		UIColor StatusColor { get; }

		// @optional -(UIColor *)actionButtonColor;
		[Export ("actionButtonColor")]
		[Verify (MethodToProperty)]
		UIColor ActionButtonColor { get; }

		// @optional -(UIColor *)cancelButtonColor;
		[Export ("cancelButtonColor")]
		[Verify (MethodToProperty)]
		UIColor CancelButtonColor { get; }

		// @optional -(UIColor *)retryBgColor;
		[Export ("retryBgColor")]
		[Verify (MethodToProperty)]
		UIColor RetryBgColor { get; }

		// @optional -(NSArray<UIColor *> *)retryBgGradientColors;
		[Export ("retryBgGradientColors")]
		[Verify (MethodToProperty)]
		UIColor[] RetryBgGradientColors { get; }

		// @optional -(UIColor *)retryBorderColor;
		[Export ("retryBorderColor")]
		[Verify (MethodToProperty)]
		UIColor RetryBorderColor { get; }

		// @optional -(UIColor *)retryTitleColor;
		[Export ("retryTitleColor")]
		[Verify (MethodToProperty)]
		UIColor RetryTitleColor { get; }

		// @optional -(UIColor *)retryTextColor;
		[Export ("retryTextColor")]
		[Verify (MethodToProperty)]
		UIColor RetryTextColor { get; }

		// @optional -(UIColor *)retryButtonColor;
		[Export ("retryButtonColor")]
		[Verify (MethodToProperty)]
		UIColor RetryButtonColor { get; }

		// @optional -(UIColor *)retryButtonHighlightColor;
		[Export ("retryButtonHighlightColor")]
		[Verify (MethodToProperty)]
		UIColor RetryButtonHighlightColor { get; }

		// @optional -(NSArray<UIColor *> *)zoomMainGradientColors;
		[Export ("zoomMainGradientColors")]
		[Verify (MethodToProperty)]
		UIColor[] ZoomMainGradientColors { get; }

		// @optional -(UIColor *)zoomMainForegroundColor;
		[Export ("zoomMainForegroundColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomMainForegroundColor { get; }

		// @optional -(UIColor *)zoomFrameBackgroundColor;
		[Export ("zoomFrameBackgroundColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomFrameBackgroundColor { get; }

		// @optional -(UIColor *)zoomFrameBorderColor;
		[Export ("zoomFrameBorderColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomFrameBorderColor { get; }

		// @optional -(UIColor *)zoomButtonColor;
		[Export ("zoomButtonColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomButtonColor { get; }

		// @optional -(UIColor *)zoomButtonHighlightColor;
		[Export ("zoomButtonHighlightColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomButtonHighlightColor { get; }

		// @optional -(UIColor *)zoomProgressColor;
		[Export ("zoomProgressColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomProgressColor { get; }

		// @optional -(UIColor *)zoomOvalBorderColor;
		[Export ("zoomOvalBorderColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomOvalBorderColor { get; }

		// @optional -(NSArray<UIColor *> *)zoomFeedbackGradientColors;
		[Export ("zoomFeedbackGradientColors")]
		[Verify (MethodToProperty)]
		UIColor[] ZoomFeedbackGradientColors { get; }

		// @optional -(UIColor *)zoomFeedbackTextColor;
		[Export ("zoomFeedbackTextColor")]
		[Verify (MethodToProperty)]
		UIColor ZoomFeedbackTextColor { get; }
	}

	// @interface SSLiveness3DResult : NSObject
	[BaseType (typeof(NSObject))]
	interface SSLiveness3DResult
	{
		// @property (copy, nonatomic) NSString * _Nullable applicantActionId;
		[NullAllowed, Export ("applicantActionId")]
		string ApplicantActionId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable reviewAnswer;
		[NullAllowed, Export ("reviewAnswer")]
		string ReviewAnswer { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable rejectLabels;
		[NullAllowed, Export ("rejectLabels", ArgumentSemantic.Copy)]
		string[] RejectLabels { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable livenessCheckAnswer;
		[NullAllowed, Export ("livenessCheckAnswer")]
		string LivenessCheckAnswer { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable livenessRetrySuggestion;
		[NullAllowed, Export ("livenessRetrySuggestion")]
		string LivenessRetrySuggestion { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable faceMatchCheckAnswer;
		[NullAllowed, Export ("faceMatchCheckAnswer")]
		string FaceMatchCheckAnswer { get; set; }
	}

	// typedef void (^SSLiveness3DResultHandler)(SSLiveness3DResult * _Nonnull, void (^ _Nonnull)(BOOL));
	delegate void SSLiveness3DResultHandler (SSLiveness3DResult arg0, Action<bool> arg1);

	// typedef void (^SSLiveness3DTokenExpirationHandler)(void (^ _Nonnull)(NSString * _Nullable));
	delegate void SSLiveness3DTokenExpirationHandler (Action<NSString> arg0);

	// typedef void (^SSLiveness3DCompletionHandler)(UIViewController * _Nonnull, SSLiveness3DStatus, SSLiveness3DResult * _Nullable);
	delegate void SSLiveness3DCompletionHandler (UIViewController arg0, SSLiveness3DStatus arg1, [NullAllowed] SSLiveness3DResult arg2);

	// typedef NSString * _Nullable (^SSLiveness3DTextHandler)(NSString * _Nonnull, NSString * _Nonnull);
	delegate string SSLiveness3DTextHandler (string arg0, string arg1);

	// typedef UIImage * _Nullable (^SSLiveness3DImageHandler)(NSString * _Nonnull);
	delegate UIImage SSLiveness3DImageHandler (string arg0);

	// @interface SSLiveness3D : NSObject
	[BaseType (typeof(NSObject))]
	interface SSLiveness3D
	{
		// +(NSString * _Nonnull)descriptionForStatus:(SSLiveness3DStatus)status;
		[Static]
		[Export ("descriptionForStatus:")]
		string DescriptionForStatus (SSLiveness3DStatus status);

		// @property (copy, nonatomic) NSString * _Nullable applicantId;
		[NullAllowed, Export ("applicantId")]
		string ApplicantId { get; set; }

		// @property (copy, nonatomic) SSLiveness3DResultHandler _Nullable resultHandler;
		[NullAllowed, Export ("resultHandler", ArgumentSemantic.Copy)]
		SSLiveness3DResultHandler ResultHandler { get; set; }

		// @property (copy, nonatomic) SSLiveness3DTextHandler _Nullable textHandler;
		[NullAllowed, Export ("textHandler", ArgumentSemantic.Copy)]
		SSLiveness3DTextHandler TextHandler { get; set; }

		// @property (copy, nonatomic) SSLiveness3DImageHandler _Nullable imageHandler;
		[NullAllowed, Export ("imageHandler", ArgumentSemantic.Copy)]
		SSLiveness3DImageHandler ImageHandler { get; set; }

		// @property (nonatomic) id<SSLiveness3DThemeProtocol> _Nonnull theme;
		[Export ("theme", ArgumentSemantic.Assign)]
		SSLiveness3DThemeProtocol Theme { get; set; }

		// @property (nonatomic) BOOL shouldCompleteOnFaceMismatch;
		[Export ("shouldCompleteOnFaceMismatch")]
		bool ShouldCompleteOnFaceMismatch { get; set; }

		// -(instancetype _Nonnull)initWithBaseUrl:(NSString * _Nonnull)baseUrl applicantId:(NSString * _Nonnull)applicantId token:(NSString * _Nonnull)token locale:(NSString * _Nonnull)locale tokenExpirationHandler:(SSLiveness3DTokenExpirationHandler _Nonnull)tokenExpirationHandler completionHandler:(SSLiveness3DCompletionHandler _Nonnull)completionHandler;
		[Export ("initWithBaseUrl:applicantId:token:locale:tokenExpirationHandler:completionHandler:")]
		IntPtr Constructor (string baseUrl, string applicantId, string token, string locale, SSLiveness3DTokenExpirationHandler tokenExpirationHandler, SSLiveness3DCompletionHandler completionHandler);

		// -(UIViewController * _Nonnull)getController;
		[Export ("getController")]
		[Verify (MethodToProperty)]
		UIViewController Controller { get; }
	}
}
