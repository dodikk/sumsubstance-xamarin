
LAUNCH_DIR=$PWD


cd ..
    REPOSITORY_ROOT_DIR=$PWD
cd "$LAUNCH_DIR"


cd "$REPOSITORY_ROOT_DIR/lib-native/ios/frameworks/fat/"


find . -name "*.framework"                      
## TODO: automate framework binary path construction and .framework extension splitting
## TODO: maybe automate architecture analysis of ```file``` command output

echo ---
echo -
echo ---     
file ./PocketSocket.framework/PocketSocket
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./Reachability.framework/Reachability
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./SumSubstanceKYC.framework/SumSubstanceKYC
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./YYText.framework/YYText
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./ReactiveObjC.framework/ReactiveObjC
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./PocketSVG.framework/PocketSVG
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./SDWebImageMapKit.framework/SDWebImageMapKit
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./SumSubstanceKYC_Liveness3D.framework/SumSubstanceKYC_Liveness3D
echo ---
echo -
echo ---


echo ---
echo -
echo ---
file ./SOCKit.framework/SOCKit
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./RestKit.framework/RestKit
echo ---
echo -
echo ---


echo ---
echo -
echo ---
file ./RKValueTransformers.framework/RKValueTransformers
echo ---
echo -
echo ---


echo ---
echo -
echo ---
file ./SumSubstanceKYC_FaceTracker.framework/SumSubstanceKYC_FaceTracker
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./SumSubstanceKYC_DocumentTracker.framework/SumSubstanceKYC_DocumentTracker
echo ---
echo -
echo ---

echo ---
echo -
echo ---
file ./SDWebImage.framework/SDWebImage
echo ---
echo -
echo ---


echo ---
echo -
echo ---
file ./ISO8601DateFormatterValueTransformer.framework/ISO8601DateFormatterValueTransformer
echo ---
echo -
echo ---


cd "$LAUNCH_DIR"
