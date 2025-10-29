// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Specs and Catalogs - Conversion Complete|$TaskDialog_Enhanced", Parent = typeof(SpecEditorDLG), GUIType = GuiType.UIA)]
    public partial class SpecandCatalogsConversionCompleteDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  Image Image1IMG;
        public  StaticText zeroFilesHaveBeenST;
        public  StaticText StaticTextST;
        public  Image Image2IMG;
        public  StaticText ViewTheConversionReportST;
        public  StaticText ListsOverallConversionResultsST;
        public  Image Image3IMG;
        public  StaticText OpenTheOutputFolderST;
        public  StaticText DisplaysTheConvertedFilesST;

        partial void OnInitialize();

        public SpecandCatalogsConversionCompleteDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Specs and Catalogs - Conversion Complete|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Specs and Catalogs - Conversion Complete|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CloseButton|#1/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            Image1IMG = new Image()
            {
                Tag = "[Image]$InformationImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            zeroFilesHaveBeenST = new StaticText()
            {
                Tag = "[StaticText]0 files have been converted to Autodesk AutoCAD Plant 3D 2024 format*|$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zeroFilesHaveBeenST);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Image2IMG = new Image()
            {
                Tag = "[Image]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            ViewTheConversionReportST = new StaticText()
            {
                Tag = "[StaticText]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewTheConversionReportST);

            ListsOverallConversionResultsST = new StaticText()
            {
                Tag = "[StaticText]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListsOverallConversionResultsST);

            Image3IMG = new Image()
            {
                Tag = "[Image]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            OpenTheOutputFolderST = new StaticText()
            {
                Tag = "[StaticText]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenTheOutputFolderST);

            DisplaysTheConvertedFilesST = new StaticText()
            {
                Tag = "[StaticText]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplaysTheConvertedFilesST);
        }
    }
}
