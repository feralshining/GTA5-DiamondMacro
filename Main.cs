using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_DIAMOND_MACRO
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        //Keyboard Hook
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        public const int WM_CHAR = 0x102;

        private KeyEventHandler KeyEventHandler = null;
        private KeyboardHook k_hook = new KeyboardHook();
        //Mouse Hook
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        
        private readonly string[] MacroChat = new string[]
        {
            "빈 칸 도배", "CRY", "RIP", "NOOB", "NICE HACK", "EZ", "lol", ";p", "러시아 욕"
        };

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 후킹을 시작합니다.
        /// </summary>
        public void StartHooking()
        {
            if (KeyEventHandler == null)
            {
                KeyEventHandler = new KeyEventHandler(HandleKeyPress);
                k_hook.KeyDownEvent += KeyEventHandler;
                k_hook.Start();
            }
        }

        /// <summary>
        /// 후킹을 중단합니다.
        /// </summary>
        public void StopHooking()
        {
            if (KeyEventHandler != null)
            {
                k_hook.KeyDownEvent -= KeyEventHandler;
                KeyEventHandler = null;
                k_hook.Stop();
            }
        }

        private void Main_MacroForm_Load(object sender, EventArgs e)
        {
            ProcessManage p = new ProcessManage();
            if (!p.IsRunning())
            {
                MessageBox.Show("GTA5이 실행되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProcessTimer.Enabled = true;
            TabControl.SelectedTab = Page_Normal;
            TabControl.SelectedIndex = 0;
            StartHooking();

            foreach (var item in MacroChat)

            {
                ChatListBox.Items.Add(item);
            }
        }

        private void Main_MacroForm_FormClosed(object sender, FormClosedEventArgs e) => StopHooking();

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            MenuOptions menu = new MenuOptions();

            if ((int)ModifierKeys == (int)Keys.Control)
            {
                switch (e.KeyValue)
                {
                    case (int)Keys.NumPad0:
                        menu.PassiveMode();
                        break;
                    case (int)Keys.NumPad1:
                        if (!MenuOptions.IsIdle) menu.PreventIdle();
                        else menu.StopPreventIdle();
                        break;
                }
            }
            else
            {
                switch (e.KeyValue)
                {
                    case 106: // * 키
                        menu.ToggleFormVisibility();
                        break;
                    case 113: // F2
                        menu.ToggleCEOMode();
                        break;
                    case 114: // F3
                        menu.ToggleBikerMode();
                        break;
                    case 115: // F4
                        menu.UtilityOpen();
                        break;
                    case 116: // F5
                        menu.BullShark();
                        break;
                    case 117: // F6
                        menu.GhostOrganization();
                        break;
                    case 118: // F7
                        Console.WriteLine("test");
                        menu.NeverWanted();
                        break;
                    case 192: // ` 키
                        if (string.IsNullOrEmpty(ChatCount_TXT.Text)) return;
                        menu.ChatSpam(ChatListBox.SelectedItem.ToString(), Convert.ToInt32(ChatCount_TXT.Text));
                        break;
                }
            }   
        }
        /// <summary>
        /// 매 초마다 GTA5 프로세스의 실행 여부를 감지하고, GTA5 프로세스가 존재하지 않으면 앱을 종료합니다.
        /// </summary>
        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            ProcessManage p = new ProcessManage();
            if (!p.IsRunning()) Application.Exit();
        }

        /// <summary>
        /// 7.5초 동안 GTA5 프로세스를 중지하여 호스트와의 통신을 중단해, 강제로 1인 공개 세션으로 전환합니다.
        /// </summary>
        public void SoloSession()
        {
            ProcessManage p = new ProcessManage();
            if (p.IsRunning()) p.SuspendGTA5(7500);
        }

        /// <summary>
        /// 즉시 GTA5 프로세스를 Kill하여 종료합니다.
        /// </summary>
        public void ExitGTA5()
        {
            ProcessManage p = new ProcessManage();
            if (p.IsRunning()) p.ExitGTA5();
        }

        private void CEO_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CEO_CheckBox.Checked == true)
            {
                MenuOptions.CEOMode = true;
                option_F5_Lbl.ForeColor = Color.FromArgb(255, 128, 128);
                option_F6_Lbl.ForeColor = Color.FromArgb(255, 255, 192);
                option_F7_Lbl.ForeColor = Color.FromArgb(0, 42, 255);
            }
            else if (CEO_CheckBox.Checked == false)
            {
                MenuOptions.CEOMode = false;
                option_F5_Lbl.ForeColor = Color.FromArgb(64, 64, 64);
                option_F6_Lbl.ForeColor = Color.FromArgb(64, 64, 64);
                option_F7_Lbl.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SendChat_BTN_Click(object sender, EventArgs e) => ChatListBox.Items.Add(AddChat_TXT.Text);

        private void SetSolo_BTN_Click(object sender, EventArgs e)
        {
            Thread ExitGame = new Thread(SoloSession);
            ExitGame.Start();
        }

        private void ExitGTA5_BTN_Click(object sender, EventArgs e)
        {
            Thread ExitGame = new Thread(ExitGTA5);
            ExitGame.Start();
        }
    }
}

