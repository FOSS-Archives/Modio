﻿
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Tools.XBOX
{
    partial class GameSaveResigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSaveResigner));
            this.GroupGameSave = new DevExpress.XtraEditors.GroupControl();
            this.ImageContent = new DevExpress.XtraEditors.PictureEdit();
            this.LabelHeaderTitleId = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxTitleId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxDeviceId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxProfileId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxConsoleId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxTitleName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.ImagePackage = new DevExpress.XtraEditors.PictureEdit();
            this.LabelHeaderDeviceId = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderProfileId = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderConsoleId = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTitleName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderDisplayName = new DevExpress.XtraEditors.LabelControl();
            this.ImageBackground = new DevExpress.XtraEditors.PictureEdit();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.PopupImage = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemExtract = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemReplace = new DevExpress.XtraBars.BarButtonItem();
            this.MenuMain = new DevExpress.XtraBars.Bar();
            this.MenuButtonFile = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuFile = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemLoadFile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemSaveFile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemSaveToDevice = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemNoDeviceFound = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonProfile = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuProfile = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemAddProfileDetails = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemAddExistingProfile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemAddProfileFromConsole = new DevExpress.XtraBars.BarButtonItem();
            this.MenuStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameSave)).BeginInit();
            this.GroupGameSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDeviceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxProfileId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsoleId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackground.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupGameSave
            // 
            this.GroupGameSave.Controls.Add(this.ImageContent);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTitleId);
            this.GroupGameSave.Controls.Add(this.TextBoxTitleId);
            this.GroupGameSave.Controls.Add(this.TextBoxDeviceId);
            this.GroupGameSave.Controls.Add(this.TextBoxProfileId);
            this.GroupGameSave.Controls.Add(this.TextBoxConsoleId);
            this.GroupGameSave.Controls.Add(this.TextBoxTitleName);
            this.GroupGameSave.Controls.Add(this.TextBoxDisplayName);
            this.GroupGameSave.Controls.Add(this.ImagePackage);
            this.GroupGameSave.Controls.Add(this.LabelHeaderDeviceId);
            this.GroupGameSave.Controls.Add(this.LabelHeaderProfileId);
            this.GroupGameSave.Controls.Add(this.LabelHeaderConsoleId);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTitleName);
            this.GroupGameSave.Controls.Add(this.LabelHeaderDisplayName);
            this.GroupGameSave.Controls.Add(this.ImageBackground);
            this.GroupGameSave.Location = new System.Drawing.Point(12, 39);
            this.GroupGameSave.Name = "GroupGameSave";
            this.GroupGameSave.Padding = new System.Windows.Forms.Padding(10);
            this.GroupGameSave.Size = new System.Drawing.Size(516, 186);
            this.GroupGameSave.TabIndex = 11;
            this.GroupGameSave.Text = "Games Save";
            // 
            // ImageContent
            // 
            this.ImageContent.Location = new System.Drawing.Point(428, 39);
            this.ImageContent.Name = "ImageContent";
            this.ImageContent.Properties.AllowFocused = false;
            this.ImageContent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageContent.Properties.NullText = " ";
            this.ImageContent.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageContent.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageContent.Size = new System.Drawing.Size(68, 68);
            this.ImageContent.TabIndex = 14;
            // 
            // LabelHeaderTitleId
            // 
            this.LabelHeaderTitleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTitleId.Appearance.Options.UseFont = true;
            this.LabelHeaderTitleId.Location = new System.Drawing.Point(341, 125);
            this.LabelHeaderTitleId.Name = "LabelHeaderTitleId";
            this.LabelHeaderTitleId.Size = new System.Drawing.Size(39, 15);
            this.LabelHeaderTitleId.TabIndex = 18;
            this.LabelHeaderTitleId.Text = "Title ID:";
            // 
            // TextBoxTitleId
            // 
            this.TextBoxTitleId.EditValue = "";
            this.TextBoxTitleId.Location = new System.Drawing.Point(390, 122);
            this.TextBoxTitleId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTitleId.Name = "TextBoxTitleId";
            this.TextBoxTitleId.Properties.AllowFocused = false;
            this.TextBoxTitleId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxTitleId.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBoxTitleId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTitleId.Properties.Appearance.Options.UseBackColor = true;
            this.TextBoxTitleId.Properties.Appearance.Options.UseFont = true;
            this.TextBoxTitleId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBoxTitleId.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.TextBoxTitleId.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBoxTitleId.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TextBoxTitleId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TextBoxTitleId.Properties.MaxLength = 8;
            this.TextBoxTitleId.Properties.NullValuePrompt = "None";
            this.TextBoxTitleId.Properties.ReadOnly = true;
            this.TextBoxTitleId.Size = new System.Drawing.Size(115, 22);
            this.TextBoxTitleId.TabIndex = 17;
            // 
            // TextBoxDeviceId
            // 
            this.TextBoxDeviceId.Location = new System.Drawing.Point(109, 122);
            this.TextBoxDeviceId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDeviceId.Name = "TextBoxDeviceId";
            this.TextBoxDeviceId.Properties.AllowFocused = false;
            this.TextBoxDeviceId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxDeviceId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDeviceId.Properties.Appearance.Options.UseFont = true;
            this.TextBoxDeviceId.Properties.MaxLength = 40;
            this.TextBoxDeviceId.Properties.NullValuePrompt = "None";
            this.TextBoxDeviceId.Size = new System.Drawing.Size(222, 22);
            this.TextBoxDeviceId.TabIndex = 7;
            // 
            // TextBoxProfileId
            // 
            this.TextBoxProfileId.Location = new System.Drawing.Point(109, 92);
            this.TextBoxProfileId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxProfileId.Name = "TextBoxProfileId";
            this.TextBoxProfileId.Properties.AllowFocused = false;
            this.TextBoxProfileId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxProfileId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfileId.Properties.Appearance.Options.UseFont = true;
            this.TextBoxProfileId.Properties.MaxLength = 16;
            this.TextBoxProfileId.Properties.NullValuePrompt = "None";
            this.TextBoxProfileId.Size = new System.Drawing.Size(222, 22);
            this.TextBoxProfileId.TabIndex = 6;
            // 
            // TextBoxConsoleId
            // 
            this.TextBoxConsoleId.Location = new System.Drawing.Point(109, 152);
            this.TextBoxConsoleId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxConsoleId.Name = "TextBoxConsoleId";
            this.TextBoxConsoleId.Properties.AllowFocused = false;
            this.TextBoxConsoleId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxConsoleId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsoleId.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConsoleId.Properties.MaxLength = 10;
            this.TextBoxConsoleId.Properties.NullValuePrompt = "None";
            this.TextBoxConsoleId.Size = new System.Drawing.Size(222, 22);
            this.TextBoxConsoleId.TabIndex = 8;
            // 
            // TextBoxTitleName
            // 
            this.TextBoxTitleName.Location = new System.Drawing.Point(109, 62);
            this.TextBoxTitleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTitleName.Name = "TextBoxTitleName";
            this.TextBoxTitleName.Properties.AllowFocused = false;
            this.TextBoxTitleName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxTitleName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTitleName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxTitleName.Properties.NullValuePrompt = "None";
            this.TextBoxTitleName.Size = new System.Drawing.Size(222, 22);
            this.TextBoxTitleName.TabIndex = 5;
            // 
            // TextBoxDisplayName
            // 
            this.TextBoxDisplayName.Location = new System.Drawing.Point(109, 32);
            this.TextBoxDisplayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDisplayName.Name = "TextBoxDisplayName";
            this.TextBoxDisplayName.Properties.AllowFocused = false;
            this.TextBoxDisplayName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDisplayName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxDisplayName.Properties.NullValuePrompt = "None";
            this.TextBoxDisplayName.Size = new System.Drawing.Size(222, 22);
            this.TextBoxDisplayName.TabIndex = 4;
            // 
            // ImagePackage
            // 
            this.ImagePackage.Location = new System.Drawing.Point(350, 39);
            this.ImagePackage.Name = "ImagePackage";
            this.BarManager.SetPopupContextMenu(this.ImagePackage, this.PopupImage);
            this.ImagePackage.Properties.AllowFocused = false;
            this.ImagePackage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImagePackage.Properties.NullText = " ";
            this.ImagePackage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagePackage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImagePackage.Size = new System.Drawing.Size(68, 68);
            this.ImagePackage.TabIndex = 15;
            // 
            // LabelHeaderDeviceId
            // 
            this.LabelHeaderDeviceId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderDeviceId.Appearance.Options.UseFont = true;
            this.LabelHeaderDeviceId.Location = new System.Drawing.Point(13, 125);
            this.LabelHeaderDeviceId.Name = "LabelHeaderDeviceId";
            this.LabelHeaderDeviceId.Size = new System.Drawing.Size(52, 15);
            this.LabelHeaderDeviceId.TabIndex = 12;
            this.LabelHeaderDeviceId.Text = "Device ID:";
            // 
            // LabelHeaderProfileId
            // 
            this.LabelHeaderProfileId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderProfileId.Appearance.Options.UseFont = true;
            this.LabelHeaderProfileId.Location = new System.Drawing.Point(13, 95);
            this.LabelHeaderProfileId.Name = "LabelHeaderProfileId";
            this.LabelHeaderProfileId.Size = new System.Drawing.Size(51, 15);
            this.LabelHeaderProfileId.TabIndex = 10;
            this.LabelHeaderProfileId.Text = "Profile ID:";
            // 
            // LabelHeaderConsoleId
            // 
            this.LabelHeaderConsoleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderConsoleId.Appearance.Options.UseFont = true;
            this.LabelHeaderConsoleId.Location = new System.Drawing.Point(13, 155);
            this.LabelHeaderConsoleId.Name = "LabelHeaderConsoleId";
            this.LabelHeaderConsoleId.Size = new System.Drawing.Size(60, 15);
            this.LabelHeaderConsoleId.TabIndex = 8;
            this.LabelHeaderConsoleId.Text = "Console ID:";
            // 
            // LabelHeaderTitleName
            // 
            this.LabelHeaderTitleName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTitleName.Appearance.Options.UseFont = true;
            this.LabelHeaderTitleName.Location = new System.Drawing.Point(13, 65);
            this.LabelHeaderTitleName.Name = "LabelHeaderTitleName";
            this.LabelHeaderTitleName.Size = new System.Drawing.Size(60, 15);
            this.LabelHeaderTitleName.TabIndex = 6;
            this.LabelHeaderTitleName.Text = "Title Name:";
            // 
            // LabelHeaderDisplayName
            // 
            this.LabelHeaderDisplayName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderDisplayName.Appearance.Options.UseFont = true;
            this.LabelHeaderDisplayName.Location = new System.Drawing.Point(13, 35);
            this.LabelHeaderDisplayName.Name = "LabelHeaderDisplayName";
            this.LabelHeaderDisplayName.Size = new System.Drawing.Size(76, 15);
            this.LabelHeaderDisplayName.TabIndex = 4;
            this.LabelHeaderDisplayName.Text = "Display Name:";
            // 
            // ImageBackground
            // 
            this.ImageBackground.Location = new System.Drawing.Point(342, 32);
            this.ImageBackground.Name = "ImageBackground";
            this.ImageBackground.Properties.AllowFocused = false;
            this.ImageBackground.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ImageBackground.Properties.NullText = " ";
            this.ImageBackground.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageBackground.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageBackground.Size = new System.Drawing.Size(163, 82);
            this.ImageBackground.TabIndex = 19;
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MenuMain,
            this.MenuStatus});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuButtonFile,
            this.MenuItemLoadFile,
            this.MenuItemSaveFile,
            this.LabelHeaderStatus,
            this.LabelStatus,
            this.MenuItemReplace,
            this.MenuItemExtract,
            this.MenuButtonProfile,
            this.MenuItemAddProfileDetails,
            this.MenuItemAddProfileFromConsole,
            this.MenuItemAddExistingProfile,
            this.MenuItemSaveToDevice,
            this.MenuItemNoDeviceFound});
            this.BarManager.MainMenu = this.MenuMain;
            this.BarManager.MaxItemId = 20;
            this.BarManager.StatusBar = this.MenuStatus;
            // 
            // PopupImage
            // 
            this.PopupImage.AutoFillEditorWidth = false;
            this.PopupImage.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupImage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemExtract),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemReplace)});
            this.PopupImage.Manager = this.BarManager;
            this.PopupImage.Name = "PopupImage";
            this.PopupImage.BeforePopup += new System.ComponentModel.CancelEventHandler(this.PopupImage_BeforePopup);
            // 
            // MenuItemExtract
            // 
            this.MenuItemExtract.Caption = "Extract...";
            this.MenuItemExtract.Id = 9;
            this.MenuItemExtract.Name = "MenuItemExtract";
            this.MenuItemExtract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemExtract_ItemClick);
            // 
            // MenuItemReplace
            // 
            this.MenuItemReplace.Caption = "Replace...";
            this.MenuItemReplace.Id = 8;
            this.MenuItemReplace.Name = "MenuItemReplace";
            this.MenuItemReplace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemReplace_ItemClick);
            // 
            // MenuMain
            // 
            this.MenuMain.BarItemHorzIndent = 6;
            this.MenuMain.BarItemVertIndent = 5;
            this.MenuMain.BarName = "Main menu";
            this.MenuMain.DockCol = 0;
            this.MenuMain.DockRow = 0;
            this.MenuMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MenuMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuButtonFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuButtonProfile)});
            this.MenuMain.OptionsBar.AllowQuickCustomization = false;
            this.MenuMain.OptionsBar.DrawBorder = false;
            this.MenuMain.OptionsBar.DrawDragBorder = false;
            this.MenuMain.OptionsBar.MultiLine = true;
            this.MenuMain.OptionsBar.RotateWhenVertical = false;
            this.MenuMain.OptionsBar.UseWholeRow = true;
            this.MenuMain.Text = "Main menu";
            // 
            // MenuButtonFile
            // 
            this.MenuButtonFile.ActAsDropDown = true;
            this.MenuButtonFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonFile.Caption = "FILE";
            this.MenuButtonFile.DropDownControl = this.PopupMenuFile;
            this.MenuButtonFile.Id = 2;
            this.MenuButtonFile.Name = "MenuButtonFile";
            // 
            // PopupMenuFile
            // 
            this.PopupMenuFile.AutoFillEditorWidth = false;
            this.PopupMenuFile.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupMenuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemLoadFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemSaveFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemSaveToDevice)});
            this.PopupMenuFile.Manager = this.BarManager;
            this.PopupMenuFile.Name = "PopupMenuFile";
            this.PopupMenuFile.BeforePopup += new System.ComponentModel.CancelEventHandler(this.PopupMenuFile_BeforePopup);
            // 
            // MenuItemLoadFile
            // 
            this.MenuItemLoadFile.Caption = "Load File...";
            this.MenuItemLoadFile.Id = 3;
            this.MenuItemLoadFile.Name = "MenuItemLoadFile";
            this.MenuItemLoadFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemLoadFile_ItemClick);
            // 
            // MenuItemSaveFile
            // 
            this.MenuItemSaveFile.Caption = "Save File...";
            this.MenuItemSaveFile.Id = 5;
            this.MenuItemSaveFile.Name = "MenuItemSaveFile";
            this.MenuItemSaveFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemSaveFile_ItemClick);
            // 
            // MenuItemSaveToDevice
            // 
            this.MenuItemSaveToDevice.Caption = "Save to Device...";
            this.MenuItemSaveToDevice.Id = 16;
            this.MenuItemSaveToDevice.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemNoDeviceFound)});
            this.MenuItemSaveToDevice.Name = "MenuItemSaveToDevice";
            // 
            // MenuItemNoDeviceFound
            // 
            this.MenuItemNoDeviceFound.Caption = "No Devices Found";
            this.MenuItemNoDeviceFound.Enabled = false;
            this.MenuItemNoDeviceFound.Id = 17;
            this.MenuItemNoDeviceFound.Name = "MenuItemNoDeviceFound";
            this.MenuItemNoDeviceFound.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.MenuItemNoDeviceFound.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // MenuButtonProfile
            // 
            this.MenuButtonProfile.ActAsDropDown = true;
            this.MenuButtonProfile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonProfile.Caption = "PROFILE";
            this.MenuButtonProfile.DropDownControl = this.PopupMenuProfile;
            this.MenuButtonProfile.Id = 10;
            this.MenuButtonProfile.Name = "MenuButtonProfile";
            // 
            // PopupMenuProfile
            // 
            this.PopupMenuProfile.AutoFillEditorWidth = false;
            this.PopupMenuProfile.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupMenuProfile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemAddProfileDetails),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemAddExistingProfile),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemAddProfileFromConsole)});
            this.PopupMenuProfile.Manager = this.BarManager;
            this.PopupMenuProfile.Name = "PopupMenuProfile";
            this.PopupMenuProfile.BeforePopup += new System.ComponentModel.CancelEventHandler(this.PopupMenuProfile_BeforePopup);
            // 
            // MenuItemAddProfileDetails
            // 
            this.MenuItemAddProfileDetails.Caption = "Add Profile Details...";
            this.MenuItemAddProfileDetails.Id = 11;
            this.MenuItemAddProfileDetails.Name = "MenuItemAddProfileDetails";
            this.MenuItemAddProfileDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemAddProfileDetails_ItemClick);
            // 
            // MenuItemAddExistingProfile
            // 
            this.MenuItemAddExistingProfile.Caption = "Add Existing Profile...";
            this.MenuItemAddExistingProfile.Id = 13;
            this.MenuItemAddExistingProfile.Name = "MenuItemAddExistingProfile";
            this.MenuItemAddExistingProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemAddExistingProfile_ItemClick);
            // 
            // MenuItemAddProfileFromConsole
            // 
            this.MenuItemAddProfileFromConsole.Caption = "Add Profile From Console...";
            this.MenuItemAddProfileFromConsole.Id = 12;
            this.MenuItemAddProfileFromConsole.Name = "MenuItemAddProfileFromConsole";
            this.MenuItemAddProfileFromConsole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemAddProfileFromConsole_ItemClick);
            // 
            // MenuStatus
            // 
            this.MenuStatus.BarItemVertIndent = 4;
            this.MenuStatus.BarName = "Status bar";
            this.MenuStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.MenuStatus.DockCol = 0;
            this.MenuStatus.DockRow = 0;
            this.MenuStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MenuStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.MenuStatus.OptionsBar.AllowQuickCustomization = false;
            this.MenuStatus.OptionsBar.DrawDragBorder = false;
            this.MenuStatus.OptionsBar.UseWholeRow = true;
            this.MenuStatus.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 6;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 2;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Idle";
            this.LabelStatus.Id = 7;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(540, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(540, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 214);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(540, 25);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 214);
            // 
            // GameSaveResigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 262);
            this.Controls.Add(this.GroupGameSave);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameSaveResigner.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSaveResigner";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Save Resigner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameSaveResigner_FormClosing);
            this.Load += new System.EventHandler(this.GameSaveResigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameSave)).EndInit();
            this.GroupGameSave.ResumeLayout(false);
            this.GroupGameSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDeviceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxProfileId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsoleId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTitleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBackground.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl GroupGameSave;
        private LabelControl LabelHeaderDisplayName;
        private LabelControl LabelHeaderConsoleId;
        private LabelControl LabelHeaderTitleName;
        private LabelControl LabelHeaderDeviceId;
        private LabelControl LabelHeaderProfileId;
        private PictureEdit ImageContent;
        private PictureEdit ImagePackage;
        private TextEdit TextBoxDeviceId;
        private TextEdit TextBoxProfileId;
        private TextEdit TextBoxConsoleId;
        private TextEdit TextBoxTitleName;
        private TextEdit TextBoxDisplayName;
        private LabelControl LabelHeaderTitleId;
        private TextEdit TextBoxTitleId;
        private PictureEdit ImageBackground;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar MenuMain;
        private DevExpress.XtraBars.Bar MenuStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem MenuButtonFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemLoadFile;
        private DevExpress.XtraBars.PopupMenu PopupMenuFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemSaveFile;
        private DevExpress.XtraBars.BarStaticItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarButtonItem MenuItemReplace;
        private DevExpress.XtraBars.BarButtonItem MenuItemExtract;
        private DevExpress.XtraBars.PopupMenu PopupImage;
        private DevExpress.XtraBars.BarButtonItem MenuButtonProfile;
        private DevExpress.XtraBars.PopupMenu PopupMenuProfile;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileDetails;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileFromConsole;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddExistingProfile;
        private DevExpress.XtraBars.BarSubItem MenuItemSaveToDevice;
        private DevExpress.XtraBars.BarButtonItem MenuItemNoDeviceFound;
    }
}