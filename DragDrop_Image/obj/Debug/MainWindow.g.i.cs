﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E9832B771F6FD27F5E5B3B9EE7EFC771B8A985BA8E0F8AA9B7A747BF5566DC65"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DragDrop_Image;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DragDrop_Image {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle myRectangle;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush imageBrush;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseBtn;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leftBtn;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rightBtn;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chooseBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DragDrop_Image;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.listBox.MouseMove += new System.Windows.Input.MouseEventHandler(this.listBox_MouseMove);
            
            #line default
            #line hidden
            
            #line 85 "..\..\MainWindow.xaml"
            this.listBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 90 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.WrapPanel)(target)).AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.WrapPanel_Drop));
            
            #line default
            #line hidden
            return;
            case 4:
            this.myRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.imageBrush = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 6:
            this.pauseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\MainWindow.xaml"
            this.pauseBtn.Click += new System.Windows.RoutedEventHandler(this.pauseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.playBtn = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\MainWindow.xaml"
            this.playBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.leftBtn = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\MainWindow.xaml"
            this.leftBtn.Click += new System.Windows.RoutedEventHandler(this.leftBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rightBtn = ((System.Windows.Controls.Button)(target));
            
            #line 183 "..\..\MainWindow.xaml"
            this.rightBtn.Click += new System.Windows.RoutedEventHandler(this.rightBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.chooseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 204 "..\..\MainWindow.xaml"
            this.chooseBtn.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
