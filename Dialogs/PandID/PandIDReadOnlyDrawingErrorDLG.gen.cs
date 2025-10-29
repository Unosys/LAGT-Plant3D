// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmReadonlyDwgError", Parent = typeof(PROJECTMANAGERDLG))]
    public partial class PandIDReadOnlyDrawingErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText OneOrMoreOfTheDrawingFil;
        public  PushButton MoreInfo;
        public  PushButton OK;

        partial void OnInitialize();

        public PandIDReadOnlyDrawingErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OneOrMoreOfTheDrawingFil = new StaticText()
            {
                Tag = "$lblWarning",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreOfTheDrawingFil);

            MoreInfo = new PushButton()
            {
                Tag = "$btnMoreInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoreInfo);

            OK = new PushButton()
            {
                Tag = "$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
