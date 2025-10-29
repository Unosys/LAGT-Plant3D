// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]NewStatusDLG", Parent = typeof(Pane))]
    public partial class PandIDNewStatusDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  StaticText LblName;
        public  TextField TbName;

        partial void OnInitialize();

        public PandIDNewStatusDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            LblName = new StaticText()
            {
                Tag = "[StaticText]$lblName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblName);

            TbName = new TextField()
            {
                Tag = "[TextField]$tbName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbName);
        }
    }
}
