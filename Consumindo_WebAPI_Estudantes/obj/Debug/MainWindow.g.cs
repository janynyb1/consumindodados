﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BD3382C4F876DE85DD40C4BBB87FB743B70109E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Consumindo_WebAPI_Estudantes;
using System;
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


namespace Consumindo_WebAPI_Estudantes {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel estudantePanel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView estudantesListView;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomeEstudante;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIDEstudante;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxGenero;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdade;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNovoEstudante;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAtualiza;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel estudanteDetalhesPanel;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbEstudanteNome;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbEstudanteID;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbGenero;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbIdade;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetEstudante;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeletaEstudante;
        
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
            System.Uri resourceLocater = new System.Uri("/Consumindo_WebAPI_Estudantes;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.estudantePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.estudantesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.txtNomeEstudante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtIDEstudante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbxGenero = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.txtIdade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnNovoEstudante = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\MainWindow.xaml"
            this.btnNovoEstudante.Click += new System.Windows.RoutedEventHandler(this.btnNovoEstudante_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnAtualiza = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.btnAtualiza.Click += new System.Windows.RoutedEventHandler(this.btnAtualiza_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.estudanteDetalhesPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.txbEstudanteNome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.txbEstudanteID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.txbGenero = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.txbIdade = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.btnGetEstudante = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\MainWindow.xaml"
            this.btnGetEstudante.Click += new System.Windows.RoutedEventHandler(this.btnGetEstudante_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnDeletaEstudante = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\MainWindow.xaml"
            this.btnDeletaEstudante.Click += new System.Windows.RoutedEventHandler(this.btnDeletaEstudante_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

