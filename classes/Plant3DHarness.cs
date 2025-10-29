using Autodesk.GUIHarness.AutoCAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.GUIHarness.Plant3D;

namespace Autodesk.GUIHarness.Plant3D
{
    public class Plant3DHarness : AcadHarness
    {
        public override void InitializeAppWnd()
        {
            AppWnd = new Dialogs.Plant3D();
        }
    }
}
