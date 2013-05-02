//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace KS_PSPDFKitBindings {
	[Register("PSPDFViewController", true)]
	public unsafe partial class PSPDFViewController : PSPDFBaseViewController {
		[CompilerGenerated]
		const string selPage = "page";
		static readonly IntPtr selPageHandle = Selector.GetHandle ("page");
		[CompilerGenerated]
		const string selSetPage_ = "setPage:";
		static readonly IntPtr selSetPage_Handle = Selector.GetHandle ("setPage:");
		[CompilerGenerated]
		const string selScreenPage = "screenPage";
		static readonly IntPtr selScreenPageHandle = Selector.GetHandle ("screenPage");
		[CompilerGenerated]
		const string selViewState = "viewState";
		static readonly IntPtr selViewStateHandle = Selector.GetHandle ("viewState");
		[CompilerGenerated]
		const string selSetViewState_ = "setViewState:";
		static readonly IntPtr selSetViewState_Handle = Selector.GetHandle ("setViewState:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDocument = "document";
		static readonly IntPtr selDocumentHandle = Selector.GetHandle ("document");
		[CompilerGenerated]
		const string selSetDocument_ = "setDocument:";
		static readonly IntPtr selSetDocument_Handle = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		const string selMargin = "margin";
		static readonly IntPtr selMarginHandle = Selector.GetHandle ("margin");
		[CompilerGenerated]
		const string selSetMargin_ = "setMargin:";
		static readonly IntPtr selSetMargin_Handle = Selector.GetHandle ("setMargin:");
		[CompilerGenerated]
		const string selPadding = "padding";
		static readonly IntPtr selPaddingHandle = Selector.GetHandle ("padding");
		[CompilerGenerated]
		const string selSetPadding_ = "setPadding:";
		static readonly IntPtr selSetPadding_Handle = Selector.GetHandle ("setPadding:");
		[CompilerGenerated]
		const string selRenderingMode = "renderingMode";
		static readonly IntPtr selRenderingModeHandle = Selector.GetHandle ("renderingMode");
		[CompilerGenerated]
		const string selSetRenderingMode_ = "setRenderingMode:";
		static readonly IntPtr selSetRenderingMode_Handle = Selector.GetHandle ("setRenderingMode:");
		[CompilerGenerated]
		const string selIsSmartZoomEnabled = "isSmartZoomEnabled";
		static readonly IntPtr selIsSmartZoomEnabledHandle = Selector.GetHandle ("isSmartZoomEnabled");
		[CompilerGenerated]
		const string selSetSmartZoomEnabled_ = "setSmartZoomEnabled:";
		static readonly IntPtr selSetSmartZoomEnabled_Handle = Selector.GetHandle ("setSmartZoomEnabled:");
		[CompilerGenerated]
		const string selIsScrollingEnabled = "isScrollingEnabled";
		static readonly IntPtr selIsScrollingEnabledHandle = Selector.GetHandle ("isScrollingEnabled");
		[CompilerGenerated]
		const string selSetScrollingEnabled_ = "setScrollingEnabled:";
		static readonly IntPtr selSetScrollingEnabled_Handle = Selector.GetHandle ("setScrollingEnabled:");
		[CompilerGenerated]
		const string selIsViewLockEnabled = "isViewLockEnabled";
		static readonly IntPtr selIsViewLockEnabledHandle = Selector.GetHandle ("isViewLockEnabled");
		[CompilerGenerated]
		const string selSetViewLockEnabled_ = "setViewLockEnabled:";
		static readonly IntPtr selSetViewLockEnabled_Handle = Selector.GetHandle ("setViewLockEnabled:");
		[CompilerGenerated]
		const string selIsRotationLockEnabled = "isRotationLockEnabled";
		static readonly IntPtr selIsRotationLockEnabledHandle = Selector.GetHandle ("isRotationLockEnabled");
		[CompilerGenerated]
		const string selSetRotationLockEnabled_ = "setRotationLockEnabled:";
		static readonly IntPtr selSetRotationLockEnabled_Handle = Selector.GetHandle ("setRotationLockEnabled:");
		[CompilerGenerated]
		const string selIsScrollOnTapPageEndEnabled = "isScrollOnTapPageEndEnabled";
		static readonly IntPtr selIsScrollOnTapPageEndEnabledHandle = Selector.GetHandle ("isScrollOnTapPageEndEnabled");
		[CompilerGenerated]
		const string selSetScrollOnTapPageEndEnabled_ = "setScrollOnTapPageEndEnabled:";
		static readonly IntPtr selSetScrollOnTapPageEndEnabled_Handle = Selector.GetHandle ("setScrollOnTapPageEndEnabled:");
		[CompilerGenerated]
		const string selIsScrollOnTapPageEndAnimationEnabled = "isScrollOnTapPageEndAnimationEnabled";
		static readonly IntPtr selIsScrollOnTapPageEndAnimationEnabledHandle = Selector.GetHandle ("isScrollOnTapPageEndAnimationEnabled");
		[CompilerGenerated]
		const string selSetScrollOnTapPageEndAnimationEnabled_ = "setScrollOnTapPageEndAnimationEnabled:";
		static readonly IntPtr selSetScrollOnTapPageEndAnimationEnabled_Handle = Selector.GetHandle ("setScrollOnTapPageEndAnimationEnabled:");
		[CompilerGenerated]
		const string selScrollOnTapPageEndMargin = "scrollOnTapPageEndMargin";
		static readonly IntPtr selScrollOnTapPageEndMarginHandle = Selector.GetHandle ("scrollOnTapPageEndMargin");
		[CompilerGenerated]
		const string selSetScrollOnTapPageEndMargin_ = "setScrollOnTapPageEndMargin:";
		static readonly IntPtr selSetScrollOnTapPageEndMargin_Handle = Selector.GetHandle ("setScrollOnTapPageEndMargin:");
		[CompilerGenerated]
		const string selInternalTapGesturesEnabled = "internalTapGesturesEnabled";
		static readonly IntPtr selInternalTapGesturesEnabledHandle = Selector.GetHandle ("internalTapGesturesEnabled");
		[CompilerGenerated]
		const string selSetInternalTapGesturesEnabled_ = "setInternalTapGesturesEnabled:";
		static readonly IntPtr selSetInternalTapGesturesEnabled_Handle = Selector.GetHandle ("setInternalTapGesturesEnabled:");
		[CompilerGenerated]
		const string selIsTextSelectionEnabled = "isTextSelectionEnabled";
		static readonly IntPtr selIsTextSelectionEnabledHandle = Selector.GetHandle ("isTextSelectionEnabled");
		[CompilerGenerated]
		const string selSetTextSelectionEnabled_ = "setTextSelectionEnabled:";
		static readonly IntPtr selSetTextSelectionEnabled_Handle = Selector.GetHandle ("setTextSelectionEnabled:");
		[CompilerGenerated]
		const string selIsImageSelectionEnabled = "isImageSelectionEnabled";
		static readonly IntPtr selIsImageSelectionEnabledHandle = Selector.GetHandle ("isImageSelectionEnabled");
		[CompilerGenerated]
		const string selSetImageSelectionEnabled_ = "setImageSelectionEnabled:";
		static readonly IntPtr selSetImageSelectionEnabled_Handle = Selector.GetHandle ("setImageSelectionEnabled:");
		[CompilerGenerated]
		const string selIsPasswordDialogEnabled = "isPasswordDialogEnabled";
		static readonly IntPtr selIsPasswordDialogEnabledHandle = Selector.GetHandle ("isPasswordDialogEnabled");
		[CompilerGenerated]
		const string selSetPasswordDialogEnabled_ = "setPasswordDialogEnabled:";
		static readonly IntPtr selSetPasswordDialogEnabled_Handle = Selector.GetHandle ("setPasswordDialogEnabled:");
		[CompilerGenerated]
		const string selUseParentNavigationBar = "useParentNavigationBar";
		static readonly IntPtr selUseParentNavigationBarHandle = Selector.GetHandle ("useParentNavigationBar");
		[CompilerGenerated]
		const string selSetUseParentNavigationBar_ = "setUseParentNavigationBar:";
		static readonly IntPtr selSetUseParentNavigationBar_Handle = Selector.GetHandle ("setUseParentNavigationBar:");
		[CompilerGenerated]
		const string selShouldRestoreNavigationBarStyle = "shouldRestoreNavigationBarStyle";
		static readonly IntPtr selShouldRestoreNavigationBarStyleHandle = Selector.GetHandle ("shouldRestoreNavigationBarStyle");
		[CompilerGenerated]
		const string selSetShouldRestoreNavigationBarStyle_ = "setShouldRestoreNavigationBarStyle:";
		static readonly IntPtr selSetShouldRestoreNavigationBarStyle_Handle = Selector.GetHandle ("setShouldRestoreNavigationBarStyle:");
		[CompilerGenerated]
		const string selLinkAction = "linkAction";
		static readonly IntPtr selLinkActionHandle = Selector.GetHandle ("linkAction");
		[CompilerGenerated]
		const string selSetLinkAction_ = "setLinkAction:";
		static readonly IntPtr selSetLinkAction_Handle = Selector.GetHandle ("setLinkAction:");
		[CompilerGenerated]
		const string selHUDView = "HUDView";
		static readonly IntPtr selHUDViewHandle = Selector.GetHandle ("HUDView");
		[CompilerGenerated]
		const string selHUDViewMode = "HUDViewMode";
		static readonly IntPtr selHUDViewModeHandle = Selector.GetHandle ("HUDViewMode");
		[CompilerGenerated]
		const string selSetHUDViewMode_ = "setHUDViewMode:";
		static readonly IntPtr selSetHUDViewMode_Handle = Selector.GetHandle ("setHUDViewMode:");
		[CompilerGenerated]
		const string selIsHUDVisible = "isHUDVisible";
		static readonly IntPtr selIsHUDVisibleHandle = Selector.GetHandle ("isHUDVisible");
		[CompilerGenerated]
		const string selSetHUDVisible_ = "setHUDVisible:";
		static readonly IntPtr selSetHUDVisible_Handle = Selector.GetHandle ("setHUDVisible:");
		[CompilerGenerated]
		const string selIsToolbarEnabled = "isToolbarEnabled";
		static readonly IntPtr selIsToolbarEnabledHandle = Selector.GetHandle ("isToolbarEnabled");
		[CompilerGenerated]
		const string selSetToolbarEnabled_ = "setToolbarEnabled:";
		static readonly IntPtr selSetToolbarEnabled_Handle = Selector.GetHandle ("setToolbarEnabled:");
		[CompilerGenerated]
		const string selAllowToolbarTitleChange = "allowToolbarTitleChange";
		static readonly IntPtr selAllowToolbarTitleChangeHandle = Selector.GetHandle ("allowToolbarTitleChange");
		[CompilerGenerated]
		const string selSetAllowToolbarTitleChange_ = "setAllowToolbarTitleChange:";
		static readonly IntPtr selSetAllowToolbarTitleChange_Handle = Selector.GetHandle ("setAllowToolbarTitleChange:");
		[CompilerGenerated]
		const string selIsScrobbleBarEnabled = "isScrobbleBarEnabled";
		static readonly IntPtr selIsScrobbleBarEnabledHandle = Selector.GetHandle ("isScrobbleBarEnabled");
		[CompilerGenerated]
		const string selSetScrobbleBarEnabled_ = "setScrobbleBarEnabled:";
		static readonly IntPtr selSetScrobbleBarEnabled_Handle = Selector.GetHandle ("setScrobbleBarEnabled:");
		[CompilerGenerated]
		const string selIsPageLabelEnabled = "isPageLabelEnabled";
		static readonly IntPtr selIsPageLabelEnabledHandle = Selector.GetHandle ("isPageLabelEnabled");
		[CompilerGenerated]
		const string selSetPageLabelEnabled_ = "setPageLabelEnabled:";
		static readonly IntPtr selSetPageLabelEnabled_Handle = Selector.GetHandle ("setPageLabelEnabled:");
		[CompilerGenerated]
		const string selIsDocumentLabelEnabled = "isDocumentLabelEnabled";
		static readonly IntPtr selIsDocumentLabelEnabledHandle = Selector.GetHandle ("isDocumentLabelEnabled");
		[CompilerGenerated]
		const string selSetDocumentLabelEnabled_ = "setDocumentLabelEnabled:";
		static readonly IntPtr selSetDocumentLabelEnabled_Handle = Selector.GetHandle ("setDocumentLabelEnabled:");
		[CompilerGenerated]
		const string selIsRenderAnimationEnabled = "isRenderAnimationEnabled";
		static readonly IntPtr selIsRenderAnimationEnabledHandle = Selector.GetHandle ("isRenderAnimationEnabled");
		[CompilerGenerated]
		const string selSetRenderAnimationEnabled_ = "setRenderAnimationEnabled:";
		static readonly IntPtr selSetRenderAnimationEnabled_Handle = Selector.GetHandle ("setRenderAnimationEnabled:");
		[CompilerGenerated]
		const string selContentView = "contentView";
		static readonly IntPtr selContentViewHandle = Selector.GetHandle ("contentView");
		[CompilerGenerated]
		const string selCloseButtonItem = "closeButtonItem";
		static readonly IntPtr selCloseButtonItemHandle = Selector.GetHandle ("closeButtonItem");
		[CompilerGenerated]
		const string selOutlineButtonItem = "outlineButtonItem";
		static readonly IntPtr selOutlineButtonItemHandle = Selector.GetHandle ("outlineButtonItem");
		[CompilerGenerated]
		const string selSearchButtonItem = "searchButtonItem";
		static readonly IntPtr selSearchButtonItemHandle = Selector.GetHandle ("searchButtonItem");
		[CompilerGenerated]
		const string selViewModeButtonItem = "viewModeButtonItem";
		static readonly IntPtr selViewModeButtonItemHandle = Selector.GetHandle ("viewModeButtonItem");
		[CompilerGenerated]
		const string selPrintButtonItem = "printButtonItem";
		static readonly IntPtr selPrintButtonItemHandle = Selector.GetHandle ("printButtonItem");
		[CompilerGenerated]
		const string selOpenInButtonItem = "openInButtonItem";
		static readonly IntPtr selOpenInButtonItemHandle = Selector.GetHandle ("openInButtonItem");
		[CompilerGenerated]
		const string selEmailButtonItem = "emailButtonItem";
		static readonly IntPtr selEmailButtonItemHandle = Selector.GetHandle ("emailButtonItem");
		[CompilerGenerated]
		const string selAnnotationButtonItem = "annotationButtonItem";
		static readonly IntPtr selAnnotationButtonItemHandle = Selector.GetHandle ("annotationButtonItem");
		[CompilerGenerated]
		const string selBookmarkButtonItem = "bookmarkButtonItem";
		static readonly IntPtr selBookmarkButtonItemHandle = Selector.GetHandle ("bookmarkButtonItem");
		[CompilerGenerated]
		const string selBrightnessButtonItem = "brightnessButtonItem";
		static readonly IntPtr selBrightnessButtonItemHandle = Selector.GetHandle ("brightnessButtonItem");
		[CompilerGenerated]
		const string selActivityButtonItem = "activityButtonItem";
		static readonly IntPtr selActivityButtonItemHandle = Selector.GetHandle ("activityButtonItem");
		[CompilerGenerated]
		const string selAdditionalActionsButtonItem = "additionalActionsButtonItem";
		static readonly IntPtr selAdditionalActionsButtonItemHandle = Selector.GetHandle ("additionalActionsButtonItem");
		[CompilerGenerated]
		const string selLeftBarButtonItems = "leftBarButtonItems";
		static readonly IntPtr selLeftBarButtonItemsHandle = Selector.GetHandle ("leftBarButtonItems");
		[CompilerGenerated]
		const string selSetLeftBarButtonItems_ = "setLeftBarButtonItems:";
		static readonly IntPtr selSetLeftBarButtonItems_Handle = Selector.GetHandle ("setLeftBarButtonItems:");
		[CompilerGenerated]
		const string selRightBarButtonItems = "rightBarButtonItems";
		static readonly IntPtr selRightBarButtonItemsHandle = Selector.GetHandle ("rightBarButtonItems");
		[CompilerGenerated]
		const string selSetRightBarButtonItems_ = "setRightBarButtonItems:";
		static readonly IntPtr selSetRightBarButtonItems_Handle = Selector.GetHandle ("setRightBarButtonItems:");
		[CompilerGenerated]
		const string selAdditionalRightBarButtonItems = "additionalRightBarButtonItems";
		static readonly IntPtr selAdditionalRightBarButtonItemsHandle = Selector.GetHandle ("additionalRightBarButtonItems");
		[CompilerGenerated]
		const string selSetAdditionalRightBarButtonItems_ = "setAdditionalRightBarButtonItems:";
		static readonly IntPtr selSetAdditionalRightBarButtonItems_Handle = Selector.GetHandle ("setAdditionalRightBarButtonItems:");
		[CompilerGenerated]
		const string selBarButtonItemsAlwaysEnabled = "barButtonItemsAlwaysEnabled";
		static readonly IntPtr selBarButtonItemsAlwaysEnabledHandle = Selector.GetHandle ("barButtonItemsAlwaysEnabled");
		[CompilerGenerated]
		const string selSetBarButtonItemsAlwaysEnabled_ = "setBarButtonItemsAlwaysEnabled:";
		static readonly IntPtr selSetBarButtonItemsAlwaysEnabled_Handle = Selector.GetHandle ("setBarButtonItemsAlwaysEnabled:");
		[CompilerGenerated]
		const string selMinLeftToolbarWidth = "minLeftToolbarWidth";
		static readonly IntPtr selMinLeftToolbarWidthHandle = Selector.GetHandle ("minLeftToolbarWidth");
		[CompilerGenerated]
		const string selSetMinLeftToolbarWidth_ = "setMinLeftToolbarWidth:";
		static readonly IntPtr selSetMinLeftToolbarWidth_Handle = Selector.GetHandle ("setMinLeftToolbarWidth:");
		[CompilerGenerated]
		const string selMinRightToolbarWidth = "minRightToolbarWidth";
		static readonly IntPtr selMinRightToolbarWidthHandle = Selector.GetHandle ("minRightToolbarWidth");
		[CompilerGenerated]
		const string selSetMinRightToolbarWidth_ = "setMinRightToolbarWidth:";
		static readonly IntPtr selSetMinRightToolbarWidth_Handle = Selector.GetHandle ("setMinRightToolbarWidth:");
		[CompilerGenerated]
		const string selUseBorderedToolbarStyle = "useBorderedToolbarStyle";
		static readonly IntPtr selUseBorderedToolbarStyleHandle = Selector.GetHandle ("useBorderedToolbarStyle");
		[CompilerGenerated]
		const string selSetUseBorderedToolbarStyle_ = "setUseBorderedToolbarStyle:";
		static readonly IntPtr selSetUseBorderedToolbarStyle_Handle = Selector.GetHandle ("setUseBorderedToolbarStyle:");
		[CompilerGenerated]
		const string selPageMode = "pageMode";
		static readonly IntPtr selPageModeHandle = Selector.GetHandle ("pageMode");
		[CompilerGenerated]
		const string selSetPageMode_ = "setPageMode:";
		static readonly IntPtr selSetPageMode_Handle = Selector.GetHandle ("setPageMode:");
		[CompilerGenerated]
		const string selPageTransition = "pageTransition";
		static readonly IntPtr selPageTransitionHandle = Selector.GetHandle ("pageTransition");
		[CompilerGenerated]
		const string selSetPageTransition_ = "setPageTransition:";
		static readonly IntPtr selSetPageTransition_Handle = Selector.GetHandle ("setPageTransition:");
		[CompilerGenerated]
		const string selScrollDirection = "scrollDirection";
		static readonly IntPtr selScrollDirectionHandle = Selector.GetHandle ("scrollDirection");
		[CompilerGenerated]
		const string selSetScrollDirection_ = "setScrollDirection:";
		static readonly IntPtr selSetScrollDirection_Handle = Selector.GetHandle ("setScrollDirection:");
		[CompilerGenerated]
		const string selIsDoublePageModeOnFirstPage = "isDoublePageModeOnFirstPage";
		static readonly IntPtr selIsDoublePageModeOnFirstPageHandle = Selector.GetHandle ("isDoublePageModeOnFirstPage");
		[CompilerGenerated]
		const string selSetDoublePageModeOnFirstPage_ = "setDoublePageModeOnFirstPage:";
		static readonly IntPtr selSetDoublePageModeOnFirstPage_Handle = Selector.GetHandle ("setDoublePageModeOnFirstPage:");
		[CompilerGenerated]
		const string selIsZoomingSmallDocumentsEnabled = "isZoomingSmallDocumentsEnabled";
		static readonly IntPtr selIsZoomingSmallDocumentsEnabledHandle = Selector.GetHandle ("isZoomingSmallDocumentsEnabled");
		[CompilerGenerated]
		const string selSetZoomingSmallDocumentsEnabled_ = "setZoomingSmallDocumentsEnabled:";
		static readonly IntPtr selSetZoomingSmallDocumentsEnabled_Handle = Selector.GetHandle ("setZoomingSmallDocumentsEnabled:");
		[CompilerGenerated]
		const string selIsPageCurlDirectionLeftToRight = "isPageCurlDirectionLeftToRight";
		static readonly IntPtr selIsPageCurlDirectionLeftToRightHandle = Selector.GetHandle ("isPageCurlDirectionLeftToRight");
		[CompilerGenerated]
		const string selSetPageCurlDirectionLeftToRight_ = "setPageCurlDirectionLeftToRight:";
		static readonly IntPtr selSetPageCurlDirectionLeftToRight_Handle = Selector.GetHandle ("setPageCurlDirectionLeftToRight:");
		[CompilerGenerated]
		const string selIsFitToWidthEnabled = "isFitToWidthEnabled";
		static readonly IntPtr selIsFitToWidthEnabledHandle = Selector.GetHandle ("isFitToWidthEnabled");
		[CompilerGenerated]
		const string selSetFitToWidthEnabled_ = "setFitToWidthEnabled:";
		static readonly IntPtr selSetFitToWidthEnabled_Handle = Selector.GetHandle ("setFitToWidthEnabled:");
		[CompilerGenerated]
		const string selFixedVerticalPositionForFitToWidthEnabledMode = "fixedVerticalPositionForFitToWidthEnabledMode";
		static readonly IntPtr selFixedVerticalPositionForFitToWidthEnabledModeHandle = Selector.GetHandle ("fixedVerticalPositionForFitToWidthEnabledMode");
		[CompilerGenerated]
		const string selSetFixedVerticalPositionForFitToWidthEnabledMode_ = "setFixedVerticalPositionForFitToWidthEnabledMode:";
		static readonly IntPtr selSetFixedVerticalPositionForFitToWidthEnabledMode_Handle = Selector.GetHandle ("setFixedVerticalPositionForFitToWidthEnabledMode:");
		[CompilerGenerated]
		const string selClipToPageBoundaries = "clipToPageBoundaries";
		static readonly IntPtr selClipToPageBoundariesHandle = Selector.GetHandle ("clipToPageBoundaries");
		[CompilerGenerated]
		const string selSetClipToPageBoundaries_ = "setClipToPageBoundaries:";
		static readonly IntPtr selSetClipToPageBoundaries_Handle = Selector.GetHandle ("setClipToPageBoundaries:");
		[CompilerGenerated]
		const string selMinimumZoomScale = "minimumZoomScale";
		static readonly IntPtr selMinimumZoomScaleHandle = Selector.GetHandle ("minimumZoomScale");
		[CompilerGenerated]
		const string selSetMinimumZoomScale_ = "setMinimumZoomScale:";
		static readonly IntPtr selSetMinimumZoomScale_Handle = Selector.GetHandle ("setMinimumZoomScale:");
		[CompilerGenerated]
		const string selMaximumZoomScale = "maximumZoomScale";
		static readonly IntPtr selMaximumZoomScaleHandle = Selector.GetHandle ("maximumZoomScale");
		[CompilerGenerated]
		const string selSetMaximumZoomScale_ = "setMaximumZoomScale:";
		static readonly IntPtr selSetMaximumZoomScale_Handle = Selector.GetHandle ("setMaximumZoomScale:");
		[CompilerGenerated]
		const string selPagePadding = "pagePadding";
		static readonly IntPtr selPagePaddingHandle = Selector.GetHandle ("pagePadding");
		[CompilerGenerated]
		const string selSetPagePadding_ = "setPagePadding:";
		static readonly IntPtr selSetPagePadding_Handle = Selector.GetHandle ("setPagePadding:");
		[CompilerGenerated]
		const string selIsShadowEnabled = "isShadowEnabled";
		static readonly IntPtr selIsShadowEnabledHandle = Selector.GetHandle ("isShadowEnabled");
		[CompilerGenerated]
		const string selSetShadowEnabled_ = "setShadowEnabled:";
		static readonly IntPtr selSetShadowEnabled_Handle = Selector.GetHandle ("setShadowEnabled:");
		[CompilerGenerated]
		const string selStatusBarStyleSetting = "statusBarStyleSetting";
		static readonly IntPtr selStatusBarStyleSettingHandle = Selector.GetHandle ("statusBarStyleSetting");
		[CompilerGenerated]
		const string selSetStatusBarStyleSetting_ = "setStatusBarStyleSetting:";
		static readonly IntPtr selSetStatusBarStyleSetting_Handle = Selector.GetHandle ("setStatusBarStyleSetting:");
		[CompilerGenerated]
		const string selStatusBarStyle = "statusBarStyle";
		static readonly IntPtr selStatusBarStyleHandle = Selector.GetHandle ("statusBarStyle");
		[CompilerGenerated]
		const string selSetStatusBarStyle_ = "setStatusBarStyle:";
		static readonly IntPtr selSetStatusBarStyle_Handle = Selector.GetHandle ("setStatusBarStyle:");
		[CompilerGenerated]
		const string selNavigationBarStyle = "navigationBarStyle";
		static readonly IntPtr selNavigationBarStyleHandle = Selector.GetHandle ("navigationBarStyle");
		[CompilerGenerated]
		const string selSetNavigationBarStyle_ = "setNavigationBarStyle:";
		static readonly IntPtr selSetNavigationBarStyle_Handle = Selector.GetHandle ("setNavigationBarStyle:");
		[CompilerGenerated]
		const string selIsTransparentHUD = "isTransparentHUD";
		static readonly IntPtr selIsTransparentHUDHandle = Selector.GetHandle ("isTransparentHUD");
		[CompilerGenerated]
		const string selSetTransparentHUD_ = "setTransparentHUD:";
		static readonly IntPtr selSetTransparentHUD_Handle = Selector.GetHandle ("setTransparentHUD:");
		[CompilerGenerated]
		const string selShouldHideNavigationBarWithHUD = "shouldHideNavigationBarWithHUD";
		static readonly IntPtr selShouldHideNavigationBarWithHUDHandle = Selector.GetHandle ("shouldHideNavigationBarWithHUD");
		[CompilerGenerated]
		const string selSetShouldHideNavigationBarWithHUD_ = "setShouldHideNavigationBarWithHUD:";
		static readonly IntPtr selSetShouldHideNavigationBarWithHUD_Handle = Selector.GetHandle ("setShouldHideNavigationBarWithHUD:");
		[CompilerGenerated]
		const string selShouldHideStatusBarWithHUD = "shouldHideStatusBarWithHUD";
		static readonly IntPtr selShouldHideStatusBarWithHUDHandle = Selector.GetHandle ("shouldHideStatusBarWithHUD");
		[CompilerGenerated]
		const string selSetShouldHideStatusBarWithHUD_ = "setShouldHideStatusBarWithHUD:";
		static readonly IntPtr selSetShouldHideStatusBarWithHUD_Handle = Selector.GetHandle ("setShouldHideStatusBarWithHUD:");
		[CompilerGenerated]
		const string selBackgroundColor = "backgroundColor";
		static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle ("backgroundColor");
		[CompilerGenerated]
		const string selSetBackgroundColor_ = "setBackgroundColor:";
		static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle ("setBackgroundColor:");
		[CompilerGenerated]
		const string selTintColor = "tintColor";
		static readonly IntPtr selTintColorHandle = Selector.GetHandle ("tintColor");
		[CompilerGenerated]
		const string selSetTintColor_ = "setTintColor:";
		static readonly IntPtr selSetTintColor_Handle = Selector.GetHandle ("setTintColor:");
		[CompilerGenerated]
		const string selShouldTintPopovers = "shouldTintPopovers";
		static readonly IntPtr selShouldTintPopoversHandle = Selector.GetHandle ("shouldTintPopovers");
		[CompilerGenerated]
		const string selSetShouldTintPopovers_ = "setShouldTintPopovers:";
		static readonly IntPtr selSetShouldTintPopovers_Handle = Selector.GetHandle ("setShouldTintPopovers:");
		[CompilerGenerated]
		const string selShouldTintAlertView = "shouldTintAlertView";
		static readonly IntPtr selShouldTintAlertViewHandle = Selector.GetHandle ("shouldTintAlertView");
		[CompilerGenerated]
		const string selSetShouldTintAlertView_ = "setShouldTintAlertView:";
		static readonly IntPtr selSetShouldTintAlertView_Handle = Selector.GetHandle ("setShouldTintAlertView:");
		[CompilerGenerated]
		const string selIsNavigationBarHidden = "isNavigationBarHidden";
		static readonly IntPtr selIsNavigationBarHiddenHandle = Selector.GetHandle ("isNavigationBarHidden");
		[CompilerGenerated]
		const string selAnnotationAnimationDuration = "annotationAnimationDuration";
		static readonly IntPtr selAnnotationAnimationDurationHandle = Selector.GetHandle ("annotationAnimationDuration");
		[CompilerGenerated]
		const string selSetAnnotationAnimationDuration_ = "setAnnotationAnimationDuration:";
		static readonly IntPtr selSetAnnotationAnimationDuration_Handle = Selector.GetHandle ("setAnnotationAnimationDuration:");
		[CompilerGenerated]
		const string selIsCreateAnnotationMenuEnabled = "isCreateAnnotationMenuEnabled";
		static readonly IntPtr selIsCreateAnnotationMenuEnabledHandle = Selector.GetHandle ("isCreateAnnotationMenuEnabled");
		[CompilerGenerated]
		const string selSetCreateAnnotationMenuEnabled_ = "setCreateAnnotationMenuEnabled:";
		static readonly IntPtr selSetCreateAnnotationMenuEnabled_Handle = Selector.GetHandle ("setCreateAnnotationMenuEnabled:");
		[CompilerGenerated]
		const string selShowAnnotationMenuAfterCreation = "showAnnotationMenuAfterCreation";
		static readonly IntPtr selShowAnnotationMenuAfterCreationHandle = Selector.GetHandle ("showAnnotationMenuAfterCreation");
		[CompilerGenerated]
		const string selSetShowAnnotationMenuAfterCreation_ = "setShowAnnotationMenuAfterCreation:";
		static readonly IntPtr selSetShowAnnotationMenuAfterCreation_Handle = Selector.GetHandle ("setShowAnnotationMenuAfterCreation:");
		[CompilerGenerated]
		const string selPopoverController = "popoverController";
		static readonly IntPtr selPopoverControllerHandle = Selector.GetHandle ("popoverController");
		[CompilerGenerated]
		const string selSetPopoverController_ = "setPopoverController:";
		static readonly IntPtr selSetPopoverController_Handle = Selector.GetHandle ("setPopoverController:");
		[CompilerGenerated]
		const string selPagingScrollView = "pagingScrollView";
		static readonly IntPtr selPagingScrollViewHandle = Selector.GetHandle ("pagingScrollView");
		[CompilerGenerated]
		const string selViewMode = "viewMode";
		static readonly IntPtr selViewModeHandle = Selector.GetHandle ("viewMode");
		[CompilerGenerated]
		const string selSetViewMode_ = "setViewMode:";
		static readonly IntPtr selSetViewMode_Handle = Selector.GetHandle ("setViewMode:");
		[CompilerGenerated]
		const string selThumbnailController = "thumbnailController";
		static readonly IntPtr selThumbnailControllerHandle = Selector.GetHandle ("thumbnailController");
		[CompilerGenerated]
		const string selSetThumbnailController_ = "setThumbnailController:";
		static readonly IntPtr selSetThumbnailController_Handle = Selector.GetHandle ("setThumbnailController:");
		[CompilerGenerated]
		const string selThumbnailSize = "thumbnailSize";
		static readonly IntPtr selThumbnailSizeHandle = Selector.GetHandle ("thumbnailSize");
		[CompilerGenerated]
		const string selSetThumbnailSize_ = "setThumbnailSize:";
		static readonly IntPtr selSetThumbnailSize_Handle = Selector.GetHandle ("setThumbnailSize:");
		[CompilerGenerated]
		const string selThumbnailMargin = "thumbnailMargin";
		static readonly IntPtr selThumbnailMarginHandle = Selector.GetHandle ("thumbnailMargin");
		[CompilerGenerated]
		const string selSetThumbnailMargin_ = "setThumbnailMargin:";
		static readonly IntPtr selSetThumbnailMargin_Handle = Selector.GetHandle ("setThumbnailMargin:");
		[CompilerGenerated]
		const string selVisiblePageNumbers = "visiblePageNumbers";
		static readonly IntPtr selVisiblePageNumbersHandle = Selector.GetHandle ("visiblePageNumbers");
		[CompilerGenerated]
		const string selVisiblePageViews = "visiblePageViews";
		static readonly IntPtr selVisiblePageViewsHandle = Selector.GetHandle ("visiblePageViews");
		[CompilerGenerated]
		const string selIsDoublePageMode = "isDoublePageMode";
		static readonly IntPtr selIsDoublePageModeHandle = Selector.GetHandle ("isDoublePageMode");
		[CompilerGenerated]
		const string selIsLastPage = "isLastPage";
		static readonly IntPtr selIsLastPageHandle = Selector.GetHandle ("isLastPage");
		[CompilerGenerated]
		const string selIsFirstPage = "isFirstPage";
		static readonly IntPtr selIsFirstPageHandle = Selector.GetHandle ("isFirstPage");
		[CompilerGenerated]
		const string selMasterViewController = "masterViewController";
		static readonly IntPtr selMasterViewControllerHandle = Selector.GetHandle ("masterViewController");
		[CompilerGenerated]
		const string selOverrideClassNames = "overrideClassNames";
		static readonly IntPtr selOverrideClassNamesHandle = Selector.GetHandle ("overrideClassNames");
		[CompilerGenerated]
		const string selSetOverrideClassNames_ = "setOverrideClassNames:";
		static readonly IntPtr selSetOverrideClassNames_Handle = Selector.GetHandle ("setOverrideClassNames:");
		[CompilerGenerated]
		const string selPageTransitionController = "pageTransitionController";
		static readonly IntPtr selPageTransitionControllerHandle = Selector.GetHandle ("pageTransitionController");
		[CompilerGenerated]
		const string selPageLabel = "pageLabel";
		static readonly IntPtr selPageLabelHandle = Selector.GetHandle ("pageLabel");
		[CompilerGenerated]
		const string selSetPageLabel_ = "setPageLabel:";
		static readonly IntPtr selSetPageLabel_Handle = Selector.GetHandle ("setPageLabel:");
		[CompilerGenerated]
		const string selScrobbleBar = "scrobbleBar";
		static readonly IntPtr selScrobbleBarHandle = Selector.GetHandle ("scrobbleBar");
		[CompilerGenerated]
		const string selSetScrobbleBar_ = "setScrobbleBar:";
		static readonly IntPtr selSetScrobbleBar_Handle = Selector.GetHandle ("setScrobbleBar:");
		[CompilerGenerated]
		const string selDocumentLabel = "documentLabel";
		static readonly IntPtr selDocumentLabelHandle = Selector.GetHandle ("documentLabel");
		[CompilerGenerated]
		const string selSetDocumentLabel_ = "setDocumentLabel:";
		static readonly IntPtr selSetDocumentLabel_Handle = Selector.GetHandle ("setDocumentLabel:");
		[CompilerGenerated]
		const string selAnnotationViewCache = "annotationViewCache";
		static readonly IntPtr selAnnotationViewCacheHandle = Selector.GetHandle ("annotationViewCache");
		[CompilerGenerated]
		const string selInitWithDocument_ = "initWithDocument:";
		static readonly IntPtr selInitWithDocument_Handle = Selector.GetHandle ("initWithDocument:");
		[CompilerGenerated]
		const string selSetPageAnimated_ = "setPage:animated:";
		static readonly IntPtr selSetPageAnimated_Handle = Selector.GetHandle ("setPage:animated:");
		[CompilerGenerated]
		const string selScrollToNextPageAnimated_ = "scrollToNextPageAnimated:";
		static readonly IntPtr selScrollToNextPageAnimated_Handle = Selector.GetHandle ("scrollToNextPageAnimated:");
		[CompilerGenerated]
		const string selScrollToPreviousPageAnimated_ = "scrollToPreviousPageAnimated:";
		static readonly IntPtr selScrollToPreviousPageAnimated_Handle = Selector.GetHandle ("scrollToPreviousPageAnimated:");
		[CompilerGenerated]
		const string selScrollRectToVisibleAnimated_ = "scrollRectToVisible:animated:";
		static readonly IntPtr selScrollRectToVisibleAnimated_Handle = Selector.GetHandle ("scrollRectToVisible:animated:");
		[CompilerGenerated]
		const string selZoomToRectAnimated_ = "zoomToRect:animated:";
		static readonly IntPtr selZoomToRectAnimated_Handle = Selector.GetHandle ("zoomToRect:animated:");
		[CompilerGenerated]
		const string selSetZoomScaleAnimated_ = "setZoomScale:animated:";
		static readonly IntPtr selSetZoomScaleAnimated_Handle = Selector.GetHandle ("setZoomScale:animated:");
		[CompilerGenerated]
		const string selSetViewStateAnimated_ = "setViewState:animated:";
		static readonly IntPtr selSetViewStateAnimated_Handle = Selector.GetHandle ("setViewState:animated:");
		[CompilerGenerated]
		const string selSearchForStringAnimated_ = "searchForString:animated:";
		static readonly IntPtr selSearchForStringAnimated_Handle = Selector.GetHandle ("searchForString:animated:");
		[CompilerGenerated]
		const string selSetHUDVisibleAnimated_ = "setHUDVisible:animated:";
		static readonly IntPtr selSetHUDVisibleAnimated_Handle = Selector.GetHandle ("setHUDVisible:animated:");
		[CompilerGenerated]
		const string selShowControlsAnimated_ = "showControlsAnimated:";
		static readonly IntPtr selShowControlsAnimated_Handle = Selector.GetHandle ("showControlsAnimated:");
		[CompilerGenerated]
		const string selHideControlsAnimated_ = "hideControlsAnimated:";
		static readonly IntPtr selHideControlsAnimated_Handle = Selector.GetHandle ("hideControlsAnimated:");
		[CompilerGenerated]
		const string selHideControlsAndPageElementsAnimated_ = "hideControlsAndPageElementsAnimated:";
		static readonly IntPtr selHideControlsAndPageElementsAnimated_Handle = Selector.GetHandle ("hideControlsAndPageElementsAnimated:");
		[CompilerGenerated]
		const string selToggleControlsAnimated_ = "toggleControlsAnimated:";
		static readonly IntPtr selToggleControlsAnimated_Handle = Selector.GetHandle ("toggleControlsAnimated:");
		[CompilerGenerated]
		const string selSetScrobbleBarEnabledAnimated_ = "setScrobbleBarEnabled:animated:";
		static readonly IntPtr selSetScrobbleBarEnabledAnimated_Handle = Selector.GetHandle ("setScrobbleBarEnabled:animated:");
		[CompilerGenerated]
		const string selAlertViewTintColor = "alertViewTintColor";
		static readonly IntPtr selAlertViewTintColorHandle = Selector.GetHandle ("alertViewTintColor");
		[CompilerGenerated]
		const string selPageViewForPage_ = "pageViewForPage:";
		static readonly IntPtr selPageViewForPage_Handle = Selector.GetHandle ("pageViewForPage:");
		[CompilerGenerated]
		const string selSetViewModeAnimated_ = "setViewMode:animated:";
		static readonly IntPtr selSetViewModeAnimated_Handle = Selector.GetHandle ("setViewMode:animated:");
		[CompilerGenerated]
		const string selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_ = "presentModalViewController:embeddedInNavigationController:withCloseButton:animated:";
		static readonly IntPtr selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_Handle = Selector.GetHandle ("presentModalViewController:embeddedInNavigationController:withCloseButton:animated:");
		[CompilerGenerated]
		const string selPresentViewControllerModalOrPopoverEmbeddedInNavigationControllerWithCloseButtonAnimatedSenderOptions_ = "presentViewControllerModalOrPopover:embeddedInNavigationController:withCloseButton:animated:sender:options:";
		static readonly IntPtr selPresentViewControllerModalOrPopoverEmbeddedInNavigationControllerWithCloseButtonAnimatedSenderOptions_Handle = Selector.GetHandle ("presentViewControllerModalOrPopover:embeddedInNavigationController:withCloseButton:animated:sender:options:");
		[CompilerGenerated]
		const string selIsDoublePageModeForOrientation_ = "isDoublePageModeForOrientation:";
		static readonly IntPtr selIsDoublePageModeForOrientation_Handle = Selector.GetHandle ("isDoublePageModeForOrientation:");
		[CompilerGenerated]
		const string selIsDoublePageModeForPage_ = "isDoublePageModeForPage:";
		static readonly IntPtr selIsDoublePageModeForPage_Handle = Selector.GetHandle ("isDoublePageModeForPage:");
		[CompilerGenerated]
		const string selIsRightPageInDoublePageMode_ = "isRightPageInDoublePageMode:";
		static readonly IntPtr selIsRightPageInDoublePageMode_Handle = Selector.GetHandle ("isRightPageInDoublePageMode:");
		[CompilerGenerated]
		const string selCommonInitWithDocument_ = "commonInitWithDocument:";
		static readonly IntPtr selCommonInitWithDocument_Handle = Selector.GetHandle ("commonInitWithDocument:");
		[CompilerGenerated]
		const string selReloadData = "reloadData";
		static readonly IntPtr selReloadDataHandle = Selector.GetHandle ("reloadData");
		[CompilerGenerated]
		const string selCreateToolbarAnimated_ = "createToolbarAnimated:";
		static readonly IntPtr selCreateToolbarAnimated_Handle = Selector.GetHandle ("createToolbarAnimated:");
		[CompilerGenerated]
		const string selUpdateToolbarAnimated_ = "updateToolbarAnimated:";
		static readonly IntPtr selUpdateToolbarAnimated_Handle = Selector.GetHandle ("updateToolbarAnimated:");
		[CompilerGenerated]
		const string selUpdateBarButtonItemAnimated_ = "updateBarButtonItem:animated:";
		static readonly IntPtr selUpdateBarButtonItemAnimated_Handle = Selector.GetHandle ("updateBarButtonItem:animated:");
		[CompilerGenerated]
		const string selUpdateSettingsForRotation_ = "updateSettingsForRotation:";
		static readonly IntPtr selUpdateSettingsForRotation_Handle = Selector.GetHandle ("updateSettingsForRotation:");
		[CompilerGenerated]
		const string selSetUpdateSettingsForRotationBlock_ = "setUpdateSettingsForRotationBlock:";
		static readonly IntPtr selSetUpdateSettingsForRotationBlock_Handle = Selector.GetHandle ("setUpdateSettingsForRotationBlock:");
		[CompilerGenerated]
		const string selClearHighlightedSearchResults = "clearHighlightedSearchResults";
		static readonly IntPtr selClearHighlightedSearchResultsHandle = Selector.GetHandle ("clearHighlightedSearchResults");
		[CompilerGenerated]
		const string selAddHighlightSearchResults_ = "addHighlightSearchResults:";
		static readonly IntPtr selAddHighlightSearchResults_Handle = Selector.GetHandle ("addHighlightSearchResults:");
		[CompilerGenerated]
		const string selAnimateSearchHighlight_ = "animateSearchHighlight:";
		static readonly IntPtr selAnimateSearchHighlight_Handle = Selector.GetHandle ("animateSearchHighlight:");
		[CompilerGenerated]
		const string selContentRect = "contentRect";
		static readonly IntPtr selContentRectHandle = Selector.GetHandle ("contentRect");
		[CompilerGenerated]
		const string selVisibleAnnotationToolbar = "visibleAnnotationToolbar";
		static readonly IntPtr selVisibleAnnotationToolbarHandle = Selector.GetHandle ("visibleAnnotationToolbar");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFViewController (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDocument_Handle, document == null ? IntPtr.Zero : document.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDocument_Handle, document == null ? IntPtr.Zero : document.Handle);
			}
		}
		
		[Export ("setPage:animated:")]
		[CompilerGenerated]
		public virtual bool SetPageAnimated (global::System.UInt32 page, bool animated)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_UInt32_bool (this.Handle, selSetPageAnimated_Handle, page, animated);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_bool (this.SuperHandle, selSetPageAnimated_Handle, page, animated);
			}
		}
		
		[Export ("scrollToNextPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToNextPageAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selScrollToNextPageAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selScrollToNextPageAnimated_Handle, animated);
			}
		}
		
		[Export ("scrollToPreviousPageAnimated:")]
		[CompilerGenerated]
		public virtual bool ScrollToPreviousPageAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selScrollToPreviousPageAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selScrollToPreviousPageAnimated_Handle, animated);
			}
		}
		
		[Export ("scrollRectToVisible:animated:")]
		[CompilerGenerated]
		public virtual void ScrollRectToVisibleAnimated (global::System.Drawing.RectangleF rec, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selScrollRectToVisibleAnimated_Handle, rec, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selScrollRectToVisibleAnimated_Handle, rec, animated);
			}
		}
		
		[Export ("zoomToRect:animated:")]
		[CompilerGenerated]
		public virtual void ZoomToRectAnimated (global::System.Drawing.RectangleF rec, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selZoomToRectAnimated_Handle, rec, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selZoomToRectAnimated_Handle, rec, animated);
			}
		}
		
		[Export ("setZoomScale:animated:")]
		[CompilerGenerated]
		public virtual void SetZoomScale (float scale, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float_bool (this.Handle, selSetZoomScaleAnimated_Handle, scale, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float_bool (this.SuperHandle, selSetZoomScaleAnimated_Handle, scale, animated);
			}
		}
		
		[Export ("setViewState:animated:")]
		[CompilerGenerated]
		public virtual void SetViewStateAnimated (PSPDFViewState viewState, bool animated)
		{
			if (viewState == null)
				throw new ArgumentNullException ("viewState");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetViewStateAnimated_Handle, viewState.Handle, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetViewStateAnimated_Handle, viewState.Handle, animated);
			}
			#pragma warning disable 168
			var postget0 = ViewState;
			#pragma warning restore 168
		}
		
		[Export ("searchForString:animated:")]
		[CompilerGenerated]
		public virtual void SearchForStringAnimated (string searchText, bool animated)
		{
			if (searchText == null)
				throw new ArgumentNullException ("searchText");
			var nssearchText = NSString.CreateNative (searchText);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSearchForStringAnimated_Handle, nssearchText, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSearchForStringAnimated_Handle, nssearchText, animated);
			}
			NSString.ReleaseNative (nssearchText);
			
		}
		
		[Export ("setHUDVisible:animated:")]
		[CompilerGenerated]
		public virtual bool SetHUDVisibleAnimated (bool show, bool animated)
		{
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_bool_bool (this.Handle, selSetHUDVisibleAnimated_Handle, show, animated);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_bool_bool (this.SuperHandle, selSetHUDVisibleAnimated_Handle, show, animated);
			}
			#pragma warning disable 168
			var postget0 = HUDVisible;
			#pragma warning restore 168
			return ret;
		}
		
		[Export ("showControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool ShowControls (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selShowControlsAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selShowControlsAnimated_Handle, animated);
			}
		}
		
		[Export ("hideControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControls (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selHideControlsAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selHideControlsAnimated_Handle, animated);
			}
		}
		
		[Export ("hideControlsAndPageElementsAnimated:")]
		[CompilerGenerated]
		public virtual bool HideControlsAndPageElements (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selHideControlsAndPageElementsAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selHideControlsAndPageElementsAnimated_Handle, animated);
			}
		}
		
		[Export ("toggleControlsAnimated:")]
		[CompilerGenerated]
		public virtual bool ToggleControls (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selToggleControlsAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selToggleControlsAnimated_Handle, animated);
			}
		}
		
		[Export ("setScrobbleBarEnabled:animated:")]
		[CompilerGenerated]
		public virtual void SetScrobbleBarEnabled (bool scrobbleBarEnabled, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (this.Handle, selSetScrobbleBarEnabledAnimated_Handle, scrobbleBarEnabled, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, selSetScrobbleBarEnabledAnimated_Handle, scrobbleBarEnabled, animated);
			}
		}
		
		[Export ("alertViewTintColor")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor AlertViewTintColor ()
		{
			if (IsDirectBinding) {
				return (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlertViewTintColorHandle));
			} else {
				return (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAlertViewTintColorHandle));
			}
		}
		
		[Export ("pageViewForPage:")]
		[CompilerGenerated]
		public virtual PSPDFPageView PageViewForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selPageViewForPage_Handle, page));
			} else {
				return (PSPDFPageView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selPageViewForPage_Handle, page));
			}
		}
		
		[Export ("setViewMode:animated:")]
		[CompilerGenerated]
		public virtual void setViewModeAnimated (PSPDFViewMode viewMode, bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSetViewModeAnimated_Handle, (int)viewMode, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSetViewModeAnimated_Handle, (int)viewMode, animated);
			}
			#pragma warning disable 168
			var postget0 = ViewMode;
			#pragma warning restore 168
		}
		
		[Export ("presentModalViewController:embeddedInNavigationController:withCloseButton:animated:")]
		[CompilerGenerated]
		public virtual void PresentModalViewController (global::MonoTouch.UIKit.UIViewController controller, bool embedded, bool closeButton, bool animated)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_bool_bool (this.Handle, selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_Handle, controller.Handle, embedded, closeButton, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_bool (this.SuperHandle, selPresentModalViewControllerEmbeddedInNavigationControllerWithCloseButtonAnimated_Handle, controller.Handle, embedded, closeButton, animated);
			}
		}
		
		[Export ("presentViewControllerModalOrPopover:embeddedInNavigationController:withCloseButton:animated:sender:options:")]
		[CompilerGenerated]
		public virtual NSObject PresentViewControllerModalOrPopover (global::MonoTouch.UIKit.UIViewController controller, bool embedded, bool closeButton, bool animated, NSObject sender, NSDictionary options)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_bool_IntPtr_IntPtr (this.Handle, selPresentViewControllerModalOrPopoverEmbeddedInNavigationControllerWithCloseButtonAnimatedSenderOptions_Handle, controller.Handle, embedded, closeButton, animated, sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_bool_IntPtr_IntPtr (this.SuperHandle, selPresentViewControllerModalOrPopoverEmbeddedInNavigationControllerWithCloseButtonAnimatedSenderOptions_Handle, controller.Handle, embedded, closeButton, animated, sender == null ? IntPtr.Zero : sender.Handle, options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("isDoublePageModeForOrientation:")]
		[CompilerGenerated]
		public virtual bool IsDoublePageModeForOrientation (global::MonoTouch.UIKit.UIInterfaceOrientation interfaceOrientation)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_int (this.Handle, selIsDoublePageModeForOrientation_Handle, (int)interfaceOrientation);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, selIsDoublePageModeForOrientation_Handle, (int)interfaceOrientation);
			}
		}
		
		[Export ("isDoublePageModeForPage:")]
		[CompilerGenerated]
		public virtual bool IsDoublePageModeForPage (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selIsDoublePageModeForPage_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selIsDoublePageModeForPage_Handle, page);
			}
		}
		
		[Export ("isRightPageInDoublePageMode:")]
		[CompilerGenerated]
		public virtual bool IsRightPageInDoublePageMode (global::System.UInt32 page)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selIsRightPageInDoublePageMode_Handle, page);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selIsRightPageInDoublePageMode_Handle, page);
			}
		}
		
		[Export ("commonInitWithDocument:")]
		[CompilerGenerated]
		public virtual void CommonInitWithDocument (PSPDFDocument document)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCommonInitWithDocument_Handle, document == null ? IntPtr.Zero : document.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCommonInitWithDocument_Handle, document == null ? IntPtr.Zero : document.Handle);
			}
		}
		
		[Export ("reloadData")]
		[CompilerGenerated]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReloadDataHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReloadDataHandle);
			}
		}
		
		[Export ("createToolbarAnimated:")]
		[CompilerGenerated]
		public virtual bool CreateToolbarAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selCreateToolbarAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selCreateToolbarAnimated_Handle, animated);
			}
		}
		
		[Export ("updateToolbarAnimated:")]
		[CompilerGenerated]
		public virtual bool UpdateToolbarAnimated (bool animated)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_bool (this.Handle, selUpdateToolbarAnimated_Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, selUpdateToolbarAnimated_Handle, animated);
			}
		}
		
		[Export ("updateBarButtonItem:animated:")]
		[CompilerGenerated]
		public virtual bool UpdateBarButtonItem (global::MonoTouch.UIKit.UIBarButtonItem barButtonItem, bool animated)
		{
			if (barButtonItem == null)
				throw new ArgumentNullException ("barButtonItem");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, selUpdateBarButtonItemAnimated_Handle, barButtonItem.Handle, animated);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selUpdateBarButtonItemAnimated_Handle, barButtonItem.Handle, animated);
			}
		}
		
		[Export ("updateSettingsForRotation:")]
		[CompilerGenerated]
		public virtual void UpdateSettingsForRotation (global::MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selUpdateSettingsForRotation_Handle, (int)toInterfaceOrientation);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selUpdateSettingsForRotation_Handle, (int)toInterfaceOrientation);
			}
		}
		
		[Export ("setUpdateSettingsForRotationBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetUpdateSettingsForRotationBlock (PSPDFViewControllerUpdateSettingsBlock block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (static_InnerPSPDFViewControllerUpdateSettingsBlock, block);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUpdateSettingsForRotationBlock_Handle, (IntPtr) block_ptr_block);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUpdateSettingsForRotationBlock_Handle, (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("clearHighlightedSearchResults")]
		[CompilerGenerated]
		public virtual void ClearHighlightedSearchResults ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearHighlightedSearchResultsHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearHighlightedSearchResultsHandle);
			}
		}
		
		[Export ("addHighlightSearchResults:")]
		[CompilerGenerated]
		public virtual void AddHighlightSearchResults (PSPDFSearchResult[] searchResults)
		{
			if (searchResults == null)
				throw new ArgumentNullException ("searchResults");
			var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddHighlightSearchResults_Handle, nsa_searchResults.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddHighlightSearchResults_Handle, nsa_searchResults.Handle);
			}
			nsa_searchResults.Dispose ();
			
		}
		
		[Export ("animateSearchHighlight:")]
		[CompilerGenerated]
		public virtual void AnimateSearchHighlight (PSPDFSearchResult searchResult)
		{
			if (searchResult == null)
				throw new ArgumentNullException ("searchResult");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAnimateSearchHighlight_Handle, searchResult.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAnimateSearchHighlight_Handle, searchResult.Handle);
			}
		}
		
		[Export ("contentRect")]
		[CompilerGenerated]
		public virtual global::System.Drawing.RectangleF ContentRect ()
		{
			global::System.Drawing.RectangleF ret;
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret (out ret, this.Handle, selContentRectHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selContentRectHandle);
			}
			return ret;
		}
		
		[Export ("visibleAnnotationToolbar")]
		[CompilerGenerated]
		public virtual PSPDFAnnotationToolbar VisibleAnnotationToolbar ()
		{
			if (IsDirectBinding) {
				return (PSPDFAnnotationToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisibleAnnotationToolbarHandle));
			} else {
				return (PSPDFAnnotationToolbar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisibleAnnotationToolbarHandle));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPageHandle);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ScreenPage {
			[Export ("screenPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selScreenPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selScreenPageHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ViewState_var;
		[CompilerGenerated]
		public virtual PSPDFViewState ViewState {
			[Export ("viewState")]
			get {
				PSPDFViewState ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewState) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewStateHandle));
				} else {
					ret = (PSPDFViewState) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewStateHandle));
				}
				MarkDirty ();
				__mt_ViewState_var = ret;
				return ret;
			}
			
			[Export ("setViewState:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetViewState_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetViewState_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ViewState_var = value;
			}
		}
		
		[CompilerGenerated]
		public PSPDFViewControllerDelegate Delegate {
			get {
				return WeakDelegate as PSPDFViewControllerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document")]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentHandle));
				} else {
					ret = (PSPDFDocument) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentHandle));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIEdgeInsets Margin {
			[Export ("margin", ArgumentSemantic.Assign)]
			get {
				global::MonoTouch.UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, selMarginHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, selMarginHandle);
				}
				return ret;
			}
			
			[Export ("setMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, selSetMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, selSetMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF Padding {
			[Export ("padding", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selPaddingHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selPaddingHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selPaddingHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selPaddingHandle);
					}
				}
				return ret;
			}
			
			[Export ("setPadding:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetPadding_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetPadding_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageRenderingMode RenderingMode {
			[Export ("renderingMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFPageRenderingMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selRenderingModeHandle);
				} else {
					return (PSPDFPageRenderingMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selRenderingModeHandle);
				}
			}
			
			[Export ("setRenderingMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetRenderingMode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetRenderingMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SmartZoomEnabled {
			[Export ("isSmartZoomEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSmartZoomEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSmartZoomEnabledHandle);
				}
			}
			
			[Export ("setSmartZoomEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSmartZoomEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSmartZoomEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollingEnabled {
			[Export ("isScrollingEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollingEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollingEnabledHandle);
				}
			}
			
			[Export ("setScrollingEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollingEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollingEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ViewLockEnabled {
			[Export ("isViewLockEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsViewLockEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsViewLockEnabledHandle);
				}
			}
			
			[Export ("setViewLockEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetViewLockEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetViewLockEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotationLockEnabled {
			[Export ("isRotationLockEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRotationLockEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRotationLockEnabledHandle);
				}
			}
			
			[Export ("setRotationLockEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRotationLockEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRotationLockEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndEnabled {
			[Export ("isScrollOnTapPageEndEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollOnTapPageEndEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollOnTapPageEndEnabledHandle);
				}
			}
			
			[Export ("setScrollOnTapPageEndEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollOnTapPageEndEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollOnTapPageEndEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollOnTapPageEndAnimationEnabled {
			[Export ("isScrollOnTapPageEndAnimationEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollOnTapPageEndAnimationEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrollOnTapPageEndAnimationEnabledHandle);
				}
			}
			
			[Export ("setScrollOnTapPageEndAnimationEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollOnTapPageEndAnimationEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrollOnTapPageEndAnimationEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ScrollOnTapPageEndMargin {
			[Export ("scrollOnTapPageEndMargin", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScrollOnTapPageEndMarginHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selScrollOnTapPageEndMarginHandle);
				}
			}
			
			[Export ("setScrollOnTapPageEndMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetScrollOnTapPageEndMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetScrollOnTapPageEndMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool InternalTapGesturesEnabled {
			[Export ("internalTapGesturesEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selInternalTapGesturesEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selInternalTapGesturesEnabledHandle);
				}
			}
			
			[Export ("setInternalTapGesturesEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetInternalTapGesturesEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetInternalTapGesturesEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TextSelectionEnabled {
			[Export ("isTextSelectionEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTextSelectionEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTextSelectionEnabledHandle);
				}
			}
			
			[Export ("setTextSelectionEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTextSelectionEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTextSelectionEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ImageSelectionEnabled {
			[Export ("isImageSelectionEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsImageSelectionEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsImageSelectionEnabledHandle);
				}
			}
			
			[Export ("setImageSelectionEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetImageSelectionEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetImageSelectionEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PasswordDialogEnabled {
			[Export ("isPasswordDialogEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPasswordDialogEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPasswordDialogEnabledHandle);
				}
			}
			
			[Export ("setPasswordDialogEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPasswordDialogEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPasswordDialogEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseParentNavigationBar {
			[Export ("useParentNavigationBar", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseParentNavigationBarHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseParentNavigationBarHandle);
				}
			}
			
			[Export ("setUseParentNavigationBar:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseParentNavigationBar_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseParentNavigationBar_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldRestoreNavigationBarStyle {
			[Export ("shouldRestoreNavigationBarStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldRestoreNavigationBarStyleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldRestoreNavigationBarStyleHandle);
				}
			}
			
			[Export ("setShouldRestoreNavigationBarStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldRestoreNavigationBarStyle_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldRestoreNavigationBarStyle_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFLinkAction LinkAction {
			[Export ("linkAction", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFLinkAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLinkActionHandle);
				} else {
					return (PSPDFLinkAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLinkActionHandle);
				}
			}
			
			[Export ("setLinkAction:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLinkAction_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLinkAction_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_HUDView_var;
		[CompilerGenerated]
		public virtual PSPDFHUDView HUDView {
			[Export ("HUDView")]
			get {
				PSPDFHUDView ret;
				if (IsDirectBinding) {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHUDViewHandle));
				} else {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHUDViewHandle));
				}
				MarkDirty ();
				__mt_HUDView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFHUDViewMode HUDViewMode {
			[Export ("HUDViewMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFHUDViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHUDViewModeHandle);
				} else {
					return (PSPDFHUDViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHUDViewModeHandle);
				}
			}
			
			[Export ("setHUDViewMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHUDViewMode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHUDViewMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HUDVisible {
			[Export ("isHUDVisible", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHUDVisibleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsHUDVisibleHandle);
				}
			}
			
			[Export ("setHUDVisible:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHUDVisible_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetHUDVisible_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ToolbarEnabled {
			[Export ("isToolbarEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsToolbarEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsToolbarEnabledHandle);
				}
			}
			
			[Export ("setToolbarEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetToolbarEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetToolbarEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowToolbarTitleChange {
			[Export ("allowToolbarTitleChange", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowToolbarTitleChangeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAllowToolbarTitleChangeHandle);
				}
			}
			
			[Export ("setAllowToolbarTitleChange:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowToolbarTitleChange_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAllowToolbarTitleChange_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrobbleBarEnabled {
			[Export ("isScrobbleBarEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrobbleBarEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsScrobbleBarEnabledHandle);
				}
			}
			
			[Export ("setScrobbleBarEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrobbleBarEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetScrobbleBarEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PageLabelEnabled {
			[Export ("isPageLabelEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPageLabelEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPageLabelEnabledHandle);
				}
			}
			
			[Export ("setPageLabelEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPageLabelEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPageLabelEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DocumentLabelEnabled {
			[Export ("isDocumentLabelEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDocumentLabelEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDocumentLabelEnabledHandle);
				}
			}
			
			[Export ("setDocumentLabelEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDocumentLabelEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDocumentLabelEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RenderAnimationEnabled {
			[Export ("isRenderAnimationEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRenderAnimationEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRenderAnimationEnabledHandle);
				}
			}
			
			[Export ("setRenderAnimationEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRenderAnimationEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRenderAnimationEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual PSPDFHUDView ContentView {
			[Export ("contentView")]
			get {
				PSPDFHUDView ret;
				if (IsDirectBinding) {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentViewHandle));
				} else {
					ret = (PSPDFHUDView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentViewHandle));
				}
				MarkDirty ();
				__mt_ContentView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CloseButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFCloseBarButtonItem CloseButtonItem {
			[Export ("closeButtonItem")]
			get {
				PSPDFCloseBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFCloseBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCloseButtonItemHandle));
				} else {
					ret = (PSPDFCloseBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCloseButtonItemHandle));
				}
				MarkDirty ();
				__mt_CloseButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OutlineButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFOutlineBarButtonItem OutlineButtonItem {
			[Export ("outlineButtonItem")]
			get {
				PSPDFOutlineBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFOutlineBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutlineButtonItemHandle));
				} else {
					ret = (PSPDFOutlineBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOutlineButtonItemHandle));
				}
				MarkDirty ();
				__mt_OutlineButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SearchButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFSearchBarButtonItem SearchButtonItem {
			[Export ("searchButtonItem")]
			get {
				PSPDFSearchBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFSearchBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchButtonItemHandle));
				} else {
					ret = (PSPDFSearchBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchButtonItemHandle));
				}
				MarkDirty ();
				__mt_SearchButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ViewModeButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFViewModeBarButtonItem ViewModeButtonItem {
			[Export ("viewModeButtonItem")]
			get {
				PSPDFViewModeBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFViewModeBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewModeButtonItemHandle));
				} else {
					ret = (PSPDFViewModeBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewModeButtonItemHandle));
				}
				MarkDirty ();
				__mt_ViewModeButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PrintButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFPrintBarButtonItem PrintButtonItem {
			[Export ("printButtonItem")]
			get {
				PSPDFPrintBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFPrintBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrintButtonItemHandle));
				} else {
					ret = (PSPDFPrintBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrintButtonItemHandle));
				}
				MarkDirty ();
				__mt_PrintButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OpenInButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFOpenInBarButtonItem OpenInButtonItem {
			[Export ("openInButtonItem")]
			get {
				PSPDFOpenInBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFOpenInBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOpenInButtonItemHandle));
				} else {
					ret = (PSPDFOpenInBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOpenInButtonItemHandle));
				}
				MarkDirty ();
				__mt_OpenInButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_EmailButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFEmailBarButtonItem EmailButtonItem {
			[Export ("emailButtonItem")]
			get {
				PSPDFEmailBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFEmailBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEmailButtonItemHandle));
				} else {
					ret = (PSPDFEmailBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEmailButtonItemHandle));
				}
				MarkDirty ();
				__mt_EmailButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AnnotationButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFAnnotationBarButtonItem AnnotationButtonItem {
			[Export ("annotationButtonItem")]
			get {
				PSPDFAnnotationBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFAnnotationBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationButtonItemHandle));
				} else {
					ret = (PSPDFAnnotationBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationButtonItemHandle));
				}
				MarkDirty ();
				__mt_AnnotationButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BookmarkButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBookmarkBarButtonItem BookmarkButtonItem {
			[Export ("bookmarkButtonItem")]
			get {
				PSPDFBookmarkBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBookmarkBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBookmarkButtonItemHandle));
				} else {
					ret = (PSPDFBookmarkBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBookmarkButtonItemHandle));
				}
				MarkDirty ();
				__mt_BookmarkButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BrightnessButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFBrightnessBarButtonItem BrightnessButtonItem {
			[Export ("brightnessButtonItem")]
			get {
				PSPDFBrightnessBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFBrightnessBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBrightnessButtonItemHandle));
				} else {
					ret = (PSPDFBrightnessBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBrightnessButtonItemHandle));
				}
				MarkDirty ();
				__mt_BrightnessButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ActivityButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFActivityBarButtonItem ActivityButtonItem {
			[Export ("activityButtonItem")]
			get {
				PSPDFActivityBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFActivityBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActivityButtonItemHandle));
				} else {
					ret = (PSPDFActivityBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActivityButtonItemHandle));
				}
				MarkDirty ();
				__mt_ActivityButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AdditionalActionsButtonItem_var;
		[CompilerGenerated]
		public virtual PSPDFMoreBarButtonItem AdditionalActionsButtonItem {
			[Export ("additionalActionsButtonItem")]
			get {
				PSPDFMoreBarButtonItem ret;
				if (IsDirectBinding) {
					ret = (PSPDFMoreBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalActionsButtonItemHandle));
				} else {
					ret = (PSPDFMoreBarButtonItem) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalActionsButtonItemHandle));
				}
				MarkDirty ();
				__mt_AdditionalActionsButtonItem_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LeftBarButtonItems_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem[] LeftBarButtonItems {
			[Export ("leftBarButtonItems", ArgumentSemantic.Copy)]
			get {
				PSPDFBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLeftBarButtonItemsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLeftBarButtonItemsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setLeftBarButtonItems:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLeftBarButtonItems_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLeftBarButtonItems_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_LeftBarButtonItems_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RightBarButtonItems_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem[] RightBarButtonItems {
			[Export ("rightBarButtonItems", ArgumentSemantic.Copy)]
			get {
				PSPDFBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRightBarButtonItemsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRightBarButtonItemsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setRightBarButtonItems:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRightBarButtonItems_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRightBarButtonItems_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_RightBarButtonItems_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AdditionalRightBarButtonItems_var;
		[CompilerGenerated]
		public virtual PSPDFBarButtonItem[] AdditionalRightBarButtonItems {
			[Export ("additionalRightBarButtonItems", ArgumentSemantic.Copy)]
			get {
				PSPDFBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalRightBarButtonItemsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalRightBarButtonItemsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalRightBarButtonItems_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalRightBarButtonItems:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdditionalRightBarButtonItems_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAdditionalRightBarButtonItems_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalRightBarButtonItems_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BarButtonItemsAlwaysEnabled_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarButtonItem[] BarButtonItemsAlwaysEnabled {
			[Export ("barButtonItemsAlwaysEnabled", ArgumentSemantic.Copy)]
			get {
				global::MonoTouch.UIKit.UIBarButtonItem[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBarButtonItemsAlwaysEnabledHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.UIKit.UIBarButtonItem>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBarButtonItemsAlwaysEnabledHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarButtonItemsAlwaysEnabled_var = ret;
				return ret;
			}
			
			[Export ("setBarButtonItemsAlwaysEnabled:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBarButtonItemsAlwaysEnabled_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBarButtonItemsAlwaysEnabled_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_BarButtonItemsAlwaysEnabled_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float MinLeftToolbarWidth {
			[Export ("minLeftToolbarWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinLeftToolbarWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinLeftToolbarWidthHandle);
				}
			}
			
			[Export ("setMinLeftToolbarWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinLeftToolbarWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinLeftToolbarWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinRightToolbarWidth {
			[Export ("minRightToolbarWidth", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinRightToolbarWidthHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinRightToolbarWidthHandle);
				}
			}
			
			[Export ("setMinRightToolbarWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinRightToolbarWidth_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinRightToolbarWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseBorderedToolbarStyle {
			[Export ("useBorderedToolbarStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseBorderedToolbarStyleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseBorderedToolbarStyleHandle);
				}
			}
			
			[Export ("setUseBorderedToolbarStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseBorderedToolbarStyle_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseBorderedToolbarStyle_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageMode PageMode {
			[Export ("pageMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFPageMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPageModeHandle);
				} else {
					return (PSPDFPageMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPageModeHandle);
				}
			}
			
			[Export ("setPageMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPageMode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPageMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFPageTransition PageTransition {
			[Export ("pageTransition", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFPageTransition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPageTransitionHandle);
				} else {
					return (PSPDFPageTransition) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPageTransitionHandle);
				}
			}
			
			[Export ("setPageTransition:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPageTransition_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPageTransition_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFScrollDirection ScrollDirection {
			[Export ("scrollDirection", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFScrollDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selScrollDirectionHandle);
				} else {
					return (PSPDFScrollDirection) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selScrollDirectionHandle);
				}
			}
			
			[Export ("setScrollDirection:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetScrollDirection_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetScrollDirection_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DoublePageModeOnFirstPage {
			[Export ("isDoublePageModeOnFirstPage", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageModeOnFirstPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageModeOnFirstPageHandle);
				}
			}
			
			[Export ("setDoublePageModeOnFirstPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoublePageModeOnFirstPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDoublePageModeOnFirstPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomingSmallDocumentsEnabled {
			[Export ("isZoomingSmallDocumentsEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZoomingSmallDocumentsEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsZoomingSmallDocumentsEnabledHandle);
				}
			}
			
			[Export ("setZoomingSmallDocumentsEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZoomingSmallDocumentsEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetZoomingSmallDocumentsEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PageCurlDirectionLeftToRight {
			[Export ("isPageCurlDirectionLeftToRight", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPageCurlDirectionLeftToRightHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPageCurlDirectionLeftToRightHandle);
				}
			}
			
			[Export ("setPageCurlDirectionLeftToRight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPageCurlDirectionLeftToRight_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPageCurlDirectionLeftToRight_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FitToWidthEnabled {
			[Export ("isFitToWidthEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFitToWidthEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFitToWidthEnabledHandle);
				}
			}
			
			[Export ("setFitToWidthEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFitToWidthEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFitToWidthEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FixedVerticalPositionForfitToWidthEnabledMode {
			[Export ("fixedVerticalPositionForFitToWidthEnabledMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFixedVerticalPositionForFitToWidthEnabledModeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selFixedVerticalPositionForFitToWidthEnabledModeHandle);
				}
			}
			
			[Export ("setFixedVerticalPositionForFitToWidthEnabledMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFixedVerticalPositionForFitToWidthEnabledMode_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFixedVerticalPositionForFitToWidthEnabledMode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ClipToPageBoundaries {
			[Export ("clipToPageBoundaries", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selClipToPageBoundariesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClipToPageBoundariesHandle);
				}
			}
			
			[Export ("setClipToPageBoundaries:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClipToPageBoundaries_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetClipToPageBoundaries_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinimumZoomScale {
			[Export ("minimumZoomScale", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumZoomScaleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMinimumZoomScaleHandle);
				}
			}
			
			[Export ("setMinimumZoomScale:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinimumZoomScale_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMinimumZoomScale_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MaximumZoomScale {
			[Export ("maximumZoomScale", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumZoomScaleHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMaximumZoomScaleHandle);
				}
			}
			
			[Export ("setMaximumZoomScale:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumZoomScale_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMaximumZoomScale_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float PagePadding {
			[Export ("pagePadding", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPagePaddingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPagePaddingHandle);
				}
			}
			
			[Export ("setPagePadding:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPagePadding_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetPagePadding_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShadowEnabled {
			[Export ("isShadowEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShadowEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShadowEnabledHandle);
				}
			}
			
			[Export ("setShadowEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShadowEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShadowEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PSPDFStatusBarStyleSetting StatusBarStyleSetting {
			[Export ("statusBarStyleSetting", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFStatusBarStyleSetting) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusBarStyleSettingHandle);
				} else {
					return (PSPDFStatusBarStyleSetting) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStatusBarStyleSettingHandle);
				}
			}
			
			[Export ("setStatusBarStyleSetting:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetStatusBarStyleSetting_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetStatusBarStyleSetting_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIStatusBarStyle StatusBarStyle {
			[Export ("statusBarStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusBarStyleHandle);
				} else {
					return (global::MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStatusBarStyleHandle);
				}
			}
			
			[Export ("setStatusBarStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetStatusBarStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetStatusBarStyle_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIBarStyle NavigationBarStyle {
			[Export ("navigationBarStyle", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNavigationBarStyleHandle);
				} else {
					return (global::MonoTouch.UIKit.UIBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNavigationBarStyleHandle);
				}
			}
			
			[Export ("setNavigationBarStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetNavigationBarStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetNavigationBarStyle_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TransparentHUD {
			[Export ("isTransparentHUD", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTransparentHUDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTransparentHUDHandle);
				}
			}
			
			[Export ("setTransparentHUD:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTransparentHUD_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTransparentHUD_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideNavigationBarWithHUD {
			[Export ("shouldHideNavigationBarWithHUD", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldHideNavigationBarWithHUDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldHideNavigationBarWithHUDHandle);
				}
			}
			
			[Export ("setShouldHideNavigationBarWithHUD:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldHideNavigationBarWithHUD_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldHideNavigationBarWithHUD_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldHideStatusBarWithHUD {
			[Export ("shouldHideStatusBarWithHUD", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldHideStatusBarWithHUDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldHideStatusBarWithHUDHandle);
				}
			}
			
			[Export ("setShouldHideStatusBarWithHUD:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldHideStatusBarWithHUD_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldHideStatusBarWithHUD_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundColorHandle));
				}
				MarkDirty ();
				__mt_BackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_BackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TintColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TintColor {
			[Export ("tintColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTintColorHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIColor) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTintColorHandle));
				}
				MarkDirty ();
				__mt_TintColor_var = ret;
				return ret;
			}
			
			[Export ("setTintColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTintColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTintColor_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_TintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldTintPopovers {
			[Export ("shouldTintPopovers", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldTintPopoversHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldTintPopoversHandle);
				}
			}
			
			[Export ("setShouldTintPopovers:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldTintPopovers_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldTintPopovers_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldTintAlertView {
			[Export ("shouldTintAlertView", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldTintAlertViewHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldTintAlertViewHandle);
				}
			}
			
			[Export ("setShouldTintAlertView:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldTintAlertView_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldTintAlertView_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool NavigationBarHidden {
			[Export ("isNavigationBarHidden", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsNavigationBarHiddenHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsNavigationBarHiddenHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float AnnotationAnimationDuration {
			[Export ("annotationAnimationDuration", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAnnotationAnimationDurationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnnotationAnimationDurationHandle);
				}
			}
			
			[Export ("setAnnotationAnimationDuration:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAnnotationAnimationDuration_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnnotationAnimationDuration_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float CreateAnnotationMenuEnabled {
			[Export ("isCreateAnnotationMenuEnabled", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selIsCreateAnnotationMenuEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selIsCreateAnnotationMenuEnabledHandle);
				}
			}
			
			[Export ("setCreateAnnotationMenuEnabled:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCreateAnnotationMenuEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetCreateAnnotationMenuEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowAnnotationMenuAfterCreation {
			[Export ("showAnnotationMenuAfterCreation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowAnnotationMenuAfterCreationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowAnnotationMenuAfterCreationHandle);
				}
			}
			
			[Export ("setShowAnnotationMenuAfterCreation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowAnnotationMenuAfterCreation_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowAnnotationMenuAfterCreation_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PopoverController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIPopoverController PopoverController {
			[Export ("popoverController")]
			get {
				global::MonoTouch.UIKit.UIPopoverController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPopoverControllerHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIPopoverController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPopoverControllerHandle));
				}
				MarkDirty ();
				__mt_PopoverController_var = ret;
				return ret;
			}
			
			[Export ("setPopoverController:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPopoverController_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPopoverController_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_PopoverController_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PagingScrollView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIScrollView PagingScrollView {
			[Export ("pagingScrollView")]
			get {
				global::MonoTouch.UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagingScrollViewHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIScrollView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagingScrollViewHandle));
				}
				MarkDirty ();
				__mt_PagingScrollView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PSPDFViewMode ViewMode {
			[Export ("viewMode", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (PSPDFViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selViewModeHandle);
				} else {
					return (PSPDFViewMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selViewModeHandle);
				}
			}
			
			[Export ("setViewMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetViewMode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetViewMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailController_var;
		[CompilerGenerated]
		public virtual NSObject ThumbnailController {
			[Export ("thumbnailController")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selThumbnailControllerHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selThumbnailControllerHandle));
				}
				MarkDirty ();
				__mt_ThumbnailController_var = ret;
				return ret;
			}
			
			[Export ("setThumbnailController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetThumbnailController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetThumbnailController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ThumbnailController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF ThumbnailSize {
			[Export ("thumbnailSize", ArgumentSemantic.Assign)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selThumbnailSizeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selThumbnailSizeHandle);
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE){
						MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, selThumbnailSizeHandle);
					} else {
						ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, selThumbnailSizeHandle);
					}
				}
				return ret;
			}
			
			[Export ("setThumbnailSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetThumbnailSize_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetThumbnailSize_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIEdgeInsets ThumbnailMargin {
			[Export ("thumbnailMargin", ArgumentSemantic.Assign)]
			get {
				global::MonoTouch.UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, selThumbnailMarginHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, selThumbnailMarginHandle);
				}
				return ret;
			}
			
			[Export ("setThumbnailMargin:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, selSetThumbnailMargin_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, selSetThumbnailMargin_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_VisiblePageNumbers_var;
		[CompilerGenerated]
		public virtual NSNumber[] VisiblePageNumbers {
			[Export ("visiblePageNumbers")]
			get {
				NSNumber[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageNumbersHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSNumber>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageNumbersHandle));
				}
				MarkDirty ();
				__mt_VisiblePageNumbers_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_VisiblePageViews_var;
		[CompilerGenerated]
		public virtual PSPDFPageView[] VisiblePageViews {
			[Export ("visiblePageViews")]
			get {
				PSPDFPageView[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVisiblePageViewsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<KS_PSPDFKitBindings.PSPDFPageView>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVisiblePageViewsHandle));
				}
				MarkDirty ();
				__mt_VisiblePageViews_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsDoublePageMode {
			[Export ("isDoublePageMode")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoublePageModeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDoublePageModeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLastPage {
			[Export ("isLastPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLastPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLastPageHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsFirstPage {
			[Export ("isFirstPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFirstPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFirstPageHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_MasterViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController MasterViewController {
			[Export ("masterViewController")]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMasterViewControllerHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMasterViewControllerHandle));
				}
				MarkDirty ();
				__mt_MasterViewController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OverrideClassNames_var;
		[CompilerGenerated]
		public virtual NSDictionary OverrideClassNames {
			[Export ("overrideClassNames", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOverrideClassNamesHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOverrideClassNamesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OverrideClassNames_var = ret;
				return ret;
			}
			
			[Export ("setOverrideClassNames:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOverrideClassNames_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOverrideClassNames_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_OverrideClassNames_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PageTransitionController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController PageTransitionController {
			[Export ("pageTransitionController")]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageTransitionControllerHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageTransitionControllerHandle));
				}
				MarkDirty ();
				__mt_PageTransitionController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PageLabel_var;
		[CompilerGenerated]
		public virtual PSPDFPageLabelView PageLabel {
			[Export ("pageLabel")]
			get {
				PSPDFPageLabelView ret;
				if (IsDirectBinding) {
					ret = (PSPDFPageLabelView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageLabelHandle));
				} else {
					ret = (PSPDFPageLabelView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPageLabelHandle));
				}
				MarkDirty ();
				__mt_PageLabel_var = ret;
				return ret;
			}
			
			[Export ("setPageLabel:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageLabel_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPageLabel_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_PageLabel_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ScrobbleBar_var;
		[CompilerGenerated]
		public virtual PSPDFScrobbleBar ScrobbleBar {
			[Export ("scrobbleBar")]
			get {
				PSPDFScrobbleBar ret;
				if (IsDirectBinding) {
					ret = (PSPDFScrobbleBar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrobbleBarHandle));
				} else {
					ret = (PSPDFScrobbleBar) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScrobbleBarHandle));
				}
				MarkDirty ();
				__mt_ScrobbleBar_var = ret;
				return ret;
			}
			
			[Export ("setScrobbleBar:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScrobbleBar_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetScrobbleBar_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ScrobbleBar_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DocumentLabel_var;
		[CompilerGenerated]
		public virtual PSPDFDocumentLabelView DocumentLabel {
			[Export ("documentLabel")]
			get {
				PSPDFDocumentLabelView ret;
				if (IsDirectBinding) {
					ret = (PSPDFDocumentLabelView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocumentLabelHandle));
				} else {
					ret = (PSPDFDocumentLabelView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocumentLabelHandle));
				}
				MarkDirty ();
				__mt_DocumentLabel_var = ret;
				return ret;
			}
			
			[Export ("setDocumentLabel:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocumentLabel_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocumentLabel_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_DocumentLabel_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AnnotationViewCache_var;
		[CompilerGenerated]
		public virtual NSObject AnnotationViewCache {
			[Export ("annotationViewCache")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnnotationViewCacheHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnnotationViewCacheHandle));
				}
				MarkDirty ();
				__mt_AnnotationViewCache_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static readonly IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionRect;
		public static NSString PSPDFPresentOptionRect {
			get {
				if (_PSPDFPresentOptionRect == null)
					_PSPDFPresentOptionRect = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionRect");
				return _PSPDFPresentOptionRect;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionPopoverContentSize;
		public static NSString PSPDFPresentOptionPopoverContentSize {
			get {
				if (_PSPDFPresentOptionPopoverContentSize == null)
					_PSPDFPresentOptionPopoverContentSize = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionPopoverContentSize");
				return _PSPDFPresentOptionPopoverContentSize;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionAllowedPopoverArrowDirections;
		public static NSString PSPDFPresentOptionAllowedPopoverArrowDirections {
			get {
				if (_PSPDFPresentOptionAllowedPopoverArrowDirections == null)
					_PSPDFPresentOptionAllowedPopoverArrowDirections = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionAllowedPopoverArrowDirections");
				return _PSPDFPresentOptionAllowedPopoverArrowDirections;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionModalPresentationStyle;
		public static NSString PSPDFPresentOptionModalPresentationStyle {
			get {
				if (_PSPDFPresentOptionModalPresentationStyle == null)
					_PSPDFPresentOptionModalPresentationStyle = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionModalPresentationStyle");
				return _PSPDFPresentOptionModalPresentationStyle;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionAlwaysModal;
		public static NSString PSPDFPresentOptionAlwaysModal {
			get {
				if (_PSPDFPresentOptionAlwaysModal == null)
					_PSPDFPresentOptionAlwaysModal = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionAlwaysModal");
				return _PSPDFPresentOptionAlwaysModal;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionAlwaysPopover;
		public static NSString PSPDFPresentOptionAlwaysPopover {
			get {
				if (_PSPDFPresentOptionAlwaysPopover == null)
					_PSPDFPresentOptionAlwaysPopover = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionAlwaysPopover");
				return _PSPDFPresentOptionAlwaysPopover;
			}
		}
		[CompilerGenerated]
		static NSString _PSPDFPresentOptionPassthroughViews;
		public static NSString PSPDFPresentOptionPassthroughViews {
			get {
				if (_PSPDFPresentOptionPassthroughViews == null)
					_PSPDFPresentOptionPassthroughViews = Dlfcn.GetStringConstant (__Internal_libraryHandle, "PSPDFPresentOptionPassthroughViews");
				return _PSPDFPresentOptionPassthroughViews;
			}
		}
		//
		// Events and properties from the delegate
		//
		
		_PSPDFViewControllerDelegate EnsurePSPDFViewControllerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _PSPDFViewControllerDelegate))){
				del = new _PSPDFViewControllerDelegate ();
				WeakDelegate = del;
			}
			return (_PSPDFViewControllerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _PSPDFViewControllerDelegate : KS_PSPDFKitBindings.PSPDFViewControllerDelegate { 
			public _PSPDFViewControllerDelegate () {}
			
			internal PSPDFViewControllerShouldSetDocument shouldSetDocument;
			[Preserve (Conditional = true)]
			public override bool ShouldSetDocument (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFDocument document)
			{
				PSPDFViewControllerShouldSetDocument handler = shouldSetDocument;
				if (handler != null)
					return handler (pdfController, document);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerDocumentEventArgs> willDisplayDocument;
			[Preserve (Conditional = true)]
			public override void WillDisplayDocument (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFDocument document)
			{
				EventHandler<PSPDFViewControllerDocumentEventArgs> handler = willDisplayDocument;
				if (handler != null){
					var args = new PSPDFViewControllerDocumentEventArgs (document);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerDocumentEventArgs> didDisplayDocument;
			[Preserve (Conditional = true)]
			public override void DidDisplayDocument (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFDocument document)
			{
				EventHandler<PSPDFViewControllerDocumentEventArgs> handler = didDisplayDocument;
				if (handler != null){
					var args = new PSPDFViewControllerDocumentEventArgs (document);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerShouldScrollToPage shouldScrollToPage;
			[Preserve (Conditional = true)]
			public override bool ShouldScrollToPage (KS_PSPDFKitBindings.PSPDFViewController pdfController, uint page)
			{
				PSPDFViewControllerShouldScrollToPage handler = shouldScrollToPage;
				if (handler != null)
					return handler (pdfController, page);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerShowPageViewwEventArgs> didShowPageView;
			[Preserve (Conditional = true)]
			public override void DidShowPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerShowPageViewwEventArgs> handler = didShowPageView;
				if (handler != null){
					var args = new PSPDFViewControllerShowPageViewwEventArgs (pageView);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerShowPageViewwEventArgs> didRenderPageView;
			[Preserve (Conditional = true)]
			public override void DidRenderPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerShowPageViewwEventArgs> handler = didRenderPageView;
				if (handler != null){
					var args = new PSPDFViewControllerShowPageViewwEventArgs (pageView);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerDidLoadPageViewEventArgs> didLoadPageView;
			[Preserve (Conditional = true)]
			public override void DidLoadPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerDidLoadPageViewEventArgs> handler = didLoadPageView;
				if (handler != null){
					var args = new PSPDFViewControllerDidLoadPageViewEventArgs (pageView);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerWillUnloadPageViewEventArgs> willUnloadPageView;
			[Preserve (Conditional = true)]
			public override void WillUnloadPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerWillUnloadPageViewEventArgs> handler = willUnloadPageView;
				if (handler != null){
					var args = new PSPDFViewControllerWillUnloadPageViewEventArgs (pageView);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerDidChangeViewModeEventArgs> didChangeViewMode;
			[Preserve (Conditional = true)]
			public override void DidChangeViewMode (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFViewMode viewMode)
			{
				EventHandler<PSPDFViewControllerDidChangeViewModeEventArgs> handler = didChangeViewMode;
				if (handler != null){
					var args = new PSPDFViewControllerDidChangeViewModeEventArgs (viewMode);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerDidEndPageDraggingEventArgs> didEndPageDragging;
			[Preserve (Conditional = true)]
			public override void DidEndPageDragging (KS_PSPDFKitBindings.PSPDFViewController pdfController, UIScrollView scrollView, bool decelerate, PointF velocity, ref PointF targetContentOffset)
			{
				EventHandler<PSPDFViewControllerDidEndPageDraggingEventArgs> handler = didEndPageDragging;
				if (handler != null){
					var args = new PSPDFViewControllerDidEndPageDraggingEventArgs (scrollView, decelerate, velocity, targetContentOffset);
					handler (pdfController, args);
					targetContentOffset = args.TargetContentOffset;
				}
			}
			
			internal EventHandler<PSPDFViewControllerDidEndPageScrollingAnimationEventArgs> didEndPageScrollingAnimation;
			[Preserve (Conditional = true)]
			public override void DidEndPageScrollingAnimation (KS_PSPDFKitBindings.PSPDFViewController pdfController, UIScrollView scrollView)
			{
				EventHandler<PSPDFViewControllerDidEndPageScrollingAnimationEventArgs> handler = didEndPageScrollingAnimation;
				if (handler != null){
					var args = new PSPDFViewControllerDidEndPageScrollingAnimationEventArgs (scrollView);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerDidEndPageZoomingEventArgs> didEndPageZooming;
			[Preserve (Conditional = true)]
			public override void DidEndPageZooming (KS_PSPDFKitBindings.PSPDFViewController pdfController, UIScrollView scrollView, float scale)
			{
				EventHandler<PSPDFViewControllerDidEndPageZoomingEventArgs> handler = didEndPageZooming;
				if (handler != null){
					var args = new PSPDFViewControllerDidEndPageZoomingEventArgs (scrollView, scale);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerDidRenderPageEventArgs> didRenderPage;
			[Preserve (Conditional = true)]
			public override void DidRenderPage (KS_PSPDFKitBindings.PSPDFViewController pdfController, uint page, IntPtr context, SizeF fullsize, RectangleF clipRect, KS_PSPDFKitBindings.PSPDFAnnotation[] annotations, NSDictionary options)
			{
				EventHandler<PSPDFViewControllerDidRenderPageEventArgs> handler = didRenderPage;
				if (handler != null){
					var args = new PSPDFViewControllerDidRenderPageEventArgs (page, context, fullsize, clipRect, annotations, options);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerDocumentForRelativePath documentForRelativePath;
			[Preserve (Conditional = true)]
			public override KS_PSPDFKitBindings.PSPDFDocument DocumentForRelativePath (KS_PSPDFKitBindings.PSPDFViewController pdfController, string relativePath)
			{
				PSPDFViewControllerDocumentForRelativePath handler = documentForRelativePath;
				if (handler != null)
					return handler (pdfController, relativePath);
				return null;
			}
			
			internal PSPDFViewControllerDidTapOnPageView didTapOnPageView;
			[Preserve (Conditional = true)]
			public override bool DidTapOnPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView, PointF viewPoint)
			{
				PSPDFViewControllerDidTapOnPageView handler = didTapOnPageView;
				if (handler != null)
					return handler (pdfController, pageView, viewPoint);
				return false;
			}
			
			internal PSPDFViewControllerDidLongPressOnPageView didLongPressOnPageView;
			[Preserve (Conditional = true)]
			public override bool DidLongPressOnPageView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFPageView pageView, PointF viewPoint, UILongPressGestureRecognizer gestureRecognizer)
			{
				PSPDFViewControllerDidLongPressOnPageView handler = didLongPressOnPageView;
				if (handler != null)
					return handler (pdfController, pageView, viewPoint, gestureRecognizer);
				return false;
			}
			
			internal PSPDFViewControllerShouldSelectText shouldSelectText;
			[Preserve (Conditional = true)]
			public override bool ShouldSelectText (KS_PSPDFKitBindings.PSPDFViewController pdfController, string text, KS_PSPDFKitBindings.PSPDFGlyph[] glyphs, RectangleF rect, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerShouldSelectText handler = shouldSelectText;
				if (handler != null)
					return handler (pdfController, text, glyphs, rect, pageView);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerDidSelectTextEventArgs> didSelectText;
			[Preserve (Conditional = true)]
			public override void DidSelectText (KS_PSPDFKitBindings.PSPDFViewController pdfController, string text, KS_PSPDFKitBindings.PSPDFGlyph[] glyphs, RectangleF rect, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerDidSelectTextEventArgs> handler = didSelectText;
				if (handler != null){
					var args = new PSPDFViewControllerDidSelectTextEventArgs (text, glyphs, rect, pageView);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerShouldShowMenuItemsForSelectedText shouldShowMenuItemsForSelectedText;
			[Preserve (Conditional = true)]
			public override KS_PSPDFKitBindings.PSPDFMenuItem[] ShouldShowMenuItemsForSelectedText (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFMenuItem[] menuItems, RectangleF rect, string selectedText, RectangleF textRect, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerShouldShowMenuItemsForSelectedText handler = shouldShowMenuItemsForSelectedText;
				if (handler != null)
					return handler (pdfController, menuItems, rect, selectedText, textRect, pageView);
				return menuItems;
			}
			
			internal PSPDFViewControllerShouldShowMenuItemsForSelectedImage shouldShowMenuItemsForSelectedImage;
			[Preserve (Conditional = true)]
			public override KS_PSPDFKitBindings.PSPDFMenuItem[] ShouldShowMenuItemsForSelectedImage (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFMenuItem[] menuItems, RectangleF rect, KS_PSPDFKitBindings.PSPDFImageInfo selectedImage, RectangleF textRect, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerShouldShowMenuItemsForSelectedImage handler = shouldShowMenuItemsForSelectedImage;
				if (handler != null)
					return handler (pdfController, menuItems, rect, selectedImage, textRect, pageView);
				return menuItems;
			}
			
			internal PSPDFViewControllerShouldShowMenuItemsForSelectedAnnotation shouldShowMenuItemsForAnnotation;
			[Preserve (Conditional = true)]
			public override KS_PSPDFKitBindings.PSPDFMenuItem[] ShouldShowMenuItemsForAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFMenuItem[] menuItems, RectangleF rect, KS_PSPDFKitBindings.PSPDFAnnotation annotation, RectangleF textRect, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerShouldShowMenuItemsForSelectedAnnotation handler = shouldShowMenuItemsForAnnotation;
				if (handler != null)
					return handler (pdfController, menuItems, rect, annotation, textRect, pageView);
				return menuItems;
			}
			
			internal PSPDFViewControllerShouldDisplayAnnotation shouldDisplayAnnotation;
			[Preserve (Conditional = true)]
			public override bool ShouldDisplayAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerShouldDisplayAnnotation handler = shouldDisplayAnnotation;
				if (handler != null)
					return handler (pdfController, annotation, pageView);
				return true;
			}
			
			internal PSPDFViewControllerDidTapOnAnnotation didTapOnAnnotation;
			[Preserve (Conditional = true)]
			public override bool DidTapOnAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, PointF annotationPoint, KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFPageView pageView, PointF viewPoint)
			{
				PSPDFViewControllerDidTapOnAnnotation handler = didTapOnAnnotation;
				if (handler != null)
					return handler (pdfController, annotation, annotationPoint, annotationView, pageView, viewPoint);
				return false;
			}
			
			internal PSPDFViewControllerShouldSelectAnnotation shouldSelectAnnotation;
			[Preserve (Conditional = true)]
			public override bool ShouldSelectAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerShouldSelectAnnotation handler = shouldSelectAnnotation;
				if (handler != null)
					return handler (pdfController, annotation, pageView);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerDidSelectAnnotationEventArgs> didSelectAnnotation;
			[Preserve (Conditional = true)]
			public override void DidSelectAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerDidSelectAnnotationEventArgs> handler = didSelectAnnotation;
				if (handler != null){
					var args = new PSPDFViewControllerDidSelectAnnotationEventArgs (annotation, pageView);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerAnnotationViewForAnnotation annotationViewForAnnotation;
			[Preserve (Conditional = true)]
			public override KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol AnnotationViewForAnnotation (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				PSPDFViewControllerAnnotationViewForAnnotation handler = annotationViewForAnnotation;
				if (handler != null)
					return handler (pdfController, annotationView, annotation, pageView);
				return annotationView;
			}
			
			internal EventHandler<PSPDFViewControllerAnnotationViewEventArgs> willShowAnnotationView;
			[Preserve (Conditional = true)]
			public override void WillShowAnnotationView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerAnnotationViewEventArgs> handler = willShowAnnotationView;
				if (handler != null){
					var args = new PSPDFViewControllerAnnotationViewEventArgs (annotationView, pageView);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerAnnotationViewEventArgs> didShowAnnotationView;
			[Preserve (Conditional = true)]
			public override void DidShowAnnotationView (KS_PSPDFKitBindings.PSPDFViewController pdfController, KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFPageView pageView)
			{
				EventHandler<PSPDFViewControllerAnnotationViewEventArgs> handler = didShowAnnotationView;
				if (handler != null){
					var args = new PSPDFViewControllerAnnotationViewEventArgs (annotationView, pageView);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerShouldShowController shouldShowController;
			[Preserve (Conditional = true)]
			public override bool ShouldShowController (KS_PSPDFKitBindings.PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated)
			{
				PSPDFViewControllerShouldShowController handler = shouldShowController;
				if (handler != null)
					return handler (pdfController, viewController, controller, animated);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerDidShowControllerEventArgs> didShowController;
			[Preserve (Conditional = true)]
			public override void DidShowController (KS_PSPDFKitBindings.PSPDFViewController pdfController, NSObject viewController, NSObject controller, bool animated)
			{
				EventHandler<PSPDFViewControllerDidShowControllerEventArgs> handler = didShowController;
				if (handler != null){
					var args = new PSPDFViewControllerDidShowControllerEventArgs (viewController, controller, animated);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerRequestsUpdateForBarButtonItemEventArgs> requestsUpdateForBarButtonItem;
			[Preserve (Conditional = true)]
			public override void RequestsUpdateForBarButtonItem (KS_PSPDFKitBindings.PSPDFViewController pdfController, UIBarButtonItem barButtonItem, bool animated)
			{
				EventHandler<PSPDFViewControllerRequestsUpdateForBarButtonItemEventArgs> handler = requestsUpdateForBarButtonItem;
				if (handler != null){
					var args = new PSPDFViewControllerRequestsUpdateForBarButtonItemEventArgs (barButtonItem, animated);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerShouldShowHUD shouldShowHUD;
			[Preserve (Conditional = true)]
			public override bool ShouldShowHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated)
			{
				PSPDFViewControllerShouldShowHUD handler = shouldShowHUD;
				if (handler != null)
					return handler (pdfController, animated);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerHUDEventArgs> willShowHUD;
			[Preserve (Conditional = true)]
			public override void WillShowHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated)
			{
				EventHandler<PSPDFViewControllerHUDEventArgs> handler = willShowHUD;
				if (handler != null){
					var args = new PSPDFViewControllerHUDEventArgs (animated);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerHUDEventArgs> didShowHUD;
			[Preserve (Conditional = true)]
			public override void DidShowHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated)
			{
				EventHandler<PSPDFViewControllerHUDEventArgs> handler = didShowHUD;
				if (handler != null){
					var args = new PSPDFViewControllerHUDEventArgs (animated);
					handler (pdfController, args);
				}
			}
			
			internal PSPDFViewControllerShouldHideHUD shouldHideHUD;
			[Preserve (Conditional = true)]
			public override bool ShouldHideHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated)
			{
				PSPDFViewControllerShouldHideHUD handler = shouldHideHUD;
				if (handler != null)
					return handler (pdfController, animated);
				return true;
			}
			
			internal EventHandler<PSPDFViewControllerHUDEventArgs> willHideHUD;
			[Preserve (Conditional = true)]
			public override void WillHideHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated)
			{
				EventHandler<PSPDFViewControllerHUDEventArgs> handler = willHideHUD;
				if (handler != null){
					var args = new PSPDFViewControllerHUDEventArgs (animated);
					handler (pdfController, args);
				}
			}
			
			internal EventHandler<PSPDFViewControllerHUDEventArgs> didHideHUD;
			[Preserve (Conditional = true)]
			public override void DidHideHUD (KS_PSPDFKitBindings.PSPDFViewController pdfController, bool animated)
			{
				EventHandler<PSPDFViewControllerHUDEventArgs> handler = didHideHUD;
				if (handler != null){
					var args = new PSPDFViewControllerHUDEventArgs (animated);
					handler (pdfController, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public PSPDFViewControllerShouldSetDocument ShouldSetDocument {
			get { return EnsurePSPDFViewControllerDelegate ().shouldSetDocument; }
			set { EnsurePSPDFViewControllerDelegate ().shouldSetDocument = value; }
		}
		
		public event EventHandler<PSPDFViewControllerDocumentEventArgs> WillDisplayDocument {
			add { EnsurePSPDFViewControllerDelegate ().willDisplayDocument += value; }
			remove { EnsurePSPDFViewControllerDelegate ().willDisplayDocument -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDocumentEventArgs> DidDisplayDocument {
			add { EnsurePSPDFViewControllerDelegate ().didDisplayDocument += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didDisplayDocument -= value; }
		}
		
		public PSPDFViewControllerShouldScrollToPage ShouldScrollToPage {
			get { return EnsurePSPDFViewControllerDelegate ().shouldScrollToPage; }
			set { EnsurePSPDFViewControllerDelegate ().shouldScrollToPage = value; }
		}
		
		public event EventHandler<PSPDFViewControllerShowPageViewwEventArgs> DidShowPageView {
			add { EnsurePSPDFViewControllerDelegate ().didShowPageView += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didShowPageView -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerShowPageViewwEventArgs> DidRenderPageView {
			add { EnsurePSPDFViewControllerDelegate ().didRenderPageView += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didRenderPageView -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidLoadPageViewEventArgs> DidLoadPageView {
			add { EnsurePSPDFViewControllerDelegate ().didLoadPageView += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didLoadPageView -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerWillUnloadPageViewEventArgs> WillUnloadPageView {
			add { EnsurePSPDFViewControllerDelegate ().willUnloadPageView += value; }
			remove { EnsurePSPDFViewControllerDelegate ().willUnloadPageView -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidChangeViewModeEventArgs> DidChangeViewMode {
			add { EnsurePSPDFViewControllerDelegate ().didChangeViewMode += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didChangeViewMode -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidEndPageDraggingEventArgs> DidEndPageDragging {
			add { EnsurePSPDFViewControllerDelegate ().didEndPageDragging += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didEndPageDragging -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidEndPageScrollingAnimationEventArgs> DidEndPageScrollingAnimation {
			add { EnsurePSPDFViewControllerDelegate ().didEndPageScrollingAnimation += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didEndPageScrollingAnimation -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidEndPageZoomingEventArgs> DidEndPageZooming {
			add { EnsurePSPDFViewControllerDelegate ().didEndPageZooming += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didEndPageZooming -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidRenderPageEventArgs> DidRenderPage {
			add { EnsurePSPDFViewControllerDelegate ().didRenderPage += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didRenderPage -= value; }
		}
		
		public PSPDFViewControllerDocumentForRelativePath DocumentForRelativePath {
			get { return EnsurePSPDFViewControllerDelegate ().documentForRelativePath; }
			set { EnsurePSPDFViewControllerDelegate ().documentForRelativePath = value; }
		}
		
		public PSPDFViewControllerDidTapOnPageView DidTapOnPageView {
			get { return EnsurePSPDFViewControllerDelegate ().didTapOnPageView; }
			set { EnsurePSPDFViewControllerDelegate ().didTapOnPageView = value; }
		}
		
		public PSPDFViewControllerDidLongPressOnPageView DidLongPressOnPageView {
			get { return EnsurePSPDFViewControllerDelegate ().didLongPressOnPageView; }
			set { EnsurePSPDFViewControllerDelegate ().didLongPressOnPageView = value; }
		}
		
		public PSPDFViewControllerShouldSelectText ShouldSelectText {
			get { return EnsurePSPDFViewControllerDelegate ().shouldSelectText; }
			set { EnsurePSPDFViewControllerDelegate ().shouldSelectText = value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidSelectTextEventArgs> DidSelectText {
			add { EnsurePSPDFViewControllerDelegate ().didSelectText += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didSelectText -= value; }
		}
		
		public PSPDFViewControllerShouldShowMenuItemsForSelectedText ShouldShowMenuItemsForSelectedText {
			get { return EnsurePSPDFViewControllerDelegate ().shouldShowMenuItemsForSelectedText; }
			set { EnsurePSPDFViewControllerDelegate ().shouldShowMenuItemsForSelectedText = value; }
		}
		
		public PSPDFViewControllerShouldShowMenuItemsForSelectedImage ShouldShowMenuItemsForSelectedImage {
			get { return EnsurePSPDFViewControllerDelegate ().shouldShowMenuItemsForSelectedImage; }
			set { EnsurePSPDFViewControllerDelegate ().shouldShowMenuItemsForSelectedImage = value; }
		}
		
		public PSPDFViewControllerShouldShowMenuItemsForSelectedAnnotation ShouldShowMenuItemsForAnnotation {
			get { return EnsurePSPDFViewControllerDelegate ().shouldShowMenuItemsForAnnotation; }
			set { EnsurePSPDFViewControllerDelegate ().shouldShowMenuItemsForAnnotation = value; }
		}
		
		public PSPDFViewControllerShouldDisplayAnnotation ShouldDisplayAnnotation {
			get { return EnsurePSPDFViewControllerDelegate ().shouldDisplayAnnotation; }
			set { EnsurePSPDFViewControllerDelegate ().shouldDisplayAnnotation = value; }
		}
		
		public PSPDFViewControllerDidTapOnAnnotation DidTapOnAnnotation {
			get { return EnsurePSPDFViewControllerDelegate ().didTapOnAnnotation; }
			set { EnsurePSPDFViewControllerDelegate ().didTapOnAnnotation = value; }
		}
		
		public PSPDFViewControllerShouldSelectAnnotation ShouldSelectAnnotation {
			get { return EnsurePSPDFViewControllerDelegate ().shouldSelectAnnotation; }
			set { EnsurePSPDFViewControllerDelegate ().shouldSelectAnnotation = value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidSelectAnnotationEventArgs> DidSelectAnnotation {
			add { EnsurePSPDFViewControllerDelegate ().didSelectAnnotation += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didSelectAnnotation -= value; }
		}
		
		public PSPDFViewControllerAnnotationViewForAnnotation AnnotationViewForAnnotation {
			get { return EnsurePSPDFViewControllerDelegate ().annotationViewForAnnotation; }
			set { EnsurePSPDFViewControllerDelegate ().annotationViewForAnnotation = value; }
		}
		
		public event EventHandler<PSPDFViewControllerAnnotationViewEventArgs> WillShowAnnotationView {
			add { EnsurePSPDFViewControllerDelegate ().willShowAnnotationView += value; }
			remove { EnsurePSPDFViewControllerDelegate ().willShowAnnotationView -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerAnnotationViewEventArgs> DidShowAnnotationView {
			add { EnsurePSPDFViewControllerDelegate ().didShowAnnotationView += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didShowAnnotationView -= value; }
		}
		
		public PSPDFViewControllerShouldShowController ShouldShowController {
			get { return EnsurePSPDFViewControllerDelegate ().shouldShowController; }
			set { EnsurePSPDFViewControllerDelegate ().shouldShowController = value; }
		}
		
		public event EventHandler<PSPDFViewControllerDidShowControllerEventArgs> DidShowController {
			add { EnsurePSPDFViewControllerDelegate ().didShowController += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didShowController -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerRequestsUpdateForBarButtonItemEventArgs> RequestsUpdateForBarButtonItem {
			add { EnsurePSPDFViewControllerDelegate ().requestsUpdateForBarButtonItem += value; }
			remove { EnsurePSPDFViewControllerDelegate ().requestsUpdateForBarButtonItem -= value; }
		}
		
		public PSPDFViewControllerShouldShowHUD ShouldShowHUD {
			get { return EnsurePSPDFViewControllerDelegate ().shouldShowHUD; }
			set { EnsurePSPDFViewControllerDelegate ().shouldShowHUD = value; }
		}
		
		public event EventHandler<PSPDFViewControllerHUDEventArgs> WillShowHUD {
			add { EnsurePSPDFViewControllerDelegate ().willShowHUD += value; }
			remove { EnsurePSPDFViewControllerDelegate ().willShowHUD -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerHUDEventArgs> DidShowHUD {
			add { EnsurePSPDFViewControllerDelegate ().didShowHUD += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didShowHUD -= value; }
		}
		
		public PSPDFViewControllerShouldHideHUD ShouldHideHUD {
			get { return EnsurePSPDFViewControllerDelegate ().shouldHideHUD; }
			set { EnsurePSPDFViewControllerDelegate ().shouldHideHUD = value; }
		}
		
		public event EventHandler<PSPDFViewControllerHUDEventArgs> WillHideHUD {
			add { EnsurePSPDFViewControllerDelegate ().willHideHUD += value; }
			remove { EnsurePSPDFViewControllerDelegate ().willHideHUD -= value; }
		}
		
		public event EventHandler<PSPDFViewControllerHUDEventArgs> DidHideHUD {
			add { EnsurePSPDFViewControllerDelegate ().didHideHUD += value; }
			remove { EnsurePSPDFViewControllerDelegate ().didHideHUD -= value; }
		}
		
		internal delegate void InnerPSPDFViewControllerUpdateSettingsBlock (IntPtr block, IntPtr pdfController, global::MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation);
		[CompilerGenerated]
		static readonly InnerPSPDFViewControllerUpdateSettingsBlock static_InnerPSPDFViewControllerUpdateSettingsBlock = TrampolinePSPDFViewControllerUpdateSettingsBlock;
		[MonoPInvokeCallback (typeof (InnerPSPDFViewControllerUpdateSettingsBlock))]
		static unsafe void TrampolinePSPDFViewControllerUpdateSettingsBlock (IntPtr block, IntPtr pdfController, global::MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation) {
			var descriptor = (BlockLiteral *) block;
			var del = (global::KS_PSPDFKitBindings.PSPDFViewControllerUpdateSettingsBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			if (del != null)
				del ((KS_PSPDFKitBindings.PSPDFViewController) Runtime.GetNSObject (pdfController), toInterfaceOrientation);
		}
		
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ViewState_var = null;
				__mt_WeakDelegate_var = null;
				__mt_Document_var = null;
				__mt_HUDView_var = null;
				__mt_ContentView_var = null;
				__mt_CloseButtonItem_var = null;
				__mt_OutlineButtonItem_var = null;
				__mt_SearchButtonItem_var = null;
				__mt_ViewModeButtonItem_var = null;
				__mt_PrintButtonItem_var = null;
				__mt_OpenInButtonItem_var = null;
				__mt_EmailButtonItem_var = null;
				__mt_AnnotationButtonItem_var = null;
				__mt_BookmarkButtonItem_var = null;
				__mt_BrightnessButtonItem_var = null;
				__mt_ActivityButtonItem_var = null;
				__mt_AdditionalActionsButtonItem_var = null;
				__mt_LeftBarButtonItems_var = null;
				__mt_RightBarButtonItems_var = null;
				__mt_AdditionalRightBarButtonItems_var = null;
				__mt_BarButtonItemsAlwaysEnabled_var = null;
				__mt_BackgroundColor_var = null;
				__mt_TintColor_var = null;
				__mt_PopoverController_var = null;
				__mt_PagingScrollView_var = null;
				__mt_ThumbnailController_var = null;
				__mt_VisiblePageNumbers_var = null;
				__mt_VisiblePageViews_var = null;
				__mt_MasterViewController_var = null;
				__mt_OverrideClassNames_var = null;
				__mt_PageTransitionController_var = null;
				__mt_PageLabel_var = null;
				__mt_ScrobbleBar_var = null;
				__mt_DocumentLabel_var = null;
				__mt_AnnotationViewCache_var = null;
			}
		}
	} /* class PSPDFViewController */
	public delegate void PSPDFViewControllerUpdateSettingsBlock (PSPDFViewController pdfController, global::MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation);
	
	
	//
	// EventArgs classes
	//
	public partial class PSPDFViewControllerDocumentEventArgs : EventArgs {
		public PSPDFViewControllerDocumentEventArgs (KS_PSPDFKitBindings.PSPDFDocument document)
		{
			this.Document = document;
		}
		public KS_PSPDFKitBindings.PSPDFDocument Document { get; set; }
	}
	
	public partial class PSPDFViewControllerShowPageViewwEventArgs : EventArgs {
		public PSPDFViewControllerShowPageViewwEventArgs (KS_PSPDFKitBindings.PSPDFPageView pageView)
		{
			this.PageView = pageView;
		}
		public KS_PSPDFKitBindings.PSPDFPageView PageView { get; set; }
	}
	
	public partial class PSPDFViewControllerDidLoadPageViewEventArgs : EventArgs {
		public PSPDFViewControllerDidLoadPageViewEventArgs (KS_PSPDFKitBindings.PSPDFPageView pageView)
		{
			this.PageView = pageView;
		}
		public KS_PSPDFKitBindings.PSPDFPageView PageView { get; set; }
	}
	
	public partial class PSPDFViewControllerWillUnloadPageViewEventArgs : EventArgs {
		public PSPDFViewControllerWillUnloadPageViewEventArgs (KS_PSPDFKitBindings.PSPDFPageView pageView)
		{
			this.PageView = pageView;
		}
		public KS_PSPDFKitBindings.PSPDFPageView PageView { get; set; }
	}
	
	public partial class PSPDFViewControllerDidChangeViewModeEventArgs : EventArgs {
		public PSPDFViewControllerDidChangeViewModeEventArgs (KS_PSPDFKitBindings.PSPDFViewMode viewMode)
		{
			this.ViewMode = viewMode;
		}
		public KS_PSPDFKitBindings.PSPDFViewMode ViewMode { get; set; }
	}
	
	public partial class PSPDFViewControllerDidEndPageDraggingEventArgs : EventArgs {
		public PSPDFViewControllerDidEndPageDraggingEventArgs (UIScrollView scrollView, bool decelerate, PointF velocity, PointF targetContentOffset)
		{
			this.ScrollView = scrollView;
			this.Decelerate = decelerate;
			this.Velocity = velocity;
			this.TargetContentOffset = targetContentOffset;
		}
		public UIScrollView ScrollView { get; set; }
		public bool Decelerate { get; set; }
		public PointF Velocity { get; set; }
		public PointF TargetContentOffset { get; set; }
	}
	
	public partial class PSPDFViewControllerDidEndPageScrollingAnimationEventArgs : EventArgs {
		public PSPDFViewControllerDidEndPageScrollingAnimationEventArgs (UIScrollView scrollView)
		{
			this.ScrollView = scrollView;
		}
		public UIScrollView ScrollView { get; set; }
	}
	
	public partial class PSPDFViewControllerDidEndPageZoomingEventArgs : EventArgs {
		public PSPDFViewControllerDidEndPageZoomingEventArgs (UIScrollView scrollView, float scale)
		{
			this.ScrollView = scrollView;
			this.Scale = scale;
		}
		public UIScrollView ScrollView { get; set; }
		public float Scale { get; set; }
	}
	
	public partial class PSPDFViewControllerDidRenderPageEventArgs : EventArgs {
		public PSPDFViewControllerDidRenderPageEventArgs (uint page, IntPtr context, SizeF fullsize, RectangleF clipRect, KS_PSPDFKitBindings.PSPDFAnnotation[] annotations, NSDictionary options)
		{
			this.Page = page;
			this.Context = context;
			this.Fullsize = fullsize;
			this.ClipRect = clipRect;
			this.Annotations = annotations;
			this.Options = options;
		}
		public uint Page { get; set; }
		public IntPtr Context { get; set; }
		public SizeF Fullsize { get; set; }
		public RectangleF ClipRect { get; set; }
		public KS_PSPDFKitBindings.PSPDFAnnotation[] Annotations { get; set; }
		public NSDictionary Options { get; set; }
	}
	
	public partial class PSPDFViewControllerDidSelectTextEventArgs : EventArgs {
		public PSPDFViewControllerDidSelectTextEventArgs (string text, KS_PSPDFKitBindings.PSPDFGlyph[] glyphs, RectangleF rect, KS_PSPDFKitBindings.PSPDFPageView pageView)
		{
			this.Text = text;
			this.Glyphs = glyphs;
			this.Rect = rect;
			this.PageView = pageView;
		}
		public string Text { get; set; }
		public KS_PSPDFKitBindings.PSPDFGlyph[] Glyphs { get; set; }
		public RectangleF Rect { get; set; }
		public KS_PSPDFKitBindings.PSPDFPageView PageView { get; set; }
	}
	
	public partial class PSPDFViewControllerDidSelectAnnotationEventArgs : EventArgs {
		public PSPDFViewControllerDidSelectAnnotationEventArgs (KS_PSPDFKitBindings.PSPDFAnnotation annotation, KS_PSPDFKitBindings.PSPDFPageView pageView)
		{
			this.Annotation = annotation;
			this.PageView = pageView;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotation Annotation { get; set; }
		public KS_PSPDFKitBindings.PSPDFPageView PageView { get; set; }
	}
	
	public partial class PSPDFViewControllerAnnotationViewEventArgs : EventArgs {
		public PSPDFViewControllerAnnotationViewEventArgs (KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol annotationView, KS_PSPDFKitBindings.PSPDFPageView pageView)
		{
			this.AnnotationView = annotationView;
			this.PageView = pageView;
		}
		public KS_PSPDFKitBindings.PSPDFAnnotationViewProtocol AnnotationView { get; set; }
		public KS_PSPDFKitBindings.PSPDFPageView PageView { get; set; }
	}
	
	public partial class PSPDFViewControllerDidShowControllerEventArgs : EventArgs {
		public PSPDFViewControllerDidShowControllerEventArgs (NSObject viewController, NSObject controller, bool animated)
		{
			this.ViewController = viewController;
			this.Controller = controller;
			this.Animated = animated;
		}
		public NSObject ViewController { get; set; }
		public NSObject Controller { get; set; }
		public bool Animated { get; set; }
	}
	
	public partial class PSPDFViewControllerRequestsUpdateForBarButtonItemEventArgs : EventArgs {
		public PSPDFViewControllerRequestsUpdateForBarButtonItemEventArgs (UIBarButtonItem barButtonItem, bool animated)
		{
			this.BarButtonItem = barButtonItem;
			this.Animated = animated;
		}
		public UIBarButtonItem BarButtonItem { get; set; }
		public bool Animated { get; set; }
	}
	
	public partial class PSPDFViewControllerHUDEventArgs : EventArgs {
		public PSPDFViewControllerHUDEventArgs (bool animated)
		{
			this.Animated = animated;
		}
		public bool Animated { get; set; }
	}
	
}
