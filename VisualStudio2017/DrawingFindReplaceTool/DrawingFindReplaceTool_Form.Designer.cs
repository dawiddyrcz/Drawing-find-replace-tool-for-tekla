/* Copyright 2018 Dawid Dyrcz 
 * See License.txt file 
 */
namespace DrawingFindReplaceTool
{
    partial class DrawingFindReplaceToolForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.replace_textBox = new System.Windows.Forms.TextBox();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.createApplyCancel1 = new Tekla.Structures.Dialog.UIControls.CreateApplyCancel();
            this.find_label = new System.Windows.Forms.Label();
            this.replace_label = new System.Windows.Forms.Label();
            this.example_label = new System.Windows.Forms.Label();
            this.writeTo_label = new System.Windows.Forms.Label();
            this.title_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // find_textBox
            // 
            this.structuresExtender.SetAttributeName(this.find_textBox, "find");
            this.structuresExtender.SetAttributeTypeName(this.find_textBox, "String");
            this.structuresExtender.SetBindPropertyName(this.find_textBox, null);
            this.find_textBox.Location = new System.Drawing.Point(115, 49);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(359, 20);
            this.find_textBox.TabIndex = 0;
            this.find_textBox.Text = "78UKH-YJKO23-";
            this.find_textBox.TextChanged += new System.EventHandler(this.find_textBox_TextChanged);
            // 
            // replace_textBox
            // 
            this.structuresExtender.SetAttributeName(this.replace_textBox, "replace");
            this.structuresExtender.SetAttributeTypeName(this.replace_textBox, "String");
            this.structuresExtender.SetBindPropertyName(this.replace_textBox, null);
            this.replace_textBox.Location = new System.Drawing.Point(115, 75);
            this.replace_textBox.Name = "replace_textBox";
            this.replace_textBox.Size = new System.Drawing.Size(359, 20);
            this.replace_textBox.TabIndex = 1;
            this.replace_textBox.Text = "-UIL";
            this.replace_textBox.TextChanged += new System.EventHandler(this.replace_textBox_TextChanged);
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(474, 43);
            this.saveLoad1.TabIndex = 4;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            this.saveLoad1.AttributesLoaded += new System.EventHandler(this.saveLoad1_AttributesLoaded);
            // 
            // createApplyCancel1
            // 
            this.structuresExtender.SetAttributeName(this.createApplyCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.createApplyCancel1, null);
            this.structuresExtender.SetBindPropertyName(this.createApplyCancel1, null);
            this.createApplyCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createApplyCancel1.Location = new System.Drawing.Point(0, 231);
            this.createApplyCancel1.Name = "createApplyCancel1";
            this.createApplyCancel1.Size = new System.Drawing.Size(474, 30);
            this.createApplyCancel1.TabIndex = 5;
            this.createApplyCancel1.CreateClicked += new System.EventHandler(this.createApplyCancel1_CreateClicked);
            this.createApplyCancel1.ApplyClicked += new System.EventHandler(this.createApplyCancel1_ApplyClicked);
            this.createApplyCancel1.CancelClicked += new System.EventHandler(this.createApplyCancel1_CancelClicked);
            // 
            // find_label
            // 
            this.structuresExtender.SetAttributeName(this.find_label, null);
            this.structuresExtender.SetAttributeTypeName(this.find_label, null);
            this.find_label.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.find_label, null);
            this.find_label.Location = new System.Drawing.Point(12, 56);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(50, 13);
            this.find_label.TabIndex = 6;
            this.find_label.Text = "Find text:";
            // 
            // replace_label
            // 
            this.structuresExtender.SetAttributeName(this.replace_label, null);
            this.structuresExtender.SetAttributeTypeName(this.replace_label, null);
            this.replace_label.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.replace_label, null);
            this.replace_label.Location = new System.Drawing.Point(12, 79);
            this.replace_label.Name = "replace_label";
            this.replace_label.Size = new System.Drawing.Size(92, 13);
            this.replace_label.TabIndex = 8;
            this.replace_label.Text = "Replace text with:";
            // 
            // example_label
            // 
            this.structuresExtender.SetAttributeName(this.example_label, null);
            this.structuresExtender.SetAttributeTypeName(this.example_label, null);
            this.example_label.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.example_label, null);
            this.example_label.Location = new System.Drawing.Point(12, 136);
            this.example_label.Name = "example_label";
            this.example_label.Size = new System.Drawing.Size(112, 13);
            this.example_label.TabIndex = 10;
            this.example_label.Text = "example replacements";
            // 
            // writeTo_label
            // 
            this.structuresExtender.SetAttributeName(this.writeTo_label, null);
            this.structuresExtender.SetAttributeTypeName(this.writeTo_label, null);
            this.writeTo_label.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.writeTo_label, null);
            this.writeTo_label.Location = new System.Drawing.Point(12, 107);
            this.writeTo_label.Name = "writeTo_label";
            this.writeTo_label.Size = new System.Drawing.Size(47, 13);
            this.writeTo_label.TabIndex = 11;
            this.writeTo_label.Text = "Write to ";
            // 
            // title_comboBox
            // 
            this.structuresExtender.SetAttributeName(this.title_comboBox, "title");
            this.structuresExtender.SetAttributeTypeName(this.title_comboBox, "Integer");
            this.structuresExtender.SetBindPropertyName(this.title_comboBox, "SelectedIndex");
            this.title_comboBox.Location = new System.Drawing.Point(115, 102);
            this.title_comboBox.Name = "title_comboBox";
            this.title_comboBox.Size = new System.Drawing.Size(359, 21);
            this.title_comboBox.TabIndex = 12;
            this.title_comboBox.SelectedIndexChanged += new System.EventHandler(this.title_comboBox_SelectedIndexChanged);
            // 
            // DrawingFindReplaceToolForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.title_comboBox);
            this.Controls.Add(this.writeTo_label);
            this.Controls.Add(this.example_label);
            this.Controls.Add(this.replace_label);
            this.Controls.Add(this.find_label);
            this.Controls.Add(this.createApplyCancel1);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.replace_textBox);
            this.Controls.Add(this.find_textBox);
            this.MaximumSize = new System.Drawing.Size(490, 300);
            this.MinimumSize = new System.Drawing.Size(490, 300);
            this.Name = "DrawingFindReplaceToolForm";
            this.Text = "Drawing Find-Replace Tool";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingFindReplaceToolForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.TextBox replace_textBox;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private Tekla.Structures.Dialog.UIControls.CreateApplyCancel createApplyCancel1;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.Label replace_label;
        private System.Windows.Forms.Label example_label;
        private System.Windows.Forms.Label writeTo_label;
        private System.Windows.Forms.ComboBox title_comboBox;
    }
}