using System;
using System.Threading;

namespace ClassLibraryCooking
{
    public class Cake
    {
        const int volumeMaxInPercent = 120;
        int volumeInPerCent;
        Thread threadInflate;
        Thread threadCook;

        public Cake()
        {
            volumeInPerCent = 10;
            threadInflate = new Thread(new ThreadStart(Inflate));
            threadCook = new Thread(new ThreadStart(Cook));
        }



        public delegate void DelegateInflateDone(int size);
        public event DelegateInflateDone InformUserAboutInflation;        
        public delegate void DelegateCookDone(int size);
        public event DelegateCookDone InformUserAboutCook;

        private void Inflate()
        {
            while (volumeInPerCent != volumeMaxInPercent)
            {
                Thread.Sleep(500);
                volumeInPerCent += 10;
                Console.WriteLine($"Cake increase : +10 % / Cake volume : {volumeInPerCent}%");
                if (volumeInPerCent == volumeMaxInPercent && InformUserAboutInflation != null)
                    InformUserAboutInflation(volumeInPerCent);
            }
        }

        public void Finish()
        {
            threadInflate.Start();
            threadCook.Start();
        }

        private void Cook()
        {
            while (volumeInPerCent != volumeMaxInPercent)
            {
                Thread.Sleep(700);
                volumeInPerCent += 10;
                Console.WriteLine($"Cooking : +10 % / Cake volume : {volumeInPerCent}%");
                if (volumeInPerCent == volumeMaxInPercent && InformUserAboutInflation != null)
                    InformUserAboutCook(volumeInPerCent);
            }
        }
    }
}
