// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Iso Style Editor|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class IsoStyleEditorSaveDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar IsoStyleEditorCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  Image Image1IMG;
        public  StaticText YouHaveUnsavedChangesST;
        public  StaticText WhatDoYouWantST;
        public  Image Image2IMG;
        public  StaticText SaveMyChangesST;
        public  Image Image3IMG;
        public  StaticText DoNotSaveMyST;

        partial void OnInitialize();

        public IsoStyleEditorSaveDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            IsoStyleEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Iso Style Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleEditorCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Iso Style Editor|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Iso Style Editor|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Iso Style Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
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

            YouHaveUnsavedChangesST = new StaticText()
            {
                Tag = "[StaticText]You have unsaved changes in this document*|$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouHaveUnsavedChangesST);

            WhatDoYouWantST = new StaticText()
            {
                Tag = "[StaticText]What do you want to do?|$MessageTexBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatDoYouWantST);

            Image2IMG = new Image()
            {
                Tag = "[Image]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            SaveMyChangesST = new StaticText()
            {
                Tag = "[StaticText]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveMyChangesST);

            Image3IMG = new Image()
            {
                Tag = "[Image]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            DoNotSaveMyST = new StaticText()
            {
                Tag = "[StaticText]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotSaveMyST);
        }
    }
}
