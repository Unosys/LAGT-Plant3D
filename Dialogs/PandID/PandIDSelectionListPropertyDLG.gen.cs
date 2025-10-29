// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Selection List Property|$PickListDlg")]
    public partial class PandIDSelectionListPropertyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton AddRowPB;
        public  PushButton DeleteRowPB;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton AddListPB;
        public  PushButton RemoveListPB;
        public  PushButton ExportPB;
        public  PushButton ImportPB;
        public  ListBox NameLB;

        partial void OnInitialize();

        public PandIDSelectionListPropertyDLG()
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

            AddListPB = new PushButton()
            {
                Tag = "[PushButton]Add List*|$AddListBtn|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddListPB);

            RemoveListPB = new PushButton()
            {
                Tag = "[PushButton]Remove List*|$RemoveListBtn|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveListPB);

            ExportPB = new PushButton()
            {
                Tag = "[PushButton]$ExportBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPB);

            ImportPB = new PushButton()
            {
                Tag = "[PushButton]$ImportBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportPB);

            NameLB = new ListBox()
            {
                Tag = "[ListBox]Name:|$PickListListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameLB);
        }
    }
}
