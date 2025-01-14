﻿using System.Collections.Generic;
using System.Linq;

namespace Modio.Database
{
    // Get the download information.
    public class GameSaveDownloadFiles
    {
        public string Name { get; set; }

        public string Region { get; set; }

        public string Url { get; set; }

        public List<string> InstallPaths { get; set; }

        /// <summary>
        /// Check whether any files are being installed to a USB device.
        /// </summary>
        public bool RequiresUsbDevice => InstallPaths.Any(x => x.Contains("{USBDEV}"));

        public List<string> LocalInstallPaths(Platform platform)
        {
            List<string> localInstallPaths = new();

            foreach (string installPath in InstallPaths)
            {
                if (platform == Platform.PS3)
                {
                    localInstallPaths.Add(installPath.Replace("/{USBDEV}/", @"PS3\").Replace("/", @"\"));
                }
                else
                {
                    localInstallPaths.Add(installPath.Replace(@"Hdd:\Modio\", @"XBOX"));
                }
            }

            return localInstallPaths;
        }
    }
}