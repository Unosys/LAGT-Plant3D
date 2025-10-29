// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$NozzleDialog_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class NozzleDialog : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close1PB;
        public  StaticText ChangeTypeST;
        public  StaticText ChangeLocationST;
        public  ComboBox NozzleLocationCB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public NozzleDialog()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close1PB = new PushButton()
            {
                Tag = "[PushButton]Close|$Button_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            ChangeTypeST = new StaticText()
            {
                Tag = "[PageList]$tabControl1|#1/[Window]Change Type|$tabItem1|#1/[StaticText]Change Type|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeTypeST);

            ChangeLocationST = new StaticText()
            {
                Tag = "[PageList]$tabControl1|#1/[Window]Change Location|$tabItem2|#2/[StaticText]Change Location|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeLocationST);

            NozzleLocationCB = new ComboBox()
            {
                Tag = "[PageList]$tabControl1|#1/[Window]Change Location|$tabItem2|#2/[ComboBox]Nozzle Location:|$ComboBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzleLocationCB);

            ClosePB = new PushButton()
            {
                Tag = "[PushButton]Close|$m_btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
