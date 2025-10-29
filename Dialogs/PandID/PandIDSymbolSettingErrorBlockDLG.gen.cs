// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(SymbolSettingsDLG))]
    public partial class PandIDSymbolSettingErrorBlockDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText PleaseSpecifyTheBlockText;

        partial void OnInitialize();

        public PandIDSymbolSettingErrorBlockDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]#1|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            PleaseSpecifyTheBlockText = new StaticText()
            {
                Tag = "[StaticText]#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseSpecifyTheBlockText);
        }
    }
}
