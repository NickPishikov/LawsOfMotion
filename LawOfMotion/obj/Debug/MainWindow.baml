   M S B A M L   `   `   `  ����G  CLawsOfMotion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LawsOfMotionLawsOfMotion  5   	       LawsOfMotion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   &localclr-namespace:LawsOfMotion  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$ grid1��5
      .+�5   
     OxyPlot.Wpf.Plot  -   5          Name$
 graf��5   +      Title$# Законы движений��6      Series. 5        OxyPlot.Wpf.LineSeries    OxyPlot.Wpf.Series   Title$	 Cos��6      Color$ Orange��5      ��5      �� *
CosPoint+5        5      $	 Sin��6   $ Green��5      ��5      �� *
SinPoint+5        5      $ Const��6   $	 Red��5      ��5      �� *
ConstPoint+5        5      $ Linear��6   $
 Blue��5      ��5      �� *LinearPoint+5         Axes 5        OxyPlot.Wpf.LinearAxis  5        OxyPlot.Wpf.Axis   Title$ X��6!   	   Maximum$		 630Q�5      
   MinorGridlineStyle$

 Dash=�5         Position$ Bottom=�5        5      $ Y��6!   $		 300Q�5   "   $

 Dash=�5!       $
 Left=�5#      5%      5&      5'      