﻿#pragma checksum "..\..\CmdQManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1931B438803647ECEB93555D2C18868"
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
using WpfStackerLibrary;


namespace WpfStackerLibrary {
    
    
    /// <summary>
    /// CmdQManager
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CmdQManager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 29 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Take;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Push;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Trans1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Trans2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGCmdlist;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_prev_cmd;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btn_play;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_next_cmd;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\CmdQManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btn_cycle_cmd;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfStackerLibrary;component/cmdqmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CmdQManager.xaml"
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
            
            #line 7 "..\..\CmdQManager.xaml"
            ((WpfStackerLibrary.CmdQManager)(target)).Initialized += new System.EventHandler(this.UserControl_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB_Take = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\CmdQManager.xaml"
            this.TB_Take.KeyUp += new System.Windows.Input.KeyEventHandler(this.TB_Take_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TB_Push = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\CmdQManager.xaml"
            this.TB_Push.KeyUp += new System.Windows.Input.KeyEventHandler(this.TB_Push_KeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TB_Trans1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TB_Trans2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\CmdQManager.xaml"
            this.TB_Trans2.KeyUp += new System.Windows.Input.KeyEventHandler(this.TB_Trans2_KeyUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DGCmdlist = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\CmdQManager.xaml"
            this.DGCmdlist.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid_LoadingRow);
            
            #line default
            #line hidden
            
            #line 33 "..\..\CmdQManager.xaml"
            this.DGCmdlist.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DGCmdlist_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_prev_cmd = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\CmdQManager.xaml"
            this.btn_prev_cmd.Click += new System.Windows.RoutedEventHandler(this.btn_prev_cmd_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_play = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 14:
            this.btn_next_cmd = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\CmdQManager.xaml"
            this.btn_next_cmd.Click += new System.Windows.RoutedEventHandler(this.btn_next_cmd_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 131 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Image)(target)).ImageFailed += new System.EventHandler<System.Windows.ExceptionRoutedEventArgs>(this.Image_ImageFailed);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btn_cycle_cmd = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 134 "..\..\CmdQManager.xaml"
            this.btn_cycle_cmd.Click += new System.Windows.RoutedEventHandler(this.btn_next_cmd_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 135 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Image)(target)).ImageFailed += new System.EventHandler<System.Windows.ExceptionRoutedEventArgs>(this.Image_ImageFailed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 11:
            
            #line 86 "..\..\CmdQManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

