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
using LAGT.CommonFiles;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class VaultProServer : MainWin
    {
        public new const string Name = "Autodesk Data Management Server Console*";
        public static readonly string Path = Product.Variables.ProductLocation;


        public override void Invoke()
        {
            this.SetActive();
        }

        //public override void Dismiss()
        //{
        //}
    }
}
