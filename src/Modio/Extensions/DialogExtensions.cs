﻿using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using Humanizer;
using Modio.Database;
using Modio.Forms.Dialogs;
using Modio.Forms.Dialogs.Details;
using Modio.Forms.Tools.PS3;
using Modio.Forms.Tools.XBOX;
using Modio.Models.Database;
using Modio.Models.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Modio.Extensions
{
    internal static class DialogExtensions
    {
        #region Details

        public static void ShowItemDetailsDialog(Form owner, Platform platform, CategoriesData categories, ModItemData modItem)
        {
            XtraForm detailsDialog = new();

            switch (platform)
            {
                case Platform.PS3:
                    if (modItem.GetCategoryType(categories) == CategoryType.Game)
                    {
                        detailsDialog = new GameModDialog
                        {
                            ModItem = modItem
                        };
                    }
                    else if (modItem.GetCategoryType(categories) == CategoryType.Homebrew)
                    {
                        detailsDialog = new HomebrewDialog
                        {
                            ModItem = modItem
                        };
                    }
                    else if (modItem.GetCategoryType(categories) == CategoryType.Resource)
                    {
                        detailsDialog = new ResourceDialog
                        {
                            ModItem = modItem
                        };
                    }
                    break;

                case Platform.XBOX360:
                    detailsDialog = new PluginDialog
                    {
                        ModItem = modItem
                    };
                    break;

                default:
                    break;

            }

            XtraForm overlayForm = new();
            overlayForm.StartPosition = FormStartPosition.Manual;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = .50d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = owner.Size;
            overlayForm.Location = owner.Location;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show(owner);

            detailsDialog.Owner = owner;
            detailsDialog.ShowDialog();

            //Get rid of the overlay form  
            overlayForm.Dispose();
        }

        public static void ShowItemPackageDetailsDialog(Form owner, PackageItemData packageItem)
        {
            using PackageDialog detailsDialog = new();
            detailsDialog.PackageItem = packageItem;

            XtraForm overlayForm = new();
            overlayForm.StartPosition = FormStartPosition.Manual;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = .50d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = owner.Size;
            overlayForm.Location = owner.Location;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show(owner);

            detailsDialog.Owner = owner;
            detailsDialog.ShowDialog();

            //Get rid of the overlay form  
            overlayForm.Dispose();
        }

        public static void ShowItemGameSaveDetailsDialog(Form owner, GameSaveItemData gameSaveItem)
        {
            using GameSaveDialog detailsDialog = new();
            detailsDialog.GameSaveItem = gameSaveItem;

            XtraForm overlayForm = new();
            overlayForm.StartPosition = FormStartPosition.Manual;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = .50d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = owner.Size;
            overlayForm.Location = owner.Location;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show(owner);

            detailsDialog.Owner = owner;
            detailsDialog.ShowDialog();

            //Get rid of the overlay form  
            overlayForm.Dispose();
        }

        public static void ShowItemGameCheatsDialog(Form owner, GameCheatItemData gameCheatItem)
        {
            using GameCheatsDialog cheatsDialog = new();
            cheatsDialog.GameCheatItem = gameCheatItem;

            XtraForm overlayForm = new();
            overlayForm.StartPosition = FormStartPosition.Manual;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = .50d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = owner.Size;
            overlayForm.Location = owner.Location;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show(owner);

            cheatsDialog.Owner = owner;
            cheatsDialog.ShowDialog();

            //Get rid of the overlay form  
            overlayForm.Dispose();
        }

        #endregion

        public static void ShowDataViewDialog(Form owner, string title, string subtitle, string body)
        {
            using DataViewDialog dataViewDialog = new()
            {
                Text = title
            };

            dataViewDialog.LabelTitle.Text = subtitle;
            dataViewDialog.LabelBody.Text = body;

            dataViewDialog.MaximumSize = new Size(dataViewDialog.MaximumSize.Width, owner.Height + 100);
            dataViewDialog.Size = new Size(dataViewDialog.Width, dataViewDialog.Height + 15);
            dataViewDialog.Owner = owner;
            dataViewDialog.ShowDialog();
        }

        public static ListItem ShowListViewDialog(Form owner, string title, List<ListItem> items)
        {
            using ListViewDialog listViewDialog = new()
            {
                Owner = owner,
                Text = title,
                Items = items
            };

            MethodInvoker dialog = new(() =>
            {
                listViewDialog.ShowDialog();
            });

            if (owner.InvokeRequired)
            {
                owner.Invoke(dialog);
            }
            else
            {
                dialog.Invoke();
            }

            return listViewDialog.SelectedItem ?? null;
        }

        public static string ShowListItemDialog(Form owner, string title, string labelText, string[] items)
        {
            using ComboBoxEdit comboBoxEdit = new();
            comboBoxEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            comboBoxEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.Default;
            comboBoxEdit.Properties.NullValuePrompt = "Select...";
            comboBoxEdit.Properties.Items.AddRange(items);
            comboBoxEdit.SelectedIndex = -1;

            XtraInputBoxArgs args = new();
            args.Owner = owner;
            args.Caption = title;
            args.Prompt = labelText;
            args.DefaultResponse = null;
            args.Editor = comboBoxEdit;

            return (string)XtraInputBox.Show(args);
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText = "", int maxLength = 0)
        {
            using TextEdit textEdit = new();
            textEdit.Text = inputText;
            textEdit.EditValue = inputText;
            textEdit.Properties.MaxLength = maxLength == 0 ? int.MaxValue : maxLength;
            textEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;

            XtraInputBoxArgs args = new();
            args.Owner = owner;
            args.Caption = title;
            args.Prompt = labelText;
            args.DefaultResponse = inputText;
            args.Editor = textEdit;

            return (string)XtraInputBox.Show(args);
        }

        public static string[] ShowMultiTextInputDialog(Form owner, string title, string labelText, string[] inputText = null, int maxLength = 0)
        {
            MemoEdit textEdit = new();
            //textEdit.Text = inputText;
            //textEdit.Properties.LinesCount = 12;
            //textEdit.EditValue = inputText;
            textEdit.Properties.MaxLength = maxLength == 0 ? int.MaxValue : maxLength;
            textEdit.Lines = inputText;

            XtraInputBoxArgs args = new();
            args.Owner = owner;
            args.Caption = title;
            args.Prompt = labelText;
            args.DefaultResponse = null;
            args.Editor = textEdit;

            return (string[])XtraInputBox.Show(args);
        }

        public static int ShowNumberInputDialog(Form owner, string title, string labelText, int inputValue = 0, int maxValue = 0)
        {
            using TextEdit textEdit = new();
            textEdit.EditValue = inputValue;
            textEdit.Properties.Mask.MaskType = MaskType.Numeric;
            textEdit.Properties.MaxLength = maxValue == 0 ? int.MaxValue : maxValue;
            textEdit.Properties.MaskSettings.DataType = typeof(int);

            XtraInputBoxArgs args = new();
            args.Owner = owner;
            args.Caption = title;
            args.Prompt = labelText;
            args.DefaultResponse = null;
            args.Editor = textEdit;

            return (int)XtraInputBox.Show(args);
        }

        public static void ShowTransferModsDialog(Form owner, TransferType transferType, Category category, ModItemData modItem, string region = "")
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                Category = category,
                ModItem = modItem,
                GameRegion = region
            };

            transferDialog.Owner = owner;
            transferDialog.ShowDialog();
        }

        public static void ShowTransferPackagesDialog(Form owner, TransferType transferType, PackageItemData packageItem)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                PackageItem = packageItem
            };

            transferDialog.Owner = owner;
            transferDialog.ShowDialog();
        }

        public static void ShowTransferGameSavesDialog(Form owner, TransferType transferType, Category category, GameSaveItemData gameSaveItem)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                Category = category,
                GameSaveItem = gameSaveItem
            };

            transferDialog.Owner = owner;
            transferDialog.ShowDialog();
        }

        public static DialogResult ShowCustomMessageBox(Form owner, string caption, string text, DialogResult[] results, Icon icon, string cancelButton = "Cancel", string abortButton = "Abort", string okButton = "OK", string yesButton = "Yes", string noButton = "No", string retryButton = "Retry")
        {
            XtraMessageBoxArgs args = new()
            {
                Icon = icon,
                Caption = caption,
                Text = text,
                Buttons = results
            };

            args.DefaultButtonIndex = 0;

            args.Showing += (o, e) =>
            {
                e.Form.Owner = owner;

                foreach (object control in e.Form.Controls)
                {
                    if (control is SimpleButton button)
                    {
                        switch (button.DialogResult.ToString())
                        {
                            case "OK":
                                button.Text = okButton;
                                break;
                            case "Cancel":
                                button.Text = cancelButton;

                                if (button.Text is not "Cancel")
                                {
                                    button.SetControlTextWidth();
                                }

                                break;
                            case "Retry":
                                button.Text = retryButton;
                                break;
                            case "Yes":
                                button.Text = yesButton;
                                break;
                            case "No":
                                button.Text = noButton;
                                break;
                            case "Abort":
                                button.Text = abortButton;
                                break;
                        }

                    }
                }
            };

            return XtraMessageBox.Show(args);
        }

        public static ConsoleProfile ShowConnectionsDialog(Form owner, Platform platform)
        {
            using ConnectionsDialog connectConsole = new() { Platform = platform };
            return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
        }

        public static void ShowEditConnectionsDialog(Form owner, bool isEditing)
        {
            using ConnectionsDialog connectConsole = new() { IsEditing = isEditing };
            connectConsole.ShowDialog(owner);
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditing)
        {
            using NewConnectionDialog newConnectionDialog = new() { ConsoleProfile = consoleProfile, IsEditingProfile = isEditing };

            if (newConnectionDialog.ShowDialog(owner) == DialogResult.OK)
            {
                return newConnectionDialog.ConsoleProfile;
            }

            return isEditing ? consoleProfile : null;
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using XtraFolderBrowserDialog folderBrowser = new() { Description = description, ShowNewFolderButton = true };
            return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
        }

        public static string ShowOpenFileDialog(Form owner, string title, string fileTypes)
        {
            using XtraOpenFileDialog openFileDialog = new() { Title = title, Filter = fileTypes };
            return openFileDialog.ShowDialog(owner) == DialogResult.OK ? openFileDialog.FileName : null;
        }

        public static string ShowSaveFileDialog(Form owner, string title, string fileTypes)
        {
            using XtraSaveFileDialog saveFileDialog = new() { Title = title, Filter = fileTypes };
            return saveFileDialog.ShowDialog(owner) == DialogResult.OK ? saveFileDialog.FileName : null;
        }

        public static SortOptionsDialog ShowSortOptions(Form owner, string sortOption, List<string> sortOptions, ColumnSortOrder sortOrder)
        {
            using SortOptionsDialog sortOptionsDialog = new() { SortOption = sortOption, SortOptions = sortOptions, SortOrder = sortOrder };
            return sortOptionsDialog.ShowDialog(owner) == DialogResult.OK ? sortOptionsDialog : null;
        }

        #region Help

        public static void ShowPackagesFaqDialog(Form owner)
        {
            using PackagesFaqDialog packagesFaqDialog = new();
            packagesFaqDialog.ShowDialog(owner);
        }

        public static void ShowWhatsNewDialog(Form owner, Models.Release_Data.GitHubReleaseData gitHubData)
        {
            try
            {
                string releaseBody = gitHubData.Body;
                string releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

                ShowDataViewDialog(owner, $"{gitHubData.Name} - What's New", $"Change Log ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})", releaseBodyWithoutLastLine.Replace("- ", "• "));
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to get latest release data from GitHub.");
            }
        }

        #endregion

        public static void ShowSubmitModsDialog(Form owner)
        {
            using RequestModsDialog requestModsDialog = new();
            requestModsDialog.ShowDialog(owner);
        }

        #region PS3 Tools

        public static void ShowGameBackupFiles(Form owner)
        {
            using BackupFileManager backupFiles = new();
            backupFiles.ShowDialog(owner);
        }

        public static BackupFile ShowBackupFileDetails(Form owner, BackupFile backupFile)
        {
            using BackupFileDialog backupFileDialog = new() { BackupFile = backupFile };
            return backupFileDialog.ShowDialog(owner) == DialogResult.OK ? backupFileDialog.BackupFile : null;
        }

        public static void ShowConsoleManager(Form owner)
        {
            using ConsoleManager consoleManager = new();
            consoleManager.ShowDialog(owner);
        }

        public static void ShowGameUpdatesFinder(Form owner)
        {
            using GameUpdatesFinder gameUpdatesFinder = new();
            gameUpdatesFinder.ShowDialog(owner);
        }

        public static void ShowPackageManager(Form owner)
        {
            using PackageFileManager packageManager = new();
            packageManager.ShowDialog(owner);
        }

        #endregion

        #region Xbox 360 Tools

        public static void ShowXboxGameLauncher(Form owner)
        {
            using GameLauncher gameLauncher = new();
            gameLauncher.ShowDialog(owner);
        }

        public static void ShowXboxPluginsEditor(Form owner)
        {
            using PluginsEditor pluginsEditor = new();
            pluginsEditor.ShowDialog(owner);
        }

        public static void ShowXboxGameSaveResigner(Form owner)
        {
            using GameSaveResigner gameSaveResigner = new();
            gameSaveResigner.ShowDialog(owner);
        }

        #endregion

        #region Options

        public static void ShowGameRegionsDialog(Form owner)
        {
            using GameRegions gameRegionsDialog = new();
            gameRegionsDialog.ShowDialog(owner);
        }

        #endregion
    }
}