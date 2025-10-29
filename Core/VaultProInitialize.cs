using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using LAGT.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D
{
    public class VaultProInitialize
    {
        public static void Launch_VaultSrv()
        {
            //string sCmdLine = LAGT.CommonFiles.Product.Variables.ProductLocation.Replace("Vault Client", "Vault Server").Replace("Explorer", "ADMS Console") +
            //    "Connectivity.ADMSConsole.exe";
            string sCmdLine = "C:\\Program Files\\Autodesk\\Vault Server " + Product.Variables.ReleaseYear + "\\ADMS Console\\Connectivity.ADMSConsole.exe ";
            System.Diagnostics.Process.Start(sCmdLine);
            System.Threading.Thread.Sleep(8000);
        }

        public static void Launch_Vault()
        {
            //string sCmdLine = LAGT.CommonFiles.Product.Variables.ProductLocation + LAGT.CommonFiles.Product.Variables.EXEName;
            string sCmdLine = "C:\\Program Files\\Autodesk\\Vault Client " + Product.Variables.ReleaseYear + "\\Explorer\\Connectivity.VaultPro.exe ";
            System.Diagnostics.Process.Start(sCmdLine);
            System.Threading.Thread.Sleep(8000);


        }

        public static void CreatedVault()
        {
            if (!Directory.Exists(VaultProFunctions.getVaultServerDataFolder() + "FileStore\\Vault"))
            {
                Launch_VaultSrv();

                VCSRV_PrivacySettingsDLG VCSRV_PrivacySettingsDLG = new VCSRV_PrivacySettingsDLG();
                if (VCSRV_PrivacySettingsDLG.WaitExists(15000))
                {
                    VCSRV_PrivacySettingsDLG.SetActive();
                    VCSRV_PrivacySettingsDLG.OKPB.Click();
                }
                
                VMSRV_NeedVaultDLG VMSRV_NeedVaultDLG = new VMSRV_NeedVaultDLG();
                if (VMSRV_NeedVaultDLG.WaitExists(15000))
                {
                    VMSRV_NeedVaultDLG.SetActive();
                    VMSRV_NeedVaultDLG.YesPB.Click();
                }                

                VCSRV_LogInServerDLG VCSRV_LogInServerDLG = new VCSRV_LogInServerDLG();
                if (VCSRV_LogInServerDLG.WaitExists(20000))
                {
                    VCSRV_LogInServerDLG.SetActive();
                    VCSRV_LogInServerDLG.OKPB.Click();
                }

                VMSRV_CreatVaultDLG VMSRV_CreatVaultDLG = new VMSRV_CreatVaultDLG();
                if (VMSRV_CreatVaultDLG.WaitExists())
                {
                    System.Threading.Thread.Sleep(10000);
                    VMSRV_CreatVaultDLG.SetActive();
                    VMSRV_CreatVaultDLG.M_vaultNameTextBox.SetText("Vault");
                    VMSRV_CreatVaultDLG.M_okButton.Click();
                }

                for (int i = 0; i < 6; i++)
                {
                    VCSRV_CreateSuccessfulDLG VCSRV_CreateSuccessfulDLG = new VCSRV_CreateSuccessfulDLG();
                    if (VCSRV_CreateSuccessfulDLG.WaitExists(30000))
                    {
                        VCSRV_CreateSuccessfulDLG.SetActive();
                        VCSRV_CreateSuccessfulDLG.OKPB.Click();
                        break;
                    }
                    System.Threading.Thread.Sleep(15000);
                    if (Directory.Exists(VaultProFunctions.getVaultServerDataFolder() + "FileStore\\Vault"))
                    {
                        Desktop.Current.Click(MouseButton.Left, 100, 50);
                        Desktop.Current.TypeKeys("<Enter>");
                        break;
                    }

                }

                VC_AutodeskCustomerInvolvementDLG VC_AutodeskCustomerInvolvementDLG = new VC_AutodeskCustomerInvolvementDLG();
                if (VC_AutodeskCustomerInvolvementDLG.WaitExists(5000))
                {
                    VC_AutodeskCustomerInvolvementDLG.OK.Click();
                }
                System.Threading.Thread.Sleep(5000);

                VaultProServer VaultProServer = new VaultProServer();
                VaultProFunctions.Pick(VaultProServer, "file", "exit");
            }
        }


        public static void InitializeVault()
        {
            Launch_Vault();
            System.Threading.Thread.Sleep(10000);
            VM_FlexNetLicenseFinderDLG VM_FlexNetLicenseFinderDLG = new VM_FlexNetLicenseFinderDLG();
            if (VM_FlexNetLicenseFinderDLG.Exists)
            {
                VM_FlexNetLicenseFinderDLG.SetActive();
                VM_FlexNetLicenseFinderDLG.NextPB.Click();
                VM_FlexNetLicenseFinderDLG.EnterTheComputerNameTF.TypeKeys(VaultProFunctions.GetLicense());
                System.Threading.Thread.Sleep(2000);
                VM_FlexNetLicenseFinderDLG.NextPB.Click();
                System.Threading.Thread.Sleep(2000);
                VM_FlexNetLicenseFinderDLG.NextPB.Click();
                System.Threading.Thread.Sleep(2500);
            }

            VC_LogInDLG VC_LogInDLG = new VC_LogInDLG();
            VC_LogInDLG.SetActive();
            VC_LogInDLG.UserNameTF.SetText(VaultProFunctions.GetLoginVaultUser(false));
            try
            {
                VC_LogInDLG.ServerCB.Select(0);
            }
            catch
            {
            }
            //VC_LogInDLG.DatabaseCB.SetText(VaultProFunctions.GetLoginVaultDatabase(false));
            VC_LogInDLG.DatabasePB.Click();
            System.Threading.Thread.Sleep(2500);
            VC_DatabaseListFormDLG VC_DatabaseListFormDLG = new VC_DatabaseListFormDLG();
            VC_DatabaseListFormDLG.SelectAVaultFromLB.Select(VaultProFunctions.GetLoginVaultDatabase(false));
            VC_DatabaseListFormDLG.OKPB.Click();
            System.Threading.Thread.Sleep(1500);
            VC_LogInDLG.OKPB.Click();
            System.Threading.Thread.Sleep(15000);
            Dialogs.VaultPro VaultPro = new Dialogs.VaultPro();
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(15000);
                if (!VaultPro.IsEnabled)
                {
                    System.Threading.Thread.Sleep(15000);
                }
                else
                {
                    try
                    {
                        VaultPro.Move(0, 0);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        VaultPro.Size(1100, 800);
                    }
                    break;
                }
            }

            string initializecheck = "C:\\temp\\";
            FileInfo shareViewsInfo = new FileInfo(initializecheck + "ClosedSharedViews.txt");
            if (!shareViewsInfo.Exists)
            {
                RECT rect = VaultPro.SharedViewsPANE.GetRect(true);
                VaultPro.SharedViewsPANE.Click(MouseButton.Left, rect.xSize - 8, 8);
                shareViewsInfo.Create().Close(); ;
            }

            FileInfo propertiesInfo = new FileInfo(initializecheck + "ClosedProperties.txt");
            if (!propertiesInfo.Exists)
            {
                RECT rect = VaultPro.PropertiesPANE.GetRect(true);
                VaultPro.PropertiesPANE.Click(MouseButton.Left, rect.xSize - 8, 8);
                propertiesInfo.Create().Close();
            }

            FileInfo Limitinfo = new FileInfo(initializecheck + "Limit.txt");
            if (!Limitinfo.Exists)
            {
                VC_NewUserDLG VC_NewUserDLG = new VC_NewUserDLG();
                VC_NewUserDLG.Invoke();
                //VC_NewUserDLG.DisplayNameTF.TypeKeys("Limit");
                VC_NewUserDLG.FirstNameTF.TypeKeys("Limit");
                
                //VC_NewUserDLG.VaultsPB.Click();
                //VC_AddVaultsDLG VC_AddVaultsDLG = new VC_AddVaultsDLG();
                //VC_AddVaultsDLG.SetActive();
                //VC_AddVaultsDLG.SelectUnselectAllCK.Check();
                
                //VC_AddVaultsDLG.OKPB.Click();
                VC_NewUserDLG.AccountsPB.Click();
                VC_AddAuthenticationAccountDLG VC_AddAuthenticationAccountDLG = new VC_AddAuthenticationAccountDLG();
                VC_AddAuthenticationAccountDLG.VaultAccountCK.Click(MouseButton.Left, 30, 10);
                VC_AddAuthenticationAccountDLG.VaultAccountCK.Check();
                VC_AddAuthenticationAccountDLG.OKPB.Click();
                VC_NewUserDLG.OKPB.Click();
                VC_UserAndGroupManagementDLG VC_UserAndGroupManagementDLG = new VC_UserAndGroupManagementDLG();
                VC_UserAndGroupManagementDLG.Dismiss();
                Limitinfo.Create().Close();


            }
            FileInfo LimitedUserinfo = new FileInfo(initializecheck + "LimitedUser.txt");
            if (!LimitedUserinfo.Exists)
            {
                VC_NewUserDLG VC_NewUserDLG = new VC_NewUserDLG();
                VC_NewUserDLG.Invoke();
                //VC_NewUserDLG.DisplayNameTF.TypeKeys("Limited User");
                VC_NewUserDLG.FirstNameTF.TypeKeys("Limited User");
                VC_NewUserDLG.RolesPB.Click();
                VC_AddRolesDLG VC_AddRolesDLG = new VC_AddRolesDLG();
                VC_AddRolesDLG.SetActive();
                VC_AddRolesDLG.TheseAreTheRolesLB.TypeKeys("<Space>");
                for (int i = 0; i < 21; i++)
                {
                    System.Threading.Thread.Sleep(2000);
                    VC_AddRolesDLG.TheseAreTheRolesLB.TypeKeys("<Down><Space>");
                }
                VC_AddRolesDLG.Size(365, 670);
                try
                {
                    VC_AddRolesDLG.Move(0, 0);
                }
                catch
                {
                }
               
                System.Threading.Thread.Sleep(2000);
                VC_AddRolesDLG.OKPB.Click();
                VC_NewUserDLG.VaultsPB.Click();
                VC_AddVaultsDLG VC_AddVaultsDLG = new VC_AddVaultsDLG();
                VC_AddVaultsDLG.SetActive();
                VC_AddVaultsDLG.SelectUnselectAllCK.Check();
                //VC_AddVaultsDLG.TypeKeys("<Space>");
                VC_AddVaultsDLG.OKPB.Click();
                VC_NewUserDLG.AccountsPB.Click();
                VC_AddAuthenticationAccountDLG VC_AddAuthenticationAccountDLG = new VC_AddAuthenticationAccountDLG();
                VC_AddAuthenticationAccountDLG.VaultAccountCK.Click(MouseButton.Left, 30, 10);
                VC_AddAuthenticationAccountDLG.VaultAccountCK.Check();
                VC_AddAuthenticationAccountDLG.OKPB.Click();
                VC_NewUserDLG.OKPB.Click();
                VC_UserAndGroupManagementDLG VC_UserAndGroupManagementDLG = new VC_UserAndGroupManagementDLG();
                VC_UserAndGroupManagementDLG.Dismiss();
                LimitedUserinfo.Create().Close();


            }
            //FileInfo setColorTheme = new FileInfo(initializecheck + "setColorTheme.txt");
            //if (!setColorTheme.Exists)
            //{
            //    VM_OptionsDLG VM_OptionsDLG = new VM_OptionsDLG();
            //    VM_OptionsDLG.Invoke();
            //    string themeType = Plant3DFunctions.GetLocString("ThemeSet");
            //    switch (themeType)
            //    {
            //        case "Light":
            //            VM_OptionsDLG.ColorThemePL.Select(Plant3DFunctions.GetLocString("Light"));
            //            break;
            //        case "Dark":
            //            VM_OptionsDLG.ColorThemePL.Select(Plant3DFunctions.GetLocString("Dark"));
            //            break;
            //        case "Classic":
            //            VM_OptionsDLG.ColorThemePL.Select(Plant3DFunctions.GetLocString("Classic"));
            //            break;
            //    }
            //    System.Threading.Thread.Sleep(8000);
            //    VM_OptionsDLG.OKPB.Click();
            //    setColorTheme.Create().Close();
            //}
           
            VaultProFunctions.Pick(VaultPro, "file");
            Desktop.Current.TypeKeys("<Up><Enter>");
        }
    }
}


