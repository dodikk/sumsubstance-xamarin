sharpie bind                                                              \
    -framework ../lib-native/ios/frameworks/fat/SumSubstanceKYC.framework \
    -sdk iphoneos13.2                                                     \
    -output ../lib-bindings/SumSubSDK/SumSubSDK.ios                       \
    -namespace "SumSubstance.iOS"

sharpie bind                                                                              \
    -framework ../lib-native/ios/frameworks/fat/SumSubstanceKYC_DocumentTracker.framework \
    -sdk iphoneos13.2                                                                     \
    -output ../lib-bindings/SumSubSDK/SumSubSDK.DocumentTracker.ios                       \
    -namespace "SumSubstance.DocumentTracker.iOS"


#### Sharpie docs
## https://docs.microsoft.com/en-gb/xamarin/cross-platform/macios/binding/objective-sharpie/examples/cocoapod
## https://docs.microsoft.com/en-gb/xamarin/cross-platform/macios/binding/objective-sharpie/examples/advanced
## https://docs.microsoft.com/en-us/xamarin/ios/platform/binding-objective-c/walkthrough


# ===
# [Verify] attributes intentionally cause C# compilation errors 
so that you are forced to verify the binding. 
You should remove the [Verify] attribute 
when you have reviewed (and possibly corrected) the code.
# ===
