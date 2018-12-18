/* Copyright 2018 Dawid Dyrcz 
 * See License.txt file 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tekla.Structures.Dialog;

namespace DrawingFindReplaceTool
{
    public partial class DrawingFindReplaceToolForm : PluginFormBase
    {
        public DrawingFindReplaceToolForm()
        {
            InitializeComponent();
            GenerateExampleNumbers();
            FillTitleCombobox();
        }

        private void FillTitleCombobox()
        {
            this.title_comboBox.Items.Clear();
            //DO NOT CHANGE THIS CODE
            this.title_comboBox.Items.Add("NAME");
            this.title_comboBox.Items.Add("TITLE1");
            this.title_comboBox.Items.Add("TITLE2");
            this.title_comboBox.Items.Add("TITLE3");

            //This try is stupid but i dont know how to test it
            try
            {
                var udaLabels = new UDAHandler().GetAllUDALabels();
                this.title_comboBox.Items.AddRange(udaLabels.ToArray());
            }
            catch (Exception) { }
        }

        private void okApplyModifyGetOnOffCancel1_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void GenerateExampleNumbers()
        {
            string exampleText = "";
            var drawingHandler = new Tekla.Structures.Drawing.DrawingHandler();
            var selectedDrawings = drawingHandler.GetDrawingSelector().GetSelected();
            int i = 0;

            while(selectedDrawings.MoveNext())
            {
                var currentDrawing = selectedDrawings.Current as Tekla.Structures.Drawing.Drawing;

                switch (this.title_comboBox.SelectedIndex)
                {
                    case (0):
                        exampleText = exampleText + currentDrawing.Name + "\t   ->   \t" + currentDrawing.Name.Replace(this.find_textBox.Text, this.replace_textBox.Text) + "\n";
                        break;
                    case (1):
                        exampleText = exampleText + currentDrawing.Title1 + "\t   ->   \t" + currentDrawing.Title1.Replace(this.find_textBox.Text, this.replace_textBox.Text) + "\n";
                        break;
                    case (2):
                        exampleText = exampleText + currentDrawing.Title2 + "\t   ->   \t" + currentDrawing.Title2.Replace(this.find_textBox.Text, this.replace_textBox.Text) + "\n";
                        break;
                    case (3):
                        exampleText = exampleText + currentDrawing.Title3 + "\t   ->   \t" + currentDrawing.Title3.Replace(this.find_textBox.Text, this.replace_textBox.Text) + "\n";
                        break;
                    default:
                        try
                        {
                            string udaName = new UDAHandler().GetUDAByIndex(this.title_comboBox.SelectedIndex - 4);

                            if (udaName != "")
                            {
                                string udaValue = "";
                                if (currentDrawing.GetUserProperty(udaName, ref udaValue))
                                {
                                    exampleText = exampleText + udaValue + "\t   ->   \t" + udaValue.Replace(this.find_textBox.Text, this.replace_textBox.Text) + "\n";
                                }
                            }
                        }
                        catch (Exception) { }
                        break;
                }

                if (i > 5) break;
                i++;
            }

            this.example_label.Text = exampleText;
        }

        private void find_textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateExampleNumbers();
        }

        private void replace_textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateExampleNumbers();
        }

        private void createApplyCancel1_ApplyClicked(object sender, EventArgs e)
        {
            GenerateExampleNumbers();
            this.Apply();
        }

        private void createApplyCancel1_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createApplyCancel1_CreateClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Create();
        }

        private void saveLoad1_AttributesLoaded(object sender, EventArgs e)
        {
            GenerateExampleNumbers();
        }

        private void title_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateExampleNumbers();
        }

        private void DrawingFindReplaceToolForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GenerateExampleNumbers();
        }
    }
}
 