using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OxyPlot;
using OxyPlot.Wpf;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace LawsOfMotion
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        LawOfCos cos;
        LawOfSin sin;
        ConstLaw const_;
        LinearLaw linear;
     
        int Tstep = 0;
        int Tsteps = 600;
      public  ObservableCollection<DataPoint> CosPoint { get;private set; } = new ObservableCollection<DataPoint>();
        public ObservableCollection<DataPoint> SinPoint { get; private set; } = new ObservableCollection<DataPoint>();
        public ObservableCollection<DataPoint> ConstPoint { get; private set; } = new ObservableCollection<DataPoint>();
        public ObservableCollection<DataPoint> LinearPoint { get; private set; } = new ObservableCollection<DataPoint>();
        double deltime = 0;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        LineSeries series = new LineSeries();

      

        public MainWindow()
        {
           
            cos = new LawOfCos();
            sin = new LawOfSin();
            const_ = new ConstLaw();
            linear = new LinearLaw();
        
            timer.Interval = TimeSpan.FromMilliseconds(0.01);
            timer.Tick += timerTick;
            timer.Start();
            InitializeComponent();
            this.DataContext = this;
           



            
            //Решить таймер.
            //Теор вер
        }//Английский

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName]string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}

        private void timerTick(object sender, EventArgs e)
        {


            deltime = (500d / Tsteps) * Tstep++;
            CosPoint.Add(new DataPoint(Tstep , cos.CalcAcceleration(500,deltime,500)*10000));
            SinPoint.Add(new DataPoint(Tstep , sin.CalcAcceleration(500,deltime,500)* 10000));
            LinearPoint.Add(new DataPoint(Tstep , linear.CalcAcceleration(500,deltime,500)* 10000));
            ConstPoint.Add(new DataPoint(Tstep , const_.CalcAcceleration(500,deltime,500)* 10000));
            if (Tsteps == Tstep)
                timer.Stop();
                
           
        }
    }
}
