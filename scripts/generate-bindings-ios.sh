sharpie bind                                                                          \
    -framework ../lib-native/ios/SumSubstanceKYC.Frameworks/SumSubstanceKYC.framework \
    -sdk iphoneos13.2                                                                 \
    -output ../lib-bindings/SumSubSDK/SumSubSDK.ios                                   \
    -namespace "SumSubstance.iOS"

sharpie bind                                                                          \
    -framework ../lib-native/ios/SumSubstanceKYC.Frameworks/SumSubstanceKYC_Liveness3D.framework \
    -sdk iphoneos13.2                                                                 \
    -output ../lib-bindings/SumSubSDK/SumSubSDK.Liveness3D.ios                        \
    -namespace "SumSubstance.Liveness3D.iOS"



### Note: this is commented since DocumentTracker.framework has no headers
#         it should be ok to link that without binding project or with an empty one
#
#   TODO: probaly an umbrella pods framework can be a better target to link depencencies
#
# sharpie bind                                         \
#    -framework ../lib-native/ios/frameworks/fat/SumSubstanceKYC_DocumentTracker.framework \
#    -sdk iphoneos13.2                                                                     \
#    -output ../lib-bindings/SumSubSDK/SumSubSDK.DocumentTracker.ios                       \
#    -namespace "SumSubstance.DocumentTracker.iOS"


# Exiting with error code 1.
# error: SumSubstanceKYC_DocumentTracker: Umbrella header file does not exist: ../lib-native/ios/frameworks/fat/SumSubstanceKYC_DocumentTracker.framework/Headers/SumSubstanceKYC_DocumentTracker.h



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
