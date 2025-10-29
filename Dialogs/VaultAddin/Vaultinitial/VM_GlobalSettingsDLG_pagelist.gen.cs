// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Global Settings|$AdminToolForm", Parent = typeof(VaultPro))]
    public partial class VM_GlobalSettingsDLG_pagelist : VM_GlobalSettingsDLG
    {
        public  PageList PageListPG;

        partial void OnInitialize();

        public VM_GlobalSettingsDLG_pagelist()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PageListPG = new PageList()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);
        }
    }
}
