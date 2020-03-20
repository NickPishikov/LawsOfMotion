using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    class ConstLaw : LawOfMotion
    {
        public override double CalcAcceleration(double time, double timer, double spath)
        {
            Acceleration = 0;
            return Acceleration;
        }

        public override double CalcVelocity(double time, double timer, double spath)
        {
            Velocity = spath / time;
            return Velocity;
        }

        public override double CalcWay(double time, double timer, double spath)
        {
            Spath = spath * (timer / time);
            return Spath;
        }
    }
}
