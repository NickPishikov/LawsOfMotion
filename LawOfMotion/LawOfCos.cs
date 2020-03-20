using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    class LawOfCos:LawOfMotion
    {
        public override double CalcAcceleration(double time, double timer, double spath)
        {
        Acceleration= (Math.Pow(Math.PI,2) * spath * Math.Cos(Math.PI * timer / time)) / (2 * Math.Pow(time,2));
            return Acceleration;
        }

        public override double CalcVelocity(double time, double timer, double spath)
        {
            Velocity= (Math.PI * spath * Math.Sin(Math.PI * timer / time)) / (2 * time);
            return Velocity;
        }

        public override double CalcWay(double time, double timer, double spath)
        {
            Spath= (spath / 2) * (1 - Math.Cos((Math.PI * timer) / time));
            return Spath;
        }
    }
}
