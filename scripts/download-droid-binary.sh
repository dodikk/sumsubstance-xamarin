LAUNCH_DIR=$PWD

cd ..
    REPOSITORY_ROOT_DIR=$PWD
cd "$LAUNCH_DIR"


cd "$REPOSITORY_ROOT_DIR/lib-bindings/SumSubSDK/SumSubSDK.Core.droid/Jars"

curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.aar \
     > kyc-core.aar

curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.pom \
     > kyc-core.pom

cd "$LAUNCH_DIR"



cd "$REPOSITORY_ROOT_DIR/lib-bindings/SumSubSDK/SumSubSDK.Client.droid/Jars"

curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.aar \
     > kyc-client.aar

curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.pom \
     > kyc-client.pom


cd "$LAUNCH_DIR"
