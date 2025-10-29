// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Iso Style Edito*|$Window_1", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class IsoStyleEditorSave : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  DialogBox IsoStyleEditorDLG;
        public  PushButton OKPB;
        public  Image Image1IMG;
        public  StaticText ChangesSavedSuccessfullyST;
        public  TitleBar IsoStyleEditor1CTL;
        public  PushButton Close1PB;
        public  TitleBar IsoStyleEditor2CTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public IsoStyleEditorSave()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            IsoStyleEditorDLG = new DialogBox()
            {
                Tag = "[DialogBox]Iso Style Editor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleEditorDLG);

            OKPB = new PushButton()
            {
                Tag = "[DialogBox]Iso Style Editor|#1/[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            Image1IMG = new Image()
            {
                Tag = "[DialogBox]Iso Style Editor|#1/[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            ChangesSavedSuccessfullyST = new StaticText()
            {
                Tag = "[DialogBox]Iso Style Editor|#1/[StaticText]Changes saved successfully*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangesSavedSuccessfullyST);

            IsoStyleEditor1CTL = new TitleBar()
            {
                Tag = "[DialogBox]Iso Style Editor|#1/[TitleBar]Iso Style Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleEditor1CTL);

            Close1PB = new PushButton()
            {
                Tag = "[DialogBox]Iso Style Editor|#1/[TitleBar]Iso Style Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            IsoStyleEditor2CTL = new TitleBar()
            {
                Tag = "[TitleBar]Iso Style Editor - C:*|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleEditor2CTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Iso Style Editor - C:*|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Iso Style Editor - C:*|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Iso Style Editor - C:*|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Iso Style Editor - C:*|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Iso Style Editor - C:*|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
