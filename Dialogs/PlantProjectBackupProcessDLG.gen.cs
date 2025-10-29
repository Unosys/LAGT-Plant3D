// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant Project Backup|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PlantProjectBackupProcessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PlantProjectBackupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWin1WIN;
        public  Image ImageIMG;
        public  StaticText CreatingProjectBackupCopyST;
        public  StaticText Copying1Of227ST;
        public  CustomWin CustomWin2WIN;
        public  PushButton PushButtonPB;
        public  StaticText OpenBackupFolderST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public PlantProjectBackupProcessDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PlantProjectBackupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Plant Project Backup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlantProjectBackupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Plant Project Backup|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Plant Project Backup|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant Project Backup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            ImageIMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            CreatingProjectBackupCopyST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Creating project backup copy*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatingProjectBackupCopyST);

            Copying1Of227ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]copying 1 of 227 model files*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Copying1Of227ST);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$ProgressBar_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            PushButtonPB = new PushButton()
            {
                Tag = "[PushButton]$Button_10|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            OpenBackupFolderST = new StaticText()
            {
                Tag = "[PushButton]$Button_10|#2/[StaticText]open backup folder|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenBackupFolderST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$Button_1|#1/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);
        }
    }
}
