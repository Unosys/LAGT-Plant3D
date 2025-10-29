// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]#1", Parent = typeof(Pane))]
    public partial class ReportTaskDLG : Pane
    {
        public  CustomWin FRules;
        public  CustomWin SShetts;
        public  CustomWin FString;
        public  CustomWin WaterMark;
        public  CustomWin FRSheet;

        partial void OnInitialize();

        public ReportTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FRules = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FRules);

            SShetts = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SShetts);

            FString = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FString);

            WaterMark = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WaterMark);

            FRSheet = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FRSheet);
        }
    }
}
