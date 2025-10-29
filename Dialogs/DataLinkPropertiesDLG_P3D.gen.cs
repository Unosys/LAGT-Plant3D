// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Data Link Properties|#1", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class DataLinkPropertiesDLG_P3D : DataLinkPropertiesDLG
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton NextPB;
        public  PushButton ClosePB;
        public  ComboBox oneSelectOrEnterCB;
        public  Window ProviderWIN;

        partial void OnInitialize();

        public DataLinkPropertiesDLG_P3D()
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

            NextPB = new PushButton()
            {
                Tag = "[PageList]$12320|#1/[Window]#1/[DialogBox]#1/[PushButton]$233|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Data Link Properties|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            oneSelectOrEnterCB = new ComboBox()
            {
                Tag = "[PageList]$12320|#1/[Window]Connection|#2/[DialogBox]Connection|#1/[ComboBox]$1023|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneSelectOrEnterCB);

            ProviderWIN = new Window()
            {
                Tag = "[PageList]$12320|#1/[Window]Provider|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProviderWIN);
        }
    }
}
