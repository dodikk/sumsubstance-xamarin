
LAUNCH_DIR=$PWD


cd ..
    REPOSITORY_ROOT_DIR=$PWD
cd "$LAUNCH_DIR"


cd "$REPOSITORY_ROOT_DIR/lib-native/ios/"


 ### Build stub project with frameworks for device 
 #
 xcodebuild \
    -scheme Sumsub-iOS \
    -sdk iphoneos \
    -configuration Release

 ### Build stub project with frameworks for simulator
 #
 xcodebuild \
    -scheme Sumsub-iOS \
    -sdk iphonesimulator \
    -configuration Debug


cd "$LAUNCH_DIR"


