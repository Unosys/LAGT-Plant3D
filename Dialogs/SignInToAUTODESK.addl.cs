// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
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
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class SignInToAUTODESK : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// <summary>
        partial void OnInitialize()
        {
            Tag = "[Window]" + "Sign in";
            // Tag = AcMainWin.cBabel(533, 8, "Sign In");
        }
        public override void Invoke()
        {
            Drawing.Current.SetActive();
            Drawing.Current.TypeE("_OnlineSyncSettings");
            ChooseWhichSettingsAreSyncedDLG ChooseWhichSettingsAreSyncedDLG = new ChooseWhichSettingsAreSyncedDLG();
            if (ChooseWhichSettingsAreSyncedDLG.Exists)
            {
                ChooseWhichSettingsAreSyncedDLG.Cancel.Click();
                System.Threading.Thread.Sleep(2);
                AdResultLog.Current.Log("already Signned in");
            }
            else
            {
                System.Threading.Thread.Sleep(15000);
                SignInToAUTODESK SignInToAUTODESK = Current<SignInToAUTODESK>();
                SignInToAUTODESK.SetActive();
            }
        }
        public override void Dismiss()
        {
            ChooseWhichSettingsAreSyncedDLG ChooseWhichSettingsAreSyncedDLG = new ChooseWhichSettingsAreSyncedDLG();
            if (ChooseWhichSettingsAreSyncedDLG.Exists)
            {
                ChooseWhichSettingsAreSyncedDLG.Cancel.Click();

            }
            SignInToAUTODESK SignInToAUTODESK = Current<SignInToAUTODESK>();
            SignInToAUTODESK.SetActive();
            SignInToAUTODESK.Close();
        }
        public void SignInWithAccount()
        {
            Drawing.Current.SetActive();
            Drawing.Current.TypeE("_OnlineSyncSettings");
            ChooseWhichSettingsAreSyncedDLG ChooseWhichSettingsAreSyncedDLG = new ChooseWhichSettingsAreSyncedDLG();
            if (ChooseWhichSettingsAreSyncedDLG.Exists)
            {
                ChooseWhichSettingsAreSyncedDLG.Cancel.Click();
                AdResultLog.Current.Log("already Signned in");
            }
            else
            {
                SignInToAUTODESK SignInToAUTODESK = new SignInToAUTODESK();
                if (SignInToAUTODESK.WaitExists(20000))
                {
                    SignInToAUTODESK.TypeKeys("p3d2017ext1@yopmail.com");
                    SignInToAUTODESK.TypeKeys("<Enter>");
                    System.Threading.Thread.Sleep(3000);
                    SignInToAUTODESK.TypeKeys("P@ssword-1");
                    SignInToAUTODESK.TypeKeys("<Enter>");
                }
                if (ChooseWhichSettingsAreSyncedDLG.WaitExists(30000))
                {
                    ChooseWhichSettingsAreSyncedDLG.Cancel.Click();

                }
            }


        }
    }
}