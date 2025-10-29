// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Supporting Content Unavailable|$TaskDialog_Enhanced", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class SupportingContentUnavailableDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar SupportingContentUnavailableCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  Image Image1IMG;
        public  StaticText SupportingContentForTheseST;
        public  StaticText SpecsAndCatalogsReferenceST;
        public  Image Image2IMG;
        public  StaticText SpecifyAutoCADPlant2011ST;
        public  Image Image3IMG;
        public  StaticText ContinueConversionWithoutSupportingST;

        partial void OnInitialize();

        public SupportingContentUnavailableDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SupportingContentUnavailableCTL = new TitleBar()
            {
                Tag = "[TitleBar]Supporting Content Unavailable|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportingContentUnavailableCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Supporting Content Unavailable|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Supporting Content Unavailable|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Supporting Content Unavailable|$TitleBar|#1/[PushButton]Close|$Close|#1",
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
                Tag = "[Image]$WarningImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            SupportingContentForTheseST = new StaticText()
            {
                Tag = "[StaticText]$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportingContentForTheseST);

            SpecsAndCatalogsReferenceST = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecsAndCatalogsReferenceST);

            Image2IMG = new Image()
            {
                Tag = "[Image]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            SpecifyAutoCADPlant2011ST = new StaticText()
            {
                Tag = "[StaticText]Specify AutoCAD Plant 2011 content folder|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAutoCADPlant2011ST);

            Image3IMG = new Image()
            {
                Tag = "[Image]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            ContinueConversionWithoutSupportingST = new StaticText()
            {
                Tag = "[StaticText]Continue conversion without supporting content|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContinueConversionWithoutSupportingST);
        }
    }
}
