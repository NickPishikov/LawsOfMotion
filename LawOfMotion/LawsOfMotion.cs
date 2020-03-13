using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsOfMotion
{
    abstract class LawOfMotion
    {
        double Alf;//угол
        protected double Velocity { get; set; }//скорость
        double Time;//время
        protected double Acceleration { get; set; }//ускорение
        protected double Spath { get; set; }//Путь
        

        public abstract void CalcAcceleration(double time, double timer, double spath);
        public abstract void CalcVelocity(double time,double timer, double spath);
        public abstract void CalcWay(double time,double timer, double spath);
    }
}
