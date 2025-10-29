// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Options")]
    public partial class P3DOptionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton ApplyPB;
        public  PageList Tab1PG;
        public  PushButton HiddenMessagesSettingsPB;

        partial void OnInitialize();

        public P3DOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ApplyPB = new PushButton()
            {
                Tag = "[PushButton]Apply|$1410",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            Tab1PG = new PageList()
            {
                Tag = "[PageList]Tab1|$1796|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tab1PG);

            HiddenMessagesSettingsPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Hidden Messages Settings|$1840",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HiddenMessagesSettingsPB);
        }
    }
}
