Build error when attempting to publish using nativeaot when project includes a binding library with specific characteristics

`dotnet publish -f net8.0-ios16.1 -c Release -r ios-arm64  /t:Run`

ILLINK : warning MT0079: The recommended Xcode version for Microsoft.iOS 16.4.8646 is Xcode 14.3.1 or later. The current Xcode version (found in /Applications/Xcode-14.3.0.app/Contents/Developer) is 14.3. [/Users/rdavis/Source/ios-net8-nativeaotbinding-repro/proj/ios-nativeaot-repro.csproj]
  		
ILLINK : warning MT2387: It's not safe to remove the dynamic registrar, because JDStatusBarNotification references 'ObjCRuntime.BlockLiteral..ctor (System.Void*, System.Object, System.Type, System.String)'. [/Users/rdavis/Source/ios-net8-nativeaotbinding-repro/proj/ios-nativeaot-repro.csproj]
  		
ILLink : iOS error IL7000: An error occured while executing the custom linker steps. Please review the build log for more information. [/Users/rdavis/Source/ios-net8-nativeaotbinding-repro/proj/ios-nativeaot-repro.csproj]

ILLINK : error MT0099: Can't create a token reference to an unregistered type when using the managed static registrar: JDStatusBarNotification.JDStatusBarNotificationBackgroundStyle [/Users/rdavis/Source/ios-net8-nativeaotbinding-repro/proj/ios-nativeaot-repro.csproj]

ILLINK : error MT2362: The linker step 'Registrar' failed during processing: Can't create a token reference to an unregistered type when using the managed static registrar: JDStatusBarNotification.JDStatusBarNotificationBackgroundStyle [/Users/rdavis/Source/ios-net8-nativeaotbinding-repro/proj/ios-nativeaot-repro.csproj]
/Users/rdavis/.nuget/packages/microsoft.net.illink.tasks/8.0.0-preview.6.23329.7/build/Microsoft.NET.ILLink.targets(83,5): error NETSDK1144: Optimizing assemblies for size failed. Optimization can be disabled by setting the PublishTrimmed property to false. [/Users/rdavis/Source/ios-net8-nativeaotbinding-repro/proj/ios-nativeaot-repro.csproj]
