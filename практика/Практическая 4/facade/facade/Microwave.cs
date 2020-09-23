using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    class Microwave
    {
        private Drive _drive;
        private Power _power;
        private Notification _notification;

        public Microwave(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }

        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowaverPower = 1000;
            _drive.TurlRight();
            _drive.TurlRight();
            _power.MicrowaverPower = 500;
            _drive.Stop();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowaverPower = 200;
            _drive.Stop();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowaverPower = 0;
            _notification.StopNotification();
        }

        public  void MediumRare()
        {
            _notification.StartNotification();
            _power.MicrowaverPower = 500;
            _drive.TurlRight();
            _power.MicrowaverPower = 1000;
            _drive.TurlRight();
            _power.MicrowaverPower = 1500;
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowaverPower = 1000;
            _drive.TurlLeft();
            _power.MicrowaverPower = 800;
            _drive.TurlLeft();
            _power.MicrowaverPower = 400;
            _drive.TurlLeft();
            _drive.Stop();
            _power.MicrowaverPower = 0;
            _notification.StopNotification();
        }
    }
}
