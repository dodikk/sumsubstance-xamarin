
LAUNCH_DIR=$PWD

cd ..
    REPOSITORY_ROOT_DIR=$PWD
cd "$LAUNCH_DIR"



cd "$REPOSITORY_ROOT_DIR/lib-native-ios"
curl \
  https://raw.githubusercontent.com/SumSubstance/KYC-iOS-Release/master/2.11.1/SumSubstanceKYC.zip \
  > SumSubstanceKYC.zip

unzip SumSubstanceKYC.zip \
      -d SumSubstanceKYC-frameworks
cd "$LAUNCH_DIR"


cd "$LAUNCH_DIR"


# xcodebuild \
#    -scheme Sumsub-iOS \
#    -sdk iphoneos \
#    -configuration Release \
