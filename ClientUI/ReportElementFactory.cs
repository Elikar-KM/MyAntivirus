using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientUI
{
    class ReportElementFactory
    {
        static int count = 0;
        static List<Panel> panels = new List<Panel>();
        static FlowLayoutPanel fileFlow;
        static public void AddElement(FlowLayoutPanel mainPanel,FlowLayoutPanel subPanel,string id,string dateStart,string dateEnd, string dir, string countFile, string countVirus)
        {
            FlowLayoutPanel flowReportPanel = new FlowLayoutPanel();
            Panel pReportElem = new Panel();
            TextBox tReportDir = new TextBox();
            Label lReportVirus = new Label();
            Label lReportCountFile = new Label();
            Label lReportDateEnd = new Label();
            Label lReportDateStart = new Label();
            Button bReportElement = new Button();

            fileFlow = subPanel;
            panels.Add(pReportElem);
            mainPanel.Controls.Add(pReportElem);
            // 
            // pReportElem
            // 
            pReportElem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pReportElem.Controls.Add(tReportDir);
            pReportElem.Controls.Add(lReportVirus);
            pReportElem.Controls.Add(lReportCountFile);
            pReportElem.Controls.Add(lReportDateEnd);
            pReportElem.Controls.Add(lReportDateStart);
            pReportElem.Controls.Add(bReportElement);
            pReportElem.Location = new System.Drawing.Point(3, 3);
            pReportElem.Name = "pReportElem_" + count;
            pReportElem.Size = new System.Drawing.Size(826, 26);
            pReportElem.TabIndex = 0;


            // 
            // tReportDir
            // 
            tReportDir.BackColor = System.Drawing.Color.AliceBlue;
            tReportDir.Location = new System.Drawing.Point(261, 2);
            tReportDir.Name = "tReportDir_" + count;
            tReportDir.ReadOnly = true;
            tReportDir.Size = new System.Drawing.Size(276, 20);
            tReportDir.TabIndex = 5;
            tReportDir.Text = dir;
            // 
            // lReportVirus
            // 
            lReportVirus.AutoSize = true;
            lReportVirus.Location = new System.Drawing.Point(653, 6);
            lReportVirus.Name = "lReportVirus_" + count;
            lReportVirus.Size = new System.Drawing.Size(35, 13);
            lReportVirus.TabIndex = 4;
            lReportVirus.Text = countVirus;
            // 
            // lReportCountFile
            // 
            lReportCountFile.AutoSize = true;
            lReportCountFile.Location = new System.Drawing.Point(543, 6);
            lReportCountFile.Name = "lReportCountFile_" + count;
            lReportCountFile.Size = new System.Drawing.Size(35, 13);
            lReportCountFile.TabIndex = 3;
            lReportCountFile.Text = countFile;
            // 
            // lReportDateEnd
            // 
            lReportDateEnd.AutoSize = true;
            lReportDateEnd.Location = new System.Drawing.Point(119, 6);
            lReportDateEnd.Name = "lReportDateEnd_" + count;
            lReportDateEnd.Size = new System.Drawing.Size(35, 13);
            lReportDateEnd.TabIndex = 1;
            lReportDateEnd.Text = dateEnd;
            // 
            // lReportDateStart
            // 
            lReportDateStart.AutoSize = true;
            lReportDateStart.Location = new System.Drawing.Point(3, 6);
            lReportDateStart.Name = "lReportDateStart_"+ count;
            lReportDateStart.Size = new System.Drawing.Size(35, 13);
            lReportDateStart.TabIndex = 0;
            lReportDateStart.Text = dateStart;
            // 
            // bReportElement
            // 
            bReportElement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bReportElement.Location = new System.Drawing.Point(730, 1);
            bReportElement.Name = "bReportElement_"+(id);
            bReportElement.Size = new System.Drawing.Size(75, 22);
            bReportElement.TabIndex = 0;
            bReportElement.Text = "Показать";
            bReportElement.UseVisualStyleBackColor = true;
            bReportElement.Click += new System.EventHandler(bReportElement_Click);

            count++;
        }

        static public void RemoveAllElement(FlowLayoutPanel mainPanel)
        {
            var list = new List<string>();
            count = 0;
            for (int i = panels.Count - 1; i >= 0; i--)
            {
                mainPanel.Controls.Remove(panels[i]);
                panels.RemoveAt(i);
            }
            mainPanel.Update();
        }

        static private void bReportElement_Click(object sender, EventArgs e)
        {
            FileElementFactory.RemoveAllElement(fileFlow);
            var arr=Form1.client.GetFile(int.Parse(((Button)sender).Name.Split('_')[1]));
            foreach(var file in arr)
            {
                var str = file.Split('|');
                string operation = "Помещен в карантин";
                if(str[2]=="1") operation = "Удален";
                FileElementFactory.AddElement(fileFlow, str[1], operation, "Тип: "+str[3]);
            }
            fileFlow.Visible = true;
        }
    }
}
