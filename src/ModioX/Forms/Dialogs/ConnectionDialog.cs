﻿using DevExpress.XtraEditors;
using ModioX.Controls;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class ConnectionDialog : XtraForm
    {
        public ConnectionDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        /// <summary>
        /// Get the user's console profile data.
        /// </summary>
        public ConsoleProfile ConsoleProfile { get; private set; }

        /// <summary>
        /// G
        /// </summary>
        public TileConsoleItem SelectedConsole { get; private set; }

        private void ConnectConsole_Load(object sender, EventArgs e)
        {
            LoadConsoles();
        }

        private void ConnectionDialogTest_SizeChanged(object sender, EventArgs e)
        {
            UpdateScrollBar();
        }

        private void LoadConsoles()
        {
            PanelConsoleProfiles.Controls.Clear();
            SelectedConsole = null;

            int consoleIndex = 0;

            foreach (ConsoleProfile consoleProfile in Settings.ConsoleProfiles)
            {
                Image consoleImage = consoleImage = Properties.Resources.PlayStation3Fat;

                switch (consoleProfile.Type)
                {
                    case ConsoleType.PlayStation3Fat:
                        consoleImage = Properties.Resources.PlayStation3Fat;
                        break;

                    case ConsoleType.PlayStation3Slim:
                        consoleImage = Properties.Resources.PlayStation3Slim;
                        break;

                    case ConsoleType.PlayStation3SuperSlim:
                        consoleImage = Properties.Resources.PlayStation3Slim;
                        break;

                    case ConsoleType.Xbox360FatWhite:
                        consoleImage = Properties.Resources.XboxFat;
                        break;

                    case ConsoleType.Xbox360EliteFatBlack:
                        consoleImage = Properties.Resources.XboxFatElite;
                        break;

                    case ConsoleType.Xbox360Slim:
                        consoleImage = Properties.Resources.XboxSlim;
                        break;

                    case ConsoleType.Xbox360SlimE:
                        consoleImage = Properties.Resources.XboxSlimE;
                        break;
                }

                TileConsoleItem consoleItem = new(consoleProfile.Name, consoleImage) { ConsoleProfile = consoleProfile };
                consoleItem.OnClick += new EventHandler(ConsoleItem_Click);
                PanelConsoleProfiles.Controls.Add(consoleItem);
                consoleIndex++;
            }
        }

        private void ConsoleItem_Click(object sender, EventArgs e)
        {
            ResetConsoleItems();

            Control SelectedItem;

            if (((Control)sender) is not TileConsoleItem)
            {
                SelectedItem = ((Control)sender).Parent;
            }
            else
            {
                SelectedItem = (Control)sender as TileConsoleItem;
            }

            SelectedConsole = SelectedItem as TileConsoleItem;
            SelectedConsole.IsSelected = true;

            ConsoleProfile = SelectedConsole.ConsoleProfile;

            ButtonEdit.Enabled = ConsoleProfile != null;
            ButtonDelete.Enabled = ConsoleProfile != null;
            ButtonConnect.Enabled = ConsoleProfile != null;

            if (ConsoleProfile != null)
            {
                ButtonConnect.Focus();
            }
        }

        private void ResetConsoleItems()
        {
            foreach (object ctrl in PanelConsoleProfiles.Controls)
            {
                TileConsoleItem item = ctrl as TileConsoleItem;
                item.IsSelected = false;
            }
        }

        private void ButtonAddNewConsole_Click(object sender, EventArgs e)
        {
            ConsoleProfile consoleProfile = DialogExtensions.ShowNewConnectionWindow(this, new ConsoleProfile(), false);

            if (consoleProfile != null)
            {
                Settings.ConsoleProfiles.Add(consoleProfile);
                MainWindow.Window.SaveSettings();
                MainWindow.Window.LoadSettings();
                LoadConsoles();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Settings.ConsoleProfiles.Count == 1)
            {
                XtraMessageBox.Show("You must have at least one console saved.", "Cannot Delete");
            }
            else
            {
                if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Settings.ConsoleProfiles.Remove(ConsoleProfile);
                    LoadConsoles();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = Settings.ConsoleProfiles.IndexOf(ConsoleProfile);
            ConsoleProfile oldConsoleProfile = Settings.ConsoleProfiles[selectedIndex];

            ConsoleProfile newConsoleProfile = DialogExtensions.ShowNewConnectionWindow(this, oldConsoleProfile, true);

            Settings.ConsoleProfiles[selectedIndex] = newConsoleProfile;

            LoadConsoles();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelConsoleProfiles_ControlAddedOrRemoved(object sender, ControlEventArgs e)
        {
            UpdateScrollBar();
        }

        private void PanelConsoleProfiles_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarConsoleProfiles.Value = PanelConsoleProfiles.VerticalScroll.Value;
        }

        private void ScrollBarConsoleProfiles_Scroll(object sender, ScrollEventArgs e)
        {
            PanelConsoleProfiles.VerticalScroll.Value = ScrollBarConsoleProfiles.Value;
            PanelConsoleProfiles.Refresh();
        }

        private void UpdateScrollBar()
        {
            ScrollBarConsoleProfiles.Visible = PanelConsoleProfiles.VerticalScroll.Visible;
            ScrollBarConsoleProfiles.Minimum = PanelConsoleProfiles.VerticalScroll.Minimum;
            ScrollBarConsoleProfiles.Maximum = PanelConsoleProfiles.VerticalScroll.Maximum;
            ScrollBarConsoleProfiles.SmallChange = PanelConsoleProfiles.VerticalScroll.SmallChange;
            ScrollBarConsoleProfiles.LargeChange = PanelConsoleProfiles.VerticalScroll.LargeChange;
            ScrollBarConsoleProfiles.Value = PanelConsoleProfiles.VerticalScroll.Value;
        }
    }
}