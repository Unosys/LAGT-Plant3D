// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Property Editor|$PropertyEditor", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilityEditpartsManagePropertiesDLG : Window
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Window ManagePropertiesWIN;

        partial void OnInitialize();

        public SpecUtilityEditpartsManagePropertiesDLG()
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

            ManagePropertiesWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Manage Properties|$ManagePropsTab|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManagePropertiesWIN);
        }
    }
}
