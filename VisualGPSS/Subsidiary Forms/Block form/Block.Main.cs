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

        //  PREEMPT устройство,[режим приоритета],[назначение],[№ параметра],[режим]
        //  RETURN устройство
        //  FUNAVAIL имя,[режим1],[метка1],[№],[режим2],[метка2],[режим3],[метка3]
        //  FAVAIL имя
        //  SUNAVAIL имя
        //  SAVAIL имя
        //  LOOP<№ параметра>[, метка]
        //  ASSIGN № параметра[суффикс],значение[, функция]
        //  MARK № параметра
        //  TEST отношение значение1, значение2[, метка]
        //  GATE условие устройство[, метка]
        //  SPLIT количество,[метка] [,№ параметра]
        //  ASSEMBLE количество
        //  GATHER количество
        //  ADOPT № группы
        //  MATCH метка

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
                case "SaveValue":
                    SetParams("ИМЯ", "ДЕЙСТВИЕ", "ЗНАЧЕНИЕ");
                    break;
                case "PREEMPT":
                    SetParams("УСТРОЙСТВО", "ПРИОРИТЕТ", "НАЗНАЧЕНИЕ", "ПАРАМЕТР", "РЕЖИМ");
                    break;
                case "RETURN":
                    SetParams("УСТРОЙСТВО");
                    break;
                case "FAVAIL":
                    SetParams("ИМЯ");
                    break;
                case "SUNAVAIL":
                    SetParams("ИМЯ");
                    break;
                case "SAVAIL":
                    SetParams("ИМЯ");
                    break;
                case "LOOP":
                    SetParams("ПАРАМЕТР", "МЕТКА");
                    break;
                case "ASSIGN":
                    SetParams("ПАРАМЕТР", "СУФФИКС", "ЗНАЧЕНИЕ", "ФУНКЦИЯ");
                    break;
                case "MARK":
                    SetParams("ПАРАМЕТР");
                    break;
                case "SPLIT":
                    SetParams("КОЛИЧЕСТВО", "МЕТКА", "ПАРАМЕТР");
                    break;
                case "ASSEMBLE":
                    SetParams("КОЛИЧЕСТВО");
                    break;
                case "GATHER":
                    SetParams("КОЛИЧЕСТВО");
                    break;
                case "ADOPT":
                    SetParams("ГРУППА");
                    break;
                case "MATCH":
                    SetParams("МЕТКА");
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

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GPSS.PLUS.Base.FunctionsHeaders.Contains((string)((ComboBox)sender).SelectedItem))
            {
                ((Control)sender).Text = GPSS.PLUS.Base.Functions
                    [GPSS.PLUS.Base.FunctionsHeaders.IndexOf((string)((ComboBox)sender).SelectedItem)];
            }
        }

        private void Block_Shown(object sender, EventArgs e)
        {
            if (visualBlock is not null)
            {
                int i = 0;
                if (TextBox1.Enabled) TextBox1.Text = i < visualBlock.Essence.Arguments.Length ?
                        visualBlock.Essence.Arguments[i++] : "";
                if (TextBox2.Enabled) TextBox2.Text = i < visualBlock.Essence.Arguments.Length ?
                        visualBlock.Essence.Arguments[i++] : "";
                if (TextBox3.Enabled) TextBox3.Text = i < visualBlock.Essence.Arguments.Length ?
                        visualBlock.Essence.Arguments[i++] : "";
                if (TextBox4.Enabled) TextBox4.Text = i < visualBlock.Essence.Arguments.Length ?
                        visualBlock.Essence.Arguments[i++] : "";
                if (TextBox5.Enabled) TextBox5.Text = i < visualBlock.Essence.Arguments.Length ?
                        visualBlock.Essence.Arguments[i++] : "";
            }
            TextBox1.SelectedIndex = TextBox2.SelectedIndex = TextBox3.SelectedIndex =
                TextBox4.SelectedIndex = TextBox5.SelectedIndex = -1;
        }
    }
}
