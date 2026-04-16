using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__3
{
    class MobilePhone
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            if(OnRing !=null)
            {
                Console.WriteLine(" ");
                Console.WriteLine("----- RECEIVING CALL -----");
                OnRing();
            }
        }

    }
    class RingTonePlayer
    {
        public void Ringtone()
        {
            Console.WriteLine("Playing Ringtone");
        }
    }
    class ScreenDisplay
    {
        public void Screen()
        {
            Console.WriteLine("Displaying Caller Information");
        }
    }
    class VibrationMotor
    {
        public void Vibrate()
        {
            Console.WriteLine("Phone is Vibrating");
        }
    }

    class Caller
    {
        public static void Main()
        {
            MobilePhone phone = new MobilePhone();
            
            RingTonePlayer r= new RingTonePlayer();
            ScreenDisplay s = new ScreenDisplay();
            VibrationMotor v= new VibrationMotor();

            phone.OnRing += r.Ringtone;
            phone.OnRing += s.Screen;
            phone.OnRing += v.Vibrate;

            Console.WriteLine("Enter Call for Calling: ");
            string str = Console.ReadLine();
            if(str.ToLower()=="call")
            {
                phone.ReceiveCall();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("!!! Calling Not Supported !!!");
            }
        }
    }
}
