// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Batch Assign Long Description Styles|$LongDescriptionBatchWindow")]
    public partial class BatchAssignLongDescriptionStylesDLG : Window
    {
        public  PushButton Cancel2PB;
        public  PushButton AddPB;
        public  ComboBox FileNameCB;
        public  PushButton OpenPB;
        public  PopupList LongDescriptionfamilyStylePL;
        public  PushButton OKPB;
        public  PopupList LongDescriptionsizeStylePL;

        partial void OnInitialize();

        public BatchAssignLongDescriptionStylesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel2PB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel2PB);

            AddPB = new PushButton()
            {
                Tag = "[GroupBox]Select spec files|$SelectSpecFilesGroupBox|#2/[PushButton]Add|$AddButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            FileNameCB = new ComboBox()
            {
                Tag = "[DialogBox]Open|#1/[ComboBox]FiLongDescriptionfamilyStylePLle name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            OpenPB = new PushButton()
            {
                Tag = "[DialogBox]Open|#1/[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            LongDescriptionfamilyStylePL = new PopupList()
            {
                Tag = "[GroupBox]Select long description styles|$SelectLDStylesGroupBox|#1/[PopupList]Long description (family) style:|$LDFamilyComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionfamilyStylePL);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            LongDescriptionsizeStylePL = new PopupList()
            {
                Tag = "[GroupBox]Select long description styles|$SelectLDStylesGroupBox|#1/[PopupList]Long description (size) style:|$LDSizeComboBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionsizeStylePL);
        }
    }
}
