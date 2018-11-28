Setting up Unity + GearVR
---- 
Assuming that your Android device is already setup with everything needed to run GearVR applications (Oculus account, etc.), and that you have Unity installed and a project you wish to run in VR:

+ Download and install the Java Development Kit (jdk)
+ Download and install Android Studio + Android SDK
+ Open Android Studio and install a new API package that is supported by your Android device
+ Enable “developer options” on your android
  - Open Settings, and select “About”
  - Tap on “Build number” seven times
  - Go back, and select “Developer options”
  - Scroll down, and check the “Android debugging” entry under “Debugging”
+ Plug your Android device into your computer
+ On the computer, open up a terminal/command prompt and run
  - cd ~/Android/Sdk/platform-tools
  - ./adb devices
+ Copy your device ID, visit Oculus OSIG generator, and obtain a credentials file
+ Copy the credentials file to your_unity_project/Assets/Plugins/Android/assets/
+ Go to your Unity project -> File menu -> Build settings
+ Change the build target to Android
+ Open the Player settings
  - Set the correct Android API
  - Give a package name to your application
+ Build
+ Manually copy the .apk file to your Android device
+ Using your Android device’s file explorer locate the .apk file and install it.
+ Open the app and connect the device to the headset
+ Enjoy!

# Rebuilding the app

+ Disconnect the device from the headset and connect it to your computer
+ Open the app
+ Press ctrl+B (or File -> Build and run)
+ Disconnect the device from your computer and connect it back to the headset

# Links
 
+ Oculus Unity Android Dev - https://developer.oculus.com/documentation/mobilesdk/latest/concepts/mobile-adb/
+ Mobile Dev prep - https://developer.oculus.com/documentation/unity/latest/concepts/unity-mobileprep/
+ Using adb - https://developer.oculus.com/documentation/mobilesdk/latest/concepts/mobile-adb/

