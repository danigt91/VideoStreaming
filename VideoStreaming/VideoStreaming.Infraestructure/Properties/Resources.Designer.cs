﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoStreaming.Infraestructure.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VideoStreaming.Infraestructure.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to [ConfirmPassword] es requerido.
        /// </summary>
        internal static string Usuario_ConfirmPassword_Required {
            get {
                return ResourceManager.GetString("Usuario_ConfirmPassword_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ConfirmPassword] debe tener entre 5 y 255 caracteres.
        /// </summary>
        internal static string Usuario_ConfirmPassword_StringLength {
            get {
                return ResourceManager.GetString("Usuario_ConfirmPassword_StringLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Password] es requerido.
        /// </summary>
        internal static string Usuario_Password_Required {
            get {
                return ResourceManager.GetString("Usuario_Password_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Password] debe tener entre 5 y 255 caracteres.
        /// </summary>
        internal static string Usuario_Password_StringLength {
            get {
                return ResourceManager.GetString("Usuario_Password_StringLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [UserName] es requerido.
        /// </summary>
        internal static string Usuario_UserName_Required {
            get {
                return ResourceManager.GetString("Usuario_UserName_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [UserName] debe tener entre 1 y 40 carácteres.
        /// </summary>
        internal static string Usuario_UserName_StringLength {
            get {
                return ResourceManager.GetString("Usuario_UserName_StringLength", resourceCulture);
            }
        }
    }
}
