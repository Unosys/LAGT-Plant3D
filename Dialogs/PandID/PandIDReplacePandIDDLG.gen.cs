// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ReplaceTableDlg")]
    public partial class PandIDReplacePandIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox ComboBox;
        public  ComboBox ComboBox2;
        public  ComboBox ComboBox3;
        public  ComboBox ComboBox4;
        public  ComboBox ComboBox5;
        public  CheckBox ControlValve;
        public  GroupBox Group;
        public  GroupBox Group2;
        public  GroupBox Group3;
        public  GroupBox Group4;
        public  GroupBox Group5;
        public  PushButton M_btnCancel;
        public  PushButton M_btnContinue;
        public  PushButton M_btnHelp;
        public  StaticText M_helperLabel;
        public  GroupBox M_joinTablePanel;
        public  CheckBox PipeLineGroup;
        public  CheckBox PipeLines;
        public  CheckBox PnPDataLinks;
        public  CheckBox PnPDrawings;

        partial void OnInitialize();

        public PandIDReplacePandIDDLG()
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

            ComboBox4 = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox4);

            ComboBox5 = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox5);

            ControlValve = new CheckBox()
            {
                Tag = "[CheckBox]$ControlValve",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ControlValve);

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

            Group4 = new GroupBox()
            {
                Tag = "[GroupBox]$m_joinTablePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group4);

            Group5 = new GroupBox()
            {
                Tag = "[GroupBox]$m_joinTablePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group5);

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

            PipeLineGroup = new CheckBox()
            {
                Tag = "[CheckBox]$PipeLineGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroup);

            PipeLines = new CheckBox()
            {
                Tag = "[CheckBox]$PipeLines",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLines);

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
