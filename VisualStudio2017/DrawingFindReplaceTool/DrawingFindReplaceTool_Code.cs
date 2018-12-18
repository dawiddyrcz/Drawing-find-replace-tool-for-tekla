/* Copyright 2018 Dawid Dyrcz 
 * See License.txt file 
 */

using System;
using Tekla.Structures.Plugins;
using Tekla.Structures.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrawingFindReplaceTool
{
    public class DrawingFindReplaceTool_StructuresData
    {
        [StructuresField("find")]
        public string Find;
        [StructuresField("replace")]
        public string Replace;
        [StructuresField("title")]
        public int Title;
    }

    [Plugin("Drawing Find-Replace Tool")] 
    [PluginUserInterface("DrawingFindReplaceTool.DrawingFindReplaceToolForm")]
    [InputObjectDependency(PluginBase.InputObjectDependency.NOT_DEPENDENT)]
   
    public class DrawingFindReplaceToolClass : PluginBase
    {
        public string _Find;
        public string _Replace;
        public int _Title;

        private readonly Model _model;
        private readonly DrawingFindReplaceTool_StructuresData _data;
        
        public DrawingFindReplaceToolClass(DrawingFindReplaceTool_StructuresData data)
        {
            _model = new Model();
            _data = data;
        }
        
        private void GetValuesFromDialog()
        {
            _Find = _data.Find;
            _Replace = _data.Replace;
            _Title = _data.Title;

            if (IsDefaultValue(_Find) || _Find == "")
                _Find = "";
            if (IsDefaultValue(_Replace) || _Replace == "")
                _Replace = "";
            if (IsDefaultValue(_Title) || _Title < 0)
                _Title = 0;
        }

        public override bool Run(List<InputDefinition> Input)
        {
            GetValuesFromDialog();
            int succesfulModified = 0;

            var selectedDrawings = new Tekla.Structures.Drawing.DrawingHandler().GetDrawingSelector().GetSelected();
            var drawingsCount = selectedDrawings.GetSize();
            if (drawingsCount == 0)
            {
                MessageBox.Show("No drawings selected", "No drawings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure do you want to change attributes in "+selectedDrawings.GetSize()+" drawings?",
                "Are you sure ?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                var progress = new Tekla.Structures.Model.Operations.Operation.ProgressBar();

                var stopwatch = new System.Diagnostics.Stopwatch();
                try
                {
                    progress.Display(10, "Task is in progress", "Task is in progress", "Cancel", " ");
                    stopwatch.Start();
                    int checkedDrawings = 0;
                    double medTimeForOne = 0;

                    while (selectedDrawings.MoveNext())
                    {
                        if (progress.Canceled()) break;

                        var currentDrawing = selectedDrawings.Current as Tekla.Structures.Drawing.Drawing;
                        bool modified = false;
                        
                        switch (_Title)
                        {
                            case (0):
                                if (currentDrawing.Name != currentDrawing.Name.Replace(_Find, _Replace))
                                {
                                    currentDrawing.Name = currentDrawing.Name.Replace(_Find, _Replace);
                                    modified = true;
                                }
                                break;
                            case (1):
                                if (currentDrawing.Title1 != currentDrawing.Title1.Replace(_Find, _Replace))
                                {
                                    currentDrawing.Title1 = currentDrawing.Title1.Replace(_Find, _Replace);
                                    modified = true;
                                }
                                break;
                            case (2):
                                if (currentDrawing.Title2 != currentDrawing.Title2.Replace(_Find, _Replace))
                                {
                                    currentDrawing.Title2 = currentDrawing.Title2.Replace(_Find, _Replace);
                                    modified = true;
                                }
                                break;
                            case (3):
                                if (currentDrawing.Title3 != currentDrawing.Title3.Replace(_Find, _Replace))
                                {
                                    currentDrawing.Title3 = currentDrawing.Title3.Replace(_Find, _Replace);
                                    modified = true;
                                }
                                break;
                            default:
                                try
                                {
                                    var udaHandler = new UDAHandler();
                                    var udaName = udaHandler.GetUDAByIndex(_Title - 4);
                                    
                                    if (udaName != "")
                                    {
                                        //I dont want to change other types than string because it might be wrong
                                        string udaStringValue = "";
                                        if (currentDrawing.GetUserProperty(udaName, ref udaStringValue))
                                        {
                                            if (udaStringValue != udaStringValue.Replace(_Find, _Replace))
                                                modified = currentDrawing.SetUserProperty(udaName, udaStringValue.Replace(_Find, _Replace));
                                        }
                                    }
                                }
                                catch (Exception) { }
                                break;
                        }

                        if (modified)
                        {
                            currentDrawing.Modify();
                            succesfulModified++;
                        }
                        checkedDrawings++;
                        medTimeForOne = stopwatch.Elapsed.TotalMinutes / checkedDrawings;
                        progress.SetProgress(checkedDrawings + "/" + drawingsCount + "\t" + Math.Round(medTimeForOne*(drawingsCount - checkedDrawings)) + " minutes left", 100 * checkedDrawings / drawingsCount);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    progress.Close();
                    stopwatch.Stop();
                    MessageBox.Show("Task has been completed.\nModified drawings: " + succesfulModified.ToString() + ".\nTime elapsed: " + Math.Round(stopwatch.Elapsed.TotalSeconds).ToString() + " seconds");
                }

            }
            return true;
        }

        public override List<InputDefinition> DefineInput()
        {
            return new List<InputDefinition>();
        }
    }
}
