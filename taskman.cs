using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace taskman
{
    public partial class taskman : Form
    {
        int locktask;
        int hidetask;
        int smallico;
        int taskpos;
        int tasksize;
        int aeropeek;
        int powerpref;
        int addapps;
        int additems;
        RegistryKey targetkey;
        RegistryKey targetsub;
        byte[] adv;
        public taskman()
        {
            
            InitializeComponent();
            readtaskpref();
            readstartpref();
            
        }

        private void readtaskpref()
        {
            locktask = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "TaskbarSizeMove", -1));
            if (locktask == 0)
            {
                locktaskbarin.Checked = true;
            }
            if (locktask == 1)
            {
                locktaskbarin.Checked = false;
            }
            smallico = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "TaskbarSmallIcons", -1));
            if (smallico == 1)
            {
                usesmalliconsin.Checked = true;
            }

            if (smallico == 0)
            {
                usesmalliconsin.Checked = false;
            } 
            tasksize = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "TaskbarGlomLevel", -1));
            if (tasksize == 2)
            {
                taskbuttin.Text = "Never hide";
            }
            if (tasksize == 1)
            {
                taskbuttin.Text = "Hide when taskbar is full";
            }

            if (tasksize == 0)
            {
                taskbuttin.Text = "Always combine, hide labels";
            }
            aeropeek = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "DisablePreviewDesktop", -1));
            if (aeropeek == 0)
            {
                useareopeekin.Checked = true;
            }

            if (aeropeek == 1)
            {
                useareopeekin.Checked = false;
            }
            targetkey = Registry.CurrentUser;
            targetsub = targetkey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3");
            adv = (byte[])targetsub.GetValue("Settings");
            if (adv[8] == 0x2)
            {
                hidetask = 0x2;
                autohidetaskbarin.Checked = false;
            }
            if (adv[8] == 0x3)
            {
                hidetask = 3;
                autohidetaskbarin.Checked = true;
            }

            if (adv[12] == 0x0)
            {
                taskpos = 0;
                taskbarposin.Text = "Left";
            }
            if (adv[12] == 0x1)
            {
                taskpos = 1;
                taskbarposin.Text = "Top";
            }
            if (adv[12] == 0x2)
            {
                taskpos = 2;
                taskbarposin.Text = "Right";
            }
            if (adv[12] == 0x3)
            {
                taskpos = 3;
                taskbarposin.Text = "Bottom";
            }
            addapps = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_TrackProgs", -1));
            if (addapps == 0)
            {
                storerecentappsin.Checked = false;
            } 

            if (addapps == 1)
            {
                storerecentappsin.Checked = true;
            }
            additems = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_TrackDocs", -1));
            if (additems == 0)
            {
                storerecentitemsin.Checked = false;
            } 

            if (additems == 1)
            {
                storerecentitemsin.Checked = true;
            }
        }

        private void readstartpref() {
            powerpref = Convert.ToInt32(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Power\PowerSettings\7648EFA3-DD9C-4E3E-B566-50F929386280", "ACSettingIndex ", -1));
            if (powerpref == 0)
            {
                poweractin.Text = "Do nothing";
            }
            if (powerpref == 1)
            {
                poweractin.Text = "Sleep";
            }
            if (powerpref == 2)
            {
                poweractin.Text = "Hibernate";
            }
            if (powerpref == 3)
            {
                poweractin.Text = "Shutdown";
            }
            if (powerpref == 4)
            {
                poweractin.Text = "Turn off Display";
            }
        }

        public void updatetaskbar()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "TaskbarSizeMove", locktask, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "TaskbarSmallIcons", smallico, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "TaskbarGlomLevel", tasksize, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "DisablePreviewDesktop", aeropeek, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3\", "Settings", adv, Microsoft.Win32.RegistryValueKind.Binary);
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "taskkill.exe",
                    Arguments = "-f -im explorer.exe",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                process.Start();
                process.WaitForExit();
                process.StartInfo = new ProcessStartInfo("explorer.exe");
                process.Start();
            }
        }

        private void updatestart()
        {
            if (powerpref == 0)
            {
                using (Process process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "powercfg",
                        Arguments = "-setdcvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 7648efa3-dd9c-4e3e-b566-50f929386280 0",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    process.Start();
                }
            }
                if (powerpref == 1)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = new ProcessStartInfo
                        {
                            FileName = "powercfg",
                            Arguments = "-setdcvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 7648efa3-dd9c-4e3e-b566-50f929386280 1",
                            WindowStyle = ProcessWindowStyle.Hidden
                        };
                        process.Start();
                    }
                }
                if (powerpref == 2)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = new ProcessStartInfo
                        {
                            FileName = "powercfg",
                            Arguments = "-setdcvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 7648efa3-dd9c-4e3e-b566-50f929386280 2",
                            WindowStyle = ProcessWindowStyle.Hidden
                        };
                        process.Start();
                    }
                }
                if (powerpref == 3)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = new ProcessStartInfo
                        {
                            FileName = "powercfg",
                            Arguments = "-setdcvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 7648efa3-dd9c-4e3e-b566-50f929386280 3",
                            WindowStyle = ProcessWindowStyle.Hidden
                        };
                        process.Start();
                    }
                }
                if (powerpref == 4)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = new ProcessStartInfo
                        {
                            FileName = "powercfg",
                            Arguments = "-setdcvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 7648efa3-dd9c-4e3e-b566-50f929386280 4",
                            WindowStyle = ProcessWindowStyle.Hidden
                        };
                        process.Start();
                    }
                }
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_TrackProgs", addapps, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_TrackDocs", additems, Microsoft.Win32.RegistryValueKind.DWord);
        }



        private void okbutt_Click(object sender, EventArgs e)
        {
            updatetaskbar();
            this.Close();
        }

        private void applybutt_Click(object sender, EventArgs e)
        {
            updatetaskbar();
            updatestart();
        }

        private void cancelbutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custstartbutt_Click(object sender, EventArgs e)
        {
            startmenu startm = new startmenu();
            startm.ShowDialog();
        }

        private void howtocust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/en-us/windows/how-to-use-the-taskbar-in-windows-0657a50f-0cc7-dbfd-ae6b-05020b195b07");
        }

        private void customnotbutt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"shell:::{05d7b0f4-2121-4eff-bf6b-ed3f69b894d9}");
        }

        private void locktaskbarin_CheckedChanged(object sender, EventArgs e)
        {
            if (locktaskbarin.Checked == true)
            {
                locktask = 0;
            }
            if (locktaskbarin.Checked == false)
            {
                locktask = 1;
            }
        }

        private void usesmalliconsin_CheckedChanged(object sender, EventArgs e)
        {
            if (usesmalliconsin.Checked == true)
            {
                smallico = 1;
            }
            if (usesmalliconsin.Checked == false)
            {
                smallico = 0;
            }
        }

        private void taskbuttin_SelectedIndexChanged(object sender, EventArgs e)
        {


                if (taskbuttin.Text == "Always combine, hide labels")
                {
                    tasksize = 0;
                }
                if (taskbuttin.Text == "Hide when taskbar is full")
                {
                    tasksize = 1;
                }
                if (taskbuttin.Text == "Never hide")
                {
                    tasksize = 2;
                }

        }

        private void useareopeekin_CheckedChanged(object sender, EventArgs e)
        {
            if (useareopeekin.Checked == true)
            {
                aeropeek = 0;
            }
            if (useareopeekin.Checked == false)
            {
                aeropeek = 1;
            }
        }

        private void autohidetaskbarin_CheckedChanged(object sender, EventArgs e)
        {
            if (autohidetaskbarin.Checked == true)
            {
                hidetask = 3;
                adv[8] = 0x3;
            }
            if (autohidetaskbarin.Checked == false)
            {
                hidetask = 2;
                adv[8] = 0x2;
            }
        }

        private void taskbarposin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskbarposin.Text == "Left")
            {
                taskpos = 0;
                adv[12] = 0x0;
            }
            if (taskbarposin.Text == "Top")
            {
                taskpos =  1;
                adv[12] = 0x1;
            }
            if (taskbarposin.Text == "Right")
            {
                taskpos = 2;
                adv[12] = 0x2;
            }
            if (taskbarposin.Text == "Bottom") {
                taskpos = 3;
                adv[12] = 0x3;
            }
        }

        private void poweractin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (poweractin.Text == "Do nothing")
            {
                powerpref = 0;
            }
            if (poweractin.Text == "Sleep")
            {
                powerpref = 1;
            }
            if (poweractin.Text == "Hibernate")
            {
                powerpref = 2;
            }
            if (poweractin.Text == "Shutdown")
            {
                powerpref = 3;
            }
            if (poweractin.Text == "Turn off display")
            {
                powerpref = 4;
            }
        }

        private void storerecentappsin_CheckedChanged(object sender, EventArgs e)
        {
            if (storerecentappsin.Checked == true)
            {
                addapps = 1;
            }
            if (storerecentappsin.Checked == false)
            {
                addapps = 0;
            }
        }

        private void storerecentitemsin_CheckedChanged(object sender, EventArgs e)
        {
            if (storerecentitemsin.Checked == true)
            {
                additems = 1;
            }
            if (storerecentitemsin.Checked == false)
            {
                additems = 0;
            }
        }

        private void howtochange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/en-us/windows/configuration/windows-10-start-layout-options-and-policies");
        }

        
    }
}
