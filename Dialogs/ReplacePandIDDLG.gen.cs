// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ReplaceTableDlg", Parent = typeof(Plant3D))]
    public partial class ReplacePandIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox ComboBox;
        public  ComboBox ComboBox2;
        public  ComboBox ComboBox3;
        public  CheckBox Equipment;
        public  GroupBox Group;
        public  GroupBox Group2;
        public  GroupBox Group3;
        public  PushButton M_btnCancel;
        public  PushButton M_btnContinue;
        public  PushButton M_btnHelp;
        public  StaticText M_helperLabel;
        public  GroupBox M_joinTablePanel;
        public  CheckBox PnPDataLinks;
        public  CheckBox PnPDrawings;

        partial void OnInitialize();

        public ReplacePandIDDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ComboBox = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox);

            ComboBox2 = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox2);

            ComboBox3 = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox3);

            Equipment = new CheckBox()
            {
                Tag = "[CheckBox]$Equipment",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Equipment);

            Group = new GroupBox()
            {
                Tag = "[GroupBox]$m_joinTablePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group);

            Group2 = new GroupBox()
            {
                Tag = "[GroupBox]$m_joinTablePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group2);

            Group3 = new GroupBox()
            {
                Tag = "[GroupBox]$m_joinTablePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group3);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnContinue = new PushButton()
            {
                Tag = "[PushButton]$m_btnContinue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnContinue);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_helperLabel = new StaticText()
            {
                Tag = "[StaticText]$m_helperLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_helperLabel);

            M_joinTablePanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_joinTablePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_joinTablePanel);

            PnPDataLinks = new CheckBox()
            {
                Tag = "[CheckBox]$PnPDataLinks",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPDataLinks);

            PnPDrawings = new CheckBox()
            {
                Tag = "[CheckBox]$PnPDrawings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPDrawings);
        }
    }
}
