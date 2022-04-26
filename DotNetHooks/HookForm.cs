using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetHooks
{
    public partial class HookForm : Form
    {

       
        
       
       

        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        #region DLL Import
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookEx", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetHook(int idHook, HookProc lpfnProc, IntPtr hMod, uint dwThreadId);


        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnsetHook(IntPtr hHook);


        [DllImport("user32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr NextHook(IntPtr hHook, int nCode, IntPtr wParam, IntPtr lParam);


        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandle", SetLastError = true)]
        private static extern IntPtr GetModule(String lpModuleName);
        #endregion


        [DllImport("user32.dll", EntryPoint = "SendInput", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint SendMessages(uint nInputs, INPUT[] inputs, int inpSize);

        private const int
            WM_KEYDOWN = 0x100,
            WH_KEYBOARD_LL = 13,

            WM_MOUSEMOVE = 0x200,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONDUP = 0x0202,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_MOUSWEHEEL = 0x020A,
            WH_MOUSE_LL = 14;

        public HookForm()
        {
            
            InitializeComponent();
        }

        #region Keyboard hook

        private IntPtr hKbHook;
        private HookProc kbHookPinned;
        private GCHandle kbGcHandle;

        [StructLayout(LayoutKind.Sequential)]
        struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
           
        }


        private void buttonStartKb_Click(object sender, EventArgs e)
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            using (ProcessModule currentModule = currentProcess.MainModule)
            {
                if (currentModule == null) return;

                kbHookPinned = KbHookProc;
                kbGcHandle = GCHandle.Alloc(kbHookPinned);
                hKbHook = SetHook(WH_KEYBOARD_LL, kbHookPinned, GetModule(currentModule.ModuleName), 0);
                kbHookStatus.Text = "active";
                kbHookStatus.ForeColor = Color.Green;

            }
        }



        private void buttonStopKb_Click(object sender, EventArgs e)
        {
            try
            {
                UnsetHook(hKbHook);
                kbGcHandle.Free();
                kbHookStatus.Text = "non-active";
                kbHookStatus.ForeColor = Color.Red;
            }
            catch
            {

                return;
            }





        }

        private IntPtr KbHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                //int keyVirtualCode = Marshal.ReadInt32(lParam);
                var msgData = Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam);
                Keys key = (Keys)msgData.vkCode;

                richTextBoxKbDemo.Text += key.ToString();
                /*if(key == Keys.LWin)
                {
                    richTextBoxKbDemo.Text += "(rejected)";
                    return (IntPtr)1;
                }*/

                if (key == Keys.Space) // Key to be replaced
                {
                    // new system message
                    INPUT inp = new INPUT
                    {
                        Type = 1 // Keyboard message
                    };
                    inp.Data.Keyboard.Vk = (ushort)Keys.OemMinus;
                    inp.Data.Keyboard.Scan = 0;
                    inp.Data.Keyboard.Flags = 0; // 0 - keyDown; 2 - keyUp
                    inp.Data.Keyboard.Time = 0;
                    inp.Data.Keyboard.ExtraInfo = IntPtr.Zero;



                    INPUT[] msgs = new INPUT[] { inp }; // For SendInput array needed



                    SendMessages(1, msgs, Marshal.SizeOf(typeof(INPUT)));

                    richTextBoxKbDemo.Text += "(Space -> -)";

                    // delete current message
                    return (IntPtr)1;
                }
            }

            return NextHook(hKbHook, nCode, wParam, lParam);
        }

        private void HookForm_Load(object sender, EventArgs e)
        {
            int x_res = Screen.PrimaryScreen.Bounds.Width / 10;
            int y_res = Screen.PrimaryScreen.Bounds.Height / 10;
            
           

            labelRes.Text = $"X: {x_res}\nY: {y_res}";


        }

        private void textBoxSourceKey_KeyDown(object sender, KeyEventArgs e)
        {
            
            e.Handled = true;
            e.SuppressKeyPress = true;
            
            if (sender is TextBox) (sender as TextBox).Text = e.KeyData.ToString();
            //source_key = e.KeyData.ToString();
            //source_key_event = e.KeyData.ToString();
            
            
        }

        private void textBoxNewKey_KeyDown(object sender, KeyEventArgs e)
        {
            
            e.Handled = true;
            e.SuppressKeyPress = true;
           
            if (sender is TextBox) (sender as TextBox).Text = e.KeyData.ToString();
           


        }

        private void buttonAddReplace_Click(object sender, EventArgs e)
        {
         
        }
        

    


        #endregion

        #region Mouse hook

        private IntPtr hMsHook;
        private HookProc MsHookPinned;
        private GCHandle MsGcHandle;

        [StructLayout(LayoutKind.Sequential)]
        struct POINT
        {
            public int x;
            public int y;

        }



        [StructLayout(LayoutKind.Sequential)]
        struct MsHookStruct
        {
            public POINT point;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

       

        [StructLayout(LayoutKind.Sequential)]
        internal struct INPUT
        {
            public uint Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }




        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public HARDWAREINPUT Hardware;
            [FieldOffset(0)]
            public KEYBDINPUT Keyboard;
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }




        [StructLayout(LayoutKind.Sequential)]
        internal struct HARDWAREINPUT
        {
            public uint Msg;
            public ushort ParamL;
            public ushort ParamH;
        }



        [StructLayout(LayoutKind.Sequential)]
        internal struct KEYBDINPUT
        {
            public ushort Vk;
            public ushort Scan;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }



        [StructLayout(LayoutKind.Sequential)]
        internal struct MOUSEINPUT
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        private IntPtr MsHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                //int keyVirtualCode = Marshal.ReadInt32(lParam);
                var msgData = Marshal.PtrToStructure<POINT>(lParam);

                switch ((int)wParam)
                {
                    case WM_LBUTTONDOWN: listBoxMs.Items.Add($"L{msgData.x},{msgData.y}"); break;
                    case WM_RBUTTONDOWN: listBoxMs.Items.Add($"R{msgData.x},{msgData.y}"); break;
                    case WM_MOUSEMOVE:
                        var gdi = panelDisplay.CreateGraphics();
                        using (Brush b = new SolidBrush(Color.Tomato))
                            gdi.FillEllipse(b, msgData.x / 10, msgData.y / 10, 2, 2);
                        break;

                }

            }

            return NextHook(hMsHook, nCode, wParam, lParam);
        }
        private void buttonStartMs_Click(object sender, EventArgs e)
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            using (ProcessModule currentModule = currentProcess.MainModule)
            {
                if (currentModule == null) return;

                MsHookPinned = MsHookProc;
                MsGcHandle = GCHandle.Alloc(MsHookPinned);
                hMsHook = SetHook(WH_MOUSE_LL, MsHookPinned, GetModule(currentModule.ModuleName), 0);
                msHookStatus.Text = "active";
                msHookStatus.ForeColor = Color.Green;

            }
        }

        private void buttonStopMs_Click(object sender, EventArgs e)
        {
            try
            {
                MsGcHandle.Free();
                UnsetHook(hMsHook);
                msHookStatus.Text = "non-active";
                msHookStatus.ForeColor = Color.Red;
            }
            catch
            {

                return;
            }

        }

        #endregion
    }

   

}
