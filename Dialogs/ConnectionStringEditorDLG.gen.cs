// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$OLAPConnectionEditorForm", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ConnectionStringEditorDLG : Pane
    {
        public  CustomWin BtnCancel;
        public  CustomWin BtnOK;
        public  CustomWin CeAdvanced;
        public  CustomWin PropertyGrid;
        public  CustomWin PropertyGridView;

        partial void OnInitialize();

        public ConnectionStringEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new CustomWin()
            {
                Tag = "[CustomWin]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnOK = new CustomWin()
            {
                Tag = "[CustomWin]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            CeAdvanced = new CustomWin()
            {
                Tag = "[CustomWin]$ceAdvanced",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CeAdvanced);

            PropertyGrid = new CustomWin()
            {
                Tag = "[CustomWin]$propertyGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGrid);

            PropertyGridView = new CustomWin()
            {
                Tag = "[CustomWin]$propertyGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGridView);
        }
    }
}
