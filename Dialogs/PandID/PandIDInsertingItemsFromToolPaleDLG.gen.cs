// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Inserting items from tool palette |$DragandDropInfoDlg|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDInsertingItemsFromToolPaleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane PanePANE;
        public  StaticText oneInAPIDST;
        public  StaticText TheBestWayToST;
        public  Pane TheBestWayToPANE;
        public  CheckBox DontShowMeThisCK;
        public  PushButton Close1PB;
        public  TitleBar InsertingItemsFromToolCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public PandIDInsertingItemsFromToolPaleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            oneInAPIDST = new StaticText()
            {
                Tag = "[Pane]$panel1|#1/[StaticText]1*|$labelItem|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneInAPIDST);

            TheBestWayToST = new StaticText()
            {
                Tag = "[Pane]$panel1|#1/[StaticText]The best way to get a component or line from the tool palette to the drawing is to click the tool on the tool palette, and then click to place it in the drawing*|$labelInfo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheBestWayToST);

            TheBestWayToPANE = new Pane()
            {
                Tag = "[Pane]$panel1|#1/[Pane]The best way to get a component or line from the tool palette to the drawing is to click the tool on the tool palette, and then click to place it in the drawing*|$pictureBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheBestWayToPANE);

            DontShowMeThisCK = new CheckBox()
            {
                Tag = "[CheckBox]Don't show me this again|$checkBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DontShowMeThisCK);

            Close1PB = new PushButton()
            {
                Tag = "[PushButton]Close|$closeButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            InsertingItemsFromToolCTL = new TitleBar()
            {
                Tag = "[TitleBar]Inserting items from tool palette |$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsertingItemsFromToolCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Inserting items from tool palette |$TitleBar|#1/[CustomWin]System Menu Bar|$DragandDropInfoDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Inserting items from tool palette |$TitleBar|#1/[CustomWin]System Menu Bar|$DragandDropInfoDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Inserting items from tool palette |$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
