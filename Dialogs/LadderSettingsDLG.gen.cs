// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Ladder Settings", Parent = typeof(Plant3D))]
    public partial class LadderSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Help;
        public  PageList PageList;

        partial void OnInitialize();

        public LadderSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Help = new PushButton()
            {
                Tag = "[PushButton]$3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            PageList = new PageList()
            {
                Tag = "[PageList]$2533",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageList);
        }
    }
}
