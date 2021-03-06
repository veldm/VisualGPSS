using GPSS.Visualiztion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Block : MaterialSkin.Controls.MaterialForm
    {
        private VisualBlock visualBlock;
        private readonly Point point;
        private readonly VisualGPSS_Schema schema;        

        //  GENERATE[〈интервал〉],[〈разброс〉],[〈задержка〉],[〈ограничение〉],[〈приоритет〉
        //  TERMINATE [hвычитаемоеi]
        //  ADVANCE[hинтервалi],[hразбросi]
        //  SEIZE hимя устройстваi
        //  RELEASE hимя устройстваi
        //  QUEUE hимя очередиi[, hколичествоi]
        //  DEPART hимя очередиi[, hколичествоi]
        //  ENTER hимяi,[hколичествоi]
        //  LEAVE hимяi,[hколичествоi]

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeCB.SelectedItem)
            {
                case "GENERATE":
                    SetParams("ИНТЕРВАЛ", "РАЗБРОС", "ЗАДЕРЖКА", "ОГРАНИЧЕНИЕ", "ПРИОРИТЕТ");
                    break;
                case "TERMINATE":
                    SetParams("ВЫЧИТАЕМОЕ");
                    break;
                case "ADVANCE":
                    SetParams("ИНТЕРВАЛ", "РАЗБРОС");
                    break;
                case "SEIZE":
                    SetParams("УСТРОЙСТВО");
                    break;
                case "RELEASE":
                    SetParams("УСТРОЙСТВО");
                    break;
                case "QUEUE":
                    SetParams("ОЧЕРЕДЬ", "КОЛИЧЕСТВО");
                    break;
                case "DEPART":
                    SetParams("ОЧЕРЕДЬ", "КОЛИЧЕСТВО");
                    break;
                case "ENTER":
                    SetParams("УСТРОЙСТВО", "КОЛИЧЕСТВО");
                    break;
                case "LEAVE":
                    SetParams("УСТРОЙСТВО", "КОЛИЧЕСТВО");
                    break;
            }

            void SetParams(string s1, string s2 = "", string s3 = "", string s4 = "", string s5 = "")
            {
                // 1
                Label1.Text = s1;
                TextBox1.Enabled = s1 is not "";

                // 2
                Label2.Text = s2;
                TextBox2.Enabled = s2 is not "";

                // 3
                Label3.Text = s3;
                TextBox3.Enabled = s3 is not "";

                // 4
                Label4.Text = s4;
                TextBox4.Enabled = s4 is not "";

                // 5
                Label5.Text = s5;
                TextBox5.Enabled = s5 is not "";
            }
        }
    }
}
