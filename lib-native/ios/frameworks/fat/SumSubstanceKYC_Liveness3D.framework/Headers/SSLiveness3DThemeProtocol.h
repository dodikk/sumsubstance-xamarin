//
//  SSLiveness3DThemeProtocol.h
//  SumSubstanceKYC_Liveness3D
//
//  Copyright © 2019 Sum & Substance. All rights reserved.
//

#ifndef SSLiveness3DThemeProtocol_h
#define SSLiveness3DThemeProtocol_h

@protocol SSLiveness3DThemeProtocol <NSObject>

@optional

- (UIColor *)mainBgColor;
- (UIColor *)titleColor;
- (UIColor *)statusColor;
- (UIColor *)actionButtonColor;
- (UIColor *)cancelButtonColor;

- (UIColor *)retryBgColor;
/** 2 colors */
- (NSArray<UIColor *> *)retryBgGradientColors;
- (UIColor *)retryBorderColor;
- (UIColor *)retryTitleColor;
- (UIColor *)retryTextColor;
- (UIColor *)retryButtonColor;
- (UIColor *)retryButtonHighlightColor;

/** 2 colors */
- (NSArray<UIColor *> *)zoomMainGradientColors;
- (UIColor *)zoomMainForegroundColor;
- (UIColor *)zoomFrameBackgroundColor;
- (UIColor *)zoomFrameBorderColor;
- (UIColor *)zoomButtonColor;
- (UIColor *)zoomButtonHighlightColor;
- (UIColor *)zoomProgressColor;
- (UIColor *)zoomOvalBorderColor;
/** 4 colors */
- (NSArray<UIColor *> *)zoomFeedbackGradientColors;
- (UIColor *)zoomFeedbackTextColor;

@end

#endif /* SSLiveness3DThemeProtocol_h */
