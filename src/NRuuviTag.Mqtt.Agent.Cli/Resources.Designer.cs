﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NRuuviTag.Mqtt.Cli {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NRuuviTag.Mqtt.Cli.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Client certificate file &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string Error_ClientCertificateFileDoesNotExist {
            get {
                return ResourceManager.GetString("Error_ClientCertificateFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When specifying a client certificate PFX file, you must specify a password using the &apos;--client-certificate-password&apos; setting..
        /// </summary>
        internal static string Error_ClientCertificatePasswordIsRequired {
            get {
                return ResourceManager.GetString("Error_ClientCertificatePasswordIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A device with MAC address &apos;{0}&apos; has already been registered..
        /// </summary>
        internal static string Error_DeviceWithSameMacAlreadyRegistered {
            get {
                return ResourceManager.GetString("Error_DeviceWithSameMacAlreadyRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid devices JSON content. Expected an object, but the root JSON element had type &apos;{0}&apos;..
        /// </summary>
        internal static string Error_InvalidDevicesJson {
            get {
                return ResourceManager.GetString("Error_InvalidDevicesJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device added:.
        /// </summary>
        internal static string LogMessage_DeviceAdded {
            get {
                return ResourceManager.GetString("LogMessage_DeviceAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device &apos;{0}&apos; was not found..
        /// </summary>
        internal static string LogMessage_DeviceNotFound {
            get {
                return ResourceManager.GetString("LogMessage_DeviceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device removed:.
        /// </summary>
        internal static string LogMessage_DeviceRemoved {
            get {
                return ResourceManager.GetString("LogMessage_DeviceRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (Name = &apos;{1}&apos;, MQTT Device ID = &apos;{2}&apos;).
        /// </summary>
        internal static string LogMessage_DeviceScanResultKnown {
            get {
                return ResourceManager.GetString("LogMessage_DeviceScanResultKnown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (Unknown RuuviTag).
        /// </summary>
        internal static string LogMessage_DeviceScanResultUnknown {
            get {
                return ResourceManager.GetString("LogMessage_DeviceScanResultUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting device scan....
        /// </summary>
        internal static string LogMessage_StartingDeviceScan {
            get {
                return ResourceManager.GetString("LogMessage_StartingDeviceScan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MQTT Device ID.
        /// </summary>
        internal static string TableColumn_DeviceID {
            get {
                return ResourceManager.GetString("TableColumn_DeviceID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display Name.
        /// </summary>
        internal static string TableColumn_DisplayName {
            get {
                return ResourceManager.GetString("TableColumn_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MAC Address.
        /// </summary>
        internal static string TableColumn_MacAddress {
            get {
                return ResourceManager.GetString("TableColumn_MacAddress", resourceCulture);
            }
        }
    }
}