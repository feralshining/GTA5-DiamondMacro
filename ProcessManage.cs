using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace GTA_DIAMOND_MACRO
{
    class ProcessManage
    {
        private enum ThreadAccess
        {
            SUSPEND_RESUME = 0x0002
        }

        [DllImport("kernel32.dll")]
        private static extern uint SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool CloseHandle(IntPtr handle);

        /// <summary>
        /// 실행 중인 GTA5 프로세스를 즉시 종료합니다.
        /// </summary>
        public void ExitGTA5()
        {
          foreach (var proc in Process.GetProcessesByName("GTA5"))
            {
                proc.Kill();
            }
        }

        /// <summary>
        /// GTA5 프로세스의 실행 여부를 반환합니다.
        /// </summary>
        public bool IsRunning()
        {
            Process[] processes = Process.GetProcessesByName("GTA5");
            if (processes.Length > 0) return true;
            return false;
        }

        /// <summary>
        /// 입력 받은 초동안 프로세스의 작동을 중지합니다.
        /// </summary>
        public void SuspendGTA5(int sec)
        {
            Process[] processes = Process.GetProcessesByName("GTA5");

            foreach (ProcessThread processThread in processes[0].Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)processThread.Id);
                SuspendThread(pOpenThread);
                Thread.Sleep(sec);
                ResumeThread(pOpenThread);
                CloseHandle(pOpenThread);
                break;
            }
        }

    }
}
