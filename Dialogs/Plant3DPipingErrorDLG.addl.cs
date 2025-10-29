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
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class Plant3DPipingErrorDLG : Pane
    {
		public string FeatureType = "Dialog";
		public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
		partial void OnInitialize()
		{
			Tag = "$AcPp3dErrorDlg";
		}

		public void Invoke()
		{
            ProjManUndocked ProjManUndocked = new ProjManUndocked();
            ProjManUndocked.Invoke();
			//FunctionsP3D FunctionsP3D = new FunctionsP3D();
			Plant3DFunctions.CreateDrawing("P3D");
			Drawing.Current.TypeE("_DYNMODE");
			Drawing.Current.TypeE("-3");
			Drawing.Current.TypeE("_PLANTROUTEBEND");
			Drawing.Current.TypeE("_ON");
            ///////////////////
            //Drawing.Current.TypeE("_PLANTDYNAMICTOOLPALETTE");
            //Drawing.Current.TypeE("_E");
            Drawing.Current.TypeE("_PLANTPIPEADD");
			Drawing.Current.TypeE("_Size");
			Drawing.Current.TypeE("10\"");
			Drawing.Current.TypeE("50,50");
			Drawing.Current.TypeE("100,50");
			Drawing.Current.TypeE("100,100");
			Drawing.Current.TypeE("");
			Drawing.Current.TypeE("_Zoom");
			Drawing.Current.TypeE("_All");
			Drawing.Current.TypeE("_PLANTEDITBEND");
			Drawing.Current.TypeE("0,0");
			Drawing.Current.TypeE("200,200");
			Drawing.Current.TypeE("_Angle");
			Drawing.Current.TypeE("80");
			Drawing.Current.TypeE("");
			Plant3DPipingErrorDLG Plant3DPipingErrorDLG = new Plant3DPipingErrorDLG();
			Plant3DPipingErrorDLG.SetActive();
		}

		public void Dismiss()
		{
			Plant3DPipingErrorDLG Plant3DPipingErrorDLG = new Plant3DPipingErrorDLG();
			if (Plant3DPipingErrorDLG.Exists)
			{
                Plant3DPipingErrorDLG.BtnClose.Click();
			}
            //FunctionsP3D FunctionsP3D = new FunctionsP3D();
			Plant3DFunctions.DeleteDrawing("P3D");
		//	Drawing.Current.TypeE("_Close");
		}
    }
}
