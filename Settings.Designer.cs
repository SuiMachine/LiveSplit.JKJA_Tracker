using LiveSplit.UI;
using System;
using System.ComponentModel;
using System.Linq;

namespace LiveSplit.JKJA_Tracker
{
    partial class Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpPointerPath = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Field2 = new System.Windows.Forms.ComboBox();
            this.C_EnableField2 = new System.Windows.Forms.CheckBox();
            this.CB_Field1 = new System.Windows.Forms.ComboBox();
            this.C_EnableField3 = new System.Windows.Forms.CheckBox();
            this.C_EnableField4 = new System.Windows.Forms.CheckBox();
            this.CB_Field4 = new System.Windows.Forms.ComboBox();
            this.CB_Field5 = new System.Windows.Forms.ComboBox();
            this.C_EnableField5 = new System.Windows.Forms.CheckBox();
            this.CB_Field3 = new System.Windows.Forms.ComboBox();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnColorIncompleted = new System.Windows.Forms.Button();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CB_OverrideTextColorEnabled = new System.Windows.Forms.CheckBox();
            this.CB_EnableCompletedColor = new System.Windows.Forms.CheckBox();
            this.btnOverrideTextColor = new System.Windows.Forms.Button();
            this.btnBackgroundColorCompleted = new System.Windows.Forms.Button();
            this.btnColorCompleted = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpPointerPath.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpGraph.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpPointerPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpGraph, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 396);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpPointerPath
            // 
            this.grpPointerPath.Controls.Add(this.tableLayoutPanel2);
            this.grpPointerPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPointerPath.Location = new System.Drawing.Point(3, 3);
            this.grpPointerPath.Name = "grpPointerPath";
            this.grpPointerPath.Size = new System.Drawing.Size(455, 164);
            this.grpPointerPath.TabIndex = 0;
            this.grpPointerPath.TabStop = false;
            this.grpPointerPath.Text = "Display Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.CB_Field2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.C_EnableField2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CB_Field1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.C_EnableField3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.C_EnableField4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CB_Field4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.CB_Field5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.C_EnableField5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CB_Field3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CB_Field2
            // 
            this.CB_Field2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Field2.FormattingEnabled = true;
            this.CB_Field2.Location = new System.Drawing.Point(89, 30);
            this.CB_Field2.Name = "CB_Field2";
            this.CB_Field2.Size = new System.Drawing.Size(357, 21);
            this.CB_Field2.TabIndex = 19;
            // 
            // C_EnableField2
            // 
            this.C_EnableField2.AutoSize = true;
            this.C_EnableField2.Location = new System.Drawing.Point(3, 30);
            this.C_EnableField2.Name = "C_EnableField2";
            this.C_EnableField2.Size = new System.Drawing.Size(59, 17);
            this.C_EnableField2.TabIndex = 1;
            this.C_EnableField2.Text = "Enable";
            this.C_EnableField2.UseVisualStyleBackColor = true;
            // 
            // CB_Field1
            // 
            this.CB_Field1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Field1.FormattingEnabled = true;
            this.CB_Field1.Location = new System.Drawing.Point(89, 3);
            this.CB_Field1.Name = "CB_Field1";
            this.CB_Field1.Size = new System.Drawing.Size(357, 21);
            this.CB_Field1.TabIndex = 10;
            // 
            // C_EnableField3
            // 
            this.C_EnableField3.AutoSize = true;
            this.C_EnableField3.Location = new System.Drawing.Point(3, 57);
            this.C_EnableField3.Name = "C_EnableField3";
            this.C_EnableField3.Size = new System.Drawing.Size(59, 17);
            this.C_EnableField3.TabIndex = 25;
            this.C_EnableField3.Text = "Enable";
            this.C_EnableField3.UseVisualStyleBackColor = true;
            // 
            // C_EnableField4
            // 
            this.C_EnableField4.AutoSize = true;
            this.C_EnableField4.Location = new System.Drawing.Point(3, 84);
            this.C_EnableField4.Name = "C_EnableField4";
            this.C_EnableField4.Size = new System.Drawing.Size(59, 17);
            this.C_EnableField4.TabIndex = 25;
            this.C_EnableField4.Text = "Enable";
            this.C_EnableField4.UseVisualStyleBackColor = true;
            // 
            // CB_Field4
            // 
            this.CB_Field4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Field4.FormattingEnabled = true;
            this.CB_Field4.Location = new System.Drawing.Point(89, 84);
            this.CB_Field4.Name = "CB_Field4";
            this.CB_Field4.Size = new System.Drawing.Size(357, 21);
            this.CB_Field4.TabIndex = 32;
            // 
            // CB_Field5
            // 
            this.CB_Field5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Field5.FormattingEnabled = true;
            this.CB_Field5.Location = new System.Drawing.Point(89, 111);
            this.CB_Field5.Name = "CB_Field5";
            this.CB_Field5.Size = new System.Drawing.Size(357, 21);
            this.CB_Field5.TabIndex = 32;
            // 
            // C_EnableField5
            // 
            this.C_EnableField5.AutoSize = true;
            this.C_EnableField5.Location = new System.Drawing.Point(3, 111);
            this.C_EnableField5.Name = "C_EnableField5";
            this.C_EnableField5.Size = new System.Drawing.Size(59, 17);
            this.C_EnableField5.TabIndex = 25;
            this.C_EnableField5.Text = "Enable";
            this.C_EnableField5.UseVisualStyleBackColor = true;
            // 
            // CB_Field3
            // 
            this.CB_Field3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Field3.FormattingEnabled = true;
            this.CB_Field3.Location = new System.Drawing.Point(89, 57);
            this.CB_Field3.Name = "CB_Field3";
            this.CB_Field3.Size = new System.Drawing.Size(357, 21);
            this.CB_Field3.TabIndex = 32;
            // 
            // grpGraph
            // 
            this.grpGraph.Controls.Add(this.tableLayoutPanel3);
            this.grpGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGraph.Location = new System.Drawing.Point(3, 176);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(455, 194);
            this.grpGraph.TabIndex = 1;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Graph";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(449, 175);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Controls.Add(this.btnBackgroundColorCompleted, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnOverrideTextColor, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBackgroundColor1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.CB_OverrideTextColorEnabled, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnColorIncompleted, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnColorCompleted, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.CB_EnableCompletedColor, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(443, 62);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnColorIncompleted
            // 
            this.btnColorIncompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColorIncompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorIncompleted.Location = new System.Drawing.Point(378, 34);
            this.btnColorIncompleted.Name = "btnColorIncompleted";
            this.btnColorIncompleted.Size = new System.Drawing.Size(29, 25);
            this.btnColorIncompleted.TabIndex = 9;
            this.btnColorIncompleted.UseVisualStyleBackColor = false;
            this.btnColorIncompleted.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(105, 3);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(29, 25);
            this.btnBackgroundColor1.TabIndex = 6;
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Background Color:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Completed Color:";
            // 
            // CB_OverrideTextColorEnabled
            // 
            this.CB_OverrideTextColorEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_OverrideTextColorEnabled.AutoSize = true;
            this.CB_OverrideTextColorEnabled.Location = new System.Drawing.Point(219, 7);
            this.CB_OverrideTextColorEnabled.Name = "CB_OverrideTextColorEnabled";
            this.CB_OverrideTextColorEnabled.Size = new System.Drawing.Size(117, 17);
            this.CB_OverrideTextColorEnabled.TabIndex = 10;
            this.CB_OverrideTextColorEnabled.Text = "Override Text Color";
            this.CB_OverrideTextColorEnabled.UseVisualStyleBackColor = true;
            // 
            // CB_EnableCompletedColor
            // 
            this.CB_EnableCompletedColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_EnableCompletedColor.AutoSize = true;
            this.CB_EnableCompletedColor.Location = new System.Drawing.Point(219, 38);
            this.CB_EnableCompletedColor.Name = "CB_EnableCompletedColor";
            this.CB_EnableCompletedColor.Size = new System.Drawing.Size(149, 17);
            this.CB_EnableCompletedColor.TabIndex = 11;
            this.CB_EnableCompletedColor.Text = "Enable \"Completed Color\"";
            this.CB_EnableCompletedColor.UseVisualStyleBackColor = true;
            // 
            // btnOverrideTextColor
            // 
            this.btnOverrideTextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOverrideTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverrideTextColor.Location = new System.Drawing.Point(413, 3);
            this.btnOverrideTextColor.Name = "btnOverrideTextColor";
            this.btnOverrideTextColor.Size = new System.Drawing.Size(29, 25);
            this.btnOverrideTextColor.TabIndex = 13;
            this.btnOverrideTextColor.UseVisualStyleBackColor = false;
            this.btnOverrideTextColor.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnBackgroundColorCompleted
            // 
            this.btnBackgroundColorCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColorCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColorCompleted.Location = new System.Drawing.Point(105, 34);
            this.btnBackgroundColorCompleted.Name = "btnBackgroundColorCompleted";
            this.btnBackgroundColorCompleted.Size = new System.Drawing.Size(29, 25);
            this.btnBackgroundColorCompleted.TabIndex = 14;
            this.btnBackgroundColorCompleted.UseVisualStyleBackColor = false;
            this.btnBackgroundColorCompleted.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnColorCompleted
            // 
            this.btnColorCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColorCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorCompleted.Location = new System.Drawing.Point(413, 34);
            this.btnColorCompleted.Name = "btnColorCompleted";
            this.btnColorCompleted.Size = new System.Drawing.Size(29, 25);
            this.btnColorCompleted.TabIndex = 15;
            this.btnColorCompleted.UseVisualStyleBackColor = false;
            this.btnColorCompleted.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // Settings
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(461, 396);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpPointerPath.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpGraph.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void AddComboboxDataSources()
        {
            CB_Field1.DisplayMember = "Description";
            CB_Field1.ValueMember = "value";
            CB_Field1.DataSource = Enum.GetValues(typeof(elementType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            CB_Field2.DisplayMember = "Description";
            CB_Field2.ValueMember = "value";
            CB_Field2.DataSource = Enum.GetValues(typeof(elementType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            CB_Field3.DisplayMember = "Description";
            CB_Field3.ValueMember = "value";
            CB_Field3.DataSource = Enum.GetValues(typeof(elementType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            CB_Field4.DisplayMember = "Description";
            CB_Field4.ValueMember = "value";
            CB_Field4.DataSource = Enum.GetValues(typeof(elementType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            CB_Field5.DisplayMember = "Description";
            CB_Field5.ValueMember = "value";
            CB_Field5.DataSource = Enum.GetValues(typeof(elementType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpPointerPath;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox C_EnableField2;
        private System.Windows.Forms.ComboBox CB_Field1;
        private System.Windows.Forms.ComboBox CB_Field2;
        private System.Windows.Forms.ComboBox CB_Field3;
        private System.Windows.Forms.CheckBox C_EnableField3;
        private System.Windows.Forms.CheckBox C_EnableField4;
        private System.Windows.Forms.ComboBox CB_Field4;
        private System.Windows.Forms.ComboBox CB_Field5;
        private System.Windows.Forms.CheckBox C_EnableField5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnBackgroundColor1;
        private System.Windows.Forms.Button btnColorIncompleted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CB_OverrideTextColorEnabled;
        private System.Windows.Forms.CheckBox CB_EnableCompletedColor;
        private System.Windows.Forms.Button btnBackgroundColorCompleted;
        private System.Windows.Forms.Button btnOverrideTextColor;
        private System.Windows.Forms.Button btnColorCompleted;
    }
}
