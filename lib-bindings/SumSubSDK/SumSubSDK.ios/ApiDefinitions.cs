using System;
using Foundation;
using ObjCRuntime;
using SumSubstanceKYC;
using UIKit;

namespace SumSubstance.iOS
{
	// @interface SSFacade : NSObject
	[BaseType (typeof(NSObject))]
	interface SSFacade
	{
		// +(SSEngine * _Nullable)setupForApplicant:(NSString * _Nonnull)applicantID withToken:(NSString * _Nonnull)token locale:(NSString * _Nonnull)locale supportEmail:(NSString * _Nonnull)supportEmail baseUrl:(NSString * _Nonnull)baseUrl colorConfig:(__kindof KYCColorConfig * _Nullable)colorConfig imageConfig:(__kindof KYCImageConfig * _Nullable)imageConfig;
		[Static]
		[Export ("setupForApplicant:withToken:locale:supportEmail:baseUrl:colorConfig:imageConfig:")]
		[return: NullAllowed]
		SSEngine SetupForApplicant (string applicantID, string token, string locale, string supportEmail, string baseUrl, KYCColorConfig colorConfig, KYCImageConfig imageConfig);

		// +(SSEngine * _Nullable)setupForApplicant:(NSString * _Nonnull)applicantID withToken:(NSString * _Nonnull)token locale:(NSString * _Nonnull)locale supportEmail:(NSString * _Nonnull)supportEmail baseUrl:(NSString * _Nonnull)baseUrl colorConfig:(__kindof KYCColorConfig * _Nullable)colorConfig imageConfig:(__kindof KYCImageConfig * _Nullable)imageConfig settings:(__kindof KYCSettings * _Nullable)settings;
		[Static]
		[Export ("setupForApplicant:withToken:locale:supportEmail:baseUrl:colorConfig:imageConfig:settings:")]
		[return: NullAllowed]
		SSEngine SetupForApplicant (string applicantID, string token, string locale, string supportEmail, string baseUrl, KYCColorConfig colorConfig, KYCImageConfig imageConfig, KYCSettings settings);

		// +(UINavigationController * _Nullable)getChatControllerWithAttributedTitle:(NSAttributedString * _Nullable)title;
		[Static]
		[Export ("getChatControllerWithAttributedTitle:")]
		[return: NullAllowed]
		UINavigationController GetChatControllerWithAttributedTitle ([NullAllowed] NSAttributedString title);

		// +(NSString * _Nullable)sdkVersion;
		[Static]
		[NullAllowed, Export ("sdkVersion")]
		[Verify (MethodToProperty)]
		string SdkVersion { get; }
	}

	// @interface SSEngine : NSObject
	[BaseType (typeof(NSObject))]
	interface SSEngine
	{
		// @property (copy, nonatomic) void (^ _Nullable)(SSActionEventInfo * _Nonnull) onActionEvent;
		[NullAllowed, Export ("onActionEvent", ArgumentSemantic.Copy)]
		Action<SSActionEventInfo> OnActionEvent { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable (^ _Nullable)(NSString * _Nonnull, NSString * _Nullable, NSString * _Nonnull) onMissedLocalizedText;
		[NullAllowed, Export ("onMissedLocalizedText", ArgumentSemantic.Copy)]
		Func<NSString, NSString, NSString, NSString> OnMissedLocalizedText { get; set; }

		// +(void)setDebug:(_Bool)isEnabled;
		[Static]
		[Export ("setDebug:")]
		void SetDebug (bool isEnabled);

		// +(instancetype _Nonnull)instance;
		[Static]
		[Export ("instance")]
		SSEngine Instance ();

		// -(void)connectWithExpirationHandler:(void (^ _Nonnull)(void))tokenExpirationHandler verificationResultHandler:(void (^ _Nonnull)(_Bool))verificationResultHandler;
		[Export ("connectWithExpirationHandler:verificationResultHandler:")]
		void ConnectWithExpirationHandler (Action tokenExpirationHandler, Action<bool> verificationResultHandler);

		// -(void)setRefreshToken:(NSString * _Nonnull)newToken;
		[Export ("setRefreshToken:")]
		void SetRefreshToken (string newToken);

		// -(void)shutdown;
		[Export ("shutdown")]
		void Shutdown ();
	}

	// @interface KYCColorConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface KYCColorConfig
	{
		// @property (nonatomic) BOOL isDynamicsDisabledForDefaultColors;
		[Export ("isDynamicsDisabledForDefaultColors")]
		bool IsDynamicsDisabledForDefaultColors { get; set; }

		// -(void)configureStart;
		[Export ("configureStart")]
		void ConfigureStart ();

		// -(UIColor * _Nonnull)alertPositive;
		[Export ("alertPositive")]
		[Verify (MethodToProperty)]
		UIColor AlertPositive { get; }

		// -(UIColor * _Nonnull)alertNegative;
		[Export ("alertNegative")]
		[Verify (MethodToProperty)]
		UIColor AlertNegative { get; }

		// -(UIColor * _Nonnull)navigationTint;
		[Export ("navigationTint")]
		[Verify (MethodToProperty)]
		UIColor NavigationTint { get; }

		// -(UIColor * _Nonnull)navigationBarTint;
		[Export ("navigationBarTint")]
		[Verify (MethodToProperty)]
		UIColor NavigationBarTint { get; }

		// -(UIColor * _Nonnull)navigationTitleColor;
		[Export ("navigationTitleColor")]
		[Verify (MethodToProperty)]
		UIColor NavigationTitleColor { get; }

		// -(NSDictionary<NSAttributedStringKey,id> * _Nonnull)navigationTitleTextAttributes;
		[Export ("navigationTitleTextAttributes")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSObject> NavigationTitleTextAttributes { get; }

		// -(UIStatusBarStyle)preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle")]
		[Verify (MethodToProperty)]
		UIStatusBarStyle PreferredStatusBarStyle { get; }

		// -(UIColor * _Nonnull)supportBackground;
		[Export ("supportBackground")]
		[Verify (MethodToProperty)]
		UIColor SupportBackground { get; }

		// -(UIColor * _Nonnull)supportDivider;
		[Export ("supportDivider")]
		[Verify (MethodToProperty)]
		UIColor SupportDivider { get; }

		// -(UIColor * _Nonnull)supportSubtitle;
		[Export ("supportSubtitle")]
		[Verify (MethodToProperty)]
		UIColor SupportSubtitle { get; }

		// -(UIColor * _Nonnull)supportText;
		[Export ("supportText")]
		[Verify (MethodToProperty)]
		UIColor SupportText { get; }

		// -(UIColor * _Nonnull)supportIcon;
		[Export ("supportIcon")]
		[Verify (MethodToProperty)]
		UIColor SupportIcon { get; }

		// -(UIColor * _Nonnull)pickerBackground;
		[Export ("pickerBackground")]
		[Verify (MethodToProperty)]
		UIColor PickerBackground { get; }

		// -(UIColor * _Nonnull)pickerSearchBarTint;
		[Export ("pickerSearchBarTint")]
		[Verify (MethodToProperty)]
		UIColor PickerSearchBarTint { get; }

		// -(UIColor * _Nonnull)pickerSearchBarText;
		[Export ("pickerSearchBarText")]
		[Verify (MethodToProperty)]
		UIColor PickerSearchBarText { get; }

		// -(UIColor * _Nonnull)pickerHeaderPaneBackground;
		[Export ("pickerHeaderPaneBackground")]
		[Verify (MethodToProperty)]
		UIColor PickerHeaderPaneBackground { get; }

		// -(UIColor * _Nonnull)pickerHeaderBackground;
		[Export ("pickerHeaderBackground")]
		[Verify (MethodToProperty)]
		UIColor PickerHeaderBackground { get; }

		// -(UIColor * _Nonnull)pickerHeaderText;
		[Export ("pickerHeaderText")]
		[Verify (MethodToProperty)]
		UIColor PickerHeaderText { get; }

		// -(UIColor * _Nonnull)pickerItemBackground;
		[Export ("pickerItemBackground")]
		[Verify (MethodToProperty)]
		UIColor PickerItemBackground { get; }

		// -(UIColor * _Nonnull)pickerItemSelectedBackground;
		[Export ("pickerItemSelectedBackground")]
		[Verify (MethodToProperty)]
		UIColor PickerItemSelectedBackground { get; }

		// -(UIColor * _Nonnull)pickerItemText;
		[Export ("pickerItemText")]
		[Verify (MethodToProperty)]
		UIColor PickerItemText { get; }

		// -(UIColor * _Nonnull)chatBackground;
		[Export ("chatBackground")]
		[Verify (MethodToProperty)]
		UIColor ChatBackground { get; }

		// -(UIColor * _Nonnull)typingIndicatorColor;
		[Export ("typingIndicatorColor")]
		[Verify (MethodToProperty)]
		UIColor TypingIndicatorColor { get; }

		// -(UIColor * _Nonnull)actionButtonText;
		[Export ("actionButtonText")]
		[Verify (MethodToProperty)]
		UIColor ActionButtonText { get; }

		// -(UIColor * _Nonnull)actionButtonBackground;
		[Export ("actionButtonBackground")]
		[Verify (MethodToProperty)]
		UIColor ActionButtonBackground { get; }

		// -(UIColor * _Nonnull)actionButtonHighlightedBackground;
		[Export ("actionButtonHighlightedBackground")]
		[Verify (MethodToProperty)]
		UIColor ActionButtonHighlightedBackground { get; }

		// -(UIColor * _Nonnull)networkStateSpinner;
		[Export ("networkStateSpinner")]
		[Verify (MethodToProperty)]
		UIColor NetworkStateSpinner { get; }

		// -(UIColor * _Nonnull)networkStateText;
		[Export ("networkStateText")]
		[Verify (MethodToProperty)]
		UIColor NetworkStateText { get; }

		// -(UIColor * _Nonnull)incomingMessageBubble;
		[Export ("incomingMessageBubble")]
		[Verify (MethodToProperty)]
		UIColor IncomingMessageBubble { get; }

		// -(UIColor * _Nonnull)incomingMessageText;
		[Export ("incomingMessageText")]
		[Verify (MethodToProperty)]
		UIColor IncomingMessageText { get; }

		// -(UIColor * _Nonnull)incomingMessageTime;
		[Export ("incomingMessageTime")]
		[Verify (MethodToProperty)]
		UIColor IncomingMessageTime { get; }

		// -(UIColor * _Nonnull)acceptedMessageBubble;
		[Export ("acceptedMessageBubble")]
		[Verify (MethodToProperty)]
		UIColor AcceptedMessageBubble { get; }

		// -(UIColor * _Nonnull)acceptedMessageText;
		[Export ("acceptedMessageText")]
		[Verify (MethodToProperty)]
		UIColor AcceptedMessageText { get; }

		// -(UIColor * _Nonnull)acceptedMessageTime;
		[Export ("acceptedMessageTime")]
		[Verify (MethodToProperty)]
		UIColor AcceptedMessageTime { get; }

		// -(UIColor * _Nonnull)incomingMessageDeclinedText;
		[Export ("incomingMessageDeclinedText")]
		[Verify (MethodToProperty)]
		UIColor IncomingMessageDeclinedText { get; }

		// -(UIColor * _Nonnull)outgoingMessageBubble;
		[Export ("outgoingMessageBubble")]
		[Verify (MethodToProperty)]
		UIColor OutgoingMessageBubble { get; }

		// -(UIColor * _Nonnull)outgoingMessageText;
		[Export ("outgoingMessageText")]
		[Verify (MethodToProperty)]
		UIColor OutgoingMessageText { get; }

		// -(UIColor * _Nonnull)outgoingMessageTime;
		[Export ("outgoingMessageTime")]
		[Verify (MethodToProperty)]
		UIColor OutgoingMessageTime { get; }

		// -(UIColor * _Nonnull)previewBackground;
		[Export ("previewBackground")]
		[Verify (MethodToProperty)]
		UIColor PreviewBackground { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonBackground;
		[Export ("acceptAttachmentButtonBackground")]
		[Verify (MethodToProperty)]
		UIColor AcceptAttachmentButtonBackground { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonHighlighted;
		[Export ("acceptAttachmentButtonHighlighted")]
		[Verify (MethodToProperty)]
		UIColor AcceptAttachmentButtonHighlighted { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonText;
		[Export ("acceptAttachmentButtonText")]
		[Verify (MethodToProperty)]
		UIColor AcceptAttachmentButtonText { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonIcon;
		[Export ("acceptAttachmentButtonIcon")]
		[Verify (MethodToProperty)]
		UIColor AcceptAttachmentButtonIcon { get; }

		// -(UIColor * _Nonnull)retakeAttachmentButtonBackground;
		[Export ("retakeAttachmentButtonBackground")]
		[Verify (MethodToProperty)]
		UIColor RetakeAttachmentButtonBackground { get; }

		// -(UIColor * _Nonnull)retakeAttachmentButtonText;
		[Export ("retakeAttachmentButtonText")]
		[Verify (MethodToProperty)]
		UIColor RetakeAttachmentButtonText { get; }

		// -(UIColor * _Nonnull)retakeAttachmentButtonIcon;
		[Export ("retakeAttachmentButtonIcon")]
		[Verify (MethodToProperty)]
		UIColor RetakeAttachmentButtonIcon { get; }

		// -(UIColor * _Nonnull)uploadProgressBarBackground;
		[Export ("uploadProgressBarBackground")]
		[Verify (MethodToProperty)]
		UIColor UploadProgressBarBackground { get; }

		// -(UIColor * _Nonnull)cameraCancelText;
		[Export ("cameraCancelText")]
		[Verify (MethodToProperty)]
		UIColor CameraCancelText { get; }

		// -(UIColor * _Nonnull)cameraHintText;
		[Export ("cameraHintText")]
		[Verify (MethodToProperty)]
		UIColor CameraHintText { get; }

		// -(UIColor * _Nonnull)detectedDocumentBoundaries;
		[Export ("detectedDocumentBoundaries")]
		[Verify (MethodToProperty)]
		UIColor DetectedDocumentBoundaries { get; }

		// -(id<SSLiveness3DThemeProtocol> _Nonnull)liveness3dTheme;
		[Export ("liveness3dTheme")]
		[Verify (MethodToProperty)]
		SSLiveness3DThemeProtocol Liveness3dTheme { get; }

		// -(UIColor * _Nonnull)videoFaceDetected;
		[Export ("videoFaceDetected")]
		[Verify (MethodToProperty)]
		UIColor VideoFaceDetected { get; }

		// -(UIColor * _Nonnull)videoFaceNotDetected;
		[Export ("videoFaceNotDetected")]
		[Verify (MethodToProperty)]
		UIColor VideoFaceNotDetected { get; }

		// -(UIColor * _Nonnull)videoCoverBg;
		[Export ("videoCoverBg")]
		[Verify (MethodToProperty)]
		UIColor VideoCoverBg { get; }

		// -(UIColor * _Nonnull)videoLandmarks;
		[Export ("videoLandmarks")]
		[Verify (MethodToProperty)]
		UIColor VideoLandmarks { get; }

		// -(UIColor * _Nonnull)videoReadAloudLabelText;
		[Export ("videoReadAloudLabelText")]
		[Verify (MethodToProperty)]
		UIColor VideoReadAloudLabelText { get; }

		// -(UIColor * _Nonnull)videoHintLabelText;
		[Export ("videoHintLabelText")]
		[Verify (MethodToProperty)]
		UIColor VideoHintLabelText { get; }

		// -(UIColor * _Nonnull)videoPrepareRecording;
		[Export ("videoPrepareRecording")]
		[Verify (MethodToProperty)]
		UIColor VideoPrepareRecording { get; }

		// -(UIColor * _Nonnull)tosBackground;
		[Export ("tosBackground")]
		[Verify (MethodToProperty)]
		UIColor TosBackground { get; }

		// -(UIColor * _Nonnull)tosGotItBackground;
		[Export ("tosGotItBackground")]
		[Verify (MethodToProperty)]
		UIColor TosGotItBackground { get; }

		// -(UIColor * _Nonnull)tosGotItHighlighted;
		[Export ("tosGotItHighlighted")]
		[Verify (MethodToProperty)]
		UIColor TosGotItHighlighted { get; }

		// -(UIColor * _Nonnull)tosGotItText;
		[Export ("tosGotItText")]
		[Verify (MethodToProperty)]
		UIColor TosGotItText { get; }

		// -(UIColor * _Nonnull)tosGotItIcon;
		[Export ("tosGotItIcon")]
		[Verify (MethodToProperty)]
		UIColor TosGotItIcon { get; }
	}

	// @interface KYCImageConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface KYCImageConfig
	{
		// -(UIImage * _Nullable)imageForName:(NSString * _Nonnull)name;
		[Export ("imageForName:")]
		[return: NullAllowed]
		UIImage ImageForName (string name);
	}

	// @interface KYCSettings : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface KYCSettings : INSCoding
	{
		// @property (readonly, nonatomic) KYCSettings_Chat * _Nonnull chat;
		[Export ("chat")]
		KYCSettings_Chat Chat { get; }

		// @property (readonly, nonatomic) KYCSettings_Document * _Nonnull document;
		[Export ("document")]
		KYCSettings_Document Document { get; }

		// @property (readonly, nonatomic) KYCSettings_Liveness * _Nonnull liveness;
		[Export ("liveness")]
		KYCSettings_Liveness Liveness { get; }

		// +(instancetype _Nullable)create:(void (^ _Nullable)(KYCSettings * _Nullable))configure;
		[Static]
		[Export ("create:")]
		[return: NullAllowed]
		KYCSettings Create ([NullAllowed] Action<KYCSettings> configure);
	}

	// @interface KYCSettings_Chat : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface KYCSettings_Chat : INSCoding
	{
		// @property (nonatomic) BOOL reportNetworkState;
		[Export ("reportNetworkState")]
		bool ReportNetworkState { get; set; }

		// @property (nonatomic) BOOL quickStart;
		[Export ("quickStart")]
		bool QuickStart { get; set; }

		// @property (nonatomic) BOOL startFromTop;
		[Export ("startFromTop")]
		bool StartFromTop { get; set; }

		// @property (nonatomic) BOOL showCloseAction;
		[Export ("showCloseAction")]
		bool ShowCloseAction { get; set; }
	}

	// @interface KYCSettings_Document : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface KYCSettings_Document : INSCoding
	{
		// @property (getter = isAutoCaptureDisabled, nonatomic) BOOL autoCaptureDisabled;
		[Export ("autoCaptureDisabled")]
		bool AutoCaptureDisabled { [Bind ("isAutoCaptureDisabled")] get; set; }
	}

	// @interface KYCSettings_Liveness : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface KYCSettings_Liveness : INSCoding
	{
		// @property (getter = isFaceTrackingDisabled, nonatomic) BOOL faceTrackingDisabled;
		[Export ("faceTrackingDisabled")]
		bool FaceTrackingDisabled { [Bind ("isFaceTrackingDisabled")] get; set; }
	}

	// @interface SSActionEventInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface SSActionEventInfo
	{
		// @property (readonly, nonatomic) NSString * _Nullable flowStep;
		[NullAllowed, Export ("flowStep")]
		string FlowStep { get; }
	}
}
