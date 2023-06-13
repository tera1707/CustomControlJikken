// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CustomControlJikken2
{
    public sealed class MySignal : Control
    {
        private Button startButton;

        public TimeSpan GoTime
        {
            get => (TimeSpan)GetValue(GoTimeProperty);
            set { SetValue(GoTimeProperty, value); }
        }
        public static readonly DependencyProperty GoTimeProperty
            = DependencyProperty.Register(nameof(GoTime), typeof(TimeSpan), typeof(MySignal), new PropertyMetadata(TimeSpan.FromSeconds(5)));

        public TimeSpan StopTime
        {
            get => (TimeSpan)GetValue(StopTimeProperty);
            set { SetValue(StopTimeProperty, value); }
        }
        public static readonly DependencyProperty StopTimeProperty
            = DependencyProperty.Register(nameof(StopTime), typeof(TimeSpan), typeof(MySignal), new PropertyMetadata(TimeSpan.FromSeconds(5)));








        public MySignal()
        {
            this.DefaultStyleKey = typeof(MySignal);
        }

        // Ž©•ª‚Åoverride‚ð’Ç‰Á
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (startButton is not null)
            {
                startButton.Click -= StartButton_Click;
            }

            startButton = this.GetTemplateChild("PART_StartButton") as Button;

            if (startButton is not null)
            {
                startButton.Click += StartButton_Click;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
