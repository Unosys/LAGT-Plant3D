// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Editor - Long Description Style Deletion|$TaskDialog_Enhanced", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecEditorLongDescriptionStyleDeletionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar SpecEditorLongCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  Image Image1IMG;
        public  StaticText DoYouWantToST;
        public  StaticText StaticTextST;
        public  Image Image2IMG;
        public  StaticText DeleteLongDescriptionStyleST;
        public  Image Image3IMG;
        public  StaticText DoNotDeleteLongST;

        partial void OnInitialize();

        public SpecEditorLongDescriptionStyleDeletionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SpecEditorLongCTL = new TitleBar()
            {
                Tag = "[TitleBar]Spec Editor - Long Description Style Deletion|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecEditorLongCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Spec Editor - Long Description Style Deletion|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Spec Editor - Long Description Style Deletion|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Spec Editor - Long Description Style Deletion|$TitleBar|#1/[PushButton]Close|$Close|#1",
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

            DoYouWantToST = new StaticText()
            {
                Tag = "[StaticText]Do you want to delete long description style Dummy?|$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoYouWantToST);

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

            DeleteLongDescriptionStyleST = new StaticText()
            {
                Tag = "[StaticText]Delete long description style Dummy|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteLongDescriptionStyleST);

            Image3IMG = new Image()
            {
                Tag = "[Image]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            DoNotDeleteLongST = new StaticText()
            {
                Tag = "[StaticText]Do not delete long description style Dummy|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotDeleteLongST);
        }
    }
}
