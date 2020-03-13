using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    class ConstLaw : LawOfMotion
    {
        public override void CalcAcceleration(double time, double timer, double spath)
        {
            Acceleration = 0;
        }

        public override void CalcVelocity(double time, double timer, double spath)
        {
            Velocity = spath / time;
        }

        public override void CalcWay(double time, double timer, double spath)
        {
            Spath = spath * (timer / time);
        }
    }
}
