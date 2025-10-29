// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Bolt Length Mapping|$StandardBoltLengthEditMappingDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class BoltLengthMappingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton AddBoltStandardPB;
        public  StaticText AddBoltStandardST;
        public  PushButton RemoveBoltStandardPB;

        partial void OnInitialize();

        public BoltLengthMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddBoltStandardPB = new PushButton()
            {
                Tag = "[PushButton]$btAddBoltStandard",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddBoltStandardPB);

            AddBoltStandardST = new StaticText()
            {
                Tag = "[PushButton]$btAddBoltStandard|#1/[StaticText]_Add Bolt Standard*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddBoltStandardST);

            RemoveBoltStandardPB = new PushButton()
            {
                Tag = "[PushButton]$btRemBoltStandard",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveBoltStandardPB);
        }
    }
}
