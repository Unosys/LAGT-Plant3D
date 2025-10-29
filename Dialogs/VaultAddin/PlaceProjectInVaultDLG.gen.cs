// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Place Project in Vault", Parent = typeof(MainWin))]
    public partial class PlaceProjectInVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  CustomWin Icon1;
        public  StaticText OneOrMoreDrawingsOfTheCu;

        partial void OnInitialize();

        public PlaceProjectInVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]$20|[Icon]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            OneOrMoreDrawingsOfTheCu = new StaticText()
            {
                Tag = "[StaticText]$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreDrawingsOfTheCu);
        }
    }
}
