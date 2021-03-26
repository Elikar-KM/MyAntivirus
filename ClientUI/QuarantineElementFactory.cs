using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientUI
{
    static class QuarantineElementFactory
    {
        static int count = 0;
        static List<Panel> panels = new List<Panel>();
        static List<CheckBox> checkBoxes = new List<CheckBox>();
        static List<TextBox> textBoxes = new List<TextBox>();

        static public void AddElement(FlowLayoutPanel mainPanel, string date, string file, string type)
        {
            Panel pQElem = new Panel();
            Label lQType = new Label();
            Label lQDate = new Label();
            TextBox tQFile = new TextBox();
            CheckBox chQ = new CheckBox();

            panels.Add(pQElem);
            checkBoxes.Add(chQ);
            textBoxes.Add(tQFile);
            mainPanel.Controls.Add(pQElem);
            // 
            // pQElem
            // 
            pQElem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pQElem.Controls.Add(chQ);
            pQElem.Controls.Add(tQFile);
            pQElem.Controls.Add(lQDate);
            pQElem.Controls.Add(lQType);
            pQElem.Location = new System.Drawing.Point(3, 3);
            pQElem.Name = "pQElem_" + count;
            pQElem.Size = new System.Drawing.Size(786, 45);
            pQElem.TabIndex = 0;
            // 
            // lQType
            // 
            lQType.AutoSize = true;
            lQType.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            lQType.Location = new System.Drawing.Point(584, 14);
            lQType.Name = "lQType_" + count;
            lQType.Size = new System.Drawing.Size(36, 15);
            lQType.TabIndex = 1;
            lQType.Text = type;
            // 
            // lQDate
            // 
            lQDate.AutoSize = true;
            lQDate.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            lQDate.Location = new System.Drawing.Point(33, 14);
            lQDate.Name = "lQDate_" + count;
            lQDate.Size = new System.Drawing.Size(36, 15);
            lQDate.TabIndex = 2;
            lQDate.Text = date;
            // 
            // tQFile
            // 
            tQFile.BackColor = System.Drawing.Color.AliceBlue;
            tQFile.Location = new System.Drawing.Point(192, 12);
            tQFile.Name = "tQFile_" + count;
            tQFile.ReadOnly = true;
            tQFile.Size = new System.Drawing.Size(386, 20);
            tQFile.TabIndex = 3;
            tQFile.Text = file;
            // 
            // chQ
            // 
            chQ.AutoSize = true;
            chQ.Location = new System.Drawing.Point(3, 14);
            chQ.Name = "chQ";
            chQ.Size = new System.Drawing.Size(15, 14);
            chQ.TabIndex = 4;
            chQ.UseVisualStyleBackColor = true;

            count++;
        }

        static public List<string> RemoveElement(FlowLayoutPanel mainPanel)
        {
            var list = new List<string>();
            for (int i = checkBoxes.Count - 1; i >= 0; i--)
            {
                if (checkBoxes[i].Checked)
                {
                    list.Add(textBoxes[i].Text);
                    mainPanel.Controls.Remove(panels[i]);
                    panels.RemoveAt(i);
                    checkBoxes.RemoveAt(i);
                    textBoxes.RemoveAt(i);
                }
            }
            mainPanel.Update();
            return list;
        }

        static public List<string> RemoveAllElement(FlowLayoutPanel mainPanel)
        {
            var list = new List<string>();
            for (int i = checkBoxes.Count - 1; i >= 0; i--)
            {
                    list.Add(textBoxes[i].Text);
                    mainPanel.Controls.Remove(panels[i]);
                    panels.RemoveAt(i);
                    checkBoxes.RemoveAt(i);
                    textBoxes.RemoveAt(i);
            }
            mainPanel.Update();
            return list;
        }
    }
}
