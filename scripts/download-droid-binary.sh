LAUNCH_DIR=$PWD

cd ..
    REPOSITORY_ROOT_DIR=$PWD
cd "$LAUNCH_DIR"


cd "$REPOSITORY_ROOT_DIR/lib-bindings/SumSubSDK/SumSubSDK.Core.droid/Jars"

#curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.aar \
#     > kyc-core.aar
wget \
    --output-document=kyc-core.aar \
    https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.aar

# curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.pom \
#      > kyc-core.pom
wget \
    --output-document=kyc-core.pom \
    https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.pom

cd "$LAUNCH_DIR"



cd "$REPOSITORY_ROOT_DIR/lib-bindings/SumSubSDK/SumSubSDK.Client.droid/Jars"

# curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.aar \
#      > kyc-client.aar
wget \
    --output-document=kyc-client.aar \
    https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.aar

# curl https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.pom \
#      > kyc-client.pom
wget \
    --output-document=kyc-client.pom \
    https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.pom

cd "$LAUNCH_DIR"



cd "$REPOSITORY_ROOT_DIR/lib-bindings/ExoMedia.droid/Jars"

wget \
    --output-document=exomedia.aar \
    https://bintray.com/brianwernick/maven/download_file?file_path=com%2Fdevbrackets%2Fandroid%2Fexomedia%2F4.3.0%2Fexomedia-4.3.0.aar

wget \
    --output-document=exomedia.pom \
    https://bintray.com/brianwernick/maven/download_file?file_path=com%2Fdevbrackets%2Fandroid%2Fexomedia%2F4.3.0%2Fexomedia-4.3.0.pom

cd "$LAUNCH_DIR"

