using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using LAGT.CommonFiles;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
//using System.Web.Script.Serialization;
using Newtonsoft.Json;
using ProductTestSuite.CommonFiles;

namespace Autodesk.GUIHarness.Plant3D
{
    public class VaultProFunctions
    {
        public static string tempFolder = @"C:\temp\";
        public static string longStringThen265 = "abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345abcde12345";
        public static string loginVaultUser;
        public static string loginVaultDatabase;
        public static string adminTempPassword = "Password=1";


        public static string treeViewUAndD()
        {
            return loginVaultDatabase + " - " + loginVaultUser;
        }


        //public static void AddFileIntoVault(string file1, string file2 = null, string folder1 = null, string folder2 = null)
        //{
        //    VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    VM_ProjectExplorerDLG.Invoke();

        //    if (file1.Contains(".iam") || file1.Contains(".ipt") || file1.Contains(".dwg"))
        //    {
        //        DisableCheckInOfCK(false);
        //    }

        //    //Check file number and folder number
        //    int flienum = 1;
        //    int foldernum = 0;
        //    if (!string.IsNullOrEmpty(file2))
        //    {
        //        flienum = 2;
        //        if (file2.Contains(".iam") || file2.Contains(".ipt") || file2.Contains(".dwg"))
        //        {
        //            DisableCheckInOfCK(false);
        //        }
        //    }
        //    if (!string.IsNullOrEmpty(folder2))
        //    {
        //        foldernum = 2;
        //    }
        //    else if (!string.IsNullOrEmpty(folder1))
        //    {
        //        foldernum = 1;
        //    }     

        //    switch (foldernum)
        //    {
        //        case 0:
        //            AddFiles(file1, file2);
        //            break;
        //        case 1:
        //            NewFolder(folder1);
        //            AddFiles(file1, file2);
        //            break;
        //        case 2:
        //            NewFolder(folder1);
        //            AddFiles(file1, file2);
        //            NewFolder(folder2);
        //            AddFiles(file1, file2);
        //            break;

        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Dialogs.VaultPro VaultPro = new Dialogs.VaultPro();
        //        System.Threading.Thread.Sleep(20000);
        //        if (!VaultPro.IsEnabled)
        //        {
        //            System.Threading.Thread.Sleep(20000);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    //Update File Satue
        //    VaultProCheckClientSatue.AddSatueForFiles(file1, file2, folder1, folder2);
        //}


        //public static void AddFiles(string file1, string file2)
        //{
        //    //int flienum = 1;
        //    //VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    //VM_FileCannotBeAddedDLG VM_FileCannotBeAddedDLG = new VM_FileCannotBeAddedDLG();
        //    //VC_ImportInventorFileWarning VC_ImportInventorFileWarning = new VC_ImportInventorFileWarning();

        //    //if (!string.IsNullOrEmpty(file2))
        //    //{
        //    //    flienum = 2;
        //    //}

        //    //Pick(VM_ProjectExplorerDLG, "file", "addfiles");
        //    //VC_AddFilesDLG VC_AddFilesDLG = new VC_AddFilesDLG();
        //    //VC_AddFilesDLG.FileNameCB.ClearText();
        //    //System.Threading.Thread.Sleep(1500);
        //    //VC_AddFilesDLG.FileNameCB.SetText(Product.Variables.TestFilesDir);
        //    //System.Threading.Thread.Sleep(1500);
        //    //VC_AddFilesDLG.OpenPB.Click();
        //    //System.Threading.Thread.Sleep(2000);
        //    //switch (flienum)
        //    //{
        //    //    case 1:
        //    //        VC_AddFilesDLG.FileNameCB.SetText(file1);
        //    //        VC_AddFilesDLG.OpenPB.Click();
        //    //        System.Threading.Thread.Sleep(2000);
        //    //        VC_AddFilesMSG VC_AddFilesMSG = new VC_AddFilesMSG();
        //    //        if (VC_AddFilesMSG.Exists)
        //    //        {
        //    //            VC_AddFilesMSG.OKPB.Click();
        //    //            VC_AddFilesDLG.FileNameCB.ClearText();
        //    //            System.Threading.Thread.Sleep(1500);
        //    //            VC_AddFilesDLG.FileNameCB.SetText(file1);
        //    //            System.Threading.Thread.Sleep(1500);
        //    //            VC_AddFilesDLG.OpenPB.Click();
        //    //            System.Threading.Thread.Sleep(2000);
        //    //        }
        //    //        VC_AddFilesFormDLG VC_AddFilesFormDLG = new VC_AddFilesFormDLG();
        //    //        for (int i = 0; i < 5; i++)
        //    //        {
        //    //            System.Threading.Thread.Sleep(5000);
        //    //            if (VC_AddFilesFormDLG.OKPB.Exists && VC_AddFilesFormDLG.OKPB.IsEnabled)
        //    //            {
        //    //                VC_AddFilesFormDLG.OKPB.Click();
        //    //                break;
        //    //            }
        //    //        }                    
        //    //        if (VM_FileCannotBeAddedDLG.WaitExists(2000))
        //    //        {
        //    //            VM_FileCannotBeAddedDLG.YesPB.Click();
        //    //        }
        //    //        if (VC_ImportInventorFileWarning.WaitExists(2000))
        //    //        {
        //    //            VC_ImportInventorFileWarning.YesPB.Click();
        //    //        }
        //    //        break;
        //    //    case 2:
        //    //        VC_AddFilesDLG.FileNameCB.SetText("\"" + file1 + "\" \"" + file2 + "\"");
        //    //        VC_AddFilesDLG.OpenPB.Click();
        //    //        System.Threading.Thread.Sleep(2000);
        //    //        VC_AddMultipleFilesDLG VC_AddMultipleFilesDLG = new VC_AddMultipleFilesDLG();
        //    //        VC_AddMultipleFilesDLG.OKPB.Click();
        //    //        if (VM_FileCannotBeAddedDLG.WaitExists(2000))
        //    //        {
        //    //            VM_FileCannotBeAddedDLG.YesPB.Click();
        //    //        }
        //    //        if (VC_ImportInventorFileWarning.WaitExists(2000))
        //    //        {
        //    //            VC_ImportInventorFileWarning.YesPB.Click();
        //    //        }
        //    //        break;
        //    //    default:
        //    //        break;
        //    //}
        //    //System.Threading.Thread.Sleep(5000);
        //}


        //public static void NewFolder(string folder)
        //{
        //    //VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    //VM_ProjectExplorerDLG.Invoke();
        //    //VM_ProjectExplorerDLG.TreeViewTV.Expand(treeViewUAndD() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)"));
        //    //if (!VM_ProjectExplorerDLG.TreeViewTV.GetSubItems(treeViewUAndD() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)")).Contains(folder))
        //    //{
        //    //    //VM_NewStandardFolderDLG VM_NewStandardFolderDLG = new VM_NewStandardFolderDLG();
        //    //    //VM_NewStandardFolderDLG.Invoke();
        //    //    //VM_NewStandardFolderDLG.CategoryPL.Select("Folder");
        //    //    //VM_NewStandardFolderDLG.FileNameTF.SetText(folder);
        //    //    //VM_NewStandardFolderDLG.OKPB.Click();
        //    //    //System.Threading.Thread.Sleep(1500);
        //    //    VC_NewFolderDLG VC_NewFolderDLG = new VC_NewFolderDLG();
        //    //    VC_NewFolderDLG.Invoke();
        //    //    VC_NewFolderDLG.FolderTF.SetText(folder);
        //    //    VC_NewFolderDLG.OKPB.Click();
        //    //    VC_NewFolderExistsDLG VC_NewFolderExistsDLG = new VC_NewFolderExistsDLG();
        //    //    if (VC_NewFolderExistsDLG.WaitExists(2000))
        //    //    {
        //    //        VC_NewFolderExistsDLG.OKPB.Click();
        //    //        VC_NewFolderDLG.SetActive();
        //    //        VC_NewFolderDLG.CancelPB.Click();
        //    //    }
        //    //    Dialogs.VaultPro VaultPro = new Dialogs.VaultPro();
        //    //    VaultPro.TreeViewTV.Expand(treeViewUAndD() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)"));
        //    //    VaultPro.TreeViewTV.Select(treeViewUAndD() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)") + "/" + folder);
        //    //    System.Threading.Thread.Sleep(1500);
        //    //    VaultPro.TreeViewTV.TypeKeys("<Down>");
        //    //    System.Threading.Thread.Sleep(1500);
        //    //    VaultPro.TreeViewTV.TypeKeys("<Up>");
        //    //    System.Threading.Thread.Sleep(1500);
        //    //}        
        //}


        ////public static void AddIAMTypeFile(string filename = "LocTemplateAssembly.iam")
        ////{
        ////    //VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        ////    //VC_AdministrationDLG.Invoke();
        ////    //VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        ////    //VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        ////    //VC_AdministrationDLG.DisableCheckInOfCK.Uncheck();
        ////    //VC_AdministrationDLG.Dismiss();
        ////    DisableCheckInOfCK(false);

        ////    AddFileIntoVault(filename);
        ////}


        //public static void CreateOrderList(int i=1)
        //{
        //    //for (int k = 0; k < i; k++)
        //    //{
        //    //    VM_CODetailFormDLG VM_CODetailFormDLG = new VM_CODetailFormDLG();
        //    //    VM_CODetailFormDLG.Invoke();
        //    //    VM_CODetailFormDLG.TypeKeys("<Alt><Down><Enter>");
        //    //    System.Threading.Thread.Sleep(2000);
        //    //    VM_CODetailFormDLG.TypeKeys("<Alt-F4>");
        //    //}

        //    //VaultProCheckClientSatue.AddSatueForOrderList(i);
        //}


        //public static void CreateItems(int i = 1)
        //{
        //    //for (int k = 0; k < i; k++)
        //    //{
        //    //    VM_CreateNewItemDLG VM_CreateNewItemDLG = new VM_CreateNewItemDLG();
        //    //    VM_CreateNewItemDLG.Invoke();
        //    //    VM_CreateNewItemDLG.TypeKeys("<Alt><Down 3><Enter>", 250);
        //    //}

        //    //VM_ItemMasterDLG VM_ItemMasterDLG = new VM_ItemMasterDLG();
        //    //for (int m = 0; m < 5; m++)
        //    //{
        //    //    System.Threading.Thread.Sleep(8000);
        //    //    if (!VM_ItemMasterDLG.IsEnabled)
        //    //    {
        //    //        System.Threading.Thread.Sleep(8000);
        //    //    }
        //    //    else
        //    //    {
        //    //        break;
        //    //    }
        //    //}            
        //    //VM_ItemMasterDLG.Invoke();
        //    //System.Threading.Thread.Sleep(4000);

        //    //VaultProCheckClientSatue.AddSatueForItems(i);
        //}


        //public static void DeleteAllFiles(string folder1 = null, string folder2 = null)
        //{
        //    //VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    //VC_ConfirmMultipleFileDeleteDLG VC_ConfirmMultipleFileDeleteDLG = new VC_ConfirmMultipleFileDeleteDLG();
        //    //VC_ConfirmFileDeleteDLG VC_ConfirmFileDeleteDLG = new VC_ConfirmFileDeleteDLG();
        //    //VM_FileCannotBeDeletedDLG VM_FileCannotBeDeletedDLG = new VM_FileCannotBeDeletedDLG();
        //    //int foldernum = 0;

        //    //VM_ProjectExplorerDLG.Invoke();

        //    ////Check file number and folder number
        //    //if (!string.IsNullOrEmpty(folder2))
        //    //{
        //    //    foldernum = 2;
        //    //}
        //    //else if (!string.IsNullOrEmpty(folder1))
        //    //{
        //    //    foldernum = 1;
        //    //}

        //    //switch (foldernum)
        //    //{
        //    //    case 0:
        //    //        Table tableTBL = VM_ProjectExplorerDLG.FileListPANE;
        //    //        RECT rect = tableTBL.GetRect(true);
        //    //        tableTBL.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    //        tableTBL.TypeKeys("<Ctrl-A>");
        //    //        System.Threading.Thread.Sleep(1500);
        //    //        tableTBL.TypeKeys("<Ctrl-D>");
        //    //        if (VC_ConfirmFileDeleteDLG.WaitExists(3000))
        //    //        {
        //    //            VC_ConfirmFileDeleteDLG.YesPB.Click();
        //    //        }
        //    //        if (VM_FileCannotBeDeletedDLG.WaitExists(2000))
        //    //        {
        //    //            VM_FileCannotBeDeletedDLG.DetailsPB.Click();
        //    //            VM_FileCannotBeDeletedDLG.IgnoreRestrictionsCK.Check();
        //    //            VM_FileCannotBeDeletedDLG.YesPB.Click();
        //    //            System.Threading.Thread.Sleep(2000);
        //    //        }
        //    //        break;
        //    //    case 1:
        //    //        DeleteFolder(folder1);
        //    //        break;
        //    //    case 2:
        //    //        DeleteFolder(folder1);
        //    //        DeleteFolder(folder2);
        //    //        break;
        //    //    default:
        //    //        break;
        //    //}
        //    //System.Threading.Thread.Sleep(2000);

        //    //switch (Product.Variables.ProductName)
        //    //{
        //    //    case "VaultPro":
        //    //        VaultProCheckClientSatue.DeleteSatueForFiles(); 
        //    //        break;
        //    //    default:
        //    //        break;
        //    //}            
        //}


        //public static void DeleteFolder(string folder)
        //{
        //    //Dialogs.VaultPro VaultPro = new Dialogs.VaultPro();
        //    //switch (LAGT.CommonFiles.Product.Variables.ProductName)
        //    //{
        //    //    case "VaultAddins":
        //    //        VaultPro.TreeViewTV.Expand("Vault - " + VaultProFunctions.GetAdministratorLocal() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)"));
        //    //        VaultPro.TreeViewTV.Select("Vault - " + VaultProFunctions.GetAdministratorLocal() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)") + "/" + folder);
        //    //        break;
        //    //    case "VaultPro":
        //    //        VaultPro.TreeViewTV.Expand(VaultProFunctions.treeViewUAndD() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)"));
        //    //        VaultPro.TreeViewTV.Select(VaultProFunctions.treeViewUAndD() + "/" + Plant3DMainWin.cBabel(8, 1, "Project Explorer ($)") + "/" + folder);
        //    //        break;
        //    //}
        //    //System.Threading.Thread.Sleep(1500);
        //    //VaultPro.TreeViewTV.TypeKeys("<Down>");
        //    //System.Threading.Thread.Sleep(1500);
        //    //VaultPro.TreeViewTV.TypeKeys("<Up>");
        //    //System.Threading.Thread.Sleep(1500);
        //    //VaultPro.TreeViewTV.TypeKeys("<Ctrl-D>");
        //    //VC_ConfirmFileDeleteDLG VC_ConfirmFileDeleteDLG = new VC_ConfirmFileDeleteDLG();
        //    //if (VC_ConfirmFileDeleteDLG.WaitExists(3000))
        //    //{
        //    //    VC_ConfirmFileDeleteDLG.YesPB.Click();
        //    //}
        //    //VC_FolderCannotBeDeletedDLG VC_FolderCannotBeDeletedDLG = new VC_FolderCannotBeDeletedDLG();
        //    //if (VC_FolderCannotBeDeletedDLG.WaitExists(2000))
        //    //{
        //    //    VC_FolderCannotBeDeletedDLG.DetailsPB.Click();
        //    //    VC_FolderCannotBeDeletedDLG.IgnoreRestrictionsdeleteUnconditionallyCK.Check();
        //    //    VC_FolderCannotBeDeletedDLG.YesPB.Click();
        //    //    System.Threading.Thread.Sleep(2000);
        //    //}
        //}


        //public static void DeleteOrderList()
        //{
        //    //VM_ChangeOrderListDLG VM_ChangeOrderListDLG = new VM_ChangeOrderListDLG();
        //    //VM_ChangeOrderListDLG.Invoke();

        //    //RECT rect = VM_ChangeOrderListDLG.TablePANE.GetRect(true);
        //    //VM_ChangeOrderListDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    //System.Threading.Thread.Sleep(2000);
        //    //VM_ChangeOrderListDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    //System.Threading.Thread.Sleep(2000);
        //    //VM_ChangeOrderListDLG.TablePANE.TypeKeys("<Ctrl-A>");
        //    //System.Threading.Thread.Sleep(2000);
        //    //VM_ChangeOrderListDLG.TablePANE.TypeKeys("<Ctrl-D>");

        //    //VM_ConfirmCODeleteDLG VM_ConfirmCODeleteDLG = new VM_ConfirmCODeleteDLG();
        //    //if (VM_ConfirmCODeleteDLG.WaitExists(3000))
        //    //{
        //    //    VM_ConfirmCODeleteDLG.YesPB.Click();
        //    //}

        //    //VM_ChangeOrderCannotBeDeletedDLG VM_ChangeOrderCannotBeDeletedDLG = new VM_ChangeOrderCannotBeDeletedDLG();
        //    //if (VM_ChangeOrderCannotBeDeletedDLG.WaitExists(2000))
        //    //{
        //    //    VM_ChangeOrderCannotBeDeletedDLG.DetailsPB.Click();
        //    //    VM_ChangeOrderCannotBeDeletedDLG.IgnoreRestrictionsdeleteUnconditionallyCK.Check();
        //    //    VM_ChangeOrderCannotBeDeletedDLG.YesPB.Click();
        //    //}
        //    //System.Threading.Thread.Sleep(2000);

        //    //VM_ChangeOrderListDLG.TablePANE.TypeKeys("<F5>");
        //    //VM_ChangeOrderErrorSpecifiedIDMSG VM_ChangeOrderErrorSpecifiedIDMSG = new VM_ChangeOrderErrorSpecifiedIDMSG();
        //    //if (VM_ChangeOrderErrorSpecifiedIDMSG.WaitExists(2000))
        //    //{
        //    //    VM_ChangeOrderErrorSpecifiedIDMSG.OKPB.Click();
        //    //    System.Threading.Thread.Sleep(2000);

        //    //    switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
        //    //    {
        //    //        case "RUS":
        //    //        case "PTB":
        //    //            Pick(VM_ChangeOrderListDLG, "file");
        //    //            System.Threading.Thread.Sleep(1000);
        //    //            Desktop.Current.TypeKeys("<Right><Enter>");
        //    //            break;
        //    //        default:
        //    //            Pick(VM_ChangeOrderListDLG, "file", "new", "newchangeorder");
        //    //            System.Threading.Thread.Sleep(1000);
        //    //            Desktop.Current.TypeKeys("<Right 2><Down><Enter>");
        //    //            break;
        //    //    }
        //    //    VM_CODetailFormDLG VM_CODetailFormDLG = new VM_CODetailFormDLG();
        //    //    VM_CODetailFormDLG.TypeKeys("<Alt><Down><Enter>");
        //    //    System.Threading.Thread.Sleep(2000);
        //    //    VM_CODetailFormDLG.TypeKeys("<Alt-F4>");
        //    //    if (VM_ChangeOrderErrorSpecifiedIDMSG.WaitExists(2000))
        //    //    {
        //    //        VM_ChangeOrderErrorSpecifiedIDMSG.OKPB.Click();
        //    //        System.Threading.Thread.Sleep(2000);
        //    //    }

        //    //    VM_ChangeOrderListDLG.TablePANE.TypeKeys("<F5>");
        //    //    if (VM_ChangeOrderErrorSpecifiedIDMSG.WaitExists(2000))
        //    //    {
        //    //        VM_ChangeOrderErrorSpecifiedIDMSG.OKPB.Click();
        //    //        System.Threading.Thread.Sleep(2000);
        //    //    }
        //    //    VM_ChangeOrderListDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    //    System.Threading.Thread.Sleep(2000);
        //    //    VM_ChangeOrderListDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    //    System.Threading.Thread.Sleep(2000);
        //    //    VM_ChangeOrderListDLG.TablePANE.TypeKeys("<Up 2>");
        //    //    System.Threading.Thread.Sleep(2000);
        //    //    VM_ChangeOrderListDLG.TablePANE.TypeKeys("<Ctrl-D>");

        //    //    VM_ConfirmCODeleteDLG = new VM_ConfirmCODeleteDLG();
        //    //    if (VM_ConfirmCODeleteDLG.WaitExists(3000))
        //    //    {
        //    //        VM_ConfirmCODeleteDLG.YesPB.Click();
        //    //    }

        //    //    VM_ChangeOrderCannotBeDeletedDLG = new VM_ChangeOrderCannotBeDeletedDLG();
        //    //    if (VM_ChangeOrderCannotBeDeletedDLG.WaitExists(2000))
        //    //    {
        //    //        VM_ChangeOrderCannotBeDeletedDLG.DetailsPB.Click();
        //    //        VM_ChangeOrderCannotBeDeletedDLG.IgnoreRestrictionsdeleteUnconditionallyCK.Check();
        //    //        VM_ChangeOrderCannotBeDeletedDLG.YesPB.Click();
        //    //    }
        //    //    System.Threading.Thread.Sleep(2000);

        //    //    VM_ChangeOrderListDLG.TablePANE.TypeKeys("<F5>");
        //    //}

        //    //VaultProCheckClientSatue.DeleteSatueForOrderList();
        //}


        //public static void DeleteItems()
        //{
        //    //VM_ItemMasterDLG VM_ItemMasterDLG = new VM_ItemMasterDLG();
        //    //VM_ItemMasterDLG.Invoke();

        //    //RECT rect = VM_ItemMasterDLG.TablePANE.GetRect(true);
        //    //VM_ItemMasterDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    //System.Threading.Thread.Sleep(200);
        //    //VM_ItemMasterDLG.TablePANE.TypeKeys("<Ctrl-A>");
        //    //System.Threading.Thread.Sleep(2000);
        //    //VM_ItemMasterDLG.TablePANE.TypeKeys("<Ctrl-D>");
        //    //System.Threading.Thread.Sleep(2000);

        //    //VM_ConfirmItemDeleteDLG VM_ConfirmItemDeleteDLG = new VM_ConfirmItemDeleteDLG();
        //    //if (VM_ConfirmItemDeleteDLG.WaitExists(3000))
        //    //{
        //    //    VM_ConfirmItemDeleteDLG.YesPB.Click();
        //    //}

        //    //VM_ErrorDeletingItemDetailDLG VM_ErrorDeletingItemDetailDLG = new VM_ErrorDeletingItemDetailDLG();
        //    //if (VM_ErrorDeletingItemDetailDLG.WaitExists(2000))
        //    //{
        //    //    VM_ErrorDeletingItemDetailDLG.DetailsPB.Click();
        //    //    VM_ErrorDeletingItemDetailDLG.IgnoreRestrictionsdeleteUnconditionallyCK.Check();
        //    //    VM_ErrorDeletingItemDetailDLG.YesPB.Click();
        //    //}

        //    //VM_ItemMasterDLG.Invoke();

        //    //VaultProCheckClientSatue.DeleteSatueForItems();
        //}


        //public static void ChangeItemsState(string state)
        //{
        //    VM_ItemMasterDLG VM_ItemMasterDLG = new VM_ItemMasterDLG();
        //    VM_ItemMasterDLG.Invoke();
        //    System.Threading.Thread.Sleep(2000);
        //    RECT rect = VM_ItemMasterDLG.TablePANE.GetRect(true);
        //    VM_ItemMasterDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    System.Threading.Thread.Sleep(200);
        //    VM_ItemMasterDLG.TablePANE.TypeKeys("<Ctrl-A>");
        //    System.Threading.Thread.Sleep(2000);
        //    switch (Product.Variables.Language.ToUpper())
        //    {
        //        case "RUS":
        //        case "ITA":
        //        case "ESP":
        //            Pick(VM_ItemMasterDLG, "actions");
        //            Desktop.Current.TypeKeys("<Down 3><Enter>");
        //            break;
        //        default:
        //            Pick(VM_ItemMasterDLG, "actions", "changestate");
        //            break;
        //    }

        //    VM_SelectLifecycleDLG VM_SelectLifecycleDLG = new VM_SelectLifecycleDLG();
        //    if (!VM_SelectLifecycleDLG.WaitExists(1500))
        //    {
        //        System.Threading.Thread.Sleep(2000);
        //        rect = VM_ItemMasterDLG.TablePANE.GetRect(true);
        //        VM_ItemMasterDLG.TablePANE.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //        System.Threading.Thread.Sleep(200);
        //        VM_ItemMasterDLG.TablePANE.TypeKeys("<Ctrl-A>");
        //        System.Threading.Thread.Sleep(2000);
        //        switch (Product.Variables.Language.ToUpper())
        //        {
        //            case "RUS":
        //            case "ITA":
        //            case "ESP":
        //                Pick(VM_ItemMasterDLG, "actions");
        //                Desktop.Current.TypeKeys("<Down 3><Enter>");
        //                break;
        //            default:
        //                Pick(VM_ItemMasterDLG, "actions", "changestate");
        //                break;
        //        }
        //        System.Threading.Thread.Sleep(2000);
        //    }
        //    switch (state)
        //    {
        //        case "Released":
        //            VM_SelectLifecycleDLG.PopupList_Statue.Select("*" + Plant3DMainWin.cBabel(23, 1, "Released") + "*");
        //            VaultProCheckClientSatue.ChangeSatueForItems(true);
        //            break;
        //        case "Work In Progress":
        //            VM_SelectLifecycleDLG.PopupList_Statue.Select(0);
        //            VM_SelectLifecycleDLG.PopupList_Statue.Select(Plant3DMainWin.cBabel(23, 2, "Work In Progress"));
        //            VaultProCheckClientSatue.ChangeSatueForItems(false);
        //            break;
        //        case "Obsolete":
        //            VM_SelectLifecycleDLG.PopupList_Statue.Select(Plant3DMainWin.cBabel(23, 3, "Obsolete"));
        //            VaultProCheckClientSatue.ChangeSatueForItems(true);
        //            break;
        //        default:
        //            break;
        //    }
        //    VM_SelectLifecycleDLG.OKPB.Click();
        //    System.Threading.Thread.Sleep(3500);
        //}


        //public static void ErrorDeleting()
        //{
        //    AddFileIntoVault("LocTemplateAssembly.iam");
        //    blockAssignItemFileHasNoItemData(false);

        //    VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    Table tableTBL = VM_ProjectExplorerDLG.FileListPANE;
        //    RECT rect = tableTBL.GetRect(true);
        //    tableTBL.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    tableTBL.TypeKeys("<Ctrl-A>");
        //    System.Threading.Thread.Sleep(1500);

        //    switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
        //    {
        //        case "PTB":
        //        case "ITA":
        //        case "ESP":
        //            Pick(VM_ProjectExplorerDLG, "actions");
        //            Desktop.Current.TypeKeys("<Down 10><Enter>");
        //            break;
        //        default:
        //            Pick(VM_ProjectExplorerDLG, "actions", "assign/updateitem");
        //            break;
        //    }

        //    VM_CreateNewItemDLG VM_CreateNewItemDLG = new VM_CreateNewItemDLG();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        System.Threading.Thread.Sleep(6000);
        //        if (VM_CreateNewItemDLG.Exists && VM_CreateNewItemDLG.IsEnabled)
        //        {
        //            break;
        //        }
        //    }
        //    VM_CreateNewItemDLG.TypeKeys("<Alt><Down 3><Enter>", 250);
        //    System.Threading.Thread.Sleep(6000);
        //}


        //public static void CheckOutFile()
        //{
        //    VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    VM_ProjectExplorerDLG.Invoke();
        //    //VM_ProjectExplorerDLG.TreeViewTV.TypeKeys("<Down>");
        //    //System.Threading.Thread.Sleep(2000);
        //    //VM_ProjectExplorerDLG.TreeViewTV.TypeKeys("<Up>");
        //    //System.Threading.Thread.Sleep(2000);
        //    Table tableTBL = VM_ProjectExplorerDLG.FileListPANE;
        //    RECT rect = tableTBL.GetRect(true);
        //    tableTBL.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //    tableTBL.TypeKeys("<Ctrl-A>");
        //    System.Threading.Thread.Sleep(1500);
        //    tableTBL.TypeKeys("<Ctrl-G>");
        //    System.Threading.Thread.Sleep(3000);
        //    VM_GetAndCheckOutFileDLG VM_GetAndCheckOutFileDLG = new VM_GetAndCheckOutFileDLG();
        //    if (!VM_GetAndCheckOutFileDLG.WaitExists(2000))
        //    {
        //        tableTBL.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
        //        tableTBL.TypeKeys("<Ctrl-A>");
        //        System.Threading.Thread.Sleep(1500);
        //        tableTBL.TypeKeys("<Ctrl-G>");
        //        System.Threading.Thread.Sleep(3000);
        //    }
        //    VM_GetAndCheckOutFileDLG.SetActive();
        //    VM_GetAndCheckOutFileDLG.ExpandPB.Click();
        //    RECT rect1 = VM_GetAndCheckOutFileDLG.ListPANE.GetRect(true);
        //    VM_GetAndCheckOutFileDLG.ListPANE.Click(MouseButton.Left, rect1.xSize - 5, 35);
        //    VM_GetAndCheckOutFileDLG.OKPB.Click();
        //    System.Threading.Thread.Sleep(10000);
        //}


        //public static void CheckAndLogInFacvault()
        //{
        //    if (!Directory.Exists(VaultProFunctions.getVaultServerDataFolder() + "FileStore\\FACTVault"))
        //    {
        //        Dialogs.VaultPro VaultPro = new Dialogs.VaultPro();
        //        if (VaultPro.Exists)
        //        {
        //            VaultPro.Exit();
        //        }

        //        VaultProInitialize.Launch_VaultSrv();

        //        VCSRV_PrivacySettingsDLG VCSRV_PrivacySettingsDLG = new VCSRV_PrivacySettingsDLG();
        //        if (VCSRV_PrivacySettingsDLG.WaitExists(1500))
        //        {
        //            VCSRV_PrivacySettingsDLG.OKPB.Click();
        //            System.Threading.Thread.Sleep(3500);
        //        }
        //        VCSRV_LogInServerDLG VCSRV_LogInServerDLG = new VCSRV_LogInServerDLG();
        //        VCSRV_LogInServerDLG.SetActive();
        //        VCSRV_LogInServerDLG.OKPB.Click();    
        //        System.Threading.Thread.Sleep(5000);

        //        VaultProServer VaultProServer = new VaultProServer();
        //        VaultProServer.TreeViewTV.Expand(getComputerName());
        //        VaultProServer.TreeViewTV.Expand(getComputerName() + "/" + Plant3DMainWin.cBabel(28, 1, "Vaults"));
        //        VaultProServer.TreeViewTV.Select(getComputerName() + "/" + Plant3DMainWin.cBabel(28, 1, "Vaults"));
        //        VaultProServer.TreeViewTV.TypeKeys("<Down>");
        //        System.Threading.Thread.Sleep(2000);
        //        VaultProServer.TreeViewTV.TypeKeys("<Up>");
        //        System.Threading.Thread.Sleep(2000);

        //        //VaultProServer.SetActive();
        //        //VaultProServer.TypeKeys("<Alt><Right 2><Down><Enter>", 250);
        //        //RECT rectVaults = VaultProServer.TreeViewTV.GetItemRect(1);
        //        VaultProServer.TreeViewTV.Click(MouseButton.Right, 35, 25);
        //        Desktop.Current.TypeKeys("<Down><Enter>", 250);
        //        VMSRV_CreatVaultDLG VMSRV_CreatVaultDLG = new VMSRV_CreatVaultDLG();
        //        VMSRV_CreatVaultDLG.SetActive();
        //        VMSRV_CreatVaultDLG.M_vaultNameTextBox.SetText("FACTVault");
        //        VMSRV_CreatVaultDLG.UseConfigurationCK.Check();
        //        //VMSRV_CreatVaultDLG.ConfigurationPL.Select(3);
        //        VMSRV_CreatVaultDLG.ConfigurationPL.Select(2);
        //        VMSRV_CreatVaultDLG.M_okButton.Click();
        //        System.Threading.Thread.Sleep(35000);

        //        VCSRV_CreateSuccessfulDLG VCSRV_CreateSuccessfulDLG = new VCSRV_CreateSuccessfulDLG();
        //        if (VCSRV_CreateSuccessfulDLG.WaitExists(15000))
        //        {
        //            VCSRV_CreateSuccessfulDLG.OKPB.Click();
        //        }

        //        VaultProServer.TypeKeys("<Alt-F4>");
        //        VaultPro.Initialize();                
        //    }

        //    LoginWithUserAndDataBase("admin", "facvault");
        //}


        //public static void AddCloudDriveMapping()
        //{
        //    if (!File.Exists(tempFolder + "AddCloudDriveMapping.txt"))
        //    {
        //        VM_CloudDriveMappingDLG VM_CloudDriveMappingDLG = new VM_CloudDriveMappingDLG();
        //        VM_CloudDriveMappingDLG.FilterPL.Click(MouseButton.Left, 10, 5);
        //        Desktop.Current.TypeKeys("<Tab><Enter>");
        //        System.Threading.Thread.Sleep(2000);
        //        VM_CloudDriveMapping_NewDefinitionDLG VM_CloudDriveMapping_NewDefinitionDLG = new VM_CloudDriveMapping_NewDefinitionDLG();
        //        VM_CloudDriveMapping_NewDefinitionDLG.AddPB.Click();
        //        VM_DefineFolderSyncDLG VM_DefineFolderSyncDLG = new VM_DefineFolderSyncDLG();
        //        VM_DefineFolderSyncDLG.BrowseForVaultPathPB.Click();
        //        System.Threading.Thread.Sleep(10000);
        //        VM_DriveSelectVaultLocationDLG VM_DriveSelectVaultLocationDLG = new VM_DriveSelectVaultLocationDLG();
        //        VM_DriveSelectVaultLocationDLG.OKPB.Click();
        //        VM_DefineFolderSyncDLG.OKPB.Click();
        //        VM_CloudDriveMapping_NewDefinitionDLG.NameTF.Click(MouseButton.Left, 10, 10);
        //        Desktop.Current.TypeKeys("<Ctrl-A><Delete>");
        //        VM_CloudDriveMapping_NewDefinitionDLG.NameTF.SetText("CloudDrive");
        //        VM_CloudDriveMapping_NewDefinitionDLG.VaultFolderPB.Click();
        //        System.Threading.Thread.Sleep(5000);
        //        VM_DriveSelectVaultLocationDLG_1 VM_DriveSelectVaultLocationDLG_1 = new VM_DriveSelectVaultLocationDLG_1();
        //        VM_DriveSelectVaultLocationDLG_1.OKPB.Click();
        //        System.Threading.Thread.Sleep(5000);
        //        VM_CloudDriveMapping_NewDefinitionDLG.CloudDriveFolderPB.Click();
        //        VM_DriveSelectVaultLocationDLG_2 VM_DriveSelectVaultLocationDLG_2 = new VM_DriveSelectVaultLocationDLG_2();
        //        //VM_DriveSelectVaultLocationDLG_1.TreeViewTV.Expand("Fusion 360");
        //        //System.Threading.Thread.Sleep(5000);
        //        //VM_DriveSelectVaultLocationDLG_1.TreeViewTV.Expand("Fusion 360/Autodesk Vault");
        //        //System.Threading.Thread.Sleep(5000);
        //        //VM_DriveSelectVaultLocationDLG_1.TreeViewTV.Select("Fusion 360/Autodesk Vault/Vault Testing Group");

        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\Fusion360.bmp");
        //        //Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 50, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(3000);
        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\AccountSelect.bmp");
        //        //Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 50, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(3000);
        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\CloudFolder.bmp");
        //        //Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 50, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(3000);

        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\BIM360.bmp");
        //        //Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(3000);
        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\AccountSelect.bmp");
        //        //Desktop.Current.DoubleClick(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(3000);
        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\AccountSelect2.bmp");
        //        //Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(3000);
        //        //SAM.GetCoords(Product.Variables.TestFilesDir + "SAMScreenshots\\CloudFolder.bmp");
        //        //Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 5, SAM.iYCoord + 5);
        //        //System.Threading.Thread.Sleep(2000);
        //        VM_DriveSelectVaultLocationDLG_2.TreeViewTV.DoubleClick(MouseButton.Left, 100, 35);
        //        System.Threading.Thread.Sleep(4000);
        //        VM_DriveSelectVaultLocationDLG_2.TreeViewTV.DoubleClick(MouseButton.Left, 100, 55);
        //        System.Threading.Thread.Sleep(5000);
        //        VM_DriveSelectVaultLocationDLG_2.TreeViewTV.DoubleClick(MouseButton.Left, 120, 75);
        //        System.Threading.Thread.Sleep(5000);
        //        VM_DriveSelectVaultLocationDLG_2.TreeViewTV.Click(MouseButton.Left, 140, 95);
        //        System.Threading.Thread.Sleep(3000);

        //        VM_DriveSelectVaultLocationDLG_2.OKPB.Click();
        //        System.Threading.Thread.Sleep(5000);
        //        VM_CloudDriveMapping_NewDefinitionDLG.OKPB.Click();
        //        File.Create(tempFolder + "AddCloudDriveMapping.txt").Close();
        //    }         
        //}

        //public static void SetPDFCreation(bool flag)
        //{
        //    if (flag)
        //    {
        //        if (!File.Exists(tempFolder + "SetPDFCreationTrue.txt"))
        //        {
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Invoke();
        //            VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        //            VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        //            VC_AdministrationDLG.EnableManualPDFCreationCK.Check();
        //            VC_AdministrationDLG.Dismiss();

        //            EnableJobServer(true);

        //            File.Create(tempFolder + "SetPDFCreationTrue.txt").Close();
        //            if (File.Exists(tempFolder + "SetPDFCreationFalse.txt"))
        //            {
        //                File.Delete(tempFolder + "SetPDFCreationFalse.txt");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (!File.Exists(tempFolder + "SetPDFCreationFalse.txt"))
        //        {
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Invoke();
        //            VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        //            VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        //            VC_AdministrationDLG.EnableManualPDFCreationCK.Check();
        //            VC_AdministrationDLG.Dismiss();

        //            EnableJobServer(false);

        //            File.Create(tempFolder + "SetPDFCreationFalse.txt").Close();
        //            if (File.Exists(tempFolder + "SetPDFCreationTrue.txt"))
        //            {
        //                File.Delete(tempFolder + "SetPDFCreationTrue.txt");
        //            }
        //        }    
        //    }   
        //}

        //public static void SetFileNameDuplicated(bool flag/*, bool subfolder*/)
        //{
        //    if (flag)
        //    {
        //        if (!File.Exists(tempFolder + "SetFileNameDuplicatedTrue.txt"))
        //        {
        //            VC_FileNameOptionsDLG VC_FileNameOptionsDLG = new VC_FileNameOptionsDLG();
        //            VC_FileNameOptionsDLG.Invoke();
        //            VC_FileNameOptionsDLG.EnforceUniqueFileNameCK.Check();
        //            VC_FileNameOptionsDLG.OKPB.Click();
        //            System.Threading.Thread.Sleep(2000);
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Dismiss();
        //            File.Create(tempFolder + "SetFileNameDuplicatedTrue.txt").Close();
        //            if (File.Exists(tempFolder + "SetFileNameDuplicatedFalse.txt"))
        //            {
        //                File.Delete(tempFolder + "SetFileNameDuplicatedFalse.txt");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (!File.Exists(tempFolder + "SetFileNameDuplicatedFalse.txt"))
        //        {
        //            VC_FileNameOptionsDLG VC_FileNameOptionsDLG = new VC_FileNameOptionsDLG();
        //            VC_FileNameOptionsDLG.Invoke();
        //            VC_FileNameOptionsDLG.EnforceUniqueFileNameCK.Uncheck();
        //            VC_FileNameOptionsDLG.OKPB.Click();
        //            System.Threading.Thread.Sleep(2000);
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Dismiss();
        //            File.Create(tempFolder + "SetFileNameDuplicatedFalse.txt").Close();
        //            if (File.Exists(tempFolder + "SetFileNameDuplicatedTrue.txt"))
        //            {
        //                File.Delete(tempFolder + "SetFileNameDuplicatedTrue.txt");
        //            }
        //        }
        //    }
        //}

        //public static void DisableCheckInOfCK(bool flag)
        //{
        //    if (flag)
        //    {
        //        if (!File.Exists(tempFolder + "DisableCheckInOfCKTrue.txt"))
        //        {
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Invoke();
        //            VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        //            VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        //            VC_AdministrationDLG.DisableCheckInOfCK.Check();
        //            VC_AdministrationDLG.Dismiss();
        //            File.Create(tempFolder + "DisableCheckInOfCKTrue.txt").Close();
        //            if (File.Exists(tempFolder + "DisableCheckInOfCKFalse.txt"))
        //            {
        //                File.Delete(tempFolder + "DisableCheckInOfCKFalse.txt");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (!File.Exists(tempFolder + "DisableCheckInOfCKFalse.txt"))
        //        {
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Invoke();
        //            VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        //            VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        //            VC_AdministrationDLG.DisableCheckInOfCK.Uncheck();
        //            VC_AdministrationDLG.Dismiss();

        //            File.Create(tempFolder + "DisableCheckInOfCKFalse.txt").Close();
        //            if (File.Exists(tempFolder + "DisableCheckInOfCKTrue.txt"))
        //            {
        //                File.Delete(tempFolder + "DisableCheckInOfCKTrue.txt");
        //            }
        //        }
        //    }
        //}


        //public static void enableUniqueFileNames(bool flag)
        //{
        //    if (flag)
        //    {
        //        if (!File.Exists(tempFolder + "enableUniqueFileNamesTrue.txt"))
        //        {
        //            //VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            //VC_AdministrationDLG.Invoke();
        //            //VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        //            //VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        //            //VC_AdministrationDLG.EnforceUniqueFileNamesCK.Check();
        //            VC_FileNameOptionsDLG VC_FileNameOptionsDLG = new VC_FileNameOptionsDLG();
        //            VC_FileNameOptionsDLG.Invoke();
        //            VC_FileNameOptionsDLG.EnforceUniqueFileNameCK.Check();
        //            VC_FileNameOptionsDLG.OKPB.Click();
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Dismiss();
        //            File.Create(tempFolder + "enableUniqueFileNamesTrue.txt").Close();
        //            if (File.Exists(tempFolder + "enableUniqueFileNamesFalse.txt"))
        //            {
        //                File.Delete(tempFolder + "enableUniqueFileNamesFalse.txt");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (!File.Exists(tempFolder + "enableUniqueFileNamesFalse.txt"))
        //        {
        //            //VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            //VC_AdministrationDLG.Invoke();
        //            //VC_AdministrationDLG_pagelist VC_AdministrationDLG_pagelist = new VC_AdministrationDLG_pagelist();
        //            //VC_AdministrationDLG_pagelist.PageListPG.Select(0);
        //            //VC_AdministrationDLG.EnforceUniqueFileNamesCK.Uncheck();
        //            VC_FileNameOptionsDLG VC_FileNameOptionsDLG = new VC_FileNameOptionsDLG();
        //            VC_FileNameOptionsDLG.Invoke();
        //            VC_FileNameOptionsDLG.EnforceUniqueFileNameCK.Uncheck();
        //            VC_FileNameOptionsDLG.OKPB.Click();
        //            VC_AdministrationDLG VC_AdministrationDLG = new VC_AdministrationDLG();
        //            VC_AdministrationDLG.Dismiss();
        //            File.Create(tempFolder + "enableUniqueFileNamesFalse.txt").Close();
        //            if (File.Exists(tempFolder + "enableUniqueFileNamesTrue.txt"))
        //            {
        //                File.Delete(tempFolder + "enableUniqueFileNamesTrue.txt");
        //            }
        //        }
        //    }
        //}


        //public static void EnableJobServer(bool flag)
        //{
        //    if (flag)
        //    {
        //        if (!File.Exists(tempFolder + "EnableJobServerTrue.txt"))
        //        {
        //            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
        //            VM_GlobalSettingsDLG.Invoke();
        //            VM_GlobalSettingsDLG_pagelist VM_GlobalSettingsDLG_pagelist = new VM_GlobalSettingsDLG_pagelist();
        //            VM_GlobalSettingsDLG_pagelist.PageListPG.Select(2);
        //            VM_GlobalSettingsDLG.EnableJobServerCK.Check();
        //            VM_GlobalSettingsDLG.Dismiss();
        //        }

        //        File.Create(tempFolder + "EnableJobServerTrue.txt").Close();
        //        if (File.Exists(tempFolder + "EnableJobServerFalse.txt"))
        //        {
        //            File.Delete(tempFolder + "EnableJobServerFalse.txt");
        //        }
        //    }
        //    else
        //    {
        //        if (!File.Exists(tempFolder + "EnableJobServerFalse.txt"))
        //        {
        //            VM_GlobalSettingsDLG VM_GlobalSettingsDLG = new VM_GlobalSettingsDLG();
        //            VM_GlobalSettingsDLG.Invoke();
        //            VM_GlobalSettingsDLG_pagelist VM_GlobalSettingsDLG_pagelist = new VM_GlobalSettingsDLG_pagelist();
        //            VM_GlobalSettingsDLG_pagelist.PageListPG.Select(2);
        //            VM_GlobalSettingsDLG.EnableJobServerCK.Uncheck();
        //            VM_GlobalSettingsDLG.Dismiss();
        //        }

        //        File.Create(tempFolder + "EnableJobServerFalse.txt").Close();
        //        if (File.Exists(tempFolder + "EnableJobServerTrue.txt"))
        //        {
        //            File.Delete(tempFolder + "EnableJobServerTrue.txt");
        //        }
        //    }
        //}


        //public static void blockAssignItemFileHasNoItemData(bool flag)
        //{
        //    if (flag)
        //    {
        //        if (!File.Exists(tempFolder + "blockAssignItemFileHasNoItemDataTrue.txt"))
        //        {
        //            VM_ConfigureAssignItem_None VM_ConfigureAssignItem_None = new VM_ConfigureAssignItem_None();
        //            VM_ConfigureAssignItem_None.Invoke();
        //            VM_ConfigureAssignItem_None.BlockAssignItemIfCK.Check();
        //            VM_ConfigureAssignItem_None.OKPB.Click();
        //            VM_VaultSettingsDLG VM_VaultSettingsDLG = new VM_VaultSettingsDLG();
        //            VM_VaultSettingsDLG.Dismiss();
        //        }

        //        File.Create(tempFolder + "blockAssignItemFileHasNoItemDataTrue.txt").Close();
        //        if (File.Exists(tempFolder + "blockAssignItemFileHasNoItemDataFalse.txt"))
        //        {
        //            File.Delete(tempFolder + "blockAssignItemFileHasNoItemDataFalse.txt");
        //        }
        //    }
        //    else
        //    {
        //        if (!File.Exists(tempFolder + "blockAssignItemFileHasNoItemDataFalse.txt"))
        //        {
        //            VM_ConfigureAssignItem_None VM_ConfigureAssignItem_None = new VM_ConfigureAssignItem_None();
        //            VM_ConfigureAssignItem_None.Invoke();
        //            VM_ConfigureAssignItem_None.BlockAssignItemIfCK.Uncheck();
        //            VM_ConfigureAssignItem_None.OKPB.Click();
        //            VM_VaultSettingsDLG VM_VaultSettingsDLG = new VM_VaultSettingsDLG();
        //            VM_VaultSettingsDLG.Dismiss();
        //        }

        //        File.Create(tempFolder + "blockAssignItemFileHasNoItemDataFalse.txt").Close();
        //        if (File.Exists(tempFolder + "blockAssignItemFileHasNoItemDataTrue.txt"))
        //        {
        //            File.Delete(tempFolder + "blockAssignItemFileHasNoItemDataTrue.txt");
        //        }
        //    }
        //}


        //public static void DeleteInventorFolder()
        //{
        //    VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
        //    VM_ProjectExplorerDLG.Invoke();
        //    DeleteFolder("Content Center Files");
        //    DeleteFolder("Designs");
        //    DeleteFolder(GetLocString("Libraries"));
        //    DeleteAllFiles();
        //}


        //public static void InitializeAutoloader()
        //{
        //    if (!File.Exists(tempFolder + "InitializeAutoloader.txt"))
        //    {
        //        AutoLoader AutoLoader = new AutoLoader();

        //        System.Threading.Thread.Sleep(1500);
        //        string autoloaderProgessName = "Autoloader";
        //        Process[] prc = Process.GetProcesses();
        //        foreach (Process pr in prc)
        //        {
        //            if (autoloaderProgessName == pr.ProcessName)
        //            {
        //                pr.Kill();
        //                System.Threading.Thread.Sleep(3000);
        //            }
        //        }
        //        Process autoloaderProcess = new Process();
        //        autoloaderProcess.StartInfo.FileName = Product.Variables.ProductLocation + "Autoloader.exe";
        //        autoloaderProcess.Start();
        //        System.Threading.Thread.Sleep(10000);
        //        try
        //        {
        //            AutoLoader.Move(0, 0);
        //        }
        //        catch
        //        {
        //        }

        //        ATL_OpenInventorProjectFileDLG ATL_OpenInventorProjectFileDLG = new ATL_OpenInventorProjectFileDLG();
        //        ATL_OpenInventorProjectFileDLG.Invoke();
        //        //string defaultINVProject = getInventorViewDefaultProjct();
        //        string defaultINVProject = @"C:\Users\Public\Documents\Autodesk\Inventor View " +
        //            Product.Variables.ReleaseYear + @"\Default.ipj";
        //        ATL_OpenInventorProjectFileDLG.FileNameCB.SetText(defaultINVProject);
        //        ATL_OpenInventorProjectFileDLG.OpenPB.Click();
        //        ATL_SelectProjectDLG ATL_SelectProjectDLG = new ATL_SelectProjectDLG();
        //        ATL_SelectProjectDLG.OK.Click();

        //        AutoLoader.Dismiss();

        //        File.Create(tempFolder + "InitializeAutoloader.txt");
        //    }
        //}

        //public static void LaunchInventor()
        //{
        //    if (!File.Exists(tempFolder + "LaunchInventor.txt"))
        //    {
        //        string inventorExe = Product.Variables.ProductLocation.Replace("Vault Client", "Inventor").Replace("Explorer", "Bin")
        //            + "Inventor.exe";

        //        Process InventorProcess = new Process();
        //        InventorProcess.StartInfo.FileName = inventorExe;
        //        InventorProcess.Start();

        //        InventorMainWin InventorMainWin = new InventorMainWin();
        //        ReregistratioOfInventorEXE ReregistratioOfInventorEXE = new ReregistratioOfInventorEXE();
        //        for (int i = 0; i < 5; i++)
        //        {
        //            System.Threading.Thread.Sleep(15000);
        //            if (ReregistratioOfInventorEXE.WaitExists(2000))
        //            {
        //                ReregistratioOfInventorEXE.YesPB.Click();
        //            }
        //            if (!InventorMainWin.Exists || !InventorMainWin.IsEnabled)
        //            {
        //                System.Threading.Thread.Sleep(15000);
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        InventorMainWin.TypeKeys("<Alt-F4>");
        //        InventorCustomerFeedbackDLG InventorCustomerFeedbackDLG = new InventorCustomerFeedbackDLG();
        //        if (InventorCustomerFeedbackDLG.WaitExists(2500))
        //        {
        //            try
        //            {
        //                InventorCustomerFeedbackDLG.TypeKeys("<Alt-F4>");
        //            }
        //            catch
        //            { }
        //        }
        //        System.Threading.Thread.Sleep(3000);

        //        File.Create(tempFolder + "LaunchInventor.txt").Close();
        //    }
        //}


        public static void CreateGroup()
        {
            string file = @"C:\temp\HasGroups.txt";
            if (!File.Exists(file))
            {
                VC_NewGroupDLG VC_NewGroupDLG = new VC_NewGroupDLG();
                VC_NewGroupDLG.Invoke();
                VC_NewGroupDLG.GroupNameTF.SetText("abz");
                VC_NewGroupDLG.EmailAliasTF.SetText("abz@az.co");
                VC_NewGroupDLG.AddPB.Click();

                VC_AddMembersDLG VC_AddMembersDLG = new VC_AddMembersDLG();
                System.Threading.Thread.Sleep(2000);
                //RECT rect = VC_AddMembersDLG.AvailableMembersPANE.GetRect(true);
                //VC_AddMembersDLG.AvailableMembersPANE.Click(MouseButton.Left, rect.xSize, rect.ySize);
                VC_AddMembersDLG.AddPB_Members.Click();
                VC_AddMembersDLG.OKPB.Click();

                VC_NewGroupDLG.SetActive();
                VC_NewGroupDLG.OKPB.Click();

                VC_UserAndGroupManagementDLG VC_UserAndGroupManagementDLG = new VC_UserAndGroupManagementDLG();
                VC_UserAndGroupManagementDLG.Dismiss();

                File.Create(file).Close();
            }
        }


        public static void createShortcutForFile(string filename)
        {
            //VaultProFunctions.AddFileIntoVault(filename);

            //VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
            //Table tableTBL = VM_ProjectExplorerDLG.FileListPANE;
            //RECT rect = tableTBL.GetRect(true);
            //tableTBL.Click(MouseButton.Left, rect.xSize / 2, rect.ySize / 2);
            //tableTBL.TypeKeys("<Ctrl-A>");
            //System.Threading.Thread.Sleep(1500);
            //switch (Product.Variables.Language.ToUpper())
            //{
            //    //case "ITA":
            //    //case "PLK":
            //    //case "DEU":
            //    //case "FRA":
            //    //case "ESP":
            //    //    VaultProFunctions.Pick(VM_ProjectExplorerDLG, "actions");
            //    //    Desktop.Current.TypeKeys("<Up 4><Right><Enter>", 250);
            //    //    break;
            //    default:
            //        //VaultProFunctions.Pick(VM_ProjectExplorerDLG, "actions", "createshortcut", "distributedshortcut");
            //        VaultProFunctions.Pick(VM_ProjectExplorerDLG, "actions");
            //        Desktop.Current.TypeKeys("<Up 4><Right><Enter>", 250);
            //        break;
            //}
            //System.Threading.Thread.Sleep(1500);
        }


        public static void Pick(Window wCurrWin, string sMenu, string sSubmenu = null, string sSubmenu1 = null)
        {
            string sMenuItem, sScut, sSubMenuItem, sSubKey, sSubKey1;
            sScut = "";
            sSubKey = "";
            sSubKey1 = "";
            switch (sMenu.ToLower())
            {
                case "file":
                    sMenuItem = Plant3DMainWin.cBabel(321, 100, "&File");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "exit":
                                sSubMenuItem = Plant3DMainWin.cBabel(321, 119, "E&xit");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "logout":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 3, "Lo&g Out");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "new":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 4, "&New...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);

                                if ((sSubmenu1 != null))
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "newchangeorder":
                                            sSubMenuItem = Plant3DMainWin.cBabel(1, 9, "New &Change Order...");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        case "newitem":
                                            sSubMenuItem = Plant3DMainWin.cBabel(1, 10, "New &Item...");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "savesearch":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 5, "&Save Search");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "managesavedsearches":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 6, "&Manage Saved Searches...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "opensearch":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 7, "Open Searc&h...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "savesearchas":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 20, "Save Search &As...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "addfiles":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 8, "&Add Files...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "plot":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 11, "Plo&t...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "printpreview":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 12, "Print Pre&view");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "packandgo":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 13, "Pac&k and Go...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "userprofile":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 14, "User P&rofile...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "filecontrol":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 15, "Fi&le Control");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                if ((sSubmenu1 != null))
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "removereservation":
                                            sSubMenuItem = Plant3DMainWin.cBabel(1, 16, "Remove &Reservation");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "setworkingfolder":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 17, "Set &Working Folder...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "send":
                                sSubMenuItem = Plant3DMainWin.cBabel(1, 18, "Sen&d");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                if ((sSubmenu1 != null))
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "sendfile":
                                            sSubMenuItem = Plant3DMainWin.cBabel(1, 19, "Send &File...");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "edit":
                    sMenuItem = Plant3DMainWin.cBabel(2, 1, "&Edit");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "rename":
                                sSubMenuItem = Plant3DMainWin.cBabel(2, 2, "&Rename...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "purge":
                                sSubMenuItem = Plant3DMainWin.cBabel(2, 3, "&Purge...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "copydesign":
                                sSubMenuItem = Plant3DMainWin.cBabel(2, 4, "&Copy Design...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "view":
                    sMenuItem = Plant3DMainWin.cBabel(3, 1, "&View");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "customizeview":
                                sSubMenuItem = Plant3DMainWin.cBabel(3, 2, "&Customize View...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "viewpropertiesgrid":
                                sSubMenuItem = Plant3DMainWin.cBabel(3, 3, "View &Properties Grid");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "tools":
                    sMenuItem = Plant3DFunctions.GetLocString("Tools"); 
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "administration":
                                sSubMenuItem = Plant3DFunctions.GetLocString("Administration");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                if ((sSubmenu1 != null))
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "vaultsettings":
                                            sSubMenuItem = Plant3DMainWin.cBabel(4, 3, "&Vault Settings");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        case "globalsettings":
                                            sSubMenuItem = Plant3DFunctions.GetLocString("GlobalSettings");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default: break;
                                    }
                                }
                                break;
                            case "labels":
                                sSubMenuItem = Plant3DMainWin.cBabel(4, 5, "&Labels...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "customize":
                                sSubMenuItem = Plant3DMainWin.cBabel(4, 6, "&Customize");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "options":
                                sSubMenuItem = Plant3DFunctions.GetLocString("Options");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "actions":
                    sMenuItem = Plant3DMainWin.cBabel(5, 1, "&Actions");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "changestate":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 2, "Cha&nge State...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "printchangeordersummary":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 3, "&Print Change Order Summary...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "respond":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 4, "&Respond");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                if (sSubmenu1 != null)
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "submit":
                                            sSubMenuItem = Plant3DMainWin.cBabel(5, 5, "Su&bmit");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        case "submitandforceapproval":
                                            sSubMenuItem = Plant3DMainWin.cBabel(5, 6, "Submit and Force Appro&val");//add in 2012
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        case "fasttrackapproval":
                                            sSubMenuItem = Plant3DMainWin.cBabel(5, 7, "Fast Trac&k Approval");//add in 2012
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        case "reviewcomment":
                                            sSubMenuItem = Plant3DMainWin.cBabel(5, 8, "Review Co&mment");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "checkin":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 9, "Check &In...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "rollbacklifecyclestatechange":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 10, "Ro&ll Back Lifecycle State Change...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "exportitems":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 11, "Expor&t Items...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "importitems":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 12, "I&mport Items...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "assign/updateitem":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 13, "&Assign Item...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "changerevision":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 14, "Change Re&vision...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "undocheckout":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 15, "&Undo Check Out...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "changecategory":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 16, "Change Categor&y...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "createshortcut":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 17, "Create &Shortcut");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                if (sSubmenu1 != null)
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "distributedshortcut":
                                            sSubMenuItem = Plant3DMainWin.cBabel(5, 24, "&Distributed Shortcut");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "attachments":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 18, "A&ttachments...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "viewinwindow":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 19, "Vi&ew in Window...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "rollbacklifecyclestatechangefile":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 20, "R&oll Back Lifecycle State Change...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "updateview":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 21, "Up&date View");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                if (sSubmenu1 != null)
                                {
                                    switch (sSubmenu1.ToLower())
                                    {
                                        case "updatelocally":
                                            sSubMenuItem = Plant3DMainWin.cBabel(5, 22, "Update &Locally");
                                            sSubKey1 = GetMenuShortCut(sSubMenuItem);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "updatefilereference":
                                sSubMenuItem = Plant3DMainWin.cBabel(5, 23, "Update File &Reference");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "help":
                    sMenuItem = Plant3DMainWin.cBabel(6, 1, "&Help");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "aboutautodeskvaultprofessional":
                                sSubMenuItem = Plant3DMainWin.cBabel(6, 2, "&About Autodesk Vault Professional");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "filepm":
                    sMenuItem = Plant3DMainWin.cBabel(25, 7, "&File");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "savetovaultpm":
                                sSubMenuItem = Plant3DMainWin.cBabel(25, 6, "Save &To Vault...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "editpm":
                    sMenuItem = Plant3DMainWin.cBabel(25, 1, "&Edit");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "optionspm":
                                sSubMenuItem = Plant3DMainWin.cBabel(25, 2, "&Options...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "actionspm":
                    sMenuItem = Plant3DMainWin.cBabel(25, 3, "&Actions");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "addfilespm":
                                sSubMenuItem = Plant3DMainWin.cBabel(25, 4, "Add &Files...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "addrelatedfilesheetspm":
                                sSubMenuItem = Plant3DMainWin.cBabel(25, 5, "Add Related Fi&le Sheets...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;

                            default: break;
                        }
                    }
                    break;
                case "filejb":
                    sMenuItem = Plant3DMainWin.cBabel(30, 1, "&File");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "exitjb":
                                sSubMenuItem = Plant3DMainWin.cBabel(30, 2, "E&xit");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "pausejb":
                                sSubMenuItem = Plant3DMainWin.cBabel(30, 5, "&Pause");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "administrationjb":
                    sMenuItem = Plant3DMainWin.cBabel(30, 3, "&Administration");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "settingsjb":
                                sSubMenuItem = Plant3DMainWin.cBabel(30, 4, "S&ettings...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "jobtypesjb":
                                sSubMenuItem = Plant3DMainWin.cBabel(30, 6, "&Job Types...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "helpjb":
                    sMenuItem = Plant3DMainWin.cBabel(30, 7, "&Help");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "aboutjobprocessorjb":
                                sSubMenuItem = Plant3DMainWin.cBabel(30, 8, "&About Job Processor");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "helpcd":
                    sMenuItem = Plant3DMainWin.cBabel(33, 1, "&Help");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "aboutcd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 2, "&About...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "optionscd":
                    sMenuItem = Plant3DMainWin.cBabel(33, 3, "&Options");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "actionrulescd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 4, "&Action Rules");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "numberingschemescd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 5, "&Numbering Schemes");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "filecd":
                    sMenuItem = Plant3DMainWin.cBabel(33, 6, "&File");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "addfilescd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 7, "&Add Files...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "executecopycd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 10, "&Execute Copy");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            case "exportcd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 11, "Ex&port...");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
                case "viewcd":
                    sMenuItem = Plant3DMainWin.cBabel(33, 8, "&View");
                    sScut = GetMenuShortCut(sMenuItem);
                    if (sSubmenu != null)
                    {
                        switch (sSubmenu.ToLower())
                        {
                            case "panelscd":
                                sSubMenuItem = Plant3DMainWin.cBabel(33, 9, "&Panels");
                                sSubKey = GetMenuShortCut(sSubMenuItem);
                                break;
                            default: break;
                        }
                    }
                    break;
            }

            if (Product.Variables.Language.ToLower() == "rus")//"Rus"
            {
                if (sScut != "")
                {
                    sScut = GetRusstring(sScut);
                }
                if (sSubKey != "")
                {
                    sSubKey = GetRusstring(sSubKey);
                }
                if (sSubKey1 != "")
                {
                    sSubKey1 = GetRusstring(sSubKey1);
                }

                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = Product.Variables.TestFilesDir + "Keyboard.exe";
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.Arguments = "rus";
                Process.Start(info);
                System.Threading.Thread.Sleep(1000);
            }

            if (wCurrWin.Name != "JobProcessorDLG")
            {
                if (!string.IsNullOrEmpty(sScut))
                {
                    if (!string.IsNullOrEmpty(sSubKey))
                    {
                        if (!string.IsNullOrEmpty(sSubKey1))
                        {
                            wCurrWin.TypeKeys("<Alt" + "-" + sScut + "-" + sSubKey + "-" + sSubKey1 + ">", 250);
                        }
                        else
                        {
                            wCurrWin.TypeKeys("<Alt" + "-" + sScut + "-" + sSubKey + ">", 250);
                        }
                    }
                    else
                    {
                        wCurrWin.TypeKeys("<Alt" + "-" + sScut + ">", 250);
                    }
                }
            }
            else
            {
                JobProcessorDLG JobProcessorDLG = new JobProcessorDLG();
                JobProcessorDLG.SetActive();
                if (!string.IsNullOrEmpty(sScut))
                {
                    if (!string.IsNullOrEmpty(sSubKey))
                    {
                        if (!string.IsNullOrEmpty(sSubKey1))
                        {
                            JobProcessorDLG.TypeKeys("<Alt" + "-" + sScut + "-" + sSubKey + "-" + sSubKey1 + ">", 250);
                        }
                        else
                        {
                            JobProcessorDLG.TypeKeys("<Alt" + "-" + sScut + "-" + sSubKey + ">", 250);
                        }
                    }
                    else
                    {
                        JobProcessorDLG.TypeKeys("<Alt" + "-" + sScut + ">", 250);
                    }
                }
            }

            if (Product.Variables.Language.ToLower() == "rus")
            {
                System.Threading.Thread.Sleep(1000);
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = Product.Variables.TestFilesDir + "Keyboard.exe";
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.Arguments = "enu";
                Process.Start(info);
                System.Threading.Thread.Sleep(1000);
            }
        }


        public static string GetMenuShortCut(string sMenuItem)
        {
            int iPos;
            string sSkey;
            iPos = sMenuItem.IndexOf("&");
            sSkey = sMenuItem.Substring(iPos + 1, 1);
            return (sSkey);
        }


        public static string GetRusstring(string sRusstring)
        {
            string sFile = Product.Variables.ProductToolsDir + "\\EDM_Mapping.txt";
            FileStream hFile = new FileStream(sFile, FileMode.Open);
            string sLine;
            string sEnustring = "";
            StreamReader hReader = new StreamReader(hFile);
            sLine = hReader.ReadLine();
            bool bCont = true;

            while (bCont)
            {
                if (sLine.Contains(sRusstring.ToLower()))
                {
                    sEnustring = sLine.Substring(2, 1);
                    break;
                }
                sLine = hReader.ReadLine();
                if (hReader.EndOfStream)
                {
                    bCont = false;
                }
            }
            hReader.Close();
            hFile.Close();
            if (sEnustring == "")
            {
                return sRusstring;
            }
            else
            {
                return sEnustring;
            }
        }


        public static void LoginWithUserAndDataBase(string user, string database)
        {
            VC_LogInDLG VC_LogInDLG = new VC_LogInDLG();
            if (!VC_LogInDLG.WaitExists(2000))
            {
                VC_LogInDLG.Invoke();
                VC_LogInDLG.LoginTypePL.Select(1);
            }

            VC_LogInDLG.SetActive();
            if (user.ToLower() == "admin")
            {
                VC_LogInDLG.UserNameTF.SetText(GetLoginVaultUser(false));
            }
            else if (user.ToLower() == "noadmin")
            {
                VC_LogInDLG.UserNameTF.SetText(GetLoginVaultUser(true));
            }

            try
            {
                VC_LogInDLG.ServerCB.Select(0);
            }
            catch
            {
            }

            VC_LogInDLG.DatabaseCB.Click(MouseButton.Left, 20, 10);
            VC_LogInDLG.DatabaseCB.TypeKeys("<Ctrl-A><Delete>");
            if (database.ToLower() == "vault")
            {
                VC_LogInDLG.DatabaseCB.SetText(GetLoginVaultDatabase(false));
            }
            else if (database.ToLower() == "facvault")
            {
                VC_LogInDLG.DatabaseCB.SetText(GetLoginVaultDatabase(true));
            }
            //VC_LogInDLG.DatabasePB.Click();
            //System.Threading.Thread.Sleep(2500);
            //VC_DatabaseListFormDLG VC_DatabaseListFormDLG = new VC_DatabaseListFormDLG();
            //if (database.ToLower() == "vault")
            //{
            //    VC_DatabaseListFormDLG.SelectAVaultFromLB.Select(GetLoginVaultDatabase(false));
            //}
            //else if (database.ToLower() == "facvault")
            //{
            //    VC_DatabaseListFormDLG.SelectAVaultFromLB.Select(GetLoginVaultDatabase(true));
            //}
            //VC_DatabaseListFormDLG.OKPB.Click();
            System.Threading.Thread.Sleep(1500);
            VC_LogInDLG.OKPB.Click();
            VC_LogInErrorDLG VC_LogInErrorDLG = new VC_LogInErrorDLG();
            if (VC_LogInErrorDLG.WaitExists(2500))
            {
                VC_LogInErrorDLG.OKPB.Click();
                VC_LogInDLG VC_LogInDLG1 = new VC_LogInDLG();
                VC_LogInDLG1.PasswordTF.Click(MouseButton.Left, 10, 10);
                VC_LogInDLG.PasswordTF.TypeKeys("<Ctrl-A><Delete>");
                VC_LogInDLG1.PasswordTF.SetText(adminTempPassword);
                System.Threading.Thread.Sleep(1500);
                VC_LogInDLG.OKPB.Click();
            }
            System.Threading.Thread.Sleep(25000);
            VM_ProjectExplorerDLG VM_ProjectExplorerDLG = new VM_ProjectExplorerDLG();
            VM_ProjectExplorerDLG.Invoke();
        }


        public static string GetAdministratorLocal()
        {
            string localName;
            switch (Product.Variables.Language.ToUpper())
            {
                case "RUS":
                    localName = "Администратор";
                    break;
                case "FRA":
                    localName = "Administrateur";
                    break;
                case "ESP":
                    localName = "Administrador";
                    break;
                case "PTB":
                    localName = "Administrador";
                    break;
                case "ITA":
                    localName = "Amministratore";
                    break;
                case "CSY":
                    localName = "Správce";
                    break;
                case "HUN":
                    localName = "Rendszergazda";
                    break;
                default:
                    localName = "Administrator";
                    break;
            }
            return localName;
        }

  

        public static string GetLoginVaultUser(bool nonadmin)
        {
            string loginuser = GetAdministratorLocal(); 
            if (nonadmin)
            {
                loginVaultUser = "Non-administrator";
                loginuser = "Non-administrator";
            }
            if (!nonadmin)
            {
                loginVaultUser = GetAdministratorLocal();
                loginuser = GetAdministratorLocal();
            }

            return loginuser;      
        }



        public static string GetLoginVaultDatabase(bool factory)
        {
            string logindatabse = "Vault";
            if (factory)
            {
                loginVaultDatabase = "FACTVault";
                logindatabse = "FACTVault";
            }
            if (!factory)
            {
                loginVaultDatabase = "Vault";
                logindatabse = "Vault";
            }

            return logindatabse;
        }


        public static string GetLicense()
        {
            string lincense = "";
            string inputFile = LAGT.CommonFiles.Core.Variables.FrameworkDir + "LAGT-APP\\Inputs.ini";
            StreamReader inputFileSR = new StreamReader(inputFile);
            while (!inputFileSR.EndOfStream)
            {
                string sLine = inputFileSR.ReadLine();
                if (sLine.Contains("License"))
                {
                    lincense = sLine.Replace("License=", "");
                    break;
                }
            }
            inputFileSR.Close();
            return lincense;
        }


        public static string getVaultServerDataFolder()
        {
            string path = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Autodesk\\PLM\\" + getVaultServerCurVersion() + "\\Install";
            string VaultServerDataFolder = Registry.GetValue(path, "VAULTSERVERDATAFOLDER", "").ToString();

            if (!VaultServerDataFolder.EndsWith("\\"))
                VaultServerDataFolder += "\\";

            return VaultServerDataFolder;
        }



        public static string getVaultServerCurVersion()
        {
            return Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Autodesk\\PLM", "CurVersion", "").ToString();
        }



        public static string getComputerName()
        {
            return Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "Hostname", "").ToString();
        }


        public static string getInventorViewDefaultProjct()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Autodesk\Inventor\" + getInventorViewVersion() + @"\System\Preferences\ExternalReferences", "PathFile", "").ToString();
        }


        public static string getInventorViewVersion()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Autodesk\Inventor\Current Version", "RegistryVersion", "").ToString();
        }

       

        //Class for DlgboxBabel metadata.
        public class DlgboxBabel
        {
            public string DlgName { get; set; }  //Name of Dlg/TC
            public string ENU { get; set; }      //ENU
            public string JPN { get; set; }      //JPN
            public string DEU { get; set; }      //DEU
            public string FRA { get; set; }      //FRA
            public string CHS { get; set; }      //CHS
            public string ITA { get; set; }      //ITA
            public string CHT { get; set; }      //CHT
            public string ESP { get; set; }      //ESP
            public string KOR { get; set; }      //KOR
            public string RUS { get; set; }      //RUS
            public string CSY { get; set; }      //CSY
            public string PLK { get; set; }      //PLK
            public string PTB { get; set; }      //PTB
            public string HUN { get; set; }      //HUN
        }

        public static string GetLocString(string dlgboxName)
        {
            string locString = null;
            string reCapBabelJsonFile = Product.Variables.TestFilesDir.Replace("TestFiles", "Core") + "VaultPro.json";
            List<DlgboxBabel> ltDlgboxBabel = new List<DlgboxBabel>();

            ltDlgboxBabel = LoadJson(reCapBabelJsonFile);
            for (int i = 0; i < ltDlgboxBabel.Count; i++)
            {
                if (ltDlgboxBabel[i].DlgName == dlgboxName)
                {
                    switch (Product.Variables.Language)
                    {
                        case "ENU":
                            locString = ltDlgboxBabel[i].ENU;
                            break;
                        case "JPN":
                            locString = ltDlgboxBabel[i].JPN;
                            break;
                        case "DEU":
                            locString = ltDlgboxBabel[i].DEU;
                            break;
                        case "FRA":
                            locString = ltDlgboxBabel[i].FRA;
                            break;
                        case "CHS":
                            locString = ltDlgboxBabel[i].CHS;
                            break;
                        case "ITA":
                            locString = ltDlgboxBabel[i].ITA;
                            break;
                        case "CHT":
                            locString = ltDlgboxBabel[i].CHT;
                            break;
                        case "ESP":
                            locString = ltDlgboxBabel[i].ESP;
                            break;
                        case "KOR":
                            locString = ltDlgboxBabel[i].KOR;
                            break;
                        case "RUS":
                            locString = ltDlgboxBabel[i].RUS;
                            break;
                        case "CSY":
                            locString = ltDlgboxBabel[i].CSY;
                            break;
                        case "PLK":
                            locString = ltDlgboxBabel[i].PLK;
                            break;
                        case "PTB":
                            locString = ltDlgboxBabel[i].PTB;
                            break;
                        case "HUN":
                            locString = ltDlgboxBabel[i].HUN;
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
            return locString;
        }

        public static List<DlgboxBabel> LoadJson(string JSONFile)
        {
            List<DlgboxBabel> dlgboxBabel = new List<DlgboxBabel>();
            try
            {
                using (StreamReader r = new StreamReader(JSONFile))
                {
                    string json = r.ReadToEnd();
                    //JavaScriptSerializer ser = new JavaScriptSerializer();
                    //dlgboxBabel = ser.Deserialize<List<DlgboxBabel>>(json);
                    dlgboxBabel = JsonConvert.DeserializeObject<List<DlgboxBabel>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The JSON file {0} is invalid!", JSONFile);
                Console.WriteLine(e.Message);
            }
            return dlgboxBabel;
        }       
        
    }
}
