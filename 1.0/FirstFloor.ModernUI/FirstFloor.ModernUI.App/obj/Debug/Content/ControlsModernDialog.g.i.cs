﻿#pragma checksum "..\..\..\Content\ControlsModernDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "206A94D75F9BB335254D1D6A6072B824"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.App;
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


namespace FirstFloor.ModernUI.App.Content {
    
    
    /// <summary>
    /// ControlsModernDialog
    /// </summary>
    public partial class ControlsModernDialog : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run dialogResult;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run dialogMessageBoxResult;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ok;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton okcancel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton yesno;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton yesnocancel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Content\ControlsModernDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run msgboxResult;
        
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
            System.Uri resourceLocater = new System.Uri("/ModernUIDemo;component/content/controlsmoderndialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Content\ControlsModernDialog.xaml"
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
            
            #line 11 "..\..\..\Content\ControlsModernDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CommonDialog_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dialogResult = ((System.Windows.Documents.Run)(target));
            return;
            case 3:
            this.dialogMessageBoxResult = ((System.Windows.Documents.Run)(target));
            return;
            case 4:
            this.ok = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.okcancel = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.yesno = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.yesnocancel = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            
            #line 29 "..\..\..\Content\ControlsModernDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MessageDialog_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.msgboxResult = ((System.Windows.Documents.Run)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

