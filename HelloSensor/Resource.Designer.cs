﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloSensor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HelloSensor.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to dotnet HelloSensor.dll IP_Address Port.
        /// </summary>
        internal static string AppRunCommandText {
            get {
                return ResourceManager.GetString("AppRunCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to c   :   Connect to the sensor.
        /// </summary>
        internal static string ConnectSensorText {
            get {
                return ResourceManager.GetString("ConnectSensorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to i   :   Put input settings to the sensor.
        /// </summary>
        internal static string InputSettingsText {
            get {
                return ResourceManager.GetString("InputSettingsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter following characters on console for various tasks.
        /// </summary>
        internal static string InstructionsTitleText {
            get {
                return ResourceManager.GetString("InstructionsTitleText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make sure to provide correct IP address and Port number to start the app, type following command;.
        /// </summary>
        internal static string InvalidInputArgsText {
            get {
                return ResourceManager.GetString("InvalidInputArgsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to o   :   Get output settings of the sensor.
        /// </summary>
        internal static string OutputSettingsText {
            get {
                return ResourceManager.GetString("OutputSettingsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to q   :   Quit the app.
        /// </summary>
        internal static string QuitAppText {
            get {
                return ResourceManager.GetString("QuitAppText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to r   :   Report status of the sensor.
        /// </summary>
        internal static string ReportStatusText {
            get {
                return ResourceManager.GetString("ReportStatusText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to f   :   Simulate sensor failure.
        /// </summary>
        internal static string SensorFailureText {
            get {
                return ResourceManager.GetString("SensorFailureText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to x   :   Stop scanning data from the sensor.
        /// </summary>
        internal static string SopScanningText {
            get {
                return ResourceManager.GetString("SopScanningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to s   :   Start scanning data from the sensor.
        /// </summary>
        internal static string StartScanningText {
            get {
                return ResourceManager.GetString("StartScanningText", resourceCulture);
            }
        }
    }
}
