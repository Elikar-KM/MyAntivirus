using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientUI
{
    static class MonitoringElementFactory
    {
        static int count = 0;
        static List<Panel> panels = new List<Panel>();
        static List<CheckBox> checkBoxes = new List<CheckBox>();
        static List<RadioButton> radioButtonsDestroy = new List<RadioButton>();
        static List<RadioButton> radioButtonsQuarantine = new List<RadioButton>();
        static List<TextBox> textBoxes = new List<TextBox>();
        static public int editLine = -1;

        static private void AddElement(FlowLayoutPanel mainPanel,string path,int rb)
        {
            var pSubMon = new Panel();
            var rdSubMon = new RadioButton();
            var rqSubMon = new RadioButton();
            var tSubMon = new TextBox();
            var chSubMon = new CheckBox();

            panels.Add(pSubMon);
            checkBoxes.Add(chSubMon);
            radioButtonsDestroy.Add(rdSubMon);
            radioButtonsQuarantine.Add(rqSubMon);
            textBoxes.Add(tSubMon);

            mainPanel.Controls.Add(pSubMon);

            pSubMon.BorderStyle = BorderStyle.FixedSingle;
            pSubMon.Controls.Add(rdSubMon);
            pSubMon.Controls.Add(rqSubMon);
            pSubMon.Controls.Add(tSubMon);
            pSubMon.Controls.Add(chSubMon);
            pSubMon.Location = new System.Drawing.Point(3, 3);
            pSubMon.Name = "pSubMon_"+count;
            pSubMon.Size = new System.Drawing.Size(562, 49);
            pSubMon.TabIndex = 0;

            // rdSubMon
            // 
            rdSubMon.AutoSize = true;
            rdSubMon.Location = new System.Drawing.Point(411, 29);
            rdSubMon.Name = "rdSubMon_"+count;
            rdSubMon.Size = new System.Drawing.Size(68, 17);
            rdSubMon.TabIndex = 3;
            rdSubMon.TabStop = true;
            rdSubMon.Text = "Удалять";
            rdSubMon.UseVisualStyleBackColor = true;
            // 
            // rqSubMon
            // 
            rqSubMon.AutoSize = true;
            rqSubMon.Location = new System.Drawing.Point(411, 3);
            rqSubMon.Name = "rqSubMon_"+count;
            rqSubMon.Size = new System.Drawing.Size(138, 17);
            rqSubMon.TabIndex = 2;
            rqSubMon.TabStop = true;
            rqSubMon.Text = "Помещать в карантин";
            rqSubMon.UseVisualStyleBackColor = true;
            // 
            // tSubMon
            // 
            tSubMon.Location = new System.Drawing.Point(107, 15);
            tSubMon.Name = "tSubMon_"+count;
            tSubMon.Text = path;
            tSubMon.ReadOnly = true;
            tSubMon.Size = new System.Drawing.Size(273, 20);
            tSubMon.TabIndex = 1;
            // 
            // chSubMon
            // 
            chSubMon.Location = new System.Drawing.Point(16, 3);
            chSubMon.Name = "chSubMon_"+count;
            chSubMon.Size = new System.Drawing.Size(84, 42);
            chSubMon.TabIndex = 0;
            chSubMon.Text = "Выбрать";
            chSubMon.UseVisualStyleBackColor = true;

            if (rb == 0)
            {
                rqSubMon.Checked = true;
                rdSubMon.Checked = false;
            }
            else
            {
                rqSubMon.Checked = false;
                rdSubMon.Checked = true;
            }

            count++;
        }

        static public void EditElement(FlowLayoutPanel mainPanel, string path, int rb)
        {
            if (editLine == -1) AddElement(mainPanel, path, rb);
            else UpdateElement(path, rb);
        }

        static private void UpdateElement(string path, int rb)
        {
            textBoxes[editLine].Text = path;
            if (rb == 0)
            {
                radioButtonsQuarantine[editLine].Checked = true;
                radioButtonsDestroy[editLine].Checked = false;
            }
            else
            {
                radioButtonsQuarantine[editLine].Checked = false;
                radioButtonsDestroy[editLine].Checked = true;
            }
            editLine = -1;
        }

        static public string SelectUpdateElement(ref int rb)
        {
            for (int i = 0; i< checkBoxes.Count; i++){
                if (checkBoxes[i].Checked)
                {
                    editLine = i;
                    if (radioButtonsQuarantine[editLine].Checked) rb = 0;
                    else rb = 1;
                    return textBoxes[editLine].Text;
                }
            }
            return "";
        }

            static public void RemoveElement(FlowLayoutPanel mainPanel)
        {
            for(int i=checkBoxes.Count-1;i>=0;i--)
            {
                if (checkBoxes[i].Checked)
                {
                    
                    mainPanel.Controls.Remove(panels[i]);
                    panels.RemoveAt(i);
                    checkBoxes.RemoveAt(i);
                    radioButtonsDestroy.RemoveAt(i);
                    radioButtonsQuarantine.RemoveAt(i);
                    textBoxes.RemoveAt(i);
                }
            }
            mainPanel.Update();
        }

        static public void SelectAllCheckBox()
        {
            foreach (var ch in checkBoxes)
            {
                ch.Checked = true;
            }
        }
    }
}
