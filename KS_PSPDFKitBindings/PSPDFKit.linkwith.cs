using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("PSPDFKit.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, IsCxx = true, Frameworks = "Security AssetsLibrary MediaPlayer CoreText QuartzCore MessageUI ImageIO CoreMedia CoreGraphics AVFoundation AudioToolbox QuickLook", LinkerFlags = "-lz -ObjC -fobjc-arc")]