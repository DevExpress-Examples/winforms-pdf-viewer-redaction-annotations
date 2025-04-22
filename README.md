<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/955250646/25.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1284649)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# PDF Viewer for WinForms - Add Redaction Annotations by Coordinates Obtained from the Viewer

The DevExpress WinForms PDF Viewer allows you to create redaction annotations within a specified PDF file region. In this example, a rectangle is drawn in the selection area. Click the **Redact** button to add a redaction annotation to the drawn rectangle.

![pdf viewer for winforms redaction annotation on selection](./media/pdf-redaction.gif)

>[!important]
> You need an active [DevExpress Office File API Subscription](https://www.devexpress.com/products/net/office-file-api/) or [DevExpress Universal Subscription](https://www.devexpress.com/subscriptions/universal.xml) to use PDF Graphics and Facade API in production code.

## Implementation Details

Selection area coordinates are obtained through `MouseUp`, `MouseMove`, and `MouseDown` event handlers. Drawing the rectangle is handled within the `PdfViewerControl.Paint` event handler. A `PdfDocumentFacade` instance of the active page is obtained in the `ButtonClick` event handler. A `AddRedactAnnotation` method call generates a redaction annotation over the rectangle. An `ApplyRedactAnnotations` method call applies the annotation.

## Files to Review

* [Form1.cs](./CS/DXApplication1/Form1.cs) (VB: [Form1.vb](./VB/DXApplication1/Form1.vb))

## More Examples

* [How to: Draw Graphics by Coordinates Obtained from the PDF Viewer](https://github.com/DevExpress-Examples/how-to-custom-draw-in-pdf-viewer)

## Documentation

* [How to: Use PDF Facade API to Manage Annotations in PDF Viewer for WinForms](https://docs.devexpress.com/WindowsForms/403206/controls-and-libraries/pdf-viewer/examples/pdf-facade-api/how-to-organize-annotations)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pdf-viewer-redaction-annotations&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pdf-viewer-redaction-annotations&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
