//
//  KYCImageConfig.h
//  SumSubstanceKYC
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <Foundation/Foundation.h>

static NSString * _Nonnull kINameDefaultPhotoFramePortrait = @"DEFAULT_PHOTO_FRAME_PORTRAIT";
static NSString * _Nonnull kINameDefaultPhotoFrameLandscape = @"DEFAULT_PHOTO_FRAME_LANDSCAPE";

@interface KYCImageConfig : NSObject

/**
*   -- Messages --
* bubbleIn - bubble for incoming message
* bubbleInGreen - bubble for acceptance incoming message
* bubbleOut - bubble for outgoing message
* declinedIcon - icon for messages reflecting declined document
* messageRead - delivery status - delivered
* messageSending - delivery status - not delivered
*   -- Action button --
* buttonBackground - background for UIControlStateNormal
* buttonPressed - background for UIControlStateHighlighted
*   -- Photo/Video --
* recordVideoButtonOuter - outer circle for video recording button
* takePhotoButtonOuter - outer circle for take photo button
* cameraButton - inner circle for take photo button
* flashOff - icon for disabled flash
* flashOn - icon for enabled flash
*   -- Liveness3D --
* liveness-fail-icon
* liveness-success-icon
* liveness-warning-icon
* liveness-logo
*   -- Support --
* emailIcon - email icon
* supportIcon - open support screen button
*   -- Term of service --
* gotItTick - icon for accepting ToS
*   -- Misc --
* playButton - play button on video preview
* accept - image on next/done/accept/etc button
* retake - image on retake button
* serverAvatar - avatar image for incoming messages
* backIndicator - back button for navigation bar
* DEFAULT_PHOTO_FRAME_PORTRAIT & DEFAULT_PHOTO_FRAME_LANDSCAPE - default frames for taking documents (nil image will remove blur effect all together)
*
*/
- (nullable UIImage *)imageForName:(nonnull NSString *)name;
@end
