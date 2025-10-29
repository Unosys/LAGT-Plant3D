// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Actuator Browser|$ClassBrowserDlg")]
    public partial class PandIDActuatorBrowserDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  TreeView TreeViewTV;
        public  TreeViewItem BackPressureRegulatorTVI;
        public  Image Image1IMG;
        public  StaticText BackPressureRegulatorST;
        public  TreeViewItem BackPressureRegulatorWithTVI;

        partial void OnInitialize();

        public PandIDActuatorBrowserDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            TreeViewTV = new TreeView()
            {
                Tag = "[TreeView]$ClassTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            BackPressureRegulatorTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$ClassTreeView|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPressureRegulatorTVI);

            Image1IMG = new Image()
            {
                Tag = "[TreeView]$ClassTreeView|#1/[TreeViewItem]#1/[Image]$NodeImg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            BackPressureRegulatorST = new StaticText()
            {
                Tag = "[TreeView]$ClassTreeView|#1/[TreeViewItem]#1/[StaticText]$NodeText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPressureRegulatorST);

            BackPressureRegulatorWithTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$ClassTreeView|#1/[TreeViewItem]Back Pressure Regulator With External Tap|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPressureRegulatorWithTVI);
        }
    }
}
