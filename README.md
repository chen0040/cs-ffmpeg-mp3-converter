# cs-ffmpeg-mp3-converter

Convert audio files of other formats to mp3 using ffmpeg in .NET

# Install 

```bash
Install-Package FFMPEG-MP3-Converter -Version 1.0.1
```


# Usage

```cs
string source_filename="sample.au";
string target_filename="converted.mp3"; 
cs_ffmpeg_mp3_converter.FFMpeg.Convert2Mp3(source_filename, target_filename);
```


