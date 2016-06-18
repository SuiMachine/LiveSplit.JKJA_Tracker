using LiveSplit.ComponentUtil;
using LiveSplit.UI;
using System;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LiveSplit.JKJA_Tracker
{
    enum elementType
    {
        [Description("Secrets")]
        Secrets,
        [Description("Enemies Killed")]
        EnemiesKilled,
        [Description("Enemies Hit")]
        EnemiesHit,
        [Description("Shots Fired")]
        ShotsFired,
        [Description("Accuracy")]
        Accuracy,
        [Description("Enemies Hit / Shots Fired")]
        HitToFiredRatio
    }

    partial class Settings : UserControl
    {
        #region Properties
        public Color BackgroundColor { get; set; }
        public Color BackgroundColorCompleted { get; set; }

        public Color OverrideTextColor { get; set; }
        public Color ComplitionColorIncomplete { get; set; }
        public Color ComplitionColorCompleted { get; set; }

        public int GraphWidth { get; set; }
        public int GraphHeight { get; set; }

        //Memory Locations
        public DeepPointer p_LevelName { get; set; }
        public DeepPointer p_currentSecrets { get; set; }
        public DeepPointer p_levelKills { get; set; }
        public DeepPointer p_maxKills { get; set; }
        public DeepPointer p_shotsFired { get; set; }
        public DeepPointer p_shotsHit { get; set; }

        public bool field1Enabled { get; set; }
        public bool field2Enabled { get; set; }
        public bool field3Enabled { get; set; }
        public bool field4Enabled { get; set; }
        public bool field5Enabled { get; set; }

        public int field1DisplayMode { get; set; }
        public int field2DisplayMode { get; set; }
        public int field3DisplayMode { get; set; }
        public int field4DisplayMode { get; set; }
        public int field5DisplayMode { get; set; }

        public bool fieldCompletionColorsEnabled { get; set; }
        public bool fieldOverrideTextColor { get; set; }
        #endregion


        public Settings()
        {
            InitializeComponent();
            setAdresses();
            setStartValues();

            GraphWidth = 200;
            GraphHeight = 30;

            //Color Buttons
            btnBackgroundColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBackgroundColorCompleted.DataBindings.Add("BackColor", this, "BackgroundColorCompleted", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOverrideTextColor.DataBindings.Add("BackColor", this, "OverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColorIncompleted.DataBindings.Add("BackColor", this, "ComplitionColorIncomplete", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColorCompleted.DataBindings.Add("BackColor", this, "ComplitionColorCompleted", false, DataSourceUpdateMode.OnPropertyChanged);

            //Checkboxes
            CB_EnableCompletedColor.DataBindings.Add("Checked", this, "fieldCompletionColorsEnabled", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_OverrideTextColorEnabled.DataBindings.Add("Checked", this, "fieldOverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            C_EnableField2.DataBindings.Add("Checked", this, "field2Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            C_EnableField3.DataBindings.Add("Checked", this, "field3Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            C_EnableField4.DataBindings.Add("Checked", this, "field4Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            C_EnableField5.DataBindings.Add("Checked", this, "field5Enabled", false, DataSourceUpdateMode.OnPropertyChanged);

            CB_Field1.DataBindings.Add("SelectedIndex", this, "field1DisplayMode", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field2.DataBindings.Add("SelectedIndex", this, "field2DisplayMode", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field3.DataBindings.Add("SelectedIndex", this, "field3DisplayMode", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field4.DataBindings.Add("SelectedIndex", this, "field4DisplayMode", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field5.DataBindings.Add("SelectedIndex", this, "field5DisplayMode", false, DataSourceUpdateMode.OnPropertyChanged);

            CB_Field2.DataBindings.Add("Enabled", this, "field2Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field3.DataBindings.Add("Enabled", this, "field3Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field4.DataBindings.Add("Enabled", this, "field4Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Field5.DataBindings.Add("Enabled", this, "field5Enabled", false, DataSourceUpdateMode.OnPropertyChanged);

            AddComboboxDataSources();

        }

        private void setStartValues()
        {
            GraphHeight = 0;
            field1Enabled = true;
            field2Enabled = false;
            field3Enabled = false;
            field4Enabled = false;
            field5Enabled = false;
            field1DisplayMode = (int)elementType.Secrets;
            field2DisplayMode = (int)elementType.Secrets;
            field3DisplayMode = (int)elementType.Secrets;
            field4DisplayMode = (int)elementType.Secrets;
            field5DisplayMode = (int)elementType.Secrets;
            fieldCompletionColorsEnabled = false;
            fieldOverrideTextColor = false;

            BackgroundColor = Color.Transparent;
            BackgroundColorCompleted = Color.Transparent;
            OverrideTextColor = Color.White;
            ComplitionColorIncomplete = Color.White;
            ComplitionColorCompleted = Color.White;
        }

        private void setAdresses()
        {
            p_LevelName = new DeepPointer(0x480C5D);
            p_currentSecrets = new DeepPointer(0x000091D4, 0x6a0, 0x16dc);
            p_levelKills = new DeepPointer(0x000091D4, 0x6a0, 0x16f0);
            p_maxKills = null;
            p_shotsFired = new DeepPointer(0x000091D4, 0x6a0, 0x16e4);
            p_shotsHit = new DeepPointer(0x000091D4, 0x6a0, 0x16e8);
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }        

        public void SetSettings(System.Xml.XmlNode node)
        {
            System.Xml.XmlElement element = (System.Xml.XmlElement) node;

            GraphWidth = SettingsHelper.ParseInt(element["GraphWidth"]);
            GraphHeight = SettingsHelper.ParseInt(element["GraphHeight"]);
            field1DisplayMode = SettingsHelper.ParseInt(element["F1DisplayMode"]);
            field2Enabled = SettingsHelper.ParseBool(element["F2Enabled"]);
            field2DisplayMode = SettingsHelper.ParseInt(element["F2DisplayMode"]);
            field3Enabled = SettingsHelper.ParseBool(element["F3Enabled"]);
            field3DisplayMode = SettingsHelper.ParseInt(element["F3DisplayMode"]);
            field4Enabled = SettingsHelper.ParseBool(element["F4Enabled"]);
            field4DisplayMode = SettingsHelper.ParseInt(element["F4DisplayMode"]);
            field5Enabled = SettingsHelper.ParseBool(element["F5Enabled"]);
            field5DisplayMode = SettingsHelper.ParseInt(element["F5DisplayMode"]);

            fieldOverrideTextColor = SettingsHelper.ParseBool(element["fieldOverrideTextColor"]);
            fieldCompletionColorsEnabled = SettingsHelper.ParseBool(element["fieldCompletionColorsEnabled"]);

            BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);
            BackgroundColorCompleted = SettingsHelper.ParseColor(element["BackgroundColorCompleted"]);
            OverrideTextColor = SettingsHelper.ParseColor(element["OverrideTextColor"]);
            ComplitionColorIncomplete = SettingsHelper.ParseColor(element["ComplitionColorIncomplete"]);
            ComplitionColorCompleted = SettingsHelper.ParseColor(element["ComplitionColorCompleted"]);
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            System.Xml.XmlElement parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(System.Xml.XmlDocument document, System.Xml.XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) ^
            SettingsHelper.CreateSetting(document, parent, "GraphWidth", GraphWidth) ^
            SettingsHelper.CreateSetting(document, parent, "GraphHeight", GraphHeight) ^
            SettingsHelper.CreateSetting(document, parent, "F1DisplayMode", field1DisplayMode) ^
            SettingsHelper.CreateSetting(document, parent, "F2Enabled", field2Enabled) ^
            SettingsHelper.CreateSetting(document, parent, "F2DisplayMode", field2DisplayMode) ^
            SettingsHelper.CreateSetting(document, parent, "F3Enabled", field3Enabled) ^
            SettingsHelper.CreateSetting(document, parent, "F3DisplayMode", field3DisplayMode) ^
            SettingsHelper.CreateSetting(document, parent, "F4Enabled", field4Enabled) ^
            SettingsHelper.CreateSetting(document, parent, "F4DisplayMode", field4DisplayMode) ^
            SettingsHelper.CreateSetting(document, parent, "F5Enabled", field5Enabled) ^
            SettingsHelper.CreateSetting(document, parent, "F5DisplayMode", field5DisplayMode) ^

            SettingsHelper.CreateSetting(document, parent, "fieldOverrideTextColor", fieldOverrideTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "fieldCompletionColorsEnabled", fieldCompletionColorsEnabled) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColorCompleted", BackgroundColorCompleted) ^
            SettingsHelper.CreateSetting(document, parent, "OverrideTextColor", OverrideTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "ComplitionColorIncomplete", ComplitionColorIncomplete) ^
            SettingsHelper.CreateSetting(document, parent, "ComplitionColorCompleted", ComplitionColorCompleted);
        }
    }
}
