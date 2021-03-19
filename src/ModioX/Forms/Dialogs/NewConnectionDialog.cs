﻿using System;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using ModioX.Properties;

namespace ModioX.Forms.Dialogs
{
    public partial class NewConnectionDialog : XtraForm
    {
        public NewConnectionDialog()
        {
            InitializeComponent();
        }

        public ConsoleProfile ConsoleProfile { get; set; } = new();

        public bool IsEditingProfile { get; set; } = false;

        private void ConsolesWindow_Load(object sender, EventArgs e)
        {
            TextBoxConnectionName.Text = ConsoleProfile.Name;
            ComboBoxConsoleType.SelectedIndex = ComboBoxConsoleType.Properties.Items.IndexOf(ConsoleProfile.Type.GetDescription());
            TextBoxConsoleAddress.Text = ConsoleProfile.Address;
            TextBoxConsolePort.Text = ConsoleProfile.Port.ToString();

            LabelUserPass.Text = ConsoleProfile.UseDefaultCredentials
                ? "Default"
                : ConsoleProfile.Username + " / " + ConsoleProfile.Password;

            TextBoxConnectionName.SelectionStart = 0;
        }

        private void ComboBoxConsoleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxConsoleType.SelectedIndex)
            {
                case 0:
                    ConsoleProfile.Type = ConsoleType.PlayStation3Fat;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.PS3;
                    ImageConsole.Image = Resources.PlayStation3Fat;
                    break;

                case 1:
                    ConsoleProfile.Type = ConsoleType.PlayStation3Slim;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.PS3;
                    ImageConsole.Image = Resources.PlayStation3Slim;
                    break;

                case 2:
                    ConsoleProfile.Type = ConsoleType.PlayStation3SuperSlim;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.PS3;
                    ImageConsole.Image = Resources.PlayStation3SuperSlim;
                    break;

                case 3:
                    ConsoleProfile.Type = ConsoleType.Xbox360FatWhite;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.XBOX;
                    ImageConsole.Image = Resources.XboxFat;
                    break;

                case 4:
                    ConsoleProfile.Type = ConsoleType.Xbox360EliteFatBlack;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.XBOX;
                    ImageConsole.Image = Resources.XboxFatElite;
                    break;

                case 5:
                    ConsoleProfile.Type = ConsoleType.Xbox360Slim;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.XBOX;
                    ImageConsole.Image = Resources.XboxSlim;
                    break;

                case 6:
                    ConsoleProfile.Type = ConsoleType.Xbox360SlimE;
                    ConsoleProfile.TypePrefix = ConsoleTypePrefix.XBOX;
                    ImageConsole.Image = Resources.XboxSlimE;
                    break;
                default:
                    goto case 0;
            }

            TextBoxConsolePort.Text = ConsoleProfile.TypePrefix == ConsoleTypePrefix.PS3 ? "21" : "730";
        }

        private void ButtonChangeCredentials_Click(object sender, EventArgs e)
        {
            using LoginDialog consoleCredentials = new();

            consoleCredentials.TextBoxUsername.Text = ConsoleProfile.Username;
            consoleCredentials.TextBoxPassword.Text = ConsoleProfile.Password;

            DialogResult setCredentials = consoleCredentials.ShowDialog(this);

            if (setCredentials == DialogResult.OK)
            {
                LabelUserPass.Text = consoleCredentials.TextBoxUsername.Text + @" / " + consoleCredentials.TextBoxPassword.Text;

                ConsoleProfile.Username = consoleCredentials.TextBoxUsername.Text;
                ConsoleProfile.Password = consoleCredentials.TextBoxPassword.Text;
                ConsoleProfile.UseDefaultCredentials = false;
            }
            else if (setCredentials == DialogResult.Abort)
            {
                LabelUserPass.Text = @"Default";

                ConsoleProfile.Username = string.Empty;
                ConsoleProfile.Password = string.Empty;
                ConsoleProfile.UseDefaultCredentials = true;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxConnectionName.Text))
            {
                XtraMessageBox.Show(this, "You must enter a connection name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsoleAddress.Text))
            {
                XtraMessageBox.Show(this, "You must enter an IP Address.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxConsolePort.Text))
            {
                XtraMessageBox.Show(this, "You must enter a port value. The default value for PS3 is 21 and Xbox is 730.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool isAddressValid = IPAddress.TryParse(TextBoxConsoleAddress.Text, out IPAddress address);
            bool isPortValid = int.TryParse(TextBoxConsolePort.Text, out int port);

            if (isAddressValid)
            {
                if (isPortValid)
                {
                    if (IsEditingProfile)
                    {
                        if (ConsoleProfile.Name != TextBoxConnectionName.Text && ProfileExists(TextBoxConnectionName.Text))
                        {
                            XtraMessageBox.Show(this, "A console with this name already exists.", "Console Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            ConsoleProfile.Name = TextBoxConnectionName.Text;
                            ConsoleProfile.Address = address.ToString();
                            ConsoleProfile.Port = port;
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        if (ProfileExists(TextBoxConnectionName.Text))
                        {
                            XtraMessageBox.Show(this, "A console with this name already exists.", "Console Name Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            ConsoleProfile.Name = TextBoxConnectionName.Text;
                            ConsoleProfile.Address = address.ToString();
                            ConsoleProfile.Port = port;
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "Port is not an integer value.", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show(this, "IP Address isn't the correct format.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static bool ProfileExists(string name)
        {
            foreach (ConsoleProfile console in MainWindow.Settings.ConsoleProfiles)
                if (console.Name.Equals(name))
                    return true;

            return false;
        }
    }
}