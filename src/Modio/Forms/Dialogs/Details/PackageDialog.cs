﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Humanizer;
using Modio.Database;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Models.Database;
using Modio.Models.Resources;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Modio.Forms.Dialogs.Details
{
    public partial class PackageDialog : XtraForm
    {
        public PackageDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public PackageItemData PackageItem;

        private void PackageDialog_Load(object sender, EventArgs e)
        {
            // Display details in UI
            LabelCategory.Text = PackageItem.Category;
            LabelName.Text = PackageItem.Name.Replace("&", "&&");
            LabelTitleIdRegion.Text = $"{PackageItem.TitleId} ({PackageItem.Region})";
            LabelContentId.Text = PackageItem.ContentId;
            LabelModifiedDate.Text = PackageItem.IsDateMissing ? Language.GetString("DATA_MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(PackageItem.ModifiedDate).Humanize() : DateTime.Parse(PackageItem.ModifiedDate).ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
            LabelFileSize.Text = PackageItem.IsSizeMissing ? Language.GetString("DATA_MISSING") : Settings.UseFormattedFileSizes ? long.Parse(PackageItem.Size).Bytes().Humanize("#.##") : PackageItem.Size + " " + Language.GetString("LABEL_BYTES");
            LabelSha256.Text = PackageItem.IsSha256Missing ? Language.GetString("DATA_MISSING") : PackageItem.Sha256;

            LabelHeaderModifiedDate.Text = Language.GetString("LABEL_MODIFIED_DATE");
            LabelHeaderContentId.Text = Language.GetString("LABEL_CONTENT_ID");
            LabelHeaderFileSize.Text = Language.GetString("LABEL_FILE_SIZE");

            ButtonInstall.SetControlText(Language.GetString("LABEL_INSTALL"), 26);
            ButtonDownload.SetControlText(Language.GetString("LABEL_DOWNLOAD"), 26);
        }

        private void ImageCloseDetails_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuActions_BeforePopup(object sender, CancelEventArgs e)
        {
            if (PackageItem != null)
            {
                MenuItemInstallFiles.Enabled = Settings.InstallPackagesToUsbDevice | MainWindow.IsConsoleConnected;
            }
        }

        private void MenuItemInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowTransferPackagesDialog(this, TransferType.InstallPackage, PackageItem);
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferPackagesDialog(this, TransferType.DownloadPackage, PackageItem);
        }

        private void ButtonFaq_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowPackagesFaqDialog(this);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}