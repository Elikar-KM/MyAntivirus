using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientUI
{
    class FileElementFactory
    {
        static int count = 0;
        static List<Panel> panels = new List<Panel>();
        static public void AddElement(FlowLayoutPanel mainPanel, string path, string oper, string type)
        {
            Panel pFile = new Panel();
            TextBox tFile = new TextBox();
            Label lFileOperation = new Label();
            Label lFileType = new Label();
            Label lFileTitle = new Label();


            panels.Add(pFile);
            mainPanel.Controls.Add(pFile);
            // 
            // pFile
            // 
            pFile.Controls.Add(lFileTitle);
            pFile.Controls.Add(lFileType);
            pFile.Controls.Add(lFileOperation);
            pFile.Controls.Add(tFile);
            pFile.Location = new System.Drawing.Point(3, 3);
            pFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pFile.Name = "pFile_"+ count;
            pFile.Size = new System.Drawing.Size(828, 36);
            pFile.TabIndex = 0;
            // 
            // tFile
            // 
            tFile.Location = new System.Drawing.Point(48, 8);
            tFile.Name = "tFile_" + count;
            tFile.ReadOnly = true;
            tFile.Size = new System.Drawing.Size(419, 20);
            tFile.TabIndex = 0;
            tFile.Text = path;
            // 
            // lFileOperation
            // 
            lFileOperation.AutoSize = true;
            lFileOperation.Location = new System.Drawing.Point(480, 11);
            lFileOperation.Name = "lFileOperation_" + count;
            lFileOperation.Size = new System.Drawing.Size(115, 13);
            lFileOperation.TabIndex = 1;
            lFileOperation.Text = oper;
            // 
            // lFileType
            // 
            lFileType.AutoSize = true;
            lFileType.Location = new System.Drawing.Point(613, 11);
            lFileType.Name = "lFileType_" + count;
            lFileType.Size = new System.Drawing.Size(35, 13);
            lFileType.TabIndex = 2;
            lFileType.Text = type;
            // 
            // lFileTitle
            // 
            lFileTitle.AutoSize = true;
            lFileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lFileTitle.Location = new System.Drawing.Point(4, 10);
            lFileTitle.Name = "lFileTitle_" + count;
            lFileTitle.Size = new System.Drawing.Size(38, 15);
            lFileTitle.TabIndex = 3;
            lFileTitle.Text = "Путь:";
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
    }
}
