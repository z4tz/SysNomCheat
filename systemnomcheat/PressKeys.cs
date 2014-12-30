using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemnomcheat
{
    class PressKeys
    {
        public static void Write(String keys)
        {
            for(int i=0;i<keys.Length;i++)
            {
                SendKeys.SendWait(keys[i].ToString());
            }
        }

    }
}
