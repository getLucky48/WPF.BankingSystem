﻿#pragma checksum "..\..\..\Windows\Register - Копировать (2).xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C13457C13833E1296BE67B339AD6FF3A1D7D9645B5581255542622E94C4F4035"
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


namespace BankingSystem.Windows {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Windows\Register - Копировать (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\Register - Копировать (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\Register - Копировать (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
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
            System.Uri resourceLocater = new System.Uri("/BankingSystem;component/windows/register%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0" +
                    "%be%d0%b2%d0%b0%d1%82%d1%8c%20(2).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Register - Копировать (2).xaml"
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
            
            #line 21 "..\..\..\Windows\Register - Копировать (2).xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Windows\Register - Копировать (2).xaml"
            this.Login.GotFocus += new System.Windows.RoutedEventHandler(this.LoginFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Windows\Register - Копировать (2).xaml"
            this.Login.LostFocus += new System.Windows.RoutedEventHandler(this.Login_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 40 "..\..\..\Windows\Register - Копировать (2).xaml"
            this.Password.LostFocus += new System.Windows.RoutedEventHandler(this.Password_LostFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Windows\Register - Копировать (2).xaml"
            this.Password.GotFocus += new System.Windows.RoutedEventHandler(this.Password_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\Windows\Register - Копировать (2).xaml"
            this.Name.GotFocus += new System.Windows.RoutedEventHandler(this.Name_GotFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\Windows\Register - Копировать (2).xaml"
            this.Name.LostFocus += new System.Windows.RoutedEventHandler(this.Name_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

