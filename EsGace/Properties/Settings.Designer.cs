﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :2.0.50727.1433
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EsGace.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public decimal Decimal {
            get {
                return ((decimal)(this["Decimal"]));
            }
            set {
                this["Decimal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int NbBGWAnalyse {
            get {
                return ((int)(this["NbBGWAnalyse"]));
            }
            set {
                this["NbBGWAnalyse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AfficherFichierAnalyse {
            get {
                return ((bool)(this["AfficherFichierAnalyse"]));
            }
            set {
                this["AfficherFichierAnalyse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AfficherIconeNotification {
            get {
                return ((bool)(this["AfficherIconeNotification"]));
            }
            set {
                this["AfficherIconeNotification"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimizerLorsReduction {
            get {
                return ((bool)(this["MinimizerLorsReduction"]));
            }
            set {
                this["MinimizerLorsReduction"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(Default)")]
        public global::System.Globalization.CultureInfo Culture {
            get {
                return ((global::System.Globalization.CultureInfo)(this["Culture"]));
            }
            set {
                this["Culture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int TreeMapProfondeur {
            get {
                return ((int)(this["TreeMapProfondeur"]));
            }
            set {
                this["TreeMapProfondeur"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F:\\Mes Documents\\Visual Studio 2008\\Projects\\EsGace\\Stats.xml")]
        public string FichierXMLStats {
            get {
                return ((string)(this["FichierXMLStats"]));
            }
            set {
                this["FichierXMLStats"] = value;
            }
        }
    }
}
