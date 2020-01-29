# sumsubstance-xamarin
Unofficial Bindings for SumSubstance SDK https://developers.sumsub.com/

# [iOS] Attention

All built fat frameworks including dependencies can be found at: 
https://github.com/SumSubstance/KYC-iOS-Release/blob/master/2.11.1/SumSubstanceKYC.Frameworks.zip

So `Cocoapods` or `Carthage` files are not needed.
Path in bindings generator script leads to the new location.

`TODO:` maybe create another binding project for bindings 
(similar to a native Pods.framework)




### Implementation Notes - iOS:

1. `carthage update --use-submodules` build command should be used
   In order to overcome error 
```
Parse error: expected submodule commit SHA in output of task (ls-tree -z 1.0.1 pages) 
but encountered:
```
That changes `.gitmodules` file. Still, neither ignoring nor commiting it. 
```
Please revert .gitmodules file locally
```

2. Cocoapods approach is not xamarin friendly as it does not produce fat frameworks
3. We'll have to fork some dependencies as they do not work well with carthage
```
Dependency "ISO8601DateFormatterValueTransformer" has no shared framework schemes
Dependency "PocketSocket" has no shared framework schemes
Dependency "Reachability" has no shared framework schemes
Dependency "RestKit" has no shared framework schemes
Dependency "RKValueTransformers" has no shared framework schemes
Dependency "sockit" has no shared framework schemes
Dependency "TransitionKit" has no shared framework schemes
```
4. Carthage build was successful for
```
PocketSVG.framework
ReactiveObjC.framework
SDWebImage.framework
SDWebImageMapKit.framework
YYText.framework
```

### Implementation Notes - droid:

jar binary download root path : https://dl.bintray.com/sumsub/maven/com/sumsub/


* core -
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.aar
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-core/3.0.1/:kyc-core-3.0.1.pom
* [?] Liveness3D -
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-liveness3d/3.0.1/:kyc-liveness3d-3.0.1.aar
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-liveness3d/3.0.1/:kyc-liveness3d-3.0.1.pom
* [?] KYC module
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc_module/2.1.4/:kyc_module-2.1.4.aar
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc_module/2.1.4/:kyc_module-2.1.4.pom
* KYC client
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.aar
    - https://dl.bintray.com/sumsub/maven/com/sumsub/kyc-client/3.0.1/:kyc-client-3.0.1.pom

Caution: When created on mac, the Xamarin.Android project fails to build out of box.

Native dependencies which cause bindings to fail :
* ConstraintLayout is not part of AppCompat. It's a standalone library.
* compile 'com.android.support:cardview-v7:23.1.1'
* riv_corner_radius  - RoundedImageView (https://github.com/vinc3m1/RoundedImageView).

Links and tutorials :
https://bsubramanyamraju.blogspot.com/2018/02/how-to-use-constraintlayout-in.html
https://github.com/brianwernick/ExoMedia
com.devbrackets.android.exomedia.ui.widget.VideoView


IMPORTANT: Exoplayer 2.9.0 and up requires Visual Studio 2019 with R8 and D8. You also need to enable AAPT2. Readmore at: https://devblogs.microsoft.com/xamarin/androids-d8-dexer-and-r8-shrinker/
https://github.com/Baseflow/ExoPlayerXamarin



