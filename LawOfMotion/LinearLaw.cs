using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    class LinearLaw : LawOfMotion
    {
        public override double CalcAcceleration(double time, double timer, double spath)
        {
            if (timer <= time / 2)
                Acceleration = 4 * spath / Math.Pow(time, 2);
            else
                Acceleration = -4 * spath / Math.Pow(time, 2);
            return Acceleration;
        }

        public override double CalcVelocity(double time, double timer, double spath)
        {
            if (timer <= time / 2)
                Velocity = 4 * spath * timer / Math.Pow(time, 2);
            else
                Velocity= (4 * spath / time) * ((time - timer) / timer);
            return Velocity;
        }

        public override double CalcWay(double time, double timer, double spath)
        {
            if (timer <= time / 2)
                Spath = 2 * spath * Math.Pow(timer / time, 2);
            else
                Spath = spath - 2 * spath * Math.Pow((time - timer) / time, 2);
            return Spath;

        }

    }
    
}
