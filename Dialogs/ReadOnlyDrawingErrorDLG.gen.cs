// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Read-only DWG Error|$frmReadonlyDwgError", Parent = typeof(ProjManUndocked), GUIType = GuiType.UIA)]
    public partial class ReadOnlyDrawingErrorDLG : Pane
    {
        public  StaticText OneOrMoreOfST;
        public  PushButton BtnMoreInfo;
        public  PushButton BtnOK;
        public  TitleBar ReadonlyDWGErrorCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReadOnlyDrawingErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OneOrMoreOfST = new StaticText()
            {
                Tag = "[StaticText]One or more of the drawing files you are attempting to remove from this project are read-only*|$lblWarning|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreOfST);

            BtnMoreInfo = new PushButton()
            {
                Tag = "[PushButton]More Info|$btnMoreInfo|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnMoreInfo);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            ReadonlyDWGErrorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Read-only DWG Error|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadonlyDWGErrorCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Read-only DWG Error|$TitleBar|#1/[CustomWin]System Menu Bar|$frmReadonlyDwgError|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Read-only DWG Error|$TitleBar|#1/[CustomWin]System Menu Bar|$frmReadonlyDwgError|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Read-only DWG Error|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
