//
//  SSFacade.h
//  SumSubstanceKYC
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <UIKit/UIKit.h>

@class SSEngine;
@class KYCColorConfig;
@class KYCImageConfig;
@class KYCSettings;

NS_ASSUME_NONNULL_BEGIN

@interface SSFacade : NSObject

+ (nullable SSEngine *)setupForApplicant:(NSString *)applicantID
                               withToken:(NSString *)token
                                  locale:(NSString *)locale
                            supportEmail:(NSString *)supportEmail
                                 baseUrl:(NSString *)baseUrl
                             colorConfig:(nullable __kindof KYCColorConfig *)colorConfig
                             imageConfig:(nullable __kindof KYCImageConfig *)imageConfig;

+ (nullable SSEngine *)setupForApplicant:(NSString *)applicantID
                               withToken:(NSString *)token
                                  locale:(NSString *)locale
                            supportEmail:(NSString *)supportEmail
                                 baseUrl:(NSString *)baseUrl
                             colorConfig:(nullable __kindof KYCColorConfig *)colorConfig
                             imageConfig:(nullable __kindof KYCImageConfig *)imageConfig
                                settings:(nullable __kindof KYCSettings *)settings;

+ (nullable UINavigationController *)getChatControllerWithAttributedTitle:(nullable NSAttributedString *)title;

+ (nullable NSString *)sdkVersion;

@end

NS_ASSUME_NONNULL_END
