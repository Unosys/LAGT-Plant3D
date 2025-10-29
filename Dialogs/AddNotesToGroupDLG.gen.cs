// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Notes To Group|$AddNotesToGroupWindow", Parent = typeof(SpecEditorDLG))]
    public partial class AddNotesToGroupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ApplyPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  StaticText GroupName;
        public  TextField GroupNotes;

        partial void OnInitialize();

        public AddNotesToGroupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ApplyPB = new PushButton()
            {
                Tag = "[PushButton]$Apply",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]$Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            GroupName = new StaticText()
            {
                Tag = "[StaticText]$GroupName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupName);

            GroupNotes = new TextField()
            {
                Tag = "[TextField]$GroupNotes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupNotes);
        }
    }
}
