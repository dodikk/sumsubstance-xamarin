//
//  KYCColorConfig.h
//  SumSubstanceKYC
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol SSLiveness3DThemeProtocol;

NS_ASSUME_NONNULL_BEGIN

@interface KYCColorConfig : NSObject

@property (nonatomic) BOOL isDynamicsDisabledForDefaultColors;

- (void)configureStart;

#pragma mark - Alert colors
/// Title color for button with UIAlertActionStyleDefault
- (UIColor *)alertPositive;
/// Title color for button with UIAlertActionStyleCancel
- (UIColor *)alertNegative;

#pragma mark - Navigation bar
/// See -[UINavigationBar tintColor]
- (UIColor *)navigationTint;
/// See -[UINavigationBar barTintColor]
- (UIColor *)navigationBarTint;
/// An optional helper to construct titleTextAttributes
- (UIColor *)navigationTitleColor;
/// See -[UINavigationBar titleTextAttributes]
- (NSDictionary<NSAttributedStringKey, id> *)navigationTitleTextAttributes;

#pragma mark - Status bar
- (UIStatusBarStyle)preferredStatusBarStyle;

#pragma mark - Support scene
- (UIColor *)supportBackground;
- (UIColor *)supportDivider;
- (UIColor *)supportSubtitle;
- (UIColor *)supportText;
- (UIColor *)supportIcon;

#pragma mark - Picker scene
- (UIColor *)pickerBackground;
- (UIColor *)pickerSearchBarTint;
- (UIColor *)pickerSearchBarText;
- (UIColor *)pickerHeaderPaneBackground;
- (UIColor *)pickerHeaderBackground;
- (UIColor *)pickerHeaderText;
- (UIColor *)pickerItemBackground;
- (UIColor *)pickerItemSelectedBackground;
- (UIColor *)pickerItemText;

#pragma mark - Chat scene | Messages
- (UIColor *)chatBackground;
- (UIColor *)typingIndicatorColor;

/// Color for text on action buttons displayed with last incoming message in chat
- (UIColor *)actionButtonText;
- (UIColor *)actionButtonBackground;
- (UIColor *)actionButtonHighlightedBackground;

#pragma mark Network states
- (UIColor *)networkStateSpinner;
- (UIColor *)networkStateText;

#pragma mark Incoming message
- (UIColor *)incomingMessageBubble;
- (UIColor *)incomingMessageText;
- (UIColor *)incomingMessageTime;

// Colors for final incoming message of successful verification
#pragma mark Acceptance message
- (UIColor *)acceptedMessageBubble;
- (UIColor *)acceptedMessageText;
- (UIColor *)acceptedMessageTime;

#pragma mark Declined document message
/// Color of "Declined" label
- (UIColor *)incomingMessageDeclinedText;

#pragma mark Outcoming message
- (UIColor *)outgoingMessageBubble;
- (UIColor *)outgoingMessageText;
- (UIColor *)outgoingMessageTime;

#pragma mark - Preview Scene
- (UIColor *)previewBackground;

/// Button for accepting taken photo/video,
#pragma mark Accept attachment button
- (UIColor *)acceptAttachmentButtonBackground;
- (UIColor *)acceptAttachmentButtonHighlighted;
- (UIColor *)acceptAttachmentButtonText;
- (UIColor *)acceptAttachmentButtonIcon;

/// Button for retaking taken photo/video,
#pragma mark Retake attachment button
- (UIColor *)retakeAttachmentButtonBackground;
- (UIColor *)retakeAttachmentButtonText;
- (UIColor *)retakeAttachmentButtonIcon;

#pragma mark
- (UIColor *)uploadProgressBarBackground;
- (UIColor *)cameraCancelText;
- (UIColor *)cameraHintText;
/// Quadrangle around document boundaries on live preview camera
- (UIColor *)detectedDocumentBoundaries;

#pragma mark - Liveness3D
- (id<SSLiveness3DThemeProtocol>)liveness3dTheme;

#pragma mark - Video scene
#pragma mark Face
/// Oval color when face inside
- (UIColor *)videoFaceDetected;
/// Oval color when face isn't inside
- (UIColor *)videoFaceNotDetected;
- (UIColor *)videoCoverBg;

#pragma mark Texts
/// Points around detected face
- (UIColor *)videoLandmarks;
/// Text to read aloud when recording
- (UIColor *)videoReadAloudLabelText;
- (UIColor *)videoHintLabelText;
- (UIColor *)videoPrepareRecording;

#pragma mark - Terms of service button
- (UIColor *)tosBackground;
- (UIColor *)tosGotItBackground;
- (UIColor *)tosGotItHighlighted;
- (UIColor *)tosGotItText;
- (UIColor *)tosGotItIcon;

@end

NS_ASSUME_NONNULL_END
