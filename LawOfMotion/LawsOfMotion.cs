using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    abstract class LawOfMotion
    {
       
        protected double Velocity { get; set; }//скорость
   
        public double Acceleration { get; set; }//ускорение
        public double Spath { get; set; }//Путь
        

        public abstract double CalcAcceleration(double time, double timer, double spath);
        public abstract double CalcVelocity(double time,double timer, double spath);
        public abstract double CalcWay(double time,double timer, double spath);
    }
}
