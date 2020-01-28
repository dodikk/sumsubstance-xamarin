

 ### Build stub project with frameworks for device 
 #
 xcodebuild \
    -scheme Sumsub-iOS \
    -sdk iphoneos \
    -configuration Release \

 ### Build stub project with frameworks for simulator
 #
 xcodebuild \
    -scheme Sumsub-iOS \
    -sdk iphonesimulator \
    -configuration Debug \
