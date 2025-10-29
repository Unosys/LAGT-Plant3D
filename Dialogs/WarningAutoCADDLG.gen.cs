// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]*/AutoCAD")]
    public partial class WarningAutoCADDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  PushButton Cancel;
        public  CustomWin Icon1;
        public  StaticText SaveChangesToCDocuments;

        partial void OnInitialize();

        public WarningAutoCADDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]Yes|#1|$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]No|#2|$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|#3|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]#1|[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            SaveChangesToCDocuments = new StaticText()
            {
                Tag = "[StaticText]Save changes to ?C:\\Documents and Settings\\nsarch\\Application Data\\Autodesk\\AutoCAD PID 2010\\R18.0\\enu\\DefaultProject\\PID_DWG*|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveChangesToCDocuments);
        }
    }
}
