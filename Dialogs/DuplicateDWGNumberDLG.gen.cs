// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Duplicate DWG Number", Parent = typeof(NewDWGDLG))]
    public partial class DuplicateDWGNumberDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  CustomWin Icon1;
        public  StaticText N01IsAlreadyAllocatedToA;

        partial void OnInitialize();

        public DuplicateDWGNumberDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|@(165,78)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]No|$7|@(246,78)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]$20|[Icon]@(27,27)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            N01IsAlreadyAllocatedToA = new StaticText()
            {
                Tag = "[StaticText]<01> is already allocated to another drawing in the current project.??It is recommended that you assign unique numbers to proj*|$65535|@(234,31)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(N01IsAlreadyAllocatedToA);
        }
    }
}
