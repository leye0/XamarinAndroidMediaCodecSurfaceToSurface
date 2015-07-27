# XamarinAndroidMediaCodecSurfaceToSurface
Xamarin Android MediaCodec Surface To Surface video decoding and encoding - CTS ported to Xamarin Android C#

This is a port of the CTS tests for MediaCodec on Android:

https://android.googlesource.com/platform/cts/+/jb-mr2-release/tests/tests/media/src/android/media/cts/DecodeEditEncodeTest.java

There original tests use a generated video. I've also add tests for conversion from file to file, so there are three
test classes:

- GeneratedVideoToMp4 - From the original test. A moving square with shader effects is rendered as MP4.
- CameraToMp4 - The camera input is directly rendered as an MP4 movie.
- FileToMp4 - A file is rendered as an MP4.

TODO: Copy and mux audio track. Should be done with API 18 muxer.
