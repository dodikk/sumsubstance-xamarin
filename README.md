# sumsubstance-xamarin
Unofficial Bindings for SumSubstance SDK https://developers.sumsub.com/

# [iOS] Attention

All built fat frameworks including dependencies can be found at: 
https://github.com/SumSubstance/KYC-iOS-Release/blob/master/2.11.1/SumSubstanceKYC.Frameworks.zip

So `Cocoapods` or `Carthage` files are not needed.

`TODO:` maybe change paths in bindings generator scripts


### Implementation Notes:

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
