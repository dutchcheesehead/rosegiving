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
using Aldebaran.Proxies;


namespace CadeauThea
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly static string NAO_IP_ADDRESS = "10.0.1.2";
        private readonly static int NAO_PORT = 9559;
        private TextToSpeechProxy TextToSpeechProxy;
        private BehaviorManagerProxy BehaviorManagerProxy;
        private LedsProxy LedsProxy;

        public MainWindow()
        {
            InitializeComponent();
            
            this.TextToSpeechProxy = new TextToSpeechProxy(NAO_IP_ADDRESS, NAO_PORT);
            this.BehaviorManagerProxy = new BehaviorManagerProxy(NAO_IP_ADDRESS, NAO_PORT);
            this.LedsProxy = new LedsProxy(NAO_IP_ADDRESS, NAO_PORT);
        }

        private void Start_walking(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/walkForward");
        }
        private void Stop_all(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.stopAllBehaviors();
        }

        private void Rotate_left(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/turnLeft");
        }

        private void Rotate_right(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/turnRight");
        }

        private void Spin_left(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/turnRight");
        }
        private void Spin_right(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/turnLeft");
        }
        private void Ask_for_rose(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/take_rose");
        }
        private void Give_rose(object sender, RoutedEventArgs e)
        {
            BehaviorManagerProxy.post.runBehavior("thea/giveRose");
        }
    }

}
