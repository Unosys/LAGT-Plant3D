// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$Select3DPipingClassDlg", Parent = typeof(Plant3D))]
    public partial class Select3DClassDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Btn_Cancel;
        public  PushButton Btn_Help;
        public  PushButton Btn_Select;
        public  StaticText Label1;
        public  ComboBox M_cmbClassNames;
        public  StaticText M_labelInfo;

        partial void OnInitialize();

        public Select3DClassDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Btn_Cancel = new PushButton()
            {
                Tag = "[PushButton]$Btn_Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Cancel);

            Btn_Help = new PushButton()
            {
                Tag = "[PushButton]$Btn_Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Help);

            Btn_Select = new PushButton()
            {
                Tag = "[PushButton]$Btn_Select",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Select);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            M_cmbClassNames = new ComboBox()
            {
                Tag = "[ComboBox]$m_cmbClassNames",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cmbClassNames);

            M_labelInfo = new StaticText()
            {
                Tag = "[StaticText]$m_labelInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelInfo);
        }
    }
}
