namespace taskman
{
    partial class taskman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taskman));
            this.applybutt = new System.Windows.Forms.Button();
            this.cancelbutt = new System.Windows.Forms.Button();
            this.okbutt = new System.Windows.Forms.Button();
            this.buttpane = new System.Windows.Forms.Panel();
            this.maintab = new System.Windows.Forms.TabControl();
            this.taskbartab = new System.Windows.Forms.TabPage();
            this.howtocust = new System.Windows.Forms.LinkLabel();
            this.previwtxt = new System.Windows.Forms.Label();
            this.peekpane = new System.Windows.Forms.Panel();
            this.useareopeekin = new System.Windows.Forms.CheckBox();
            this.areopeektxt = new System.Windows.Forms.Label();
            this.notificationarea = new System.Windows.Forms.Label();
            this.notpane = new System.Windows.Forms.Panel();
            this.customnotbutt = new System.Windows.Forms.Button();
            this.customnottxt = new System.Windows.Forms.Label();
            this.taskbarapperance = new System.Windows.Forms.Label();
            this.apperancepane = new System.Windows.Forms.Panel();
            this.taskbuttin = new System.Windows.Forms.ComboBox();
            this.taskbarbuttttxt = new System.Windows.Forms.Label();
            this.taskbarposin = new System.Windows.Forms.ComboBox();
            this.taskbarlocationtxt = new System.Windows.Forms.Label();
            this.usesmalliconsin = new System.Windows.Forms.CheckBox();
            this.autohidetaskbarin = new System.Windows.Forms.CheckBox();
            this.locktaskbarin = new System.Windows.Forms.CheckBox();
            this.startmeutab = new System.Windows.Forms.TabPage();
            this.howtochange = new System.Windows.Forms.LinkLabel();
            this.privacy = new System.Windows.Forms.Label();
            this.privacytab = new System.Windows.Forms.Panel();
            this.storerecentitemsin = new System.Windows.Forms.CheckBox();
            this.storerecentappsin = new System.Windows.Forms.CheckBox();
            this.poweractin = new System.Windows.Forms.ComboBox();
            this.poweracttxt = new System.Windows.Forms.Label();
            this.custstartbutt = new System.Windows.Forms.Button();
            this.custsytartxt = new System.Windows.Forms.Label();
            this.toolbartab = new System.Windows.Forms.TabPage();
            this.toolbarpane = new System.Windows.Forms.Panel();
            this.deskin = new System.Windows.Forms.CheckBox();
            this.tabletin = new System.Windows.Forms.CheckBox();
            this.linksin = new System.Windows.Forms.CheckBox();
            this.adressin = new System.Windows.Forms.CheckBox();
            this.toolbartxt = new System.Windows.Forms.Label();
            this.buttpane.SuspendLayout();
            this.maintab.SuspendLayout();
            this.taskbartab.SuspendLayout();
            this.peekpane.SuspendLayout();
            this.notpane.SuspendLayout();
            this.apperancepane.SuspendLayout();
            this.startmeutab.SuspendLayout();
            this.privacytab.SuspendLayout();
            this.toolbartab.SuspendLayout();
            this.toolbarpane.SuspendLayout();
            this.SuspendLayout();
            // 
            // applybutt
            // 
            this.applybutt.Location = new System.Drawing.Point(94, 8);
            this.applybutt.Name = "applybutt";
            this.applybutt.Size = new System.Drawing.Size(75, 23);
            this.applybutt.TabIndex = 0;
            this.applybutt.Text = "Apply";
            this.applybutt.UseVisualStyleBackColor = true;
            this.applybutt.Click += new System.EventHandler(this.applybutt_Click);
            // 
            // cancelbutt
            // 
            this.cancelbutt.Location = new System.Drawing.Point(175, 8);
            this.cancelbutt.Name = "cancelbutt";
            this.cancelbutt.Size = new System.Drawing.Size(75, 23);
            this.cancelbutt.TabIndex = 1;
            this.cancelbutt.Text = "Cancel";
            this.cancelbutt.UseVisualStyleBackColor = true;
            this.cancelbutt.Click += new System.EventHandler(this.cancelbutt_Click);
            // 
            // okbutt
            // 
            this.okbutt.Location = new System.Drawing.Point(256, 8);
            this.okbutt.Name = "okbutt";
            this.okbutt.Size = new System.Drawing.Size(75, 23);
            this.okbutt.TabIndex = 2;
            this.okbutt.Text = "OK";
            this.okbutt.UseVisualStyleBackColor = true;
            this.okbutt.Click += new System.EventHandler(this.okbutt_Click);
            // 
            // buttpane
            // 
            this.buttpane.Controls.Add(this.okbutt);
            this.buttpane.Controls.Add(this.cancelbutt);
            this.buttpane.Controls.Add(this.applybutt);
            this.buttpane.Location = new System.Drawing.Point(3, 326);
            this.buttpane.Name = "buttpane";
            this.buttpane.Size = new System.Drawing.Size(345, 38);
            this.buttpane.TabIndex = 1;
            // 
            // maintab
            // 
            this.maintab.Controls.Add(this.taskbartab);
            this.maintab.Controls.Add(this.startmeutab);
            this.maintab.Controls.Add(this.toolbartab);
            this.maintab.Location = new System.Drawing.Point(3, 3);
            this.maintab.Name = "maintab";
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(345, 325);
            this.maintab.TabIndex = 2;
            // 
            // taskbartab
            // 
            this.taskbartab.Controls.Add(this.howtocust);
            this.taskbartab.Controls.Add(this.previwtxt);
            this.taskbartab.Controls.Add(this.peekpane);
            this.taskbartab.Controls.Add(this.notificationarea);
            this.taskbartab.Controls.Add(this.notpane);
            this.taskbartab.Controls.Add(this.taskbarapperance);
            this.taskbartab.Controls.Add(this.apperancepane);
            this.taskbartab.Location = new System.Drawing.Point(4, 22);
            this.taskbartab.Name = "taskbartab";
            this.taskbartab.Padding = new System.Windows.Forms.Padding(3);
            this.taskbartab.Size = new System.Drawing.Size(337, 299);
            this.taskbartab.TabIndex = 0;
            this.taskbartab.Text = "Taskbar";
            this.taskbartab.UseVisualStyleBackColor = true;
            // 
            // howtocust
            // 
            this.howtocust.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.howtocust.AutoSize = true;
            this.howtocust.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.howtocust.Location = new System.Drawing.Point(6, 278);
            this.howtocust.Name = "howtocust";
            this.howtocust.Size = new System.Drawing.Size(162, 13);
            this.howtocust.TabIndex = 6;
            this.howtocust.TabStop = true;
            this.howtocust.Text = "How do I customize the taskbar?";
            this.howtocust.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            this.howtocust.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.howtocust_LinkClicked);
            // 
            // previwtxt
            // 
            this.previwtxt.AutoSize = true;
            this.previwtxt.Location = new System.Drawing.Point(12, 195);
            this.previwtxt.Name = "previwtxt";
            this.previwtxt.Size = new System.Drawing.Size(161, 13);
            this.previwtxt.TabIndex = 5;
            this.previwtxt.Text = "Preview desktop with Aero Peek";
            this.previwtxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // peekpane
            // 
            this.peekpane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peekpane.Controls.Add(this.useareopeekin);
            this.peekpane.Controls.Add(this.areopeektxt);
            this.peekpane.Location = new System.Drawing.Point(6, 201);
            this.peekpane.Name = "peekpane";
            this.peekpane.Size = new System.Drawing.Size(321, 74);
            this.peekpane.TabIndex = 4;
            // 
            // useareopeekin
            // 
            this.useareopeekin.AutoSize = true;
            this.useareopeekin.Location = new System.Drawing.Point(11, 44);
            this.useareopeekin.Name = "useareopeekin";
            this.useareopeekin.Size = new System.Drawing.Size(209, 17);
            this.useareopeekin.TabIndex = 7;
            this.useareopeekin.Text = "Use Areo Peek to preview the desktop";
            this.useareopeekin.UseVisualStyleBackColor = true;
            this.useareopeekin.CheckedChanged += new System.EventHandler(this.useareopeekin_CheckedChanged);
            // 
            // areopeektxt
            // 
            this.areopeektxt.AutoSize = true;
            this.areopeektxt.Location = new System.Drawing.Point(7, 15);
            this.areopeektxt.Name = "areopeektxt";
            this.areopeektxt.Size = new System.Drawing.Size(310, 26);
            this.areopeektxt.TabIndex = 6;
            this.areopeektxt.Text = "Temporarily view the desktop when you move your mouse to the\r\nShow desktop button" +
                " at the end of the taskbar.";
            // 
            // notificationarea
            // 
            this.notificationarea.AutoSize = true;
            this.notificationarea.Location = new System.Drawing.Point(10, 145);
            this.notificationarea.Name = "notificationarea";
            this.notificationarea.Size = new System.Drawing.Size(84, 13);
            this.notificationarea.TabIndex = 3;
            this.notificationarea.Text = "Notification area";
            this.notificationarea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notpane
            // 
            this.notpane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notpane.Controls.Add(this.customnotbutt);
            this.notpane.Controls.Add(this.customnottxt);
            this.notpane.Location = new System.Drawing.Point(6, 154);
            this.notpane.Name = "notpane";
            this.notpane.Size = new System.Drawing.Size(321, 36);
            this.notpane.TabIndex = 2;
            // 
            // customnotbutt
            // 
            this.customnotbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.customnotbutt.Location = new System.Drawing.Point(259, 5);
            this.customnotbutt.Name = "customnotbutt";
            this.customnotbutt.Size = new System.Drawing.Size(58, 20);
            this.customnotbutt.TabIndex = 1;
            this.customnotbutt.Text = "Customize";
            this.customnotbutt.UseVisualStyleBackColor = true;
            this.customnotbutt.Click += new System.EventHandler(this.customnotbutt_Click);
            // 
            // customnottxt
            // 
            this.customnottxt.AutoSize = true;
            this.customnottxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customnottxt.Location = new System.Drawing.Point(3, 4);
            this.customnottxt.Name = "customnottxt";
            this.customnottxt.Size = new System.Drawing.Size(259, 26);
            this.customnottxt.TabIndex = 0;
            this.customnottxt.Text = "Customize which icons and notifications appear in the\r\nnotification area\r\n";
            // 
            // taskbarapperance
            // 
            this.taskbarapperance.AutoSize = true;
            this.taskbarapperance.Location = new System.Drawing.Point(10, 3);
            this.taskbarapperance.Name = "taskbarapperance";
            this.taskbarapperance.Size = new System.Drawing.Size(101, 13);
            this.taskbarapperance.TabIndex = 1;
            this.taskbarapperance.Text = "Taskbar Apperance";
            this.taskbarapperance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apperancepane
            // 
            this.apperancepane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apperancepane.Controls.Add(this.taskbuttin);
            this.apperancepane.Controls.Add(this.taskbarbuttttxt);
            this.apperancepane.Controls.Add(this.taskbarposin);
            this.apperancepane.Controls.Add(this.taskbarlocationtxt);
            this.apperancepane.Controls.Add(this.usesmalliconsin);
            this.apperancepane.Controls.Add(this.autohidetaskbarin);
            this.apperancepane.Controls.Add(this.locktaskbarin);
            this.apperancepane.Location = new System.Drawing.Point(5, 10);
            this.apperancepane.Name = "apperancepane";
            this.apperancepane.Size = new System.Drawing.Size(325, 132);
            this.apperancepane.TabIndex = 0;
            // 
            // taskbuttin
            // 
            this.taskbuttin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskbuttin.FormattingEnabled = true;
            this.taskbuttin.Items.AddRange(new object[] {
            "Always combine, hide labels",
            "Hide when taskbar is full",
            "Never hide"});
            this.taskbuttin.Location = new System.Drawing.Point(159, 97);
            this.taskbuttin.Name = "taskbuttin";
            this.taskbuttin.Size = new System.Drawing.Size(154, 21);
            this.taskbuttin.TabIndex = 6;
            this.taskbuttin.Text = "Always combine, hide labels";
            this.taskbuttin.SelectedIndexChanged += new System.EventHandler(this.taskbuttin_SelectedIndexChanged);
            // 
            // taskbarbuttttxt
            // 
            this.taskbarbuttttxt.AutoSize = true;
            this.taskbarbuttttxt.Location = new System.Drawing.Point(5, 100);
            this.taskbarbuttttxt.Name = "taskbarbuttttxt";
            this.taskbarbuttttxt.Size = new System.Drawing.Size(91, 13);
            this.taskbarbuttttxt.TabIndex = 5;
            this.taskbarbuttttxt.Text = "Taskbar Buttons: ";
            // 
            // taskbarposin
            // 
            this.taskbarposin.FormattingEnabled = true;
            this.taskbarposin.Items.AddRange(new object[] {
            "Bottom",
            "Top",
            "Left",
            "Right"});
            this.taskbarposin.Location = new System.Drawing.Point(159, 70);
            this.taskbarposin.Name = "taskbarposin";
            this.taskbarposin.Size = new System.Drawing.Size(154, 21);
            this.taskbarposin.TabIndex = 4;
            this.taskbarposin.Text = "Bottom";
            this.taskbarposin.SelectedIndexChanged += new System.EventHandler(this.taskbarposin_SelectedIndexChanged);
            // 
            // taskbarlocationtxt
            // 
            this.taskbarlocationtxt.AutoSize = true;
            this.taskbarlocationtxt.Location = new System.Drawing.Point(5, 74);
            this.taskbarlocationtxt.Name = "taskbarlocationtxt";
            this.taskbarlocationtxt.Size = new System.Drawing.Size(142, 13);
            this.taskbarlocationtxt.TabIndex = 3;
            this.taskbarlocationtxt.Text = "Taskbar location on screen: ";
            // 
            // usesmalliconsin
            // 
            this.usesmalliconsin.AutoSize = true;
            this.usesmalliconsin.Location = new System.Drawing.Point(3, 54);
            this.usesmalliconsin.Name = "usesmalliconsin";
            this.usesmalliconsin.Size = new System.Drawing.Size(99, 17);
            this.usesmalliconsin.TabIndex = 2;
            this.usesmalliconsin.Text = "Use small icons";
            this.usesmalliconsin.UseVisualStyleBackColor = true;
            this.usesmalliconsin.CheckedChanged += new System.EventHandler(this.usesmalliconsin_CheckedChanged);
            // 
            // autohidetaskbarin
            // 
            this.autohidetaskbarin.AutoSize = true;
            this.autohidetaskbarin.Location = new System.Drawing.Point(3, 31);
            this.autohidetaskbarin.Name = "autohidetaskbarin";
            this.autohidetaskbarin.Size = new System.Drawing.Size(127, 17);
            this.autohidetaskbarin.TabIndex = 1;
            this.autohidetaskbarin.Text = "Auto-hide the taskbar";
            this.autohidetaskbarin.UseVisualStyleBackColor = true;
            this.autohidetaskbarin.CheckedChanged += new System.EventHandler(this.autohidetaskbarin_CheckedChanged);
            // 
            // locktaskbarin
            // 
            this.locktaskbarin.AutoSize = true;
            this.locktaskbarin.Location = new System.Drawing.Point(3, 8);
            this.locktaskbarin.Name = "locktaskbarin";
            this.locktaskbarin.Size = new System.Drawing.Size(106, 17);
            this.locktaskbarin.TabIndex = 0;
            this.locktaskbarin.Text = "Lock the taskbar";
            this.locktaskbarin.UseVisualStyleBackColor = true;
            this.locktaskbarin.CheckedChanged += new System.EventHandler(this.locktaskbarin_CheckedChanged);
            // 
            // startmeutab
            // 
            this.startmeutab.Controls.Add(this.howtochange);
            this.startmeutab.Controls.Add(this.privacy);
            this.startmeutab.Controls.Add(this.privacytab);
            this.startmeutab.Controls.Add(this.poweractin);
            this.startmeutab.Controls.Add(this.poweracttxt);
            this.startmeutab.Controls.Add(this.custstartbutt);
            this.startmeutab.Controls.Add(this.custsytartxt);
            this.startmeutab.Location = new System.Drawing.Point(4, 22);
            this.startmeutab.Name = "startmeutab";
            this.startmeutab.Padding = new System.Windows.Forms.Padding(3);
            this.startmeutab.Size = new System.Drawing.Size(337, 299);
            this.startmeutab.TabIndex = 1;
            this.startmeutab.Text = "Start Menu";
            this.startmeutab.UseVisualStyleBackColor = true;
            // 
            // howtochange
            // 
            this.howtochange.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.howtochange.AutoSize = true;
            this.howtochange.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.howtochange.Location = new System.Drawing.Point(6, 283);
            this.howtochange.Name = "howtochange";
            this.howtochange.Size = new System.Drawing.Size(236, 13);
            this.howtochange.TabIndex = 7;
            this.howtochange.TabStop = true;
            this.howtochange.Text = "How do I change the way the Start Menu looks?";
            this.howtochange.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            this.howtochange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.howtochange_LinkClicked);
            // 
            // privacy
            // 
            this.privacy.AutoSize = true;
            this.privacy.Location = new System.Drawing.Point(14, 82);
            this.privacy.Name = "privacy";
            this.privacy.Size = new System.Drawing.Size(42, 13);
            this.privacy.TabIndex = 5;
            this.privacy.Text = "Privacy";
            // 
            // privacytab
            // 
            this.privacytab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.privacytab.Controls.Add(this.storerecentitemsin);
            this.privacytab.Controls.Add(this.storerecentappsin);
            this.privacytab.Location = new System.Drawing.Point(6, 88);
            this.privacytab.Name = "privacytab";
            this.privacytab.Size = new System.Drawing.Size(321, 80);
            this.privacytab.TabIndex = 4;
            // 
            // storerecentitemsin
            // 
            this.storerecentitemsin.AutoSize = true;
            this.storerecentitemsin.Location = new System.Drawing.Point(6, 42);
            this.storerecentitemsin.Name = "storerecentitemsin";
            this.storerecentitemsin.Size = new System.Drawing.Size(318, 30);
            this.storerecentitemsin.TabIndex = 1;
            this.storerecentitemsin.Text = "Store and display recently opened programs in the Start menu \r\nand the taskbar";
            this.storerecentitemsin.UseVisualStyleBackColor = true;
            this.storerecentitemsin.CheckedChanged += new System.EventHandler(this.storerecentitemsin_CheckedChanged);
            // 
            // storerecentappsin
            // 
            this.storerecentappsin.AutoSize = true;
            this.storerecentappsin.Location = new System.Drawing.Point(5, 19);
            this.storerecentappsin.Name = "storerecentappsin";
            this.storerecentappsin.Size = new System.Drawing.Size(315, 17);
            this.storerecentappsin.TabIndex = 0;
            this.storerecentappsin.Text = "Store and display recently opened programs in the Start menu";
            this.storerecentappsin.UseVisualStyleBackColor = true;
            this.storerecentappsin.CheckedChanged += new System.EventHandler(this.storerecentappsin_CheckedChanged);
            // 
            // poweractin
            // 
            this.poweractin.FormattingEnabled = true;
            this.poweractin.Items.AddRange(new object[] {
            "Shutdown",
            "Sleep",
            "Hibernate",
            "Turn off display",
            "Do nothing"});
            this.poweractin.Location = new System.Drawing.Point(122, 51);
            this.poweractin.Name = "poweractin";
            this.poweractin.Size = new System.Drawing.Size(141, 21);
            this.poweractin.TabIndex = 3;
            this.poweractin.Text = "Shut Down";
            this.poweractin.SelectedIndexChanged += new System.EventHandler(this.poweractin_SelectedIndexChanged);
            // 
            // poweracttxt
            // 
            this.poweracttxt.AutoSize = true;
            this.poweracttxt.Location = new System.Drawing.Point(3, 54);
            this.poweracttxt.Name = "poweracttxt";
            this.poweracttxt.Size = new System.Drawing.Size(113, 13);
            this.poweracttxt.TabIndex = 2;
            this.poweracttxt.Text = "Power button actions: ";
            // 
            // custstartbutt
            // 
            this.custstartbutt.Location = new System.Drawing.Point(259, 15);
            this.custstartbutt.Name = "custstartbutt";
            this.custstartbutt.Size = new System.Drawing.Size(75, 23);
            this.custstartbutt.TabIndex = 1;
            this.custstartbutt.Text = "Customize...";
            this.custstartbutt.UseVisualStyleBackColor = true;
            this.custstartbutt.Click += new System.EventHandler(this.custstartbutt_Click);
            // 
            // custsytartxt
            // 
            this.custsytartxt.AutoSize = true;
            this.custsytartxt.Location = new System.Drawing.Point(3, 15);
            this.custsytartxt.Name = "custsytartxt";
            this.custsytartxt.Size = new System.Drawing.Size(250, 26);
            this.custsytartxt.TabIndex = 0;
            this.custsytartxt.Text = "To customize how links, icons, and menus look and\r\nbehave in the Start menu, clic" +
                "k Customize";
            // 
            // toolbartab
            // 
            this.toolbartab.Controls.Add(this.toolbarpane);
            this.toolbartab.Controls.Add(this.toolbartxt);
            this.toolbartab.Location = new System.Drawing.Point(4, 22);
            this.toolbartab.Name = "toolbartab";
            this.toolbartab.Size = new System.Drawing.Size(337, 299);
            this.toolbartab.TabIndex = 2;
            this.toolbartab.Text = "Toolbar";
            this.toolbartab.UseVisualStyleBackColor = true;
            // 
            // toolbarpane
            // 
            this.toolbarpane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarpane.Controls.Add(this.deskin);
            this.toolbarpane.Controls.Add(this.tabletin);
            this.toolbarpane.Controls.Add(this.linksin);
            this.toolbarpane.Controls.Add(this.adressin);
            this.toolbarpane.Location = new System.Drawing.Point(20, 26);
            this.toolbarpane.Name = "toolbarpane";
            this.toolbarpane.Size = new System.Drawing.Size(307, 240);
            this.toolbarpane.TabIndex = 1;
            // 
            // deskin
            // 
            this.deskin.AutoSize = true;
            this.deskin.Location = new System.Drawing.Point(3, 72);
            this.deskin.Name = "deskin";
            this.deskin.Size = new System.Drawing.Size(66, 17);
            this.deskin.TabIndex = 3;
            this.deskin.Text = "Desktop";
            this.deskin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deskin.UseVisualStyleBackColor = true;
            // 
            // tabletin
            // 
            this.tabletin.AutoSize = true;
            this.tabletin.Location = new System.Drawing.Point(3, 49);
            this.tabletin.Name = "tabletin";
            this.tabletin.Size = new System.Drawing.Size(130, 17);
            this.tabletin.TabIndex = 2;
            this.tabletin.Text = "Tablet PC Input Panel";
            this.tabletin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tabletin.UseVisualStyleBackColor = true;
            // 
            // linksin
            // 
            this.linksin.AutoSize = true;
            this.linksin.Location = new System.Drawing.Point(3, 26);
            this.linksin.Name = "linksin";
            this.linksin.Size = new System.Drawing.Size(51, 17);
            this.linksin.TabIndex = 1;
            this.linksin.Text = "Links";
            this.linksin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.linksin.UseVisualStyleBackColor = true;
            // 
            // adressin
            // 
            this.adressin.AutoSize = true;
            this.adressin.Location = new System.Drawing.Point(3, 3);
            this.adressin.Name = "adressin";
            this.adressin.Size = new System.Drawing.Size(58, 17);
            this.adressin.TabIndex = 0;
            this.adressin.Text = "Adress";
            this.adressin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.adressin.UseVisualStyleBackColor = true;
            // 
            // toolbartxt
            // 
            this.toolbartxt.AutoSize = true;
            this.toolbartxt.Location = new System.Drawing.Point(17, 10);
            this.toolbartxt.Name = "toolbartxt";
            this.toolbartxt.Size = new System.Drawing.Size(209, 13);
            this.toolbartxt.TabIndex = 0;
            this.toolbartxt.Text = "Select which toolbars to add to the taskbar";
            // 
            // taskman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 361);
            this.Controls.Add(this.maintab);
            this.Controls.Add(this.buttpane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "taskman";
            this.Text = "Taskbar and Start Menu Properties";
            this.buttpane.ResumeLayout(false);
            this.maintab.ResumeLayout(false);
            this.taskbartab.ResumeLayout(false);
            this.taskbartab.PerformLayout();
            this.peekpane.ResumeLayout(false);
            this.peekpane.PerformLayout();
            this.notpane.ResumeLayout(false);
            this.notpane.PerformLayout();
            this.apperancepane.ResumeLayout(false);
            this.apperancepane.PerformLayout();
            this.startmeutab.ResumeLayout(false);
            this.startmeutab.PerformLayout();
            this.privacytab.ResumeLayout(false);
            this.privacytab.PerformLayout();
            this.toolbartab.ResumeLayout(false);
            this.toolbartab.PerformLayout();
            this.toolbarpane.ResumeLayout(false);
            this.toolbarpane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applybutt;
        private System.Windows.Forms.Button cancelbutt;
        private System.Windows.Forms.Button okbutt;
        private System.Windows.Forms.Panel buttpane;
        private System.Windows.Forms.TabControl maintab;
        private System.Windows.Forms.TabPage taskbartab;
        private System.Windows.Forms.TabPage toolbartab;
        private System.Windows.Forms.Panel apperancepane;
        private System.Windows.Forms.Label taskbarapperance;
        private System.Windows.Forms.CheckBox locktaskbarin;
        private System.Windows.Forms.Label taskbarlocationtxt;
        private System.Windows.Forms.CheckBox usesmalliconsin;
        private System.Windows.Forms.CheckBox autohidetaskbarin;
        private System.Windows.Forms.ComboBox taskbarposin;
        private System.Windows.Forms.Label taskbarbuttttxt;
        private System.Windows.Forms.Label notificationarea;
        private System.Windows.Forms.Panel notpane;
        private System.Windows.Forms.Label customnottxt;
        private System.Windows.Forms.Button customnotbutt;
        private System.Windows.Forms.Label previwtxt;
        private System.Windows.Forms.Panel peekpane;
        private System.Windows.Forms.Label areopeektxt;
        private System.Windows.Forms.CheckBox useareopeekin;
        private System.Windows.Forms.LinkLabel howtocust;
        private System.Windows.Forms.Label custsytartxt;
        private System.Windows.Forms.Button custstartbutt;
        private System.Windows.Forms.ComboBox poweractin;
        private System.Windows.Forms.Label poweracttxt;
        private System.Windows.Forms.Panel privacytab;
        private System.Windows.Forms.Label privacy;
        private System.Windows.Forms.LinkLabel howtochange;
        private System.Windows.Forms.CheckBox storerecentitemsin;
        private System.Windows.Forms.CheckBox storerecentappsin;
        private System.Windows.Forms.Panel toolbarpane;
        private System.Windows.Forms.CheckBox adressin;
        private System.Windows.Forms.Label toolbartxt;
        private System.Windows.Forms.CheckBox deskin;
        private System.Windows.Forms.CheckBox tabletin;
        private System.Windows.Forms.CheckBox linksin;
        public System.Windows.Forms.ComboBox taskbuttin;
        public System.Windows.Forms.TabPage startmeutab;

    }
}

