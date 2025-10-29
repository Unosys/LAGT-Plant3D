// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Override Valve Operator|$CustomizeValveOperatorWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDOverrideValveOperatorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText OKST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton HelpPB;

        partial void OnInitialize();

        public PandIDOverrideValveOperatorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$OKButton|#1/[StaticText]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);
        }
    }
}
