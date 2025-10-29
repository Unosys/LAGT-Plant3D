// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Data Link Properties", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class DataLinkPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  Window ProviderWIN;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DataLinkPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ProviderWIN = new Window()
            {
                Tag = "[PageList]$12320|#1/[Window]Provider|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProviderWIN);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Data Link Properties|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
