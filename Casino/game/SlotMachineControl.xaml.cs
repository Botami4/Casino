using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Casino.Engine;


namespace Casino.game
{
    /// <summary>
    /// Interaction logic for SlotMachineControl.xaml
    /// </summary>
    public partial class SlotMachineControl : UserControl
    {

        private const int VisibleRows = 3;
        private const int SymbolWidth = 200;
        private const int SymbolHeight = 60;

        private readonly SlotReel _reelA;
        private readonly SlotReel _reelB;
        private readonly SlotReel _reelC;
        private readonly PayoutTable _payout;
        private readonly Rng _rng;

        public SlotMachineControl()
        {
            InitializeComponent();
            _payout = new PayoutTable();
            _rng = new Rng();
            _reelA = new SlotReel(Reel1, SymbolWidth, SymbolHeight, VisibleRows, CreateSymbolVisual);
            _reelB = new SlotReel(Reel2, SymbolWidth, SymbolHeight, VisibleRows, CreateSymbolVisual);
            _reelC = new SlotReel(Reel3, SymbolWidth, SymbolHeight, VisibleRows, CreateSymbolVisual);

            // Kezdő kitöltés

            _reelA.FillInitial(_rng);
            _reelB.FillInitial(_rng);
            _reelC.FillInitial(_rng);
        }
        
        private FrameworkElement CreateSymbolVisual(Symbol symbol)
        {
            var info = SymbolInfo.Get(symbol);
            var root = new Grid
            {
                Width = SymbolWidth,
                Height = SymbolHeight,
                Background = new SolidColorBrush(info.background)
            };

            root.Effect = new System.Windows.Media.Effects.DropShadowEffect
            {
                ShadowDepth = 0,
                BlurRadius = 8,
                Color = Color.FromRgb(20, 20, 20),
                Opacity = .6
            };

            var rect = new Rectangle
            {
                Fill = new LinearGradientBrush(info.background, Color.Multiply(info.background, 0.85f), 90),
                RadiusX = 10,
                RadiusY = 10
            };
            root.Children.Add(rect);
            var text = new TextBlock
            {
                Text = info.Lable,
                Foreground = new SolidColorBrush(info.Foreground),
                FontWeight = FontWeights.Bold,
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            root.Children.Add(text);
            return root;

        }
    }
}
