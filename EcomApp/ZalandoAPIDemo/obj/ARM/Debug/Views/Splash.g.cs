﻿#pragma checksum "E:\Projects\Github\Github\Anees\EcomApp\EcomApp\ZalandoAPIDemo\Views\Splash.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5AE57CEF692BC21AD2A123C1C8B78BE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZalandoAPIDemo.Views
{
    partial class Splash : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.rootCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 2:
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 3:
                {
                    this.ProgressTransform = (global::Windows.UI.Xaml.Media.CompositeTransform)(target);
                }
                break;
            case 4:
                {
                    this.splashImage = (global::Windows.UI.Xaml.Controls.Viewbox)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Image element5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 20 "..\..\..\Views\Splash.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)element5).ImageOpened += this.Image_Loaded;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

