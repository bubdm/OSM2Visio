﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSM2Visio.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OSM2Visio.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon DrawProcess {
            get {
                object obj = ResourceManager.GetObject("DrawProcess", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap OsmImport {
            get {
                object obj = ResourceManager.GetObject("OsmImport", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSM Import.
        /// </summary>
        internal static string OsmImport_Label {
            get {
                return ResourceManager.GetString("OsmImport_Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap OsmImport_sm {
            get {
                object obj = ResourceManager.GetObject("OsmImport_sm", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;customUI
        ///xmlns=&quot;http://schemas.microsoft.com/office/2009/07/customui&quot; onLoad=&quot;OnRibbonLoad&quot;&gt;
        ///  &lt;ribbon&gt;
        ///    &lt;tabs&gt;
        ///      &lt;tab idMso=&quot;TabHome&quot;&gt;
        ///        &lt;group id=&quot;Group1&quot; label=&quot;OSM2Visio&quot;&gt;
        ///          &lt;button id=&quot;OsmImport&quot; size=&quot;large&quot; 
        ///                  getLabel=&quot;OnGetRibbonLabel&quot; onAction=&quot;OnRibbonButtonClick&quot; getEnabled=&quot;IsRibbonCommandEnabled&quot; getImage=&quot;GetRibbonImage&quot; /&gt;
        ///        &lt;/group&gt;
        ///      &lt;/tab&gt;
        ///    &lt;/tabs&gt;
        ///  &lt;/ribbon&gt;
        ///&lt;/customUI&gt;.
        /// </summary>
        internal static string Ribbon {
            get {
                return ResourceManager.GetString("Ribbon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon setting_tools {
            get {
                object obj = ResourceManager.GetObject("setting_tools", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}