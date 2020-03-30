using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace KeyPressBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SoundPlayer sd = new SoundPlayer();
                sd.SoundLocation = @"D:\TIQRICDM\cdm\Inputs\ButtonClick\button_click_001.wav";
                sd.Play();
            }
            catch (Exception)
            {
                Console.WriteLine("Error :- Beep Sound path not found");
            }
        }
    }
}
