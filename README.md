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


Unsolved error message caused by SumSubSDK.Client native library:
Adding ExoPlayer plug-ins does not help
```
2> ...\obj\Debug\90\lp\10\jl\res\layout\video_activity.xml(2): 
error APT0000: No resource identifier found for attribute 'useDefaultControls' 
in package 'SumSubDemo_droid.SumSubDemo_droid'
```

Control which causes the issue:
```
<FrameLayout 
	android:layout_width="match_parent" 
	android:layout_height="match_parent" 
	android:background="#000000" 
	xmlns:android="http://schemas.android.com/apk/res/android" 
	xmlns:app="http://schemas.android.com/apk/res-auto" 
	xmlns:tools="http://schemas.android.com/tools">
	
	<com.devbrackets.android.exomedia.ui.widget.VideoView 
		android:id="@+id/video_view" 
		android:layout_width="match_parent" 
		android:layout_height="match_parent" 
>>>		app:useDefaultControls="true" />
		
	<ImageView 
		android:id="@+id/video_close" 
		android:layout_width="56dp" 
		android:layout_height="56dp" 
		android:scaleType="center" 
		android:layout_gravity="right|top" 
		app:srcCompat="@drawable/ic_video_close" 
		tools:ignore="ContentDescription" />
		
</FrameLayout>
```




```
1>COMPILETODALVIK : Uncaught translation error : com.android.dx.cf.code.SimException: invalid opcode ba (invokedynamic requires --min-sdk-version >= 26)
```
THis happens when SumSubSDK.Client is disabled




Seems like SumSubstance SDK uses ExoMedia which is a different thing from ExoPlayer. 
Actually, ExoMedia wraps ExoPlayer.
However, nuget packages are available only for ExoPlayer.
Will try to build a wrapper project for ExoMedia.
* https://bintray.com/brianwernick/maven/ExoMedia
* https://github.com/brianwernick/ExoMedia




ExoMedia binding project has helped to fix `useDefaultControls` issue
New ones have arised:
```
    obj/Debug/android/src/mono/com/devbrackets/android/exomedia/core/listener/MetadataListenerImplementor.java:4: error: MetadataListenerImplementor is not abstract and does not override abstract method onMetadata(Metadata) in MetadataListener
    public class MetadataListenerImplementor
```
https://forums.xamarin.com/discussion/176667/cannot-implement-abstract-method-in-android-java-class
https://github.com/Baseflow/ExoPlayerXamarin/issues/64

This blogpost might help to overcome the issue
http://www.andipalo.com/2017/07/16/java-seesharp-xamarin/



```
    obj/Debug/android/src/mono/com/devbrackets/android/exomedia/core/listener/CaptionListenerImplementor.java:4: error: CaptionListenerImplementor is not abstract and does not override abstract method onCues(List<Cue>) in CaptionListener
    public class CaptionListenerImplementor
           ^
    obj/Debug/android/src/mono/com/devbrackets/android/exomedia/core/listener/MetadataListenerImplementor.java:4: error: MetadataListenerImplementor is not abstract and does not override abstract method onMetadata(Metadata) in MetadataListener
    public class MetadataListenerImplementor
           ^
    obj/Debug/android/src/mono/com/sumsub/kyc/client/ui/chat/ChatListClickListenerImplementor.java:4: error: ChatListClickListenerImplementor is not abstract and does not override abstract method onScenarioClick(ScenarioBaseEntity) in ChatListClickListener
    public class ChatListClickListenerImplementor
           ^
    obj/Debug/android/src/mono/com/sumsub/kyc/client/ui/picker/PickerOnItemClickListenerImplementor.java:4: error: PickerOnItemClickListenerImplementor is not abstract and does not override abstract method onItemClick(MapItemEntity) in PickerOnItemClickListener
    public class PickerOnItemClickListenerImplementor
           ^
    Note: Some input files use or override a deprecated API.
    Note: Recompile with -Xlint:deprecation for details.
    Note: Some input files use unchecked or unsafe operations.
    Note: Recompile with -Xlint:unchecked for details.
    4 errors
```



