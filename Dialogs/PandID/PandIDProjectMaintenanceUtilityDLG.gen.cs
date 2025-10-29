// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$ProjectMaintenanceDlg", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class PandIDProjectMaintenanceUtilityDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CloseBtn;
        public  GroupBox UtilityDetailsGB;
        public  RadioButton CopyRBtn;
        public  RadioButton MoveRBtn;
        public  RadioButton ConvertRBtn;
        public  GroupBox GroupBox1;
        public  GroupBox GroupBox2;
        public  StaticText Label1;
        public  StaticText Label2;
        public  StaticText Label3;
        public  StaticText Label4;
        public  PushButton NextBtn;
        public  CustomWin UtilityDetailsCtrl;

        partial void OnInitialize();

        public PandIDProjectMaintenanceUtilityDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CloseBtn = new PushButton()
            {
                Tag = "[PushButton]$CloseBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseBtn);

            UtilityDetailsGB = new GroupBox()
            {
                Tag = "[Pane]$UtilityDetailsCtrl|#1/[GroupBox]$groupBox1|#1/[GroupBox]Utility details|$groupBox2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UtilityDetailsGB);

            CopyRBtn = new RadioButton()
            {
                Tag = "[Pane]$UtilityDetailsCtrl|#1/[GroupBox]$groupBox1|#1/[GroupBox]Utility details|$groupBox2|#1/[RadioButton]Close AutoCAD PID or AutoCAD Plant 3D and select one of the options below: [1]|$CopyRBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyRBtn);

            MoveRBtn = new RadioButton()
            {
                Tag = "[Pane]$UtilityDetailsCtrl|#1/[GroupBox]$groupBox1|#1/[GroupBox]Utility details|$groupBox2|#1/[RadioButton]Close AutoCAD PID or AutoCAD Plant 3D and select one of the options below: [2]|$MoveRBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveRBtn);

            ConvertRBtn = new RadioButton()
            {
                Tag = "[Pane]$UtilityDetailsCtrl|#1/[GroupBox]$groupBox1|#1/[GroupBox]Utility details|$groupBox2|#1/[RadioButton]Close AutoCAD PID or AutoCAD Plant 3D and select one of the options below: [3]|$ConvertRBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertRBtn);

            GroupBox1 = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1);

            GroupBox2 = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox2);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            Label3 = new StaticText()
            {
                Tag = "[StaticText]$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label3);

            Label4 = new StaticText()
            {
                Tag = "[StaticText]$label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label4);

            NextBtn = new PushButton()
            {
                Tag = "[Pane]$UtilityDetailsCtrl|#1/[PushButton]Next >>|$NextBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextBtn);

            UtilityDetailsCtrl = new CustomWin()
            {
                Tag = "[CustomWin]$UtilityDetailsCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UtilityDetailsCtrl);
        }
    }
}
