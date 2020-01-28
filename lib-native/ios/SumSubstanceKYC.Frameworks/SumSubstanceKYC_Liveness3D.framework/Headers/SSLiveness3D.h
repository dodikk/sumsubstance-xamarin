//
//  SSLiveness3D.h
//  SumSubstanceKYC_Liveness3D
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "SSLiveness3DThemeProtocol.h"
#import "SSLiveness3DResult.h"

typedef NS_ENUM(NSInteger, SSLiveness3DStatus) {
    SSLiveness3DStatus_Cancelled,
    SSLiveness3DStatus_InitializationFailed,
    SSLiveness3DStatus_CameraPermissionDenied,
    SSLiveness3DStatus_TokenIsInvalid,
    SSLiveness3DStatus_FaceMismatched,
    SSLiveness3DStatus_VerificationPassedSuccessfully,
};

@class SSLiveness3D;

NS_ASSUME_NONNULL_BEGIN

typedef void(^SSLiveness3DResultHandler)(SSLiveness3DResult *result, void(^completionHandler)(BOOL stopProcessing));
typedef void(^SSLiveness3DTokenExpirationHandler)(void(^completionHandler)(NSString * __nullable newToken));
typedef void(^SSLiveness3DCompletionHandler)(UIViewController *controller, SSLiveness3DStatus status, SSLiveness3DResult * __nullable result);
typedef NSString * __nullable(^SSLiveness3DTextHandler)(NSString *key, NSString *locale);
typedef UIImage * __nullable(^SSLiveness3DImageHandler)(NSString *key);

#pragma mark -

@interface SSLiveness3D : NSObject

+ (NSString *)descriptionForStatus:(SSLiveness3DStatus)status;

@property (nonatomic, copy) NSString * __nullable applicantId;

/*!
 Optional asynchronous handler to be called right after a new result is got from the server.
 Must call `completionHandler` passed with a boolean parameter.
 Pass `YES` to stop further processing.
 */
@property (nonatomic, copy) SSLiveness3DResultHandler __nullable resultHandler;
@property (nonatomic, copy) SSLiveness3DTextHandler __nullable textHandler;
@property (nonatomic, copy) SSLiveness3DImageHandler __nullable imageHandler;
@property (nonatomic) id<SSLiveness3DThemeProtocol> theme;

@property (nonatomic) BOOL shouldCompleteOnFaceMismatch;

- (instancetype)initWithBaseUrl:(NSString *)baseUrl
                    applicantId:(NSString *)applicantId
                          token:(NSString *)token
                         locale:(NSString *)locale
         tokenExpirationHandler:(SSLiveness3DTokenExpirationHandler)tokenExpirationHandler
              completionHandler:(SSLiveness3DCompletionHandler)completionHandler;

- (UIViewController *)getController;

@end

NS_ASSUME_NONNULL_END
