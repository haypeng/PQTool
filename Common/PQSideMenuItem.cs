using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PQToolBoxCore.Common
{
    public class PQSideMenuItem : SideMenuItem
    {


        public ToolType ToolType
        {
            get { return (ToolType)GetValue(ToolTypeProperty); }
            set { SetValue(ToolTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ToolType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToolTypeProperty =
            DependencyProperty.Register("ToolType", typeof(ToolType), typeof(PQSideMenuItem), new PropertyMetadata(ToolType.Hot));



        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
        DependencyProperty.Register("Image", typeof(ImageSource), typeof(PQSideMenuItem), new PropertyMetadata(null, OnImageChanged));

        private static void OnImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var item = d as PQSideMenuItem;
            if (item == null)
                return;

            //item.Icon=new ImageBrush(item.Image);
            item.Icon = new Image()
            {
                Source = item.Image,
                Width = 24,
            };


        }
    }
}
