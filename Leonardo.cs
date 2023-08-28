using System;
using System.IO.Ports;


namespace FG_ARDUINO
{

    // Token: 0x02000023 RID: 35
    public class Leonardo
    {
        // Token: 0x060000BF RID: 191 RVA: 0x00007B5C File Offset: 0x00005D5C
        public Leonardo(string COMPORT)
        {
            this.port = new SerialPort(COMPORT, 115100);
            try
            {
                this.port.Open();
                this.ArduinoOpened = true;
            }
            catch
            {
                this.ArduinoOpened = false;
            }
        }

        // Token: 0x060000C0 RID: 192 RVA: 0x00007BC4 File Offset: 0x00005DC4
        public void Move(int x, int y, bool shot)
        {
            bool flag = this.port != null;
            bool flag2 = flag;
            if (flag2)
            {
                this.port.Write(string.Concat(new string[]
                {
                this.roundtosignedchar(x).ToString(),
                ",",
                this.roundtosignedchar(y).ToString(),
                ",",
                Convert.ToInt32(shot).ToString()
                }));
            }
        }

        // Token: 0x060000C1 RID: 193 RVA: 0x00007C40 File Offset: 0x00005E40
        private int roundtosignedchar(int a)
        {
            bool flag = a < -127;
            bool flag2 = flag;
            int result;
            if (flag2)
            {
                result = -127;
            }
            else
            {
                bool flag3 = a > 127;
                bool flag4 = flag3;
                if (flag4)
                {
                    result = 127;
                }
                else
                {
                    result = a;
                }
            }
            return result;
        }

        // Token: 0x0400007C RID: 124
        private SerialPort port = null;

        // Token: 0x0400007D RID: 125
        public bool ArduinoOpened = false;
    }
}
