//
//  KYCSettings.h
//  SumSubstanceKYC
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <Foundation/Foundation.h>

@class KYCSettings_Chat;
@class KYCSettings_Document;
@class KYCSettings_Liveness;

NS_ASSUME_NONNULL_BEGIN

@interface KYCSettings : NSObject <NSCoding>

/*!
 Chat settings
 */
@property (nonatomic, readonly) KYCSettings_Chat *chat;

/*!
 Document settings
 */
@property (nonatomic, readonly) KYCSettings_Document *document;

/*!
 Liveness settings
 */
@property (nonatomic, readonly) KYCSettings_Liveness *liveness;

/*!
 Creates an instance populated with default settings
 @param configure an optional block that takes the created instance as a parameter and give a chance to modify the settings before return
 @return KYCSettings object
 */
+ (instancetype _Nullable)create:(void(^ _Nullable)(KYCSettings * _Nullable settings))configure;

@end

#pragma mark -

@interface KYCSettings_Chat : NSObject <NSCoding>

/*!
 Display network-related states in the navigation bar (default is YES)
 */
@property (nonatomic) BOOL reportNetworkState;

/*!
 Display initial messages as quick as possible, without typing indicatior (default is YES)
 */
@property (nonatomic) BOOL quickStart;

/*!
 Start display messages from the top of the screen (default is NO)
 */
@property (nonatomic) BOOL startFromTop;

/*!
 Display Close button when all documents are sent and when verification is finished
 */
@property (nonatomic) BOOL showCloseAction;

@end

#pragma mark -

@interface KYCSettings_Document : NSObject <NSCoding>

/*!
 Disables document auto capture (default is NO)
 */
@property (nonatomic, getter=isAutoCaptureDisabled) BOOL autoCaptureDisabled;

@end

#pragma mark -

@interface KYCSettings_Liveness : NSObject <NSCoding>

/*!
 Disables face tracking during Liveness check (default is NO)
 */
@property (nonatomic, getter=isFaceTrackingDisabled) BOOL faceTrackingDisabled;

@end

NS_ASSUME_NONNULL_END
