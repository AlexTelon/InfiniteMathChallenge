using InfiniteMathChallenge.MathEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InfiniteMathChallenge.Controls
{
    /// <summary>
    /// Interaction logic for StatsControl.xaml
    /// </summary>
    public partial class StatsControl : UserControl
    {
        public StatsControl()
        {
            InitializeComponent();
        }

        public ResultLog Stats
        {
            get { return (ResultLog)GetValue(StatsProperty); }
            set { SetValue(StatsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Stats.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StatsProperty =
            DependencyProperty.Register("Stats", typeof(ResultLog), typeof(StatsControl));


    }
}
