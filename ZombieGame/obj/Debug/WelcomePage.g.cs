﻿#pragma checksum "C:\Users\Administrator\Desktop\ProjectNew這個有改過HANK的專案之後都是用這個改得\ZombieGame\ZombieGame\WelcomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAF482332A20F87103FA795B94D9D917"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.225
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ZombieGame {
    
    
    public partial class WelcomePage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard TextMove;
        
        internal System.Windows.Media.Animation.Storyboard Transition;
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState Normal;
        
        internal System.Windows.VisualState Turn;
        
        internal System.Windows.Controls.TextBlock Escape;
        
        internal System.Windows.Controls.TextBlock Zombies;
        
        internal System.Windows.Shapes.Rectangle InBlack;
        
        internal System.Windows.Shapes.Rectangle Door;
        
        internal System.Windows.Controls.HyperlinkButton Enter;
        
        internal Microsoft.Expression.Interactivity.Core.GoToStateAction Leave;
        
        internal Microsoft.Expression.Interactivity.Core.GoToStateAction Enter1;
        
        internal System.Windows.Controls.Image image;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ZombieGame;component/WelcomePage.xaml", System.UriKind.Relative));
            this.TextMove = ((System.Windows.Media.Animation.Storyboard)(this.FindName("TextMove")));
            this.Transition = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Transition")));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("VisualStateGroup")));
            this.Normal = ((System.Windows.VisualState)(this.FindName("Normal")));
            this.Turn = ((System.Windows.VisualState)(this.FindName("Turn")));
            this.Escape = ((System.Windows.Controls.TextBlock)(this.FindName("Escape")));
            this.Zombies = ((System.Windows.Controls.TextBlock)(this.FindName("Zombies")));
            this.InBlack = ((System.Windows.Shapes.Rectangle)(this.FindName("InBlack")));
            this.Door = ((System.Windows.Shapes.Rectangle)(this.FindName("Door")));
            this.Enter = ((System.Windows.Controls.HyperlinkButton)(this.FindName("Enter")));
            this.Leave = ((Microsoft.Expression.Interactivity.Core.GoToStateAction)(this.FindName("Leave")));
            this.Enter1 = ((Microsoft.Expression.Interactivity.Core.GoToStateAction)(this.FindName("Enter1")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
        }
    }
}
