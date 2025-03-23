using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_DIAMOND_MACRO
{
    public class MenuOptions
    {
        public static bool IsHide { get; private set; } = false;
        private static bool ceoMode = false;

        public static bool CEOMode
        {
            get {return ceoMode; }
            set
            {
                ceoMode = value;
                if (Application.OpenForms["MainForm"] is MainForm mainForm)
                {
                    mainForm.CEO_CheckBox.Checked = ceoMode;
                }
            }
        }
        public static bool IsIdle { get; set; } = false;
        public void ToggleFormVisibility()
        {
            if (IsHide) Application.OpenForms[0].Show();
            else Application.OpenForms[0].Hide();
            IsHide = !IsHide;
        }

        public void ToggleCEOMode()
        {
            CEOMode = !CEOMode;
            MenuActions(CEOMode ? "ActivateCEO" : "DeactivateCEO");
        }        
        public void ToggleBikerMode()
        {
            CEOMode = !CEOMode;
            MenuActions(CEOMode ? "ActivateBiker" : "DeactivateBiker");
        }
        public void UtilityOpen() => MenuActions("OpenUtilityWindow");
        public void SnackOpen() => MenuActions("OpenSnackWindow");
        public void BulletProof() => MenuActions("BulletProof");

        public void RefillAmmo() => MenuActions("RefillAmmo");

        public void NightVision() => MenuActions("NightVision");
        public void PreventIdle() => MenuActions("PreventIdle");

        public void StopPreventIdle() => IsIdle = false;
        public void PassiveMode() => MenuActions("Passive Mode");
        public void BullShark() => CEOActions("BullShark");
        public void GhostOrganization() => CEOActions("Ghost Organization");
        public void NeverWanted() => CEOActions("Never Wanted");

        public void ChatSpam(string chatText, int count)
        {
            for (int i = 0; i < count; i++)
            {
                SendText(chatText);
            }
        }
        private void MenuActions(string action)
        {
            switch (action)
            {
                case "ActivateCEO":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "DeactivateCEO":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "ActivateBiker":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;                
                case "DeactivateBiker":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "OpenUtilityWindow":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                #region "[     Old Code     ]"
                    //24년 11월 패치 기점으로 빠른 속도의 키보드 연타를 GTA5 내에서 인식하지 않도록 설계된 것으로 추정.
                    //그런 이유로 코드의 속도를 조정하려고 했으나, Thread.Sleep(80)이 마지노선이고 매크로 성능이 떨어져서 코드를 제거하고 유틸창 기능으로 대체.
                case "OpenSnackWindow":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "BulletProof":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.ESCAPE);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.ESCAPE);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.ESCAPE);
                    break;
                case "RefillAmmo":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "NightVision":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);                    
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.SPACE);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.ESCAPE);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.ESCAPE);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.ESCAPE);
                    break;
                #endregion
                case "PreventIdle":
                    IsIdle = !IsIdle;
                    while (IsIdle == true)
                    {
                        if (IsIdle == false) break;
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_W);
                        Thread.Sleep(50);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_A);
                        Thread.Sleep(50);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_S);
                        Thread.Sleep(50);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_D);
                        Thread.Sleep(50);
                    }
                    break;
                case "Passive Mode":
                    if (CEOMode)
                    {
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                        Thread.Sleep(100);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                        CEOMode = !CEOMode;
                    }
                    else
                    {
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                        Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    }
                   
                    break;

            }
        }

        private void CEOActions(string action)
        {
            switch (action)
            {
                case "BullShark":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.DOWN, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "Ghost Organization":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;                
                case "Never Wanted":
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.KEY_M);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.UP, true);
                    Keyboard.FuckingPressKey(Keyboard.ScanCodeShort.RETURN);
                    break;
            }
        }

        private void SendText(string chatText)
        {
            switch (chatText)
            {
                case "빈 칸 도배":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.SPACE);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "CRY":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_C);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_R);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_Y);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "RIP":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_R);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_I);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_P);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "NOOB":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_N);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_O);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_O);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_B);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "NICE HACK":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_N);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_I);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_C);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_E);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.SPACE);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_H);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_A);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_C);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_K);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "EZ":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_E);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_Z);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "lol":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_L);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_O);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_L);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case ";p":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.OEM_1);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_P);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                case "러시아 욕":
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    SendKeys.Send("Сосать");
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
                default:
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.KEY_T);
                    SendKeys.Send(chatText);
                    Keyboard.FuckingSendChat(Keyboard.ScanCodeShort.RETURN);
                    break;
            }
        }
    }
}
