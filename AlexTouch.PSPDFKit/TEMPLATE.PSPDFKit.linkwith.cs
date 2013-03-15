using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("PSPDFKit.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | 1LinkTarget.Simulator, ForceLoad = true, IsCxx = true, Frameworks = "Security AssetsLibrary MediaPlayer CoreText QuartzCore MessageUI ImageIO CoreMedia CoreGraphics AVFoundation", LinkerFlags = "-lz -ObjC -fobjc-arc")]