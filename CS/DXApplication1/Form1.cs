using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;
using System.Diagnostics;


namespace DXApplication1
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            pdfViewer.LoadDocument("Demo.pdf");
            pdfViewer.MouseDown += pdfViewer1_MouseDown;
            pdfViewer.MouseUp += pdfViewer1_MouseUp;
            pdfViewer.MouseMove += PdfViewer_MouseMove;
            pdfViewer.Paint += PdfViewer_Paint;
            pdfViewer.CursorMode = PdfCursorMode.Custom;
            pdfViewer.MouseWheel += PdfViewer_MouseWheel;
            ActivateDrawing = true;
        }
        private void redactionBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            PdfDocumentFacade documentFacade = pdfViewer.GetDocumentFacade();
            foreach (var rect in rectangleCoordinateList)
            {
                PdfPageInfo pageInfo = pdfViewer.GetPageInfo(rect.PageIndex + 1);
                PdfRectangle pageCropBox = pageInfo.CropBox;
                PdfPoint p1 = rect.Point1;
                PdfPoint p2 = rect.Point2;

                PdfRectangle bounds = new PdfRectangle(
                    (float)Math.Min(p1.X, p2.X), (float)Math.Min(p1.Y, p2.Y),
                    (float)Math.Max(p1.X, p2.X), (float)Math.Max(p1.Y, p2.Y));

                PdfRedactAnnotationFacade redactAnnotation = documentFacade.Pages[rect.PageIndex].AddRedactAnnotation(bounds);
                redactAnnotation.Author = "Jane Doe";
                redactAnnotation.FillColor = new PdfRGBColor(0, 0, 0);
                redactAnnotation.FontColor = new PdfRGBColor(1, 1, 1);
                redactAnnotation.FontName = "Calibri";
                redactAnnotation.FontSize = 0; // enables font auto-size
                redactAnnotation.OverlayText = "Classified";
                redactAnnotation.TextJustification = PdfTextJustification.Centered;
                redactAnnotation.RepeatText = false;

                redactAnnotation.Apply();
            }
            rectangleCoordinateList.Clear();
        }

        #region GraphicsCoordinates
        // This class is used to save
        // and restore the selection area coordinates
        class GraphicsCoordinates
        {
            public GraphicsCoordinates(int pageIndex, PdfPoint point1, PdfPoint point2)
            {
                PageIndex = pageIndex;
                Point1 = point1;
                Point2 = point2;
            }

            public int PageIndex { get; }
            public PdfPoint Point1 { get; }
            public PdfPoint Point2 { get; }
            public bool IsEmpty => Point1 == Point2;
        }

        List<GraphicsCoordinates> rectangleCoordinateList = new List<GraphicsCoordinates>();
        GraphicsCoordinates currentCoordinates;

        // This variable indicates whether the Drawing button
        // is activated
        bool ActivateDrawing = false;
        #endregion GraphicsCoordinates

        #region Drawing
        void PdfViewer_Paint(object sender, PaintEventArgs e)
        {
            if (ActivateDrawing)
            {
                foreach (var r in rectangleCoordinateList)
                    DrawImageRectangle(e.Graphics, r);
                if (currentCoordinates != null)
                    DrawImageRectangle(e.Graphics, currentCoordinates);
            }
        }
        void DrawImageRectangle(Graphics graphics, GraphicsCoordinates rect)
        {
            PointF start = pdfViewer.GetClientPoint(new PdfDocumentPosition(rect.PageIndex + 1, rect.Point1));
            PointF end = pdfViewer.GetClientPoint(new PdfDocumentPosition(rect.PageIndex + 1, rect.Point2));
            // Create a rectangle where graphics should be drawn
            var r = Rectangle.FromLTRB((int)Math.Min(start.X, end.X), (int)Math.Min(start.Y, end.Y), (int)Math.Max(start.X, end.X), (int)Math.Max(start.Y, end.Y));

            // Draw a rectangle in the created area
            graphics.DrawRectangle(new Pen(Color.Red), r);
        }
        #endregion Drawing
        #region MouseEvents
        void PdfViewer_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
                pdfViewer.ZoomFactor += e.Delta / 100;
            else
                pdfViewer.ScrollVertical(-e.Delta);
        }
        void PdfViewer_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentCoordinates != null)
            {
                UpdateCurrentRect(e.Location);
                pdfViewer.Invalidate();
            }
        }
        void pdfViewer1_MouseUp(object sender, MouseEventArgs e)
        {

            // Convert the retrieved coordinates 
            // to the page coordinates
            UpdateCurrentRect(e.Location);
            if (currentCoordinates != null)
            {
                if (!currentCoordinates.IsEmpty && ActivateDrawing)
                    // Add coordinates to the list
                    rectangleCoordinateList.Add(currentCoordinates);
                currentCoordinates = null;
            }
        }
        void pdfViewer1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = pdfViewer.GetDocumentPosition(e.Location, true);
            currentCoordinates = new GraphicsCoordinates(position.PageNumber - 1, position.Point, position.Point);
        }

        void UpdateCurrentRect(Point location)
        {
            if (rectangleCoordinateList != null)
            {
                var documentPosition = pdfViewer.GetDocumentPosition(location, true);
                if (currentCoordinates.PageIndex == documentPosition.PageNumber - 1)

                    currentCoordinates = new GraphicsCoordinates(currentCoordinates.PageIndex, currentCoordinates.Point1, documentPosition.Point);
            }
        }
        #endregion MouseEvents
    }
}