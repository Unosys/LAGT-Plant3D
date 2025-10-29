// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$AddListCategoryDlg")]
    public partial class PandIDAddSelectionListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TextField NewSelectionListNameTF;
        public  CheckBox CreateSharedSelectionListCK;
        public  PushButton OKPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public PandIDAddSelectionListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NewSelectionListNameTF = new TextField()
            {
                Tag = "[TextField]New selection list name:|$NameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSelectionListNameTF);

            CreateSharedSelectionListCK = new CheckBox()
            {
                Tag = "[CheckBox]Create shared selection list|$ShareCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateSharedSelectionListCK);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$OKBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$CancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
