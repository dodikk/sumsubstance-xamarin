//
//  SSEngine.h
//  SumSubstanceKYC
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@class SSActionEventInfo;

@interface SSEngine : NSObject

/*!
 Called on every incoming event of action type
 */
@property (nonatomic, copy) void (^ __nullable onActionEvent)(SSActionEventInfo *info);

/*!
 Called when the engine fails to find the remotely configured localization for a localizable key.
 
 Note: always happens for new applicants with the key "status_connecting" and possibly "status_waiting_for_network" until socket is connected
 */
@property (nonatomic, copy) NSString * __nullable(^ __nullable onMissedLocalizedText)(NSString *key, NSString * __nullable lang, NSString *locale);


+ (void)setDebug:(bool)isEnabled;

+ (instancetype)instance;

- (void)connectWithExpirationHandler:(void (^)(void))tokenExpirationHandler
           verificationResultHandler:(void (^)(bool verified))verificationResultHandler;

- (void)setRefreshToken:(NSString *)newToken;

- (void)shutdown;

@end

NS_ASSUME_NONNULL_END
