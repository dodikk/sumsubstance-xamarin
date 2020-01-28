## ISO8601DateFormatterValueTransformer
## PocketSocket
## RKValueTransformers
## Reachability
## RestKit
## SOCKit
## TransitionKit
#
## TODO: maybe automate copying fat files inside frameworks
##       for a prototype this is supposed to be manual
## Note: also assuming that thin frameworks have been built already
##       and copied to 
##       * lib-native/ios/frameworks/Debug-iphonesimulator
##       * lib-native/ios/frameworks/Release-iphoneos
## -------------

LAUNCH_DIR=$PWD


cd ..
    REPOSITORY_ROOT_DIR=$PWD
cd "$LAUNCH_DIR"


cd "$REPOSITORY_ROOT_DIR/lib-native/ios"


lipo -create \
	-output frameworks/fat/ISO8601DateFormatterValueTransformer \
	frameworks/Release-iphoneos/ISO8601DateFormatterValueTransformer/ISO8601DateFormatterValueTransformer.framework/ISO8601DateFormatterValueTransformer \
	frameworks/Debug-iphonesimulator/ISO8601DateFormatterValueTransformer/ISO8601DateFormatterValueTransformer.framework/ISO8601DateFormatterValueTransformer

lipo -create \
	-output frameworks/fat/PocketSocket \
	frameworks/Release-iphoneos/PocketSocket/PocketSocket.framework/PocketSocket \
	frameworks/Debug-iphonesimulator/PocketSocket/PocketSocket.framework/PocketSocket


lipo -create \
	-output frameworks/fat/PocketSocket \
	frameworks/Release-iphoneos/PocketSocket/PocketSocket.framework/PocketSocket \
	frameworks/Debug-iphonesimulator/PocketSocket/PocketSocket.framework/PocketSocket


lipo -create \
	-output frameworks/fat/RKValueTransformers \
	frameworks/Release-iphoneos/RKValueTransformers/RKValueTransformers.framework/RKValueTransformers \
	frameworks/Debug-iphonesimulator/RKValueTransformers/RKValueTransformers.framework/RKValueTransformers


lipo -create \
	-output frameworks/fat/Reachability \
	frameworks/Release-iphoneos/Reachability/Reachability.framework/Reachability \
	frameworks/Debug-iphonesimulator/Reachability/Reachability.framework/Reachability


lipo -create \
	-output frameworks/fat/RestKit \
	frameworks/Release-iphoneos/RestKit/RestKit.framework/RestKit \
	frameworks/Debug-iphonesimulator/RestKit/RestKit.framework/RestKit


lipo -create \
	-output frameworks/fat/SOCKit \
	frameworks/Release-iphoneos/SOCKit/SOCKit.framework/SOCKit \
	frameworks/Debug-iphonesimulator/SOCKit/SOCKit.framework/SOCKit


lipo -create \
	-output frameworks/fat/TransitionKit \
	frameworks/Release-iphoneos/TransitionKit/TransitionKit.framework/TransitionKit \
	frameworks/Debug-iphonesimulator/TransitionKit/TransitionKit.framework/TransitionKit


cd "$LAUNCH_DIR"


