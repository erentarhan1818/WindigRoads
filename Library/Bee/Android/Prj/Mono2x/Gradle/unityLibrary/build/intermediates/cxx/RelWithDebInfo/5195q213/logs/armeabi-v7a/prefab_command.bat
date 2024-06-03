@echo off
"C:\\Program Files\\Unity\\Hub\\Editor\\2023.1.0b20\\Editor\\Data\\PlaybackEngines\\AndroidPlayer\\OpenJDK\\bin\\java" ^
  --class-path ^
  "C:\\Users\\eren1\\.gradle\\caches\\modules-2\\files-2.1\\com.google.prefab\\cli\\2.0.0\\f2702b5ca13df54e3ca92f29d6b403fb6285d8df\\cli-2.0.0-all.jar" ^
  com.google.prefab.cli.AppKt ^
  --build-system ^
  cmake ^
  --platform ^
  android ^
  --abi ^
  armeabi-v7a ^
  --os-version ^
  24 ^
  --stl ^
  c++_shared ^
  --ndk-version ^
  23 ^
  --output ^
  "C:\\Users\\eren1\\winding roads\\.utmp\\RelWithDebInfo\\5195q213\\prefab\\armeabi-v7a\\prefab-configure" ^
  "C:\\Users\\eren1\\.gradle\\caches\\transforms-3\\121b6b243cedf8bef90d462440e4bf24\\transformed\\jetified-games-frame-pacing-1.10.0\\prefab"
