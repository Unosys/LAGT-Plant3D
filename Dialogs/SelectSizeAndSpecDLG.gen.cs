// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]SelectSizeAndSpecDLG", Parent = typeof(DataManagerDLG))]
    public partial class SelectSizeAndSpecDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton EditSizeMappings;
        public  ListBox Size;
        public  ListBox Spec;
        public  PushButton Cancel;
        public  PushButton Help;
        public  PushButton Select;
        public  StaticText SizeText;
        public  StaticText SpecText;
        public  StaticText TheSizeOrSpecPropertiesOf;
        public  CustomWin WarningIcon;

        partial void OnInitialize();

        public SelectSizeAndSpecDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            EditSizeMappings = new PushButton()
            {
                Tag = "[PushButton]Edit size mappings|$Btn_EditSizeMappings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditSizeMappings);

            Size = new ListBox()
            {
                Tag = "[ListBox]Size:|$m_listBoxSize",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size);

            Spec = new ListBox()
            {
                Tag = "[ListBox]Spec:|$m_listBoxSpec",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spec);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Btn_Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$Btn_Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Select = new PushButton()
            {
                Tag = "[PushButton]Select|$Btn_Select",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Select);

            SizeText = new StaticText()
            {
                Tag = "[StaticText]Size:|$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeText);

            SpecText = new StaticText()
            {
                Tag = "[StaticText]Spec:|$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecText);

            TheSizeOrSpecPropertiesOf = new StaticText()
            {
                Tag = "[StaticText]The Size or Spec properties of P&ID class Primary Line Segment ?-?-?-? does not match what is available in this project*|$m_labelInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSizeOrSpecPropertiesOf);

            WarningIcon = new CustomWin()
            {
                Tag = "[System.Windows.Forms.PictureBox]$WarningIcon",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WarningIcon);
        }
    }
}
