// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using LAGT.CommonFiles;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public class AutoCADMenuItem : MenuItem
    {
        public string ShortCutKeys { get; set; }

        public override void Pick()
        {
            Dashboard dashboard = new Dashboard();
            CmdWnd cmdWnd = new CmdWnd();
            if (cmdWnd.Exists)
            {
                cmdWnd.TypeKeys(ShortCutKeys);
            }
            else if (dashboard.Exists)
            {
                dashboard.TypeKeys(ShortCutKeys);
            }
            else
            {
                Harness.Current.AppWnd.TypeKeys(ShortCutKeys);
            }

        }
    }

    public partial class Plant3D : Plant3DMainWin
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[MainWin]Autodesk AutoCAD Plant 3D*";
        }
        public new const string Name = "Plant3D";
        public static readonly string Path = Product.Variables.ProductLocation;
    }
}
