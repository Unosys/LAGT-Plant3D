// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select P&ID Class", Parent = typeof(Plant3D))]
    public partial class SelectPIDClassDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin TableLayoutPanel1;
        public  CustomWin Panel1;
        public  TreeView ClassTreeView;
        public  CustomWin Panel2;
        public  PushButton Cancel;
        public  PushButton OK;

        partial void OnInitialize();

        public SelectPIDClassDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TableLayoutPanel1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.TableLayoutPanel]#1|[System.Windows.Forms.TableLayoutPanel]$tableLayoutPanel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel1);

            Panel1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            ClassTreeView = new TreeView()
            {
                Tag = "[TreeView]#1|$classTreeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassTreeView);

            Panel2 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]#2|[System.Windows.Forms.Panel]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
