﻿#pragma checksum "..\..\..\Страницы\СписокТоваров.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1E22787EA78AFF3BCD9B5B19B0BC8880EBDB4F89D22DE4DDEFAD33B3B18FE0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
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
using WpStozohilovEgor.Страницы;


namespace WpStozohilovEgor.Страницы {
    
    
    /// <summary>
    /// СписокТоваров
    /// </summary>
    public partial class СписокТоваров : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Страницы\СписокТоваров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGProducts;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Страницы\СписокТоваров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterList;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Страницы\СписокТоваров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortList;
        
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
            System.Uri resourceLocater = new System.Uri("/WpStozohilovEgor;component/%d0%a1%d1%82%d1%80%d0%b0%d0%bd%d0%b8%d1%86%d1%8b/%d0%" +
                    "a1%d0%bf%d0%b8%d1%81%d0%be%d0%ba%d0%a2%d0%be%d0%b2%d0%b0%d1%80%d0%be%d0%b2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Страницы\СписокТоваров.xaml"
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
            
            #line 9 "..\..\..\Страницы\СписокТоваров.xaml"
            ((WpStozohilovEgor.Страницы.СписокТоваров)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChange);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGProducts = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.FilterList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 45 "..\..\..\Страницы\СписокТоваров.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnFilter_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SortList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 56 "..\..\..\Страницы\СписокТоваров.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSort_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 60 "..\..\..\Страницы\СписокТоваров.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnGoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

