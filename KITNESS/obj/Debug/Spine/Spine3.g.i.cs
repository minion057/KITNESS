﻿#pragma checksum "..\..\..\Spine\Spine3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6F86630E31D70D77D1EFD49981356DF679D3AF06"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using Kitness.Leg;
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
using WpfAnimatedGif;


namespace Kitness.Spine {
    
    
    /// <summary>
    /// Spine3
    /// </summary>
    public partial class Spine3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image user_img;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_gif;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label count;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label stepno;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_restart;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Spine\Spine3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_back;
        
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
            System.Uri resourceLocater = new System.Uri("/Kitness;component/spine/spine3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Spine\Spine3.xaml"
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
            this.canvas1 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.user_img = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.img_gif = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.count = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.stepno = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.bt_restart = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Spine\Spine3.xaml"
            this.bt_restart.Click += new System.Windows.RoutedEventHandler(this.Restart);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bt_back = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Spine\Spine3.xaml"
            this.bt_back.Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

