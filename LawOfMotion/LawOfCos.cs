using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    class LawOfCos:LawOfMotion
    {
        public override void CalcAcceleration(double time, double timer, double spath)
        {
        Acceleration= (Math.Pow(Math.PI,2) * spath * Math.Cos(Math.PI * timer / time)) / (2 * Math.Pow(time,2));
        }

        public override void CalcVelocity(double time, double timer, double spath)
        {
            Velocity= (Math.PI * spath * Math.Sin(Math.PI * timer / time)) / (2 * time);
        }

        public override void CalcWay(double time, double timer, double spath)
        {
            Spath= (spath / 2) * (1 - Math.Cos((Math.PI * timer) / time));
        }
    }
}
