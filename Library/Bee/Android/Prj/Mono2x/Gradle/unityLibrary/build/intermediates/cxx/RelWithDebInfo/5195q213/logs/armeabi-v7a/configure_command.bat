@echo off
"C:\\Program Files\\Unity\\Hub\\Editor\\2023.1.0b20\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\SDK\\cmake\\3.22.1\\bin\\cmake.exe" ^
  "-HC:\\Users\\eren1\\winding roads\\Library\\Bee\\Android\\Prj\\Mono2x\\Gradle\\unityLibrary\\src\\main\\cpp" ^
  "-DCMAKE_SYSTEM_NAME=Android" ^
  "-DCMAKE_EXPORT_COMPILE_COMMANDS=ON" ^
  "-DCMAKE_SYSTEM_VERSION=24" ^
  "-DANDROID_PLATFORM=android-24" ^
  "-DANDROID_ABI=armeabi-v7a" ^
  "-DCMAKE_ANDROID_ARCH_ABI=armeabi-v7a" ^
  "-DANDROID_NDK=C:\\Program Files\\Unity\\Hub\\Editor\\2023.1.0b20\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\NDK" ^
  "-DCMAKE_ANDROID_NDK=C:\\Program Files\\Unity\\Hub\\Editor\\2023.1.0b20\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\NDK" ^
  "-DCMAKE_TOOLCHAIN_FILE=C:\\Program Files\\Unity\\Hub\\Editor\\2023.1.0b20\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\NDK\\build\\cmake\\android.toolchain.cmake" ^
  "-DCMAKE_MAKE_PROGRAM=C:\\Program Files\\Unity\\Hub\\Editor\\2023.1.0b20\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\SDK\\cmake\\3.22.1\\bin\\ninja.exe" ^
  "-DCMAKE_LIBRARY_OUTPUT_DIRECTORY=C:\\Users\\eren1\\winding roads\\Library\\Bee\\Android\\Prj\\Mono2x\\Gradle\\unityLibrary\\build\\intermediates\\cxx\\RelWithDebInfo\\5195q213\\obj\\armeabi-v7a" ^
  "-DCMAKE_RUNTIME_OUTPUT_DIRECTORY=C:\\Users\\eren1\\winding roads\\Library\\Bee\\Android\\Prj\\Mono2x\\Gradle\\unityLibrary\\build\\intermediates\\cxx\\RelWithDebInfo\\5195q213\\obj\\armeabi-v7a" ^
  "-DCMAKE_BUILD_TYPE=RelWithDebInfo" ^
  "-DCMAKE_FIND_ROOT_PATH=C:\\Users\\eren1\\winding roads\\.utmp\\RelWithDebInfo\\5195q213\\prefab\\armeabi-v7a\\prefab" ^
  "-BC:\\Users\\eren1\\winding roads\\.utmp\\RelWithDebInfo\\5195q213\\armeabi-v7a" ^
  -GNinja ^
  "-DBUILD_GRADLE_DIRECTORY=C:\\Users\\eren1\\winding roads\\Library\\Bee\\Android\\Prj\\Mono2x\\Gradle\\unityLibrary" ^
  "-DANDROID_STL=c++_shared"
