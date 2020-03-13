﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    class LawOfSin:LawOfMotion
    {
        public override void CalcAcceleration(double time, double timer, double spath)
        {
            Acceleration = (2 * Math.PI * spath * Math.Sin((2 * Math.PI * timer) / time)) / (Math.Pow(time, 2));
        }

        public override void CalcVelocity(double time, double timer, double spath)
        {
            Velocity = (spath / time) * (1 - Math.Cos(2 * Math.PI * timer / time));
        }

        public override void CalcWay(double time, double timer, double spath)
        {
            Spath = spath * (timer / time - Math.Sin(2 * Math.PI * timer / time) / (2 * Math.PI));
        }
    }

}
