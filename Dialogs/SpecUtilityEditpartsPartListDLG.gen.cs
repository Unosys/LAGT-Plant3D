// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Property Editor|$PropertyEditor")]
    public partial class SpecUtilityEditpartsPartListDLG : Window
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Window PartListWIN;
        public  Window ManageSizesWIN;
        public  Window ManagePropertiesWIN;
        public  PopupList DisplayPL;

        partial void OnInitialize();

        public SpecUtilityEditpartsPartListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel_Button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OK_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            PartListWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Part List|$PartListTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartListWIN);

            ManageSizesWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Sizes|$ManageSizesTab|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageSizesWIN);

            ManagePropertiesWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Properties|$ManagePropsTab|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManagePropertiesWIN);

            DisplayPL = new PopupList()
            {
                Tag = "[CustomWin]$UserControl_EditPartsList|#1/[PopupList]Display:|$PropertyTypeCombo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayPL);
        }
    }
}
