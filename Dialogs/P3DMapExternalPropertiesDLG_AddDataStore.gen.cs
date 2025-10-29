// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Map External Properties|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class P3DMapExternalPropertiesDLG_AddDataStore : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton AddDataSourcePB;
        public  PushButton MapPropertiesPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public P3DMapExternalPropertiesDLG_AddDataStore()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            AddDataSourcePB = new PushButton()
            {
                Tag = "[ListView]$DataReferenceDataGrid|#1/[ListViewItem]#2/[CustomWin]#2/[PushButton]$AddDataSourceBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddDataSourcePB);

            MapPropertiesPB = new PushButton()
            {
                Tag = "[PushButton]$MapPropertiesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapPropertiesPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
