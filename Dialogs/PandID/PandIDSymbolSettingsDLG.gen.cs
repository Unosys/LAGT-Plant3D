// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Symbol Settings", Parent = typeof(Pane))]
    public partial class PandIDSymbolSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin ATL5C42D9901;
        public  ListBox ListBox1;
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton Help;

        partial void OnInitialize();

        public PandIDSymbolSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ATL5C42D9901 = new CustomWin()
            {
                Tag = "[CustomWin][ATL:5C42D990]#1|[ATL:5C42D990]$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ATL5C42D9901);

            ListBox1 = new ListBox()
            {
                Tag = "[ListBox]#1|$239",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox1);

            OK = new PushButton()
            {
                Tag = "[PushButton]#1|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]#2|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]#3|$9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
