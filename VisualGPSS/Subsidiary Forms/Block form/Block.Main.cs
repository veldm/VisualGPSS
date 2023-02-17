using GPSS;
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
        private bool[] necessarity;

        //  GENERATE[〈интервал〉],[〈разброс〉],[〈задержка〉],[〈ограничение〉],[〈приоритет〉
        //  TERMINATE [вычитаемое]
        //  ADVANCE[интервал],[разброс]
        //  SEIZE имя устройства
        //  RELEASE имя устройства
        //  QUEUE имя очереди[, количество]
        //  DEPART имя очереди[, количество]
        //  ENTER имя,[количество]
        //  LEAVE имя,[количество]

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
                // GENERATE[〈интервал〉],[〈разброс〉],[〈задержка〉],[〈ограничение〉],[〈приоритет〉]
                case "GENERATE":
                    SetParams(("ИНТЕРВАЛ", DataType.Math, false),
                        ("РАЗБРОС", DataType.Math, false),
                        ("ЗАДЕРЖКА", DataType.Math, false),
                        ("ОГРАНИЧЕНИЕ", DataType.Math, false),
                        ("ПРИОРИТЕТ", DataType.Math, false));
                    break;

                // TERMINATE [вычитаемое]
                case "TERMINATE":
                    SetParams(("ВЫЧИТАЕМОЕ", DataType.Math, false));
                    break;

                // ADVANCE[интервал],[разброс]
                case "ADVANCE":
                    SetParams(("ИНТЕРВАЛ", DataType.Math, false),
                        ("РАЗБРОС", DataType.Math, false));
                    break;

                //  SEIZE имя устройства
                case "SEIZE":
                    SetParams(("УСТРОЙСТВО", DataType.Device, true));
                    break;

                // RELEASE имя устройства
                case "RELEASE":
                    SetParams(("УСТРОЙСТВО", DataType.Device, true));
                    break;

                // QUEUE имя очереди[, количество]
                case "QUEUE":
                    SetParams(("ОЧЕРЕДЬ", DataType.Queue, true),
                        ("КОЛИЧЕСТВО", DataType.Math, false));
                    break;

                //  DEPART имя очереди[, количество]
                case "DEPART":
                    SetParams(("ОЧЕРЕДЬ", DataType.Queue, true),
                        ("КОЛИЧЕСТВО", DataType.Math, false));
                    break;

                // ENTER имя[,количество]
                case "ENTER":
                    SetParams(("УСТРОЙСТВО", DataType.Device, true),
                        ("КОЛИЧЕСТВО", DataType.Math, false));
                    break;

                // LEAVE имя,[количество]
                case "LEAVE":
                    SetParams(("УСТРОЙСТВО", DataType.Device, true),
                        ("КОЛИЧЕСТВО", DataType.Math, false));
                    break;

                case "SaveValue":
                    SetParams(("ИМЯ", DataType.None, true),
                        ("ДЕЙСТВИЕ", DataType.Action, false),
                        ("ЗНАЧЕНИЕ", DataType.Math, true));
                    break;

                // PREEMPT устройство,[режим приоритета],[назначение],[№ параметра],[режим]
                case "PREEMPT":
                    SetParams(("УСТРОЙСТВО", DataType.Device, true),
                        ("ПРИОРИТЕТ", DataType.Priority, false),
                        ("НАЗНАЧЕНИЕ", DataType.Label, false),
                        ("ПАРАМЕТР", DataType.None, false),
                        ("РЕЖИМ", DataType.PreemptRegime, false));
                    break;

                // RETURN устройство
                case "RETURN":
                    SetParams(("УСТРОЙСТВО", DataType.Device, true));
                    break;

                // FUNAVAIL имя,[режим1],[метка1],[№],[режим2],[метка2],[режим3],[метка3]
                case "FUNAVAIL":
                    SetParams(("ИМЯ", DataType.Device, true),
                        ("РЕЖИМ 1", DataType.FunavailRegime, false),
                        ("МЕТКА 1", DataType.Label, false),
                        ("№", DataType.None, false),
                        ("РЕЖИМ 2", DataType.FunavailRegime, false),
                        ("МЕТКА 2", DataType.Label, false),
                        ("РЕЖИМ 3", DataType.FunavailRegime, false),
                        ("МЕТКА 3", DataType.Label, false));
                    break;

                // FAVAIL имя
                case "FAVAIL":
                    SetParams(("ИМЯ", DataType.Device, true));
                    break;

                // SUNAVAIL имя
                case "SUNAVAIL":
                    SetParams(("ИМЯ", DataType.Device, true));
                    break;

                // SAVAIL имя
                case "SAVAIL":
                    SetParams(("ИМЯ", DataType.Device, true));
                    break;

                // LOOP<№ параметра>[, метка]
                case "LOOP":
                    SetParams(("ПАРАМЕТР", DataType.None, true),
                        ("МЕТКА", DataType.Label, true));
                    break;

                // ASSIGN № параметра[суффикс],значение[, функция]
                case "ASSIGN":
                    SetParams(("ПАРАМЕТР", DataType.None, true),
                        ("СУФФИКС", DataType.Action, false),
                        ("ЗНАЧЕНИЕ", DataType.Math, true),
                        ("ФУНКЦИЯ", DataType.Math, false));
                    break;

                // MARK № параметра
                case "MARK":
                    SetParams(("ПАРАМЕТР", DataType.None, true));
                    break;

                // SPLIT количество,[метка] [,№ параметра]
                case "SPLIT":
                    SetParams(("КОЛИЧЕСТВО", DataType.Math, true),
                        ("МЕТКА", DataType.Label, false),
                        ("ПАРАМЕТР", DataType.None, false));
                    break;

                // ASSEMBLE количество
                case "ASSEMBLE":
                    SetParams(("КОЛИЧЕСТВО", DataType.Math, true));
                    break;

                // GATHER количество
                case "GATHER":
                    SetParams(("КОЛИЧЕСТВО", DataType.Math, true));
                    break;

                // ADOPT № группы
                case "ADOPT":
                    SetParams(("ГРУППА", DataType.Math, true));
                    break;

                // MATCH метка
                case "MATCH":
                    SetParams(("МЕТКА", DataType.Label, true));
                    break;
            }

            void SetParams(params (string name, GPSS.DataType Type, bool necessarity)[] dataPattern)
            {
                necessarity = dataPattern.Select(pattern => pattern.necessarity).ToArray();

                // 1
                Label1.Text = dataPattern[0].name;
                TextBox1.Enabled = Label1.Text is not "";
                if (TextBox1.Enabled)
                {
                    TextBox1.DataSource = dataPattern[0].Type.GetDataSource(schema, out List<string> tag);
                    if (tag.Count > 0) TextBox1.Tag = tag;
                }

                // 2
                Label2.Text = dataPattern.Length > 1 ? dataPattern[1].name : "";
                TextBox2.Enabled = Label2.Text is not "";
                if (TextBox2.Enabled)
                {
                    TextBox2.DataSource = dataPattern[1].Type.GetDataSource(schema, out List<string> tag);
                    if (tag.Count > 0) TextBox2.Tag = tag;
                }

                // 3
                Label3.Text = dataPattern.Length > 2 ? dataPattern[2].name : "";
                TextBox3.Enabled = Label3.Text is not "";
                if (TextBox3.Enabled)
                {
                    TextBox3.DataSource = dataPattern[2].Type.GetDataSource(schema, out List<string> tag);
                    if (tag.Count > 0) TextBox3.Tag = tag;
                }

                // 4
                Label4.Text = dataPattern.Length > 3 ? dataPattern[3].name : "";
                TextBox4.Enabled = Label4.Text is not "";
                if (TextBox4.Enabled)
                {
                    TextBox4.DataSource = dataPattern[3].Type.GetDataSource(schema, out List<string> tag);
                    if (tag.Count > 0) TextBox4.Tag = tag;
                }

                // 5
                Label5.Text = dataPattern.Length > 4 ? dataPattern[4].name : "";
                TextBox5.Enabled = Label5.Text is not "";
                if (TextBox5.Enabled)
                {
                    TextBox5.DataSource = dataPattern[4].Type.GetDataSource(schema, out List<string> tag);
                    if (tag.Count > 0) TextBox5.Tag = tag;
                }
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
