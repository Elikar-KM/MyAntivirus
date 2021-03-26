using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientUI
{
    class UpdateElementFactory
    {
        static int count = 0;
        static List<CheckBox> checkBoxes = new List<CheckBox>();
        static List<Panel> panels = new List<Panel>();
        static List<TextBox> textBoxes = new List<TextBox>();
        static List<Label> labels = new List<Label>();
        static public void AddElement(FlowLayoutPanel mainPanel, string time, string path, int rb){
            Panel pElemUpdate = new Panel();
            CheckBox cElemUpdate = new CheckBox();
            Label lElemUpdate = new Label();
            TextBox tElemUpdate = new TextBox();
            RadioButton rqElemUpdate = new RadioButton();
            RadioButton rdElemUpdate = new RadioButton();

            checkBoxes.Add(cElemUpdate);
            panels.Add(pElemUpdate);
            textBoxes.Add(tElemUpdate);
            labels.Add(lElemUpdate);
            mainPanel.Controls.Add(pElemUpdate);


            // 
            // pElemUpdate
            // 
            pElemUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pElemUpdate.Controls.Add(rdElemUpdate);
            pElemUpdate.Controls.Add(rqElemUpdate);
            pElemUpdate.Controls.Add(tElemUpdate);
            pElemUpdate.Controls.Add(lElemUpdate);
            pElemUpdate.Controls.Add(cElemUpdate);
            pElemUpdate.Location = new System.Drawing.Point(3, 3);
            pElemUpdate.Name = "pElemUpdate_"+count;
            pElemUpdate.Size = new System.Drawing.Size(649, 50);
            pElemUpdate.TabIndex = 0;
            // 
            // cElemUpdate
            // 
            cElemUpdate.AutoSize = true;
            cElemUpdate.Location = new System.Drawing.Point(12, 16);
            cElemUpdate.Name = "cElemUpdate_" + count;
            cElemUpdate.Size = new System.Drawing.Size(15, 14);
            cElemUpdate.TabIndex = 0;
            cElemUpdate.UseVisualStyleBackColor = true;
            // 
            // lElemUpdate
            // 
            lElemUpdate.AutoSize = true;
            lElemUpdate.Location = new System.Drawing.Point(50, 16);
            lElemUpdate.Name = "lElemUpdate_" + count;
            lElemUpdate.Size = new System.Drawing.Size(35, 13);
            lElemUpdate.TabIndex = 1;
            lElemUpdate.Text = time;
            // 
            // tElemUpdate
            // 
            tElemUpdate.Location = new System.Drawing.Point(107, 13);
            tElemUpdate.Name = "tElemUpdate_" + count;
            tElemUpdate.ReadOnly = true;
            tElemUpdate.Size = new System.Drawing.Size(369, 20);
            tElemUpdate.TabIndex = 2;
            tElemUpdate.Text = path;
            // 
            // rqElemUpdate
            // 
            rqElemUpdate.AutoSize = true;
            rqElemUpdate.Enabled = false;
            rqElemUpdate.Location = new System.Drawing.Point(501, 3);
            rqElemUpdate.Name = "rqElemUpdate_" + count;
            rqElemUpdate.Size = new System.Drawing.Size(138, 17);
            rqElemUpdate.TabIndex = 3;
            rqElemUpdate.TabStop = true;
            rqElemUpdate.Text = "Помещать в карантин";
            rqElemUpdate.UseVisualStyleBackColor = true;
            // 
            // rdElemUpdate
            // 
            rdElemUpdate.AutoSize = true;
            rdElemUpdate.Enabled = false;
            rdElemUpdate.Location = new System.Drawing.Point(501, 24);
            rdElemUpdate.Name = "rdElemUpdate_" + count;
            rdElemUpdate.Size = new System.Drawing.Size(68, 17);
            rdElemUpdate.TabIndex = 4;
            rdElemUpdate.TabStop = true;
            rdElemUpdate.Text = "Удалять";
            rdElemUpdate.UseVisualStyleBackColor = true;

            if (rb == 0) rqElemUpdate.Checked = true;
            else rdElemUpdate.Checked = true;

            count++;
        }

        static public List<string> RemoveElement(FlowLayoutPanel mainPanel)
        {
            var list = new List<string>();
            for (int i = checkBoxes.Count - 1; i >= 0; i--)
            {
                if (checkBoxes[i].Checked)
                {
                    list.Add(labels[i].Text+"|"+ textBoxes[i].Text);
                    mainPanel.Controls.Remove(panels[i]);
                    panels.RemoveAt(i);
                    checkBoxes.RemoveAt(i);
                    textBoxes.RemoveAt(i);
                    labels.RemoveAt(i);
                }
            }
            mainPanel.Update();
            return list;
        }
    }
}
