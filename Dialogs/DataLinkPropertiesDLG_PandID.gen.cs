// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Data Link Properties|#1", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class DataLinkPropertiesDLG_PandID : DataLinkPropertiesDLG
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  ListView SelectTheDataYouLV;
        public  Window ProviderWIN;
        public  ComboBox oneSelectOrEnterCB;
        public  PushButton NextPB;

        partial void OnInitialize();

        public DataLinkPropertiesDLG_PandID()
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

            SelectTheDataYouLV = new ListView()
            {
                Tag = "[PageList]$12320|#1/[Window]#1/[DialogBox]#1/[ListView]$1000|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheDataYouLV);

            ProviderWIN = new Window()
            {
                Tag = "[PageList]$12320|#1/[Window]Provider|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProviderWIN);

            oneSelectOrEnterCB = new ComboBox()
            {
                Tag = "[PageList]$12320|#1/[Window]Connection|#2/[DialogBox]Connection|#1/[ComboBox]$1023|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneSelectOrEnterCB);

            NextPB = new PushButton()
            {
                Tag = "[PageList]$12320|#1/[Window]#1/[DialogBox]#1/[PushButton]$233|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);
        }
    }
}
