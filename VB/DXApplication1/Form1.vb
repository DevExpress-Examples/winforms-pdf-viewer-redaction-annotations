Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraPdfViewer


Namespace DXApplication1
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            pdfViewer.LoadDocument("Demo.pdf")
            AddHandler pdfViewer.MouseDown, AddressOf pdfViewer1_MouseDown
            AddHandler pdfViewer.MouseUp, AddressOf pdfViewer1_MouseUp
            AddHandler pdfViewer.MouseMove, AddressOf PdfViewer_MouseMove
            AddHandler pdfViewer.Paint, AddressOf PdfViewer_Paint
            pdfViewer.CursorMode = PdfCursorMode.Custom
            AddHandler pdfViewer.MouseWheel, AddressOf PdfViewer_MouseWheel
            ActivateDrawing = True
        End Sub
        Private Sub redactionBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles redactionBarButtonItem.ItemClick
            Dim documentFacade As PdfDocumentFacade = pdfViewer.GetDocumentFacade()
            For Each rect In rectangleCoordinateList
                Dim pageInfo As PdfPageInfo = pdfViewer.GetPageInfo(rect.PageIndex + 1)
                Dim pageCropBox As PdfRectangle = pageInfo.CropBox
                Dim p1 As PdfPoint = rect.Point1
                Dim p2 As PdfPoint = rect.Point2

                Dim bounds As New PdfRectangle(CSng(Math.Min(p1.X, p2.X)), CSng(Math.Min(p1.Y, p2.Y)), CSng(Math.Max(p1.X, p2.X)), CSng(Math.Max(p1.Y, p2.Y)))

                Dim redactAnnotation As PdfRedactAnnotationFacade = documentFacade.Pages(rect.PageIndex).AddRedactAnnotation(bounds)
                redactAnnotation.Author = "Jane Doe"
                redactAnnotation.FillColor = New PdfRGBColor(0, 0, 0)
                redactAnnotation.FontColor = New PdfRGBColor(1, 1, 1)
                redactAnnotation.FontName = "Calibri"
                redactAnnotation.FontSize = 0 ' enables font auto-size
                redactAnnotation.OverlayText = "Classified"
                redactAnnotation.TextJustification = PdfTextJustification.Centered
                redactAnnotation.RepeatText = False

                redactAnnotation.Apply()
            Next rect
            rectangleCoordinateList.Clear()
        End Sub

#Region "GraphicsCoordinates"
        ' This class is used to save
        ' and restore the selection area coordinates
        Private Class GraphicsCoordinates
            Public Sub New(ByVal pageIndex As Integer, ByVal point1 As PdfPoint, ByVal point2 As PdfPoint)
                Me.PageIndex = pageIndex
                Me.Point1 = point1
                Me.Point2 = point2
            End Sub

            Public ReadOnly Property PageIndex() As Integer
            Public ReadOnly Property Point1() As PdfPoint
            Public ReadOnly Property Point2() As PdfPoint
            Public ReadOnly Property IsEmpty() As Boolean
                Get
                    Return Point1 = Point2
                End Get
            End Property
        End Class

        Private rectangleCoordinateList As New List(Of GraphicsCoordinates)()
        Private currentCoordinates As GraphicsCoordinates

        ' This variable indicates whether the Drawing button
        ' is activated
        Private ActivateDrawing As Boolean = False
#End Region ' GraphicsCoordinates

#Region "Drawing"
        Private Sub PdfViewer_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            If ActivateDrawing Then
                For Each r In rectangleCoordinateList
                    DrawImageRectangle(e.Graphics, r)
                Next r
                If currentCoordinates IsNot Nothing Then
                    DrawImageRectangle(e.Graphics, currentCoordinates)
                End If
            End If
        End Sub
        Private Sub DrawImageRectangle(ByVal graphics As Graphics, ByVal rect As GraphicsCoordinates)
            Dim start As PointF = pdfViewer.GetClientPoint(New PdfDocumentPosition(rect.PageIndex + 1, rect.Point1))
            Dim [end] As PointF = pdfViewer.GetClientPoint(New PdfDocumentPosition(rect.PageIndex + 1, rect.Point2))
            ' Create a rectangle where graphics should be drawn
            Dim r = Rectangle.FromLTRB(CInt(Math.Truncate(Math.Min(start.X, [end].X))), CInt(Math.Truncate(Math.Min(start.Y, [end].Y))), CInt(Math.Truncate(Math.Max(start.X, [end].X))), CInt(Math.Truncate(Math.Max(start.Y, [end].Y))))

            ' Draw a rectangle in the created area
            graphics.DrawRectangle(New Pen(Color.Red), r)
        End Sub
#End Region ' Drawing
#Region "MouseEvents"
        Private Sub PdfViewer_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
            If ModifierKeys = Keys.Control Then
                'INSTANT VB WARNING: Instant VB cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
                pdfViewer.ZoomFactor += e.Delta / 100
            Else
                pdfViewer.ScrollVertical(-e.Delta)
            End If
        End Sub
        Private Sub PdfViewer_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If currentCoordinates IsNot Nothing Then
                UpdateCurrentRect(e.Location)
                pdfViewer.Invalidate()
            End If
        End Sub
        Private Sub pdfViewer1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)

            ' Convert the retrieved coordinates 
            ' to the page coordinates
            UpdateCurrentRect(e.Location)
            If currentCoordinates IsNot Nothing Then
                If Not currentCoordinates.IsEmpty AndAlso ActivateDrawing Then
                    ' Add coordinates to the list
                    rectangleCoordinateList.Add(currentCoordinates)
                End If
                currentCoordinates = Nothing
            End If
        End Sub
        Private Sub pdfViewer1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim position = pdfViewer.GetDocumentPosition(e.Location, True)
            currentCoordinates = New GraphicsCoordinates(position.PageNumber - 1, position.Point, position.Point)
        End Sub

        Private Sub UpdateCurrentRect(ByVal location As Point)
            If rectangleCoordinateList IsNot Nothing Then
                Dim documentPosition = pdfViewer.GetDocumentPosition(location, True)
                If currentCoordinates.PageIndex = documentPosition.PageNumber - 1 Then

                    currentCoordinates = New GraphicsCoordinates(currentCoordinates.PageIndex, currentCoordinates.Point1, documentPosition.Point)
                End If
            End If
        End Sub
#End Region ' MouseEvents
    End Class
End Namespace