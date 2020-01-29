using System;
using Foundation;
using ObjCRuntime;
// using SumSubstanceKYC;
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
		UIColor AlertPositive { get; }

		// -(UIColor * _Nonnull)alertNegative;
		[Export ("alertNegative")]
		UIColor AlertNegative { get; }

		// -(UIColor * _Nonnull)navigationTint;
		[Export ("navigationTint")]
		UIColor NavigationTint { get; }

		// -(UIColor * _Nonnull)navigationBarTint;
		[Export ("navigationBarTint")]
		UIColor NavigationBarTint { get; }

		// -(UIColor * _Nonnull)navigationTitleColor;
		[Export ("navigationTitleColor")]
		UIColor NavigationTitleColor { get; }

		// -(NSDictionary<NSAttributedStringKey,id> * _Nonnull)navigationTitleTextAttributes;
		[Export ("navigationTitleTextAttributes")]
		NSDictionary<NSString, NSObject> NavigationTitleTextAttributes { get; }

		// -(UIStatusBarStyle)preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; }

		// -(UIColor * _Nonnull)supportBackground;
		[Export ("supportBackground")]
		UIColor SupportBackground { get; }

		// -(UIColor * _Nonnull)supportDivider;
		[Export ("supportDivider")]
		UIColor SupportDivider { get; }

		// -(UIColor * _Nonnull)supportSubtitle;
		[Export ("supportSubtitle")]
		UIColor SupportSubtitle { get; }

		// -(UIColor * _Nonnull)supportText;
		[Export ("supportText")]
		UIColor SupportText { get; }

		// -(UIColor * _Nonnull)supportIcon;
		[Export ("supportIcon")]
		UIColor SupportIcon { get; }

		// -(UIColor * _Nonnull)pickerBackground;
		[Export ("pickerBackground")]
		UIColor PickerBackground { get; }

		// -(UIColor * _Nonnull)pickerSearchBarTint;
		[Export ("pickerSearchBarTint")]
		UIColor PickerSearchBarTint { get; }

		// -(UIColor * _Nonnull)pickerSearchBarText;
		[Export ("pickerSearchBarText")]
		UIColor PickerSearchBarText { get; }

		// -(UIColor * _Nonnull)pickerHeaderPaneBackground;
		[Export ("pickerHeaderPaneBackground")]
		UIColor PickerHeaderPaneBackground { get; }

		// -(UIColor * _Nonnull)pickerHeaderBackground;
		[Export ("pickerHeaderBackground")]
		UIColor PickerHeaderBackground { get; }

		// -(UIColor * _Nonnull)pickerHeaderText;
		[Export ("pickerHeaderText")]
		UIColor PickerHeaderText { get; }

		// -(UIColor * _Nonnull)pickerItemBackground;
		[Export ("pickerItemBackground")]
		UIColor PickerItemBackground { get; }

		// -(UIColor * _Nonnull)pickerItemSelectedBackground;
		[Export ("pickerItemSelectedBackground")]
		UIColor PickerItemSelectedBackground { get; }

		// -(UIColor * _Nonnull)pickerItemText;
		[Export ("pickerItemText")]
		UIColor PickerItemText { get; }

		// -(UIColor * _Nonnull)chatBackground;
		[Export ("chatBackground")]
		UIColor ChatBackground { get; }

		// -(UIColor * _Nonnull)typingIndicatorColor;
		[Export ("typingIndicatorColor")]
		UIColor TypingIndicatorColor { get; }

		// -(UIColor * _Nonnull)actionButtonText;
		[Export ("actionButtonText")]
		UIColor ActionButtonText { get; }

		// -(UIColor * _Nonnull)actionButtonBackground;
		[Export ("actionButtonBackground")]
		UIColor ActionButtonBackground { get; }

		// -(UIColor * _Nonnull)actionButtonHighlightedBackground;
		[Export ("actionButtonHighlightedBackground")]
		UIColor ActionButtonHighlightedBackground { get; }

		// -(UIColor * _Nonnull)networkStateSpinner;
		[Export ("networkStateSpinner")]
		UIColor NetworkStateSpinner { get; }

		// -(UIColor * _Nonnull)networkStateText;
		[Export ("networkStateText")]
		UIColor NetworkStateText { get; }

		// -(UIColor * _Nonnull)incomingMessageBubble;
		[Export ("incomingMessageBubble")]
		UIColor IncomingMessageBubble { get; }

		// -(UIColor * _Nonnull)incomingMessageText;
		[Export ("incomingMessageText")]
		UIColor IncomingMessageText { get; }

		// -(UIColor * _Nonnull)incomingMessageTime;
		[Export ("incomingMessageTime")]
		UIColor IncomingMessageTime { get; }

		// -(UIColor * _Nonnull)acceptedMessageBubble;
		[Export ("acceptedMessageBubble")]
		UIColor AcceptedMessageBubble { get; }

		// -(UIColor * _Nonnull)acceptedMessageText;
		[Export ("acceptedMessageText")]
		UIColor AcceptedMessageText { get; }

		// -(UIColor * _Nonnull)acceptedMessageTime;
		[Export ("acceptedMessageTime")]
		UIColor AcceptedMessageTime { get; }

		// -(UIColor * _Nonnull)incomingMessageDeclinedText;
		[Export ("incomingMessageDeclinedText")]
		UIColor IncomingMessageDeclinedText { get; }

		// -(UIColor * _Nonnull)outgoingMessageBubble;
		[Export ("outgoingMessageBubble")]
		UIColor OutgoingMessageBubble { get; }

		// -(UIColor * _Nonnull)outgoingMessageText;
		[Export ("outgoingMessageText")]
		UIColor OutgoingMessageText { get; }

		// -(UIColor * _Nonnull)outgoingMessageTime;
		[Export ("outgoingMessageTime")]
		UIColor OutgoingMessageTime { get; }

		// -(UIColor * _Nonnull)previewBackground;
		[Export ("previewBackground")]
		UIColor PreviewBackground { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonBackground;
		[Export ("acceptAttachmentButtonBackground")]
		UIColor AcceptAttachmentButtonBackground { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonHighlighted;
		[Export ("acceptAttachmentButtonHighlighted")]
		UIColor AcceptAttachmentButtonHighlighted { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonText;
		[Export ("acceptAttachmentButtonText")]
		UIColor AcceptAttachmentButtonText { get; }

		// -(UIColor * _Nonnull)acceptAttachmentButtonIcon;
		[Export ("acceptAttachmentButtonIcon")]
		UIColor AcceptAttachmentButtonIcon { get; }

		// -(UIColor * _Nonnull)retakeAttachmentButtonBackground;
		[Export ("retakeAttachmentButtonBackground")]
		UIColor RetakeAttachmentButtonBackground { get; }

		// -(UIColor * _Nonnull)retakeAttachmentButtonText;
		[Export ("retakeAttachmentButtonText")]
		UIColor RetakeAttachmentButtonText { get; }

		// -(UIColor * _Nonnull)retakeAttachmentButtonIcon;
		[Export ("retakeAttachmentButtonIcon")]
		UIColor RetakeAttachmentButtonIcon { get; }

		// -(UIColor * _Nonnull)uploadProgressBarBackground;
		[Export ("uploadProgressBarBackground")]
		UIColor UploadProgressBarBackground { get; }

		// -(UIColor * _Nonnull)cameraCancelText;
		[Export ("cameraCancelText")]
		UIColor CameraCancelText { get; }

		// -(UIColor * _Nonnull)cameraHintText;
		[Export ("cameraHintText")]
		UIColor CameraHintText { get; }

		// -(UIColor * _Nonnull)detectedDocumentBoundaries;
		[Export ("detectedDocumentBoundaries")]
		UIColor DetectedDocumentBoundaries { get; }

        // -(id<SSLiveness3DThemeProtocol> _Nonnull)liveness3dTheme;
        //[Export ("liveness3dTheme")]
        //[Verify (MethodToProperty)]
        //SSLiveness3DThemeProtocol Liveness3dTheme { get; }

        // TODO: [alex-d] uncomment Liveness3dTheme property if needed
        // Note: another binding project might be required for that
        // -

        // -(UIColor * _Nonnull)videoFaceDetected;
        [Export ("videoFaceDetected")]
		UIColor VideoFaceDetected { get; }

		// -(UIColor * _Nonnull)videoFaceNotDetected;
		[Export ("videoFaceNotDetected")]
		UIColor VideoFaceNotDetected { get; }

		// -(UIColor * _Nonnull)videoCoverBg;
		[Export ("videoCoverBg")]
		UIColor VideoCoverBg { get; }

		// -(UIColor * _Nonnull)videoLandmarks;
		[Export ("videoLandmarks")]
		UIColor VideoLandmarks { get; }

		// -(UIColor * _Nonnull)videoReadAloudLabelText;
		[Export ("videoReadAloudLabelText")]
		UIColor VideoReadAloudLabelText { get; }

		// -(UIColor * _Nonnull)videoHintLabelText;
		[Export ("videoHintLabelText")]
		UIColor VideoHintLabelText { get; }

		// -(UIColor * _Nonnull)videoPrepareRecording;
		[Export ("videoPrepareRecording")]
		UIColor VideoPrepareRecording { get; }

		// -(UIColor * _Nonnull)tosBackground;
		[Export ("tosBackground")]
		UIColor TosBackground { get; }

		// -(UIColor * _Nonnull)tosGotItBackground;
		[Export ("tosGotItBackground")]
		UIColor TosGotItBackground { get; }

		// -(UIColor * _Nonnull)tosGotItHighlighted;
		[Export ("tosGotItHighlighted")]
		UIColor TosGotItHighlighted { get; }

		// -(UIColor * _Nonnull)tosGotItText;
		[Export ("tosGotItText")]
		UIColor TosGotItText { get; }

		// -(UIColor * _Nonnull)tosGotItIcon;
		[Export ("tosGotItIcon")]
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
