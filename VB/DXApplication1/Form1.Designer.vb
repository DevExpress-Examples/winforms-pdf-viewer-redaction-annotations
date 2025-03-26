Namespace DXApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			components = New System.ComponentModel.Container()
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip2 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem2 As New DevExpress.Utils.ToolTipItem()
			pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			pdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
			pdfFileSaveAsBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
			pdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
			pdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
			pdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
			pdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
			pdfSetPageNumberBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem()
			repositoryItemPageNumberEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit()
			pdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
			pdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
			pdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
			pdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
			pdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
			pdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
			pdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
			pdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
			pdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
			pdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
			pdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
			pdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
			pdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
			pdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
			pdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
			pdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
			pdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
			hotkeyFocusNextBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusNextBarItem()
			hotkeyFocusPreviousBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusPreviousBarItem()
			hotkeyFocusThumbnailTabBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusThumbnailTabBarItem()
			hotkeyFocusBookmarksTabBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusBookmarksTabBarItem()
			hotkeyFocusAttachmentsTabBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusAttachmentsTabBarItem()
			hotkeyFocusCommentsTabBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusCommentsTabBarItem()
			hotkeyFocusLayersTabBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusLayersTabBarItem()
			hotkeyFocusSignaturesTabBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusSignaturesTabBarItem()
			hotkeyFocusDocumentViewerBarItem1 = New DevExpress.XtraPdfViewer.Native.HotkeyFocusDocumentViewerBarItem()
			pdfTextHighlightBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem()
			pdfTextStrikethroughBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem()
			pdfTextUnderlineBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem()
			pdfStickyNoteBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfStickyNoteBarItem()
			pdfFreeTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFreeTextBarItem()
			pdfCalloutFreeTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfCalloutFreeTextBarItem()
			pdfExportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem()
			pdfImportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem()
			redactionBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
			pdfRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfRibbonPage()
			pdfFileRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup()
			pdfFindRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup()
			pdfNavigationRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup()
			pdfZoomRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup()
			globalHotkeysPageGroup1 = New DevExpress.XtraPdfViewer.Native.GlobalHotkeysPageGroup()
			ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			pdfCommentRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfCommentRibbonPage()
			pdfTextCommentPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfTextCommentPageGroup()
			pdfNoteCommentPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNoteCommentPageGroup()
			pdfFreeTextCommentPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFreeTextCommentPageGroup()
			pdfFormDataRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage()
			pdfFormDataBarPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup()
			pdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController(components)
			DirectCast(ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(repositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(pdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			SuspendLayout()
			' 
			' pdfViewer
			' 
			pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			pdfViewer.Location = New System.Drawing.Point(0, 193)
			pdfViewer.MenuManager = ribbonControl1
			pdfViewer.Name = "pdfViewer"
			pdfViewer.Size = New System.Drawing.Size(1100, 507)
			pdfViewer.TabIndex = 0
			' 
			' ribbonControl1
			' 
			ribbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(37)
			ribbonControl1.ExpandCollapseItem.Id = 0
			ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { ribbonControl1.ExpandCollapseItem, pdfFileOpenBarItem1, pdfFileSaveAsBarItem1, pdfFilePrintBarItem1, pdfFindTextBarItem1, pdfPreviousPageBarItem1, pdfNextPageBarItem1, pdfSetPageNumberBarItem1, pdfZoomOutBarItem1, pdfZoomInBarItem1, pdfExactZoomListBarSubItem1, pdfZoom10CheckItem1, pdfZoom25CheckItem1, pdfZoom50CheckItem1, pdfZoom75CheckItem1, pdfZoom100CheckItem1, pdfZoom125CheckItem1, pdfZoom150CheckItem1, pdfZoom200CheckItem1, pdfZoom400CheckItem1, pdfZoom500CheckItem1, pdfSetActualSizeZoomModeCheckItem1, pdfSetPageLevelZoomModeCheckItem1, pdfSetFitWidthZoomModeCheckItem1, pdfSetFitVisibleZoomModeCheckItem1, hotkeyFocusNextBarItem1, hotkeyFocusPreviousBarItem1, hotkeyFocusThumbnailTabBarItem1, hotkeyFocusBookmarksTabBarItem1, hotkeyFocusAttachmentsTabBarItem1, hotkeyFocusCommentsTabBarItem1, hotkeyFocusLayersTabBarItem1, hotkeyFocusSignaturesTabBarItem1, hotkeyFocusDocumentViewerBarItem1, pdfTextHighlightBarItem1, pdfTextStrikethroughBarItem1, pdfTextUnderlineBarItem1, pdfStickyNoteBarItem1, pdfFreeTextBarItem1, pdfCalloutFreeTextBarItem1, pdfExportFormDataBarItem1, pdfImportFormDataBarItem1, redactionBarButtonItem })
			ribbonControl1.Location = New System.Drawing.Point(0, 0)
			ribbonControl1.Margin = New System.Windows.Forms.Padding(4)
			ribbonControl1.MaxItemId = 44
			ribbonControl1.Name = "ribbonControl1"
			ribbonControl1.OptionsMenuMinWidth = 412
			ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { pdfRibbonPage1, pdfCommentRibbonPage1, pdfFormDataRibbonPage1 })
			ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { repositoryItemPageNumberEdit1 })
			ribbonControl1.Size = New System.Drawing.Size(1100, 193)
			' 
			' pdfFileOpenBarItem1
			' 
			pdfFileOpenBarItem1.Id = 1
			pdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O)
			pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1"
			' 
			' pdfFileSaveAsBarItem1
			' 
			pdfFileSaveAsBarItem1.Id = 2
			pdfFileSaveAsBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S)
			pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1"
			' 
			' pdfFilePrintBarItem1
			' 
			pdfFilePrintBarItem1.Id = 3
			pdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P)
			pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1"
			' 
			' pdfFindTextBarItem1
			' 
			pdfFindTextBarItem1.Id = 4
			pdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F)
			pdfFindTextBarItem1.Name = "pdfFindTextBarItem1"
			' 
			' pdfPreviousPageBarItem1
			' 
			pdfPreviousPageBarItem1.Id = 5
			pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1"
			' 
			' pdfNextPageBarItem1
			' 
			pdfNextPageBarItem1.Id = 6
			pdfNextPageBarItem1.Name = "pdfNextPageBarItem1"
			' 
			' pdfSetPageNumberBarItem1
			' 
			pdfSetPageNumberBarItem1.Edit = repositoryItemPageNumberEdit1
			pdfSetPageNumberBarItem1.Id = 7
			pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1"
			' 
			' repositoryItemPageNumberEdit1
			' 
			repositoryItemPageNumberEdit1.AutoHeight = False
			repositoryItemPageNumberEdit1.Mask.EditMask = "########;"
			repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1"
			' 
			' pdfZoomOutBarItem1
			' 
			pdfZoomOutBarItem1.Id = 8
			pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1"
			toolTipTitleItem1.Text = "Zoom Out (Ctrl + Minus)"
			toolTipItem1.Text = "Zoom out to see more of the page at a reduced size."
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			pdfZoomOutBarItem1.SuperTip = superToolTip1
			' 
			' pdfZoomInBarItem1
			' 
			pdfZoomInBarItem1.Id = 9
			pdfZoomInBarItem1.Name = "pdfZoomInBarItem1"
			toolTipTitleItem2.Text = "Zoom In (Ctrl + Plus)"
			toolTipItem2.Text = "Zoom in to get a close-up view of the PDF document."
			superToolTip2.Items.Add(toolTipTitleItem2)
			superToolTip2.Items.Add(toolTipItem2)
			pdfZoomInBarItem1.SuperTip = superToolTip2
			' 
			' pdfExactZoomListBarSubItem1
			' 
			pdfExactZoomListBarSubItem1.Id = 10
			pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom10CheckItem1, True),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom25CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom50CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom75CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom100CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom125CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom150CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom200CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom400CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfZoom500CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfSetActualSizeZoomModeCheckItem1, True),
				New DevExpress.XtraBars.LinkPersistInfo(pdfSetPageLevelZoomModeCheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfSetFitWidthZoomModeCheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(pdfSetFitVisibleZoomModeCheckItem1)
			})
			pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1"
			pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
			' 
			' pdfZoom10CheckItem1
			' 
			pdfZoom10CheckItem1.Id = 11
			pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1"
			' 
			' pdfZoom25CheckItem1
			' 
			pdfZoom25CheckItem1.Id = 12
			pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1"
			' 
			' pdfZoom50CheckItem1
			' 
			pdfZoom50CheckItem1.Id = 13
			pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1"
			' 
			' pdfZoom75CheckItem1
			' 
			pdfZoom75CheckItem1.Id = 14
			pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1"
			' 
			' pdfZoom100CheckItem1
			' 
			pdfZoom100CheckItem1.Id = 15
			pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1"
			' 
			' pdfZoom125CheckItem1
			' 
			pdfZoom125CheckItem1.Id = 16
			pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1"
			' 
			' pdfZoom150CheckItem1
			' 
			pdfZoom150CheckItem1.Id = 17
			pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1"
			' 
			' pdfZoom200CheckItem1
			' 
			pdfZoom200CheckItem1.Id = 18
			pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1"
			' 
			' pdfZoom400CheckItem1
			' 
			pdfZoom400CheckItem1.Id = 19
			pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1"
			' 
			' pdfZoom500CheckItem1
			' 
			pdfZoom500CheckItem1.Id = 20
			pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1"
			' 
			' pdfSetActualSizeZoomModeCheckItem1
			' 
			pdfSetActualSizeZoomModeCheckItem1.Id = 21
			pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1"
			' 
			' pdfSetPageLevelZoomModeCheckItem1
			' 
			pdfSetPageLevelZoomModeCheckItem1.Id = 22
			pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1"
			' 
			' pdfSetFitWidthZoomModeCheckItem1
			' 
			pdfSetFitWidthZoomModeCheckItem1.Id = 23
			pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1"
			' 
			' pdfSetFitVisibleZoomModeCheckItem1
			' 
			pdfSetFitVisibleZoomModeCheckItem1.Id = 24
			pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1"
			' 
			' hotkeyFocusNextBarItem1
			' 
			hotkeyFocusNextBarItem1.Id = 25
			hotkeyFocusNextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
			hotkeyFocusNextBarItem1.Name = "hotkeyFocusNextBarItem1"
			' 
			' hotkeyFocusPreviousBarItem1
			' 
			hotkeyFocusPreviousBarItem1.Id = 26
			hotkeyFocusPreviousBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F6)
			hotkeyFocusPreviousBarItem1.Name = "hotkeyFocusPreviousBarItem1"
			' 
			' hotkeyFocusThumbnailTabBarItem1
			' 
			hotkeyFocusThumbnailTabBarItem1.Id = 27
			hotkeyFocusThumbnailTabBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T)
			hotkeyFocusThumbnailTabBarItem1.Name = "hotkeyFocusThumbnailTabBarItem1"
			' 
			' hotkeyFocusBookmarksTabBarItem1
			' 
			hotkeyFocusBookmarksTabBarItem1.Id = 28
			hotkeyFocusBookmarksTabBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B)
			hotkeyFocusBookmarksTabBarItem1.Name = "hotkeyFocusBookmarksTabBarItem1"
			' 
			' hotkeyFocusAttachmentsTabBarItem1
			' 
			hotkeyFocusAttachmentsTabBarItem1.Id = 29
			hotkeyFocusAttachmentsTabBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A)
			hotkeyFocusAttachmentsTabBarItem1.Name = "hotkeyFocusAttachmentsTabBarItem1"
			' 
			' hotkeyFocusCommentsTabBarItem1
			' 
			hotkeyFocusCommentsTabBarItem1.Id = 30
			hotkeyFocusCommentsTabBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C)
			hotkeyFocusCommentsTabBarItem1.Name = "hotkeyFocusCommentsTabBarItem1"
			' 
			' hotkeyFocusLayersTabBarItem1
			' 
			hotkeyFocusLayersTabBarItem1.Id = 31
			hotkeyFocusLayersTabBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L)
			hotkeyFocusLayersTabBarItem1.Name = "hotkeyFocusLayersTabBarItem1"
			' 
			' hotkeyFocusSignaturesTabBarItem1
			' 
			hotkeyFocusSignaturesTabBarItem1.Id = 32
			hotkeyFocusSignaturesTabBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S)
			hotkeyFocusSignaturesTabBarItem1.Name = "hotkeyFocusSignaturesTabBarItem1"
			' 
			' hotkeyFocusDocumentViewerBarItem1
			' 
			hotkeyFocusDocumentViewerBarItem1.Id = 33
			hotkeyFocusDocumentViewerBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
			hotkeyFocusDocumentViewerBarItem1.Name = "hotkeyFocusDocumentViewerBarItem1"
			' 
			' pdfTextHighlightBarItem1
			' 
			pdfTextHighlightBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			pdfTextHighlightBarItem1.Id = 34
			pdfTextHighlightBarItem1.Name = "pdfTextHighlightBarItem1"
			' 
			' pdfTextStrikethroughBarItem1
			' 
			pdfTextStrikethroughBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			pdfTextStrikethroughBarItem1.Id = 35
			pdfTextStrikethroughBarItem1.Name = "pdfTextStrikethroughBarItem1"
			' 
			' pdfTextUnderlineBarItem1
			' 
			pdfTextUnderlineBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			pdfTextUnderlineBarItem1.Id = 36
			pdfTextUnderlineBarItem1.Name = "pdfTextUnderlineBarItem1"
			' 
			' pdfStickyNoteBarItem1
			' 
			pdfStickyNoteBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			pdfStickyNoteBarItem1.Id = 37
			pdfStickyNoteBarItem1.Name = "pdfStickyNoteBarItem1"
			' 
			' pdfFreeTextBarItem1
			' 
			pdfFreeTextBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			pdfFreeTextBarItem1.Id = 38
			pdfFreeTextBarItem1.Name = "pdfFreeTextBarItem1"
			' 
			' pdfCalloutFreeTextBarItem1
			' 
			pdfCalloutFreeTextBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
			pdfCalloutFreeTextBarItem1.Id = 39
			pdfCalloutFreeTextBarItem1.Name = "pdfCalloutFreeTextBarItem1"
			' 
			' pdfExportFormDataBarItem1
			' 
			pdfExportFormDataBarItem1.Id = 40
			pdfExportFormDataBarItem1.Name = "pdfExportFormDataBarItem1"
			' 
			' pdfImportFormDataBarItem1
			' 
			pdfImportFormDataBarItem1.Id = 41
			pdfImportFormDataBarItem1.Name = "pdfImportFormDataBarItem1"
			' 
			' redactionBarButtonItem
			' 
			redactionBarButtonItem.Caption = "Redact"
			redactionBarButtonItem.Id = 42
			redactionBarButtonItem.Name = "redactionBarButtonItem"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: redactionBarButtonItem.ItemClick += redactionBarButtonItem_ItemClick;
			' 
			' pdfRibbonPage1
			' 
			pdfRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { pdfFileRibbonPageGroup1, pdfFindRibbonPageGroup1, pdfNavigationRibbonPageGroup1, pdfZoomRibbonPageGroup1, globalHotkeysPageGroup1, ribbonPageGroup1 })
			pdfRibbonPage1.Name = "pdfRibbonPage1"
			' 
			' pdfFileRibbonPageGroup1
			' 
			pdfFileRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfFileRibbonPageGroup1.ItemLinks.Add(pdfFileOpenBarItem1)
			pdfFileRibbonPageGroup1.ItemLinks.Add(pdfFileSaveAsBarItem1)
			pdfFileRibbonPageGroup1.ItemLinks.Add(pdfFilePrintBarItem1)
			pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1"
			' 
			' pdfFindRibbonPageGroup1
			' 
			pdfFindRibbonPageGroup1.AllowTextClipping = False
			pdfFindRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfFindRibbonPageGroup1.ItemLinks.Add(pdfFindTextBarItem1)
			pdfFindRibbonPageGroup1.Name = "pdfFindRibbonPageGroup1"
			' 
			' pdfNavigationRibbonPageGroup1
			' 
			pdfNavigationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfNavigationRibbonPageGroup1.ItemLinks.Add(pdfPreviousPageBarItem1)
			pdfNavigationRibbonPageGroup1.ItemLinks.Add(pdfNextPageBarItem1)
			pdfNavigationRibbonPageGroup1.ItemLinks.Add(pdfSetPageNumberBarItem1)
			pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1"
			' 
			' pdfZoomRibbonPageGroup1
			' 
			pdfZoomRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfZoomRibbonPageGroup1.ItemLinks.Add(pdfZoomOutBarItem1)
			pdfZoomRibbonPageGroup1.ItemLinks.Add(pdfZoomInBarItem1)
			pdfZoomRibbonPageGroup1.ItemLinks.Add(pdfExactZoomListBarSubItem1)
			pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1"
			' 
			' globalHotkeysPageGroup1
			' 
			globalHotkeysPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusNextBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusPreviousBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusThumbnailTabBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusBookmarksTabBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusAttachmentsTabBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusCommentsTabBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusLayersTabBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusSignaturesTabBarItem1)
			globalHotkeysPageGroup1.ItemLinks.Add(hotkeyFocusDocumentViewerBarItem1)
			globalHotkeysPageGroup1.Name = "globalHotkeysPageGroup1"
			globalHotkeysPageGroup1.Visible = False
			' 
			' ribbonPageGroup1
			' 
			ribbonPageGroup1.ItemLinks.Add(redactionBarButtonItem)
			ribbonPageGroup1.Name = "ribbonPageGroup1"
			ribbonPageGroup1.Text = "Redaction"
			' 
			' pdfCommentRibbonPage1
			' 
			pdfCommentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { pdfTextCommentPageGroup1, pdfNoteCommentPageGroup1, pdfFreeTextCommentPageGroup1 })
			pdfCommentRibbonPage1.Name = "pdfCommentRibbonPage1"
			' 
			' pdfTextCommentPageGroup1
			' 
			pdfTextCommentPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfTextCommentPageGroup1.ItemLinks.Add(pdfTextHighlightBarItem1)
			pdfTextCommentPageGroup1.ItemLinks.Add(pdfTextStrikethroughBarItem1)
			pdfTextCommentPageGroup1.ItemLinks.Add(pdfTextUnderlineBarItem1)
			pdfTextCommentPageGroup1.Name = "pdfTextCommentPageGroup1"
			' 
			' pdfNoteCommentPageGroup1
			' 
			pdfNoteCommentPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfNoteCommentPageGroup1.ItemLinks.Add(pdfStickyNoteBarItem1)
			pdfNoteCommentPageGroup1.Name = "pdfNoteCommentPageGroup1"
			' 
			' pdfFreeTextCommentPageGroup1
			' 
			pdfFreeTextCommentPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfFreeTextCommentPageGroup1.ItemLinks.Add(pdfFreeTextBarItem1)
			pdfFreeTextCommentPageGroup1.ItemLinks.Add(pdfCalloutFreeTextBarItem1)
			pdfFreeTextCommentPageGroup1.Name = "pdfFreeTextCommentPageGroup1"
			' 
			' pdfFormDataRibbonPage1
			' 
			pdfFormDataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { pdfFormDataBarPageGroup1 })
			pdfFormDataRibbonPage1.Name = "pdfFormDataRibbonPage1"
			' 
			' pdfFormDataBarPageGroup1
			' 
			pdfFormDataBarPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
			pdfFormDataBarPageGroup1.ItemLinks.Add(pdfExportFormDataBarItem1)
			pdfFormDataBarPageGroup1.ItemLinks.Add(pdfImportFormDataBarItem1)
			pdfFormDataBarPageGroup1.Name = "pdfFormDataBarPageGroup1"
			' 
			' pdfBarController1
			' 
			pdfBarController1.BarItems.Add(pdfFileOpenBarItem1)
			pdfBarController1.BarItems.Add(pdfFileSaveAsBarItem1)
			pdfBarController1.BarItems.Add(pdfFilePrintBarItem1)
			pdfBarController1.BarItems.Add(pdfFindTextBarItem1)
			pdfBarController1.BarItems.Add(pdfPreviousPageBarItem1)
			pdfBarController1.BarItems.Add(pdfNextPageBarItem1)
			pdfBarController1.BarItems.Add(pdfSetPageNumberBarItem1)
			pdfBarController1.BarItems.Add(pdfZoomOutBarItem1)
			pdfBarController1.BarItems.Add(pdfZoomInBarItem1)
			pdfBarController1.BarItems.Add(pdfZoom10CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom25CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom50CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom75CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom100CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom125CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom150CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom200CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom400CheckItem1)
			pdfBarController1.BarItems.Add(pdfZoom500CheckItem1)
			pdfBarController1.BarItems.Add(pdfSetActualSizeZoomModeCheckItem1)
			pdfBarController1.BarItems.Add(pdfSetPageLevelZoomModeCheckItem1)
			pdfBarController1.BarItems.Add(pdfSetFitWidthZoomModeCheckItem1)
			pdfBarController1.BarItems.Add(pdfSetFitVisibleZoomModeCheckItem1)
			pdfBarController1.BarItems.Add(pdfExactZoomListBarSubItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusNextBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusPreviousBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusThumbnailTabBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusBookmarksTabBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusAttachmentsTabBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusCommentsTabBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusLayersTabBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusSignaturesTabBarItem1)
			pdfBarController1.BarItems.Add(hotkeyFocusDocumentViewerBarItem1)
			pdfBarController1.BarItems.Add(pdfTextHighlightBarItem1)
			pdfBarController1.BarItems.Add(pdfTextStrikethroughBarItem1)
			pdfBarController1.BarItems.Add(pdfTextUnderlineBarItem1)
			pdfBarController1.BarItems.Add(pdfStickyNoteBarItem1)
			pdfBarController1.BarItems.Add(pdfFreeTextBarItem1)
			pdfBarController1.BarItems.Add(pdfCalloutFreeTextBarItem1)
			pdfBarController1.BarItems.Add(pdfExportFormDataBarItem1)
			pdfBarController1.BarItems.Add(pdfImportFormDataBarItem1)
			pdfBarController1.Control = pdfViewer
			' 
			' Form1
			' 
			AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
			AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			ClientSize = New System.Drawing.Size(1100, 700)
			Controls.Add(pdfViewer)
			Controls.Add(ribbonControl1)
			Name = "Form1"
			Ribbon = ribbonControl1
			Text = "Form1"
			DirectCast(ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(repositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(pdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			ResumeLayout(False)
			PerformLayout()

		End Sub

		#End Region

		Private pdfViewer As DevExpress.XtraPdfViewer.PdfViewer
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private pdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
		Private pdfFileSaveAsBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem
		Private pdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
		Private pdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
		Private pdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
		Private pdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
		Private pdfSetPageNumberBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem
		Private repositoryItemPageNumberEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit
		Private pdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
		Private pdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
		Private pdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
		Private pdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
		Private pdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
		Private pdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
		Private pdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
		Private pdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
		Private pdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
		Private pdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
		Private pdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
		Private pdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
		Private pdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
		Private pdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
		Private pdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
		Private pdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
		Private pdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
		Private hotkeyFocusNextBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusNextBarItem
		Private hotkeyFocusPreviousBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusPreviousBarItem
		Private hotkeyFocusThumbnailTabBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusThumbnailTabBarItem
		Private hotkeyFocusBookmarksTabBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusBookmarksTabBarItem
		Private hotkeyFocusAttachmentsTabBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusAttachmentsTabBarItem
		Private hotkeyFocusCommentsTabBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusCommentsTabBarItem
		Private hotkeyFocusLayersTabBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusLayersTabBarItem
		Private hotkeyFocusSignaturesTabBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusSignaturesTabBarItem
		Private hotkeyFocusDocumentViewerBarItem1 As DevExpress.XtraPdfViewer.Native.HotkeyFocusDocumentViewerBarItem
		Private pdfTextHighlightBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem
		Private pdfTextStrikethroughBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem
		Private pdfTextUnderlineBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem
		Private pdfStickyNoteBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfStickyNoteBarItem
		Private pdfFreeTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFreeTextBarItem
		Private pdfCalloutFreeTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfCalloutFreeTextBarItem
		Private pdfExportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem
		Private pdfImportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem
		Private pdfRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfRibbonPage
		Private pdfFileRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup
		Private pdfFindRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup
		Private pdfNavigationRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup
		Private pdfZoomRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup
		Private globalHotkeysPageGroup1 As DevExpress.XtraPdfViewer.Native.GlobalHotkeysPageGroup
		Private pdfCommentRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfCommentRibbonPage
		Private pdfTextCommentPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfTextCommentPageGroup
		Private pdfNoteCommentPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNoteCommentPageGroup
		Private pdfFreeTextCommentPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFreeTextCommentPageGroup
		Private pdfFormDataRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage
		Private pdfFormDataBarPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup
		Private pdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents redactionBarButtonItem As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace
