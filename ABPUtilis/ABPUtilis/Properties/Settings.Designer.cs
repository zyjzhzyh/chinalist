﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABPUtils.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.1")]
        public string ABPVersion {
            get {
                return ((string)(this["ABPVersion"]));
            }
            set {
                this["ABPVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"""[Adblock Plus 2.1]
!  Adblock Plus List with Main Focus on Chinese Sites.
!  Last Modified:  
!  Homepage: http://chinalist.github.io/
!
!  ListUpdater Lazy = Part of EasyList + ListUpdater + Part of EasyPrivacy
!  If you need to know the details,
!  please visit: https://github.com/chinalist/chinalist/wiki/something_about_ChinaList_Lazy
!
!  If you need help or have any question,
!  please visit: https://github.com/chinalist/chinalist
!
!  coding: utf-8, expires: 5 days
!--CC-BY-SA 3.0 + Licensed, NO WARRANTY but Best Wishes----
""")]
        public string ChinaListLazyHeader {
            get {
                return ((string)(this["ChinaListLazyHeader"]));
            }
            set {
                this["ChinaListLazyHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chinalist/chinalist.txt")]
        public string ChinaList {
            get {
                return ((string)(this["ListUpdater"]));
            }
            set {
                this["ListUpdater"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chinalist/chinalist-anti-social.txt")]
        public string ChinaListAntiSocial {
            get {
                return ((string)(this["ChinaListAntiSocial"]));
            }
            set {
                this["ChinaListAntiSocial"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chinalist/chinalist-privacy.txt")]
        public string ChinaListPrivacy {
            get {
                return ((string)(this["ChinaListPrivacy"]));
            }
            set {
                this["ChinaListPrivacy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"[Adblock Plus 2.1]
!  Title: ListUpdater
!  Adblock Plus List with Main Focus on Chinese Sites.
!  Last Modified:  
!  Homepage: http://chinalist.github.io/
!
!  As a supplement for EasyList,ListUpdater won't provide the filters
!  which in EasyList already.Please subscribe EasyList also.
!  If you need help or have any question,
!  please visit: https://github.com/chinalist/chinalist
!
!  coding: utf-8, expires: 5 days
!----GNU LGPL Licensed, NO WARRANTY but Best Wishes----")]
        public string ChinaListHeader {
            get {
                return ((string)(this["ChinaListHeader"]));
            }
            set {
                this["ChinaListHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"[Adblock Plus 2.1]
!  Title: ListUpdater Anti Social
!  Adblock Plus List with Main Focus on Chinese Sites.
!  Last Modified:  
!  Homepage: http://chinalist.github.io/
!
!  This is an unofficial version, 
!  does not provide any technical support
!
!  please visit: https://github.com/chinalist/chinalist
!
!  coding: utf-8, expires: 5 days
!----GNU LGPL Licensed, NO WARRANTY but Best Wishes----")]
        public string ChinaListAntiSocialHeader {
            get {
                return ((string)(this["ChinaListAntiSocialHeader"]));
            }
            set {
                this["ChinaListAntiSocialHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"[Adblock Plus 2.1]
!  Title: ListUpdater Privacy
!  Adblock Plus List with Main Focus on Chinese Sites.
!  Last Modified:  
!  Homepage: http://chinalist.github.io/
!
!  As a supplement for EasyPrivacy,ListUpdater won't provide the filters
!  which in EasyPrivacy already.Please subscribe EasyPrivacy also.
!  If you need help or have any question,
!  please visit: https://github.com/chinalist/chinalist
!
!  coding: utf-8, expires: 5 days
!----GNU LGPL Licensed, NO WARRANTY but Best Wishes----")]
        public string ChinaListPrivacyHeader {
            get {
                return ((string)(this["ChinaListPrivacyHeader"]));
            }
            set {
                this["ChinaListPrivacyHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://easylist-downloads.adblockplus.org/easylist.txt")]
        public string EasylistUrl {
            get {
                return ((string)(this["EasylistUrl"]));
            }
            set {
                this["EasylistUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://easylist-downloads.adblockplus.org/easyprivacy.txt")]
        public string EasyprivacyUrl {
            get {
                return ((string)(this["EasyprivacyUrl"]));
            }
            set {
                this["EasyprivacyUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Copyright (C) 2008 - {0} Adblock Plus ListUpdater Project
This is free software. You may redistribute copies of it under the terms of
the GNU LGPL License <http://www.gnu.org/copyleft/lesser.html>.
Usage: ABPUtils.exe -n -d=google.com -dns=8.8.8.8
       ABPUtils.exe -v -i=adblock.txt
       ABPUtils.exe -u -i=adblock.txt
       ABPUtils.exe -m -i=adblock.txt -patch -o=adblock-lazy.txt
       ABPUtils.exe -i=adblock.txt -conf

  version        Show ABPUtils version.

  c, check       Check the domains in the specific input file.

  conf           Clean patch.xml if exist.

  d, domain      The domain need to be checked (required).

  m, merge       Merge the specific input file with Part of EasyList and
                 EasyPrivacy.

  n, nsookup     Show the ns server of the specific domain.

  u, update      Update and validate the checksum of the specific input file.

  v, validate    Validate the checksum of the specific input file.

  i, input       Input file with filters to process (required).

  o, output      Output file with processed filters.

  patch          Use the patch.xml.

  p, proxy       Proxy server used when download the lastest EasyList and EasyPrivacy files (optional).

  dns            DNS server (optional).

  h, help        Dispaly this help screen.
")]
        public string HelpInfo {
            get {
                return ((string)(this["HelpInfo"]));
            }
            set {
                this["HelpInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("patch.xml")]
        public string PatchFile {
            get {
                return ((string)(this["PatchFile"]));
            }
            set {
                this["PatchFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ListUpdater,ChinaListAntiSocial,ChinaListPrivacy")]
        public string EnabledList {
            get {
                return ((string)(this["EnabledList"]));
            }
            set {
                this["EnabledList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("easylist:easylist/easylist_general_block.txt\r\neasylist:easylist/easylist_general_" +
            "block_dimensions.txt\r\neasylist:easylist/easylist_general_block_popup.txt\r\neasyli" +
            "st:easylist/easylist_general_hide.txt\r\neasylist:easylist/easylist_adservers.txt")]
        public string EasyListFlag {
            get {
                return ((string)(this["EasyListFlag"]));
            }
            set {
                this["EasyListFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"easylist:easyprivacy/easyprivacy_general.txt
easylist:easyprivacy/easyprivacy_trackingservers_international.txt
easylist:easyprivacy/easyprivacy_thirdparty_international.txt
easylist:easyprivacy/easyprivacy_specific_international.txt
easylist:easyprivacy/easyprivacy_whitelist_international.txt<")]
        public string EasyPrivacyFlag {
            get {
                return ((string)(this["EasyPrivacyFlag"]));
            }
            set {
                this["EasyPrivacyFlag"] = value;
            }
        }
    }
}
