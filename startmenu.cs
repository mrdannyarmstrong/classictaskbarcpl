using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace taskman
{
    public partial class startmenu : Form
    {
        int computer;
        int connectto;
        int control;
        int defaultapps;
        int deviceandprinter;
        int net;
        int docs;
        int music;
        int pics;
        int vids;
        int recentdocs;
        int run;
        int progsize = 0;
        int itemsize = 0;
        public startmenu()
        {
            readprefs();
            InitializeComponent();
        }

        private void readprefs()
        {
            computer = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowMyComputer", -1));
            if (computer == 2)
            {
                compin2.Checked = true;
                compin1.Checked = false;
                compin0.Checked = false;
            }
            if (computer == 1)
            {
                compin2.Checked = false;
                compin1.Checked = true;
                compin0.Checked = false;
            }
            if (computer == 0)
            {
                compin2.Checked = false;
                compin1.Checked = false;
                compin0.Checked = true;
            }
            connectto = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowConnectTo", -1));
            if (connectto == 1)
            {
                connectin.Checked = true;
            }
            if (connectto == 0)
            {
                connectin.Checked = false;
            }
            control = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowControlPanel", -1));
            if (control == 2)
            {
                controlin2.Checked = true;
                controlin1.Checked = false;
                controlin0.Checked = false;
            }
            if (control == 1)
            {
                controlin2.Checked = false;
                controlin1.Checked = true;
                controlin0.Checked = false;
            }
            if (control == 0)
            {
                controlin2.Checked = false;
                controlin1.Checked = false;
                controlin0.Checked = true;
            }
            defaultapps = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowDefaultApps", -1));
            if (defaultapps == 1)
            {
                defprogin.Checked = true;
            }
            if (defaultapps == 0)
            {
                defprogin.Checked = false;
            }
            deviceandprinter = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "StartMenuAdminTools", -1));
            if (deviceandprinter == 1)
            {
                devin.Checked = true;
            }
            if (deviceandprinter == 0)
            {
                devin.Checked = false;
            }
            net = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowNetPlaces", -1));
            if (net == 2)
            {
                net2.Checked = true;
                net1.Checked = false;
                net0.Checked = false;
            }
            if (net == 1)
            {
                net2.Checked = false;
                net1.Checked = true;
                net0.Checked = false;
            }
            if (net == 0)
            {
                net2.Checked = false;
                net1.Checked = false;
                net0.Checked = true;
            }
            docs = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowMyDocs", -1));
            if (docs == 2)
            {
                docs2.Checked = true;
                docs1.Checked = false;
                docs0.Checked = false;
            }
            if (docs == 1)
            {
                docs2.Checked = false;
                docs1.Checked = true;
                docs0.Checked = false;
            }
            if (docs == 0)
            {
                docs2.Checked = false;
                docs1.Checked = false;
                docs0.Checked = true;
            }
            music = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowMyMusic", -1));
            if (music == 2)
            {
                music2.Checked = true;
                music1.Checked = false;
                music0.Checked = false;
            }
            if (music == 1)
            {
                music2.Checked = false;
                music1.Checked = true;
                music0.Checked = false;
            }
            if (music == 0)
            {
                music2.Checked = false;
                music1.Checked = false;
                music0.Checked = true;
            }
            pics = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowMyPics", -1));
            if (pics == 2)
            {
                pics2.Checked = true;
                pics1.Checked = false;
                pics0.Checked = false;
            }
            if (pics == 1)
            {
                pics2.Checked = false;
                pics1.Checked = true;
                pics0.Checked = false;
            }
            if (pics == 0)
            {
                pics2.Checked = false;
                pics1.Checked = false;
                pics0.Checked = true;
            }
            vids = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowMyVids", -1));
            if (vids == 2)
            {
                vids2.Checked = true;
                vids1.Checked = false;
                vids0.Checked = false;
            }
            if (vids == 1)
            {
                vids2.Checked = false;
                vids1.Checked = true;
                vids0.Checked = false;
            }
            if (vids == 0)
            {
                vids2.Checked = false;
                vids1.Checked = false;
                vids0.Checked = true;
            }
            recentdocs = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowRecentDocs", -1));
            if (recentdocs == 1)
            {
                recentdocsin.Checked = true;
            }
            if (recentdocs == 0)
            {
                recentdocsin.Checked = false;
            }
            run = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowRun", -1));
            if (run == 1)
            {
                runin.Checked = true;
            }
            if (run == 0)
            {
                runin.Checked = false;
            }
        }

        private void writeprefs()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowMyComputer", computer, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowConnectTo", connectto, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_Start_ShowControlPanel", control, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_StartMenuAdminTools", defaultapps, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_StartMenuAdminTools", deviceandprinter, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowNetPlaces", net, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowMyDocs", docs, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowMyMusic", music, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowMyPics", pics, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowMyVids", vids, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowRecentDocs", run, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "Start_ShowRun", run, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "ProgramsItems_Maximum", progsize, Microsoft.Win32.RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", "JumpListItems_Maximum", itemsize, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void okbutt_Click(object sender, EventArgs e)
        {
            writeprefs();
            this.Close();
        }

        private void cancelbutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetbutt_Click(object sender, EventArgs e)
        {
            computer = 2;
            compin2.Checked = true;
            compin1.Checked = false;
            compin0.Checked = false;
            connectto = 0;
            connectin.Checked = false;
            control = 2;
            controlin2.Checked = true;
            controlin1.Checked = false;
            controlin0.Checked = false;
            defaultapps = 1;
            defprogin.Checked = true;
            deviceandprinter = 1;
            devin.Checked = true;
            net = 2;
            net2.Checked = true;
            net1.Checked = false;
            net0.Checked = false;
            docs = 2;
            docs2.Checked = true;
            docs1.Checked = false;
            docs0.Checked = false;
            music = 2;
            music2.Checked = true;
            music1.Checked = false;
            music0.Checked = false;
            pics = 2;
            pics2.Checked = true;
            pics1.Checked = false;
            pics0.Checked = false;
            vids = 0;
            vids2.Checked = false;
            vids1.Checked = false;
            vids0.Checked = true;
            recentdocs = 0;
            recentdocsin.Checked = false;
            run = 0;
            runin.Checked = false;

        }

        private void compin2_CheckedChanged(object sender, EventArgs e)
        {
            computer = 2;
        }
        private void compin1_CheckedChanged(object sender, EventArgs e)
        {
            computer = 1;
        }
        private void compin0_CheckedChanged(object sender, EventArgs e)
        {
            computer = 0;
        }

        private void connectin_CheckedChanged(object sender, EventArgs e)
        {
            if (connectin.Checked == true)
            {
                connectto = 1;
            }
            if (connectin.Checked == false)
            {
                connectto = 0;
            }
        }

        private void controlin2_CheckedChanged(object sender, EventArgs e)
        {
            control = 2;
        }

        private void controlin1_CheckedChanged(object sender, EventArgs e)
        {
            control = 1;
        }

        private void controlin0_CheckedChanged(object sender, EventArgs e)
        {
            control = 0;
        }

        private void defprogin_CheckedChanged(object sender, EventArgs e)
        {
            if (defprogin.Checked == true)
            {
                defaultapps = 1;
            }
            if (defprogin.Checked == false)
            {
                defaultapps = 0;
            }
        }

        private void devin_CheckedChanged(object sender, EventArgs e)
        {
            if (devin.Checked == true)
            {
                deviceandprinter = 1;
            }
            if (devin.Checked == false)
            {
                deviceandprinter = 0;
            }
        }

        private void net2_CheckedChanged(object sender, EventArgs e)
        {
            net = 2;
        }

        private void net1_CheckedChanged(object sender, EventArgs e)
        {
            net = 1;
        }

        private void net0_CheckedChanged(object sender, EventArgs e)
        {
            net = 0;
        }

        private void docs2_CheckedChanged(object sender, EventArgs e)
        {
            docs = 2;
        }

        private void docs1_CheckedChanged(object sender, EventArgs e)
        {
            docs = 1;
        }

        private void docs0_CheckedChanged(object sender, EventArgs e)
        {
            docs = 0;
        }

        private void music2_CheckedChanged(object sender, EventArgs e)
        {
            music = 2;
        }

        private void music1_CheckedChanged(object sender, EventArgs e)
        {
            music = 1;
        }

        private void music0_CheckedChanged(object sender, EventArgs e)
        {
            music = 0;
        }

        private void pics2_CheckedChanged(object sender, EventArgs e)
        {
            pics = 2;
        }

        private void pics1_CheckedChanged(object sender, EventArgs e)
        {
            pics = 1;
        }

        private void pics0_CheckedChanged(object sender, EventArgs e)
        {
            pics = 0;
        }

        private void vids2_CheckedChanged(object sender, EventArgs e)
        {
            vids = 2;
        }

        private void vids1_CheckedChanged(object sender, EventArgs e)
        {
            vids = 1;
        }

        private void vids0_CheckedChanged(object sender, EventArgs e)
        {
            vids = 0;
        }

        private void recentdocsin_CheckedChanged(object sender, EventArgs e)
        {
            if (recentdocsin.Checked == true)
            {
                recentdocs = 1;
            }
            if (recentdocsin.Checked == false)
            {
                recentdocs = 0;
            }
        }

        private void runin_CheckedChanged(object sender, EventArgs e)
        {
            if (runin.Checked == true)
            {
                run = 1;
            }
            if (runin.Checked == false)
            {
                run = 0;
            }
        }
        private void appnumin_ValueChanged(object sender, EventArgs e)
        {
            progsize = (int)appnumin.Value;
        }

        private void itemnumin_ValueChanged(object sender, EventArgs e)
        {
            itemsize = (int)itemnumin.Value;
        }
        
    }
}
