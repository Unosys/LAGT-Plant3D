// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Convert to P&ID Object", Parent = typeof(Plant3D))]
    public partial class ConvertToPIDObjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  StaticText Classes;
        public  TreeView TreeView;

        partial void OnInitialize();

        public ConvertToPIDObjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$btnHelp|@(249,382)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|@(166,382)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOk|@(83,382)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Classes = new StaticText()
            {
                Tag = "[StaticText]Classes|$groupBox|@(148,178)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes);

            TreeView = new TreeView()
            {
                Tag = "[TreeView]$treeView|@(142,183)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeView);
        }
    }
}
