﻿#pragma checksum "..\..\StackerControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65DC85FBA9418097E80283BB471F63BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.1022
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfStackerLibrary;


namespace WpfStackerLibrary {
    
    
    /// <summary>
    /// StackerControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class StackerControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition stacker_left_panel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition stacker_right_panel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid stacker_rails;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border stacker_base;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel stacker_rect;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.ResourceDictionary StackerStyles;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle y_rect;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle z_left_rect;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rack_left;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\StackerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rack_right;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/WpfStackerLibrary;component/stackercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StackerControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\StackerControl.xaml"
            ((WpfStackerLibrary.StackerControl)(target)).Initialized += new System.EventHandler(this.UserControl_Initialized);
            
            #line default
            #line hidden
            
            #line 8 "..\..\StackerControl.xaml"
            ((WpfStackerLibrary.StackerControl)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 10 "..\..\StackerControl.xaml"
            ((System.ComponentModel.BackgroundWorker)(target)).DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            
            #line default
            #line hidden
            
            #line 10 "..\..\StackerControl.xaml"
            ((System.ComponentModel.BackgroundWorker)(target)).RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stacker_left_panel = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.stacker_right_panel = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 5:
            this.stacker_rails = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.stacker_base = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.stacker_rect = ((System.Windows.Controls.DockPanel)(target));
            
            #line 45 "..\..\StackerControl.xaml"
            this.stacker_rect.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.stacker_rails_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.StackerStyles = ((System.Windows.ResourceDictionary)(target));
            return;
            case 9:
            this.y_rect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 10:
            this.z_left_rect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 11:
            this.rack_left = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            this.rack_right = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

