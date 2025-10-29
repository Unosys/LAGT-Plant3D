// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$PickListDlg", Parent = typeof(ProjectSetupPlant3DDWG))]
    public partial class P3DSelectionListPropertyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton AddRowPB;
        public  PushButton DeleteRowPB;
        public  PushButton OKPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public P3DSelectionListPropertyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddRowPB = new PushButton()
            {
                Tag = "[PushButton]Add Row*|$AddRowBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddRowPB);

            DeleteRowPB = new PushButton()
            {
                Tag = "[PushButton]Delete Row|$DeleteRowBtn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteRowPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKBtn|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
