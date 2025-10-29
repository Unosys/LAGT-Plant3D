// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Edit Block Definition", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class EditBlockDefinitionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  ListBox BlockToCreateOrLB;

        partial void OnInitialize();

        public EditBlockDefinitionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            BlockToCreateOrLB = new ListBox()
            {
                Tag = "[ListBox]Block to create or edit|$1003|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlockToCreateOrLB);
        }
    }
}
