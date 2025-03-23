namespace GTA_DIAMOND_MACRO
{
    partial class MainForm
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows

        /// <summary>
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.option_F2_Lbl = new MetroFramework.Controls.MetroLabel();
            this.CEO_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.option_F3_Lbl = new MetroFramework.Controls.MetroLabel();
            this.option_F4_Lbl = new MetroFramework.Controls.MetroLabel();
            this.option_F5_Lbl = new MetroFramework.Controls.MetroLabel();
            this.option_F6_Lbl = new MetroFramework.Controls.MetroLabel();
            this.option_Num0_Lbl = new MetroFramework.Controls.MetroLabel();
            this.option_Num1_Lbl = new MetroFramework.Controls.MetroLabel();
            this.ChatListBox = new System.Windows.Forms.ListBox();
            this.AddChat_TXT = new MetroFramework.Controls.MetroTextBox();
            this.option_Insert_Lbl = new MetroFramework.Controls.MetroLabel();
            this.ChatCount_TXT = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.option_F7_Lbl = new MetroFramework.Controls.MetroLabel();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.Page_Normal = new MetroFramework.Controls.MetroTabPage();
            this.Page_Chat = new MetroFramework.Controls.MetroTabPage();
            this.SendChat_BTN = new MetroFramework.Controls.MetroButton();
            this.Page_Option = new MetroFramework.Controls.MetroTabPage();
            this.ExitGTA5_BTN = new MetroFramework.Controls.MetroButton();
            this.SetSolo_BTN = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.Page_Normal.SuspendLayout();
            this.Page_Chat.SuspendLayout();
            this.Page_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // option_F2_Lbl
            // 
            this.option_F2_Lbl.AutoSize = true;
            this.option_F2_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_F2_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_F2_Lbl.ForeColor = System.Drawing.Color.Silver;
            this.option_F2_Lbl.Location = new System.Drawing.Point(81, 82);
            this.option_F2_Lbl.Name = "option_F2_Lbl";
            this.option_F2_Lbl.Size = new System.Drawing.Size(78, 15);
            this.option_F2_Lbl.TabIndex = 3;
            this.option_F2_Lbl.Text = "F2 : CEO 되기";
            this.option_F2_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_F2_Lbl.UseCustomForeColor = true;
            // 
            // CEO_CheckBox
            // 
            this.CEO_CheckBox.AutoSize = true;
            this.CEO_CheckBox.Location = new System.Drawing.Point(32, 46);
            this.CEO_CheckBox.Name = "CEO_CheckBox";
            this.CEO_CheckBox.Size = new System.Drawing.Size(178, 15);
            this.CEO_CheckBox.Style = MetroFramework.MetroColorStyle.Red;
            this.CEO_CheckBox.TabIndex = 4;
            this.CEO_CheckBox.Text = "CEO 또는 바이커일 경우 체크";
            this.CEO_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CEO_CheckBox.UseSelectable = true;
            this.CEO_CheckBox.UseStyleColors = true;
            this.CEO_CheckBox.CheckedChanged += new System.EventHandler(this.CEO_CheckBox_CheckedChanged);
            // 
            // option_F3_Lbl
            // 
            this.option_F3_Lbl.AutoSize = true;
            this.option_F3_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_F3_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_F3_Lbl.ForeColor = System.Drawing.Color.Silver;
            this.option_F3_Lbl.Location = new System.Drawing.Point(75, 110);
            this.option_F3_Lbl.Name = "option_F3_Lbl";
            this.option_F3_Lbl.Size = new System.Drawing.Size(92, 15);
            this.option_F3_Lbl.TabIndex = 5;
            this.option_F3_Lbl.Text = "F3 : 바이커 되기";
            this.option_F3_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_F3_Lbl.UseCustomForeColor = true;
            // 
            // option_F4_Lbl
            // 
            this.option_F4_Lbl.AutoSize = true;
            this.option_F4_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_F4_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_F4_Lbl.ForeColor = System.Drawing.Color.Silver;
            this.option_F4_Lbl.Location = new System.Drawing.Point(72, 139);
            this.option_F4_Lbl.Name = "option_F4_Lbl";
            this.option_F4_Lbl.Size = new System.Drawing.Size(95, 15);
            this.option_F4_Lbl.TabIndex = 6;
            this.option_F4_Lbl.Text = "F4 : 유틸 창 오픈";
            this.option_F4_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_F4_Lbl.UseCustomForeColor = true;
            // 
            // option_F5_Lbl
            // 
            this.option_F5_Lbl.AutoSize = true;
            this.option_F5_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_F5_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_F5_Lbl.ForeColor = System.Drawing.Color.Silver;
            this.option_F5_Lbl.Location = new System.Drawing.Point(71, 168);
            this.option_F5_Lbl.Name = "option_F5_Lbl";
            this.option_F5_Lbl.Size = new System.Drawing.Size(95, 15);
            this.option_F5_Lbl.TabIndex = 8;
            this.option_F5_Lbl.Text = "F5 : 불 샤크 투하";
            this.option_F5_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_F5_Lbl.UseCustomForeColor = true;
            // 
            // option_F6_Lbl
            // 
            this.option_F6_Lbl.AutoSize = true;
            this.option_F6_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_F6_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_F6_Lbl.ForeColor = System.Drawing.Color.Silver;
            this.option_F6_Lbl.Location = new System.Drawing.Point(81, 194);
            this.option_F6_Lbl.Name = "option_F6_Lbl";
            this.option_F6_Lbl.Size = new System.Drawing.Size(80, 15);
            this.option_F6_Lbl.TabIndex = 9;
            this.option_F6_Lbl.Text = "F6 : 유령 연맹";
            this.option_F6_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_F6_Lbl.UseCustomForeColor = true;
            // 
            // option_Num0_Lbl
            // 
            this.option_Num0_Lbl.AutoSize = true;
            this.option_Num0_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_Num0_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_Num0_Lbl.ForeColor = System.Drawing.Color.White;
            this.option_Num0_Lbl.Location = new System.Drawing.Point(49, 253);
            this.option_Num0_Lbl.Name = "option_Num0_Lbl";
            this.option_Num0_Lbl.Size = new System.Drawing.Size(147, 15);
            this.option_Num0_Lbl.Style = MetroFramework.MetroColorStyle.Green;
            this.option_Num0_Lbl.TabIndex = 11;
            this.option_Num0_Lbl.Text = "Ctrl + Num0 : 패시브 모드";
            this.option_Num0_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_Num0_Lbl.UseStyleColors = true;
            // 
            // option_Num1_Lbl
            // 
            this.option_Num1_Lbl.AutoSize = true;
            this.option_Num1_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_Num1_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_Num1_Lbl.ForeColor = System.Drawing.Color.White;
            this.option_Num1_Lbl.Location = new System.Drawing.Point(53, 280);
            this.option_Num1_Lbl.Name = "option_Num1_Lbl";
            this.option_Num1_Lbl.Size = new System.Drawing.Size(135, 15);
            this.option_Num1_Lbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.option_Num1_Lbl.TabIndex = 12;
            this.option_Num1_Lbl.Text = "Ctrl + Num1 : 잠수 방지";
            this.option_Num1_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_Num1_Lbl.UseStyleColors = true;
            // 
            // ChatListBox
            // 
            this.ChatListBox.FormattingEnabled = true;
            this.ChatListBox.ItemHeight = 12;
            this.ChatListBox.Location = new System.Drawing.Point(5, 16);
            this.ChatListBox.Name = "ChatListBox";
            this.ChatListBox.Size = new System.Drawing.Size(234, 208);
            this.ChatListBox.TabIndex = 15;
            // 
            // AddChat_TXT
            // 
            // 
            // 
            // 
            this.AddChat_TXT.CustomButton.Image = null;
            this.AddChat_TXT.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.AddChat_TXT.CustomButton.Name = "";
            this.AddChat_TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AddChat_TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddChat_TXT.CustomButton.TabIndex = 1;
            this.AddChat_TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddChat_TXT.CustomButton.UseSelectable = true;
            this.AddChat_TXT.CustomButton.Visible = false;
            this.AddChat_TXT.Lines = new string[0];
            this.AddChat_TXT.Location = new System.Drawing.Point(5, 232);
            this.AddChat_TXT.MaxLength = 32767;
            this.AddChat_TXT.Name = "AddChat_TXT";
            this.AddChat_TXT.PasswordChar = '\0';
            this.AddChat_TXT.PromptText = "보낼 메시지를 입력하세요";
            this.AddChat_TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddChat_TXT.SelectedText = "";
            this.AddChat_TXT.SelectionLength = 0;
            this.AddChat_TXT.SelectionStart = 0;
            this.AddChat_TXT.ShortcutsEnabled = true;
            this.AddChat_TXT.Size = new System.Drawing.Size(151, 23);
            this.AddChat_TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.AddChat_TXT.TabIndex = 16;
            this.AddChat_TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddChat_TXT.UseSelectable = true;
            this.AddChat_TXT.UseStyleColors = true;
            this.AddChat_TXT.WaterMark = "보낼 메시지를 입력하세요";
            this.AddChat_TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddChat_TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // option_Insert_Lbl
            // 
            this.option_Insert_Lbl.AutoSize = true;
            this.option_Insert_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_Insert_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_Insert_Lbl.ForeColor = System.Drawing.Color.White;
            this.option_Insert_Lbl.Location = new System.Drawing.Point(36, 300);
            this.option_Insert_Lbl.Name = "option_Insert_Lbl";
            this.option_Insert_Lbl.Size = new System.Drawing.Size(163, 15);
            this.option_Insert_Lbl.Style = MetroFramework.MetroColorStyle.Magenta;
            this.option_Insert_Lbl.TabIndex = 18;
            this.option_Insert_Lbl.Text = "` or ~ : 현재 선택한 채팅 도배";
            this.option_Insert_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_Insert_Lbl.UseStyleColors = true;
            // 
            // ChatCount_TXT
            // 
            // 
            // 
            // 
            this.ChatCount_TXT.CustomButton.Image = null;
            this.ChatCount_TXT.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.ChatCount_TXT.CustomButton.Name = "";
            this.ChatCount_TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ChatCount_TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChatCount_TXT.CustomButton.TabIndex = 1;
            this.ChatCount_TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChatCount_TXT.CustomButton.UseSelectable = true;
            this.ChatCount_TXT.CustomButton.Visible = false;
            this.ChatCount_TXT.Lines = new string[0];
            this.ChatCount_TXT.Location = new System.Drawing.Point(4, 261);
            this.ChatCount_TXT.MaxLength = 32767;
            this.ChatCount_TXT.Name = "ChatCount_TXT";
            this.ChatCount_TXT.PasswordChar = '\0';
            this.ChatCount_TXT.PromptText = "보낼 횟수 설정";
            this.ChatCount_TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChatCount_TXT.SelectedText = "";
            this.ChatCount_TXT.SelectionLength = 0;
            this.ChatCount_TXT.SelectionStart = 0;
            this.ChatCount_TXT.ShortcutsEnabled = true;
            this.ChatCount_TXT.Size = new System.Drawing.Size(152, 23);
            this.ChatCount_TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.ChatCount_TXT.TabIndex = 19;
            this.ChatCount_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChatCount_TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChatCount_TXT.UseSelectable = true;
            this.ChatCount_TXT.UseStyleColors = true;
            this.ChatCount_TXT.WaterMark = "보낼 횟수 설정";
            this.ChatCount_TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChatCount_TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(61, 325);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 15);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "End : 채팅 도배 중단";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // option_F7_Lbl
            // 
            this.option_F7_Lbl.AutoSize = true;
            this.option_F7_Lbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.option_F7_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.option_F7_Lbl.ForeColor = System.Drawing.Color.Silver;
            this.option_F7_Lbl.Location = new System.Drawing.Point(72, 221);
            this.option_F7_Lbl.Name = "option_F7_Lbl";
            this.option_F7_Lbl.Size = new System.Drawing.Size(92, 15);
            this.option_F7_Lbl.TabIndex = 13;
            this.option_F7_Lbl.Text = "F7 : 관계자 매수";
            this.option_F7_Lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.option_F7_Lbl.UseCustomForeColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Page_Normal);
            this.TabControl.Controls.Add(this.Page_Chat);
            this.TabControl.Controls.Add(this.Page_Option);
            this.TabControl.Location = new System.Drawing.Point(15, 100);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(257, 389);
            this.TabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.TabControl.TabIndex = 21;
            this.TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl.UseSelectable = true;
            // 
            // Page_Normal
            // 
            this.Page_Normal.Controls.Add(this.option_F7_Lbl);
            this.Page_Normal.Controls.Add(this.CEO_CheckBox);
            this.Page_Normal.Controls.Add(this.option_F3_Lbl);
            this.Page_Normal.Controls.Add(this.option_F4_Lbl);
            this.Page_Normal.Controls.Add(this.option_Num0_Lbl);
            this.Page_Normal.Controls.Add(this.option_F6_Lbl);
            this.Page_Normal.Controls.Add(this.option_F5_Lbl);
            this.Page_Normal.Controls.Add(this.option_F2_Lbl);
            this.Page_Normal.Controls.Add(this.option_Num1_Lbl);
            this.Page_Normal.HorizontalScrollbarBarColor = true;
            this.Page_Normal.HorizontalScrollbarHighlightOnWheel = false;
            this.Page_Normal.HorizontalScrollbarSize = 10;
            this.Page_Normal.Location = new System.Drawing.Point(4, 38);
            this.Page_Normal.Name = "Page_Normal";
            this.Page_Normal.Size = new System.Drawing.Size(249, 347);
            this.Page_Normal.TabIndex = 0;
            this.Page_Normal.Text = "일반 매크로";
            this.Page_Normal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Page_Normal.VerticalScrollbarBarColor = true;
            this.Page_Normal.VerticalScrollbarHighlightOnWheel = false;
            this.Page_Normal.VerticalScrollbarSize = 10;
            // 
            // Page_Chat
            // 
            this.Page_Chat.Controls.Add(this.SendChat_BTN);
            this.Page_Chat.Controls.Add(this.metroLabel3);
            this.Page_Chat.Controls.Add(this.option_Insert_Lbl);
            this.Page_Chat.Controls.Add(this.ChatCount_TXT);
            this.Page_Chat.Controls.Add(this.ChatListBox);
            this.Page_Chat.Controls.Add(this.AddChat_TXT);
            this.Page_Chat.HorizontalScrollbarBarColor = true;
            this.Page_Chat.HorizontalScrollbarHighlightOnWheel = false;
            this.Page_Chat.HorizontalScrollbarSize = 10;
            this.Page_Chat.Location = new System.Drawing.Point(4, 38);
            this.Page_Chat.Name = "Page_Chat";
            this.Page_Chat.Size = new System.Drawing.Size(249, 347);
            this.Page_Chat.TabIndex = 1;
            this.Page_Chat.Text = "채팅 매크로";
            this.Page_Chat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Page_Chat.VerticalScrollbarBarColor = true;
            this.Page_Chat.VerticalScrollbarHighlightOnWheel = false;
            this.Page_Chat.VerticalScrollbarSize = 10;
            // 
            // SendChat_BTN
            // 
            this.SendChat_BTN.Location = new System.Drawing.Point(162, 232);
            this.SendChat_BTN.Name = "SendChat_BTN";
            this.SendChat_BTN.Size = new System.Drawing.Size(77, 52);
            this.SendChat_BTN.Style = MetroFramework.MetroColorStyle.Blue;
            this.SendChat_BTN.TabIndex = 24;
            this.SendChat_BTN.Text = "추가";
            this.SendChat_BTN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SendChat_BTN.UseSelectable = true;
            this.SendChat_BTN.UseStyleColors = true;
            this.SendChat_BTN.Click += new System.EventHandler(this.SendChat_BTN_Click);
            // 
            // Page_Option
            // 
            this.Page_Option.Controls.Add(this.ExitGTA5_BTN);
            this.Page_Option.Controls.Add(this.SetSolo_BTN);
            this.Page_Option.HorizontalScrollbarBarColor = true;
            this.Page_Option.HorizontalScrollbarHighlightOnWheel = false;
            this.Page_Option.HorizontalScrollbarSize = 10;
            this.Page_Option.Location = new System.Drawing.Point(4, 38);
            this.Page_Option.Name = "Page_Option";
            this.Page_Option.Size = new System.Drawing.Size(249, 347);
            this.Page_Option.TabIndex = 2;
            this.Page_Option.Text = "부가 기능";
            this.Page_Option.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Page_Option.VerticalScrollbarBarColor = true;
            this.Page_Option.VerticalScrollbarHighlightOnWheel = false;
            this.Page_Option.VerticalScrollbarSize = 10;
            // 
            // ExitGTA5_BTN
            // 
            this.ExitGTA5_BTN.Location = new System.Drawing.Point(3, 62);
            this.ExitGTA5_BTN.Name = "ExitGTA5_BTN";
            this.ExitGTA5_BTN.Size = new System.Drawing.Size(243, 27);
            this.ExitGTA5_BTN.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ExitGTA5_BTN.TabIndex = 24;
            this.ExitGTA5_BTN.Text = "GTA5 강제 종료";
            this.ExitGTA5_BTN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExitGTA5_BTN.UseSelectable = true;
            this.ExitGTA5_BTN.UseStyleColors = true;
            this.ExitGTA5_BTN.Click += new System.EventHandler(this.ExitGTA5_BTN_Click);
            // 
            // SetSolo_BTN
            // 
            this.SetSolo_BTN.Location = new System.Drawing.Point(4, 16);
            this.SetSolo_BTN.Name = "SetSolo_BTN";
            this.SetSolo_BTN.Size = new System.Drawing.Size(242, 27);
            this.SetSolo_BTN.Style = MetroFramework.MetroColorStyle.Red;
            this.SetSolo_BTN.TabIndex = 23;
            this.SetSolo_BTN.Text = "1인 공개세션";
            this.SetSolo_BTN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetSolo_BTN.UseSelectable = true;
            this.SetSolo_BTN.UseStyleColors = true;
            this.SetSolo_BTN.Click += new System.EventHandler(this.SetSolo_BTN_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(206, 490);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 15);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "ver : 24.11";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GTA_DIAMOND_MACRO.Properties.Resources.Diamond_Width_2;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Interval = 1000;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // MainForm
            // 
            this.AccessibleName = "*";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 505);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel4);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "*";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_MacroForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_MacroForm_Load);
            this.TabControl.ResumeLayout(false);
            this.Page_Normal.ResumeLayout(false);
            this.Page_Normal.PerformLayout();
            this.Page_Chat.ResumeLayout(false);
            this.Page_Chat.PerformLayout();
            this.Page_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel option_F2_Lbl;
        private MetroFramework.Controls.MetroLabel option_F3_Lbl;
        private MetroFramework.Controls.MetroLabel option_F4_Lbl;
        private MetroFramework.Controls.MetroLabel option_F5_Lbl;
        private MetroFramework.Controls.MetroLabel option_F6_Lbl;
        private MetroFramework.Controls.MetroLabel option_Num0_Lbl;
        private MetroFramework.Controls.MetroLabel option_Num1_Lbl;
        private MetroFramework.Controls.MetroTextBox AddChat_TXT;
        private MetroFramework.Controls.MetroLabel option_Insert_Lbl;
        private MetroFramework.Controls.MetroTextBox ChatCount_TXT;
        private MetroFramework.Controls.MetroLabel option_F7_Lbl;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage Page_Normal;
        private MetroFramework.Controls.MetroTabPage Page_Chat;
        private MetroFramework.Controls.MetroTabPage Page_Option;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton SendChat_BTN;
        private MetroFramework.Controls.MetroButton SetSolo_BTN;
        private MetroFramework.Controls.MetroButton ExitGTA5_BTN;
        private System.Windows.Forms.Timer ProcessTimer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroCheckBox CEO_CheckBox;
        public System.Windows.Forms.ListBox ChatListBox;
    }
}

