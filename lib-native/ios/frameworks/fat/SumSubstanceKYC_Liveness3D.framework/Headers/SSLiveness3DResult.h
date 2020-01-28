//
//  SSLiveness3DResult.h
//  SumSubstanceKYC_Liveness3D
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface SSLiveness3DResult : NSObject

@property (nonatomic, copy) NSString * __nullable applicantActionId;

@property (nonatomic, copy) NSString * __nullable reviewAnswer;
@property (nonatomic, copy) NSArray<NSString *> * __nullable rejectLabels;

@property (nonatomic, copy) NSString * __nullable livenessCheckAnswer;
@property (nonatomic, copy) NSString * __nullable livenessRetrySuggestion;

@property (nonatomic, copy) NSString * __nullable faceMatchCheckAnswer;

@end

NS_ASSUME_NONNULL_END
