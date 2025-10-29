// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Valve Operator Mapping|$ValveOperatorMappingWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ValveOperatorMappingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton ApplyPB;
        public  PushButton RemovePB;
        public  PushButton AddPB;

        partial void OnInitialize();

        public ValveOperatorMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OK|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ApplyPB = new PushButton()
            {
                Tag = "[PushButton]Apply|$Apply|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            RemovePB = new PushButton()
            {
                Tag = "[PushButton]Remove|$RemoveButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]Add|$AddButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);
        }
    }
}
