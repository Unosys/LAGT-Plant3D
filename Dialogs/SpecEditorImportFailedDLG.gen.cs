// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Import Failed|#1", Parent = typeof(SpecEditorDLG), GUIType = GuiType.UIA)]
    public partial class SpecEditorImportFailedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  Image ImageIMG;
        public  StaticText TheExcelFileIsST;
        public  TitleBar ImportFailedCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SpecEditorImportFailedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            TheExcelFileIsST = new StaticText()
            {
                Tag = "[StaticText]The Excel File is not an exported Spec Data File*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheExcelFileIsST);

            ImportFailedCTL = new TitleBar()
            {
                Tag = "[TitleBar]Import Failed|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportFailedCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Import Failed|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
