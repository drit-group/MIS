﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisSystem.Server.Api.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class EmailStrings {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EmailStrings() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("MisSystem.Server.Api.Resources.EmailStrings", typeof(EmailStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string ConfirmationEmailSubject {
            get {
                return ResourceManager.GetString("ConfirmationEmailSubject", resourceCulture);
            }
        }
        
        public static string ConfirmEmail {
            get {
                return ResourceManager.GetString("ConfirmEmail", resourceCulture);
            }
        }
        
        public static string CopyLink {
            get {
                return ResourceManager.GetString("CopyLink", resourceCulture);
            }
        }
        
        public static string EmailConfirmationMessageBody {
            get {
                return ResourceManager.GetString("EmailConfirmationMessageBody", resourceCulture);
            }
        }
        
        public static string ResetPasswordEmailSubject {
            get {
                return ResourceManager.GetString("ResetPasswordEmailSubject", resourceCulture);
            }
        }
        
        public static string ResetPasswordHello {
            get {
                return ResourceManager.GetString("ResetPasswordHello", resourceCulture);
            }
        }
        
        public static string ResetPasswordMessage {
            get {
                return ResourceManager.GetString("ResetPasswordMessage", resourceCulture);
            }
        }
        
        public static string ResetPasswordNote {
            get {
                return ResourceManager.GetString("ResetPasswordNote", resourceCulture);
            }
        }
        
        public static string ResetYourPassword {
            get {
                return ResourceManager.GetString("ResetYourPassword", resourceCulture);
            }
        }
        
        public static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        public static string WelcomeToApp {
            get {
                return ResourceManager.GetString("WelcomeToApp", resourceCulture);
            }
        }
    }
}
