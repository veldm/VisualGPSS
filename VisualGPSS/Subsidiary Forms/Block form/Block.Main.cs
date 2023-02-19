using GPSS;
using GPSS.Visualiztion;
using MaterialSkin.Controls;
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

        //  +GENERATE[〈интервал〉],[〈разброс〉],[〈задержка〉],[〈ограничение〉],[〈приоритет〉
        //  +TERMINATE [вычитаемое]
        //  +ADVANCE[интервал],[разброс]
        //  +SEIZE имя устройства
        //  +RELEASE имя устройства
        //  +QUEUE имя очереди[, количество]
        //  +DEPART имя очереди[, количество]
        //  ENTER имя,[количество]
        //  LEAVE имя,[количество]

        //  PREEMPT устройство,[режим приоритета],[назначение],[№ параметра],[режим]
        //  RETURN устройство
        //  +FUNAVAIL имя,[режим1],[метка1],[№],[режим2],[метка2],[режим3],[метка3]
        //  +FAVAIL имя
        //  +SUNAVAIL имя
        //  +SAVAIL имя
        //  +LOOP<№ параметра>[, метка]
        //  ASSIGN № параметра[суффикс],значение[, функция]
        //  MARK № параметра
        //  +TEST отношение значение1, значение2[, метка]
        //  +GATE условие устройство[, метка]
        //  +SPLIT количество,[метка] [,№ параметра]
        //  +ASSEMBLE количество
        //  +GATHER количество
        //  +ADOPT № группы
        //  +MATCH метка

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

            foreach (var control in from Control control in groupBox2.Controls
                                    where (control
                                    is MaterialSingleLineTextField or ComboBox)
                                    select control)
                control.Text = "";

            void SetParams(params (string name, GPSS.DataType Type, bool necessarity)[] dataPattern)
            {
                necessarity = dataPattern.Select(pattern => pattern.necessarity).ToArray();

                // 1
                Label1.Text = dataPattern[0].name;
                ComboBox1.Visible = materialSingleLineTextField1.Visible =
                    Label1.Text is not "";
                if (dataPattern.Length > 0)
                {
                    ComboBox1.DataSource = dataPattern[0].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox1.SelectedIndex = -1;
                    ComboBox1.Tag = tag.Count > 0 ?  tag : null;
                    ComboBox1.Enabled = ((List<string>)ComboBox1.DataSource).Count > 0;
                }

                // 2
                Label2.Text = dataPattern.Length > 1 ? dataPattern[1].name : "";
                ComboBox2.Visible = materialSingleLineTextField2.Visible =
                    Label2.Text is not "";
                if (dataPattern.Length > 1)
                {
                    ComboBox2.DataSource = dataPattern[1].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox2.SelectedIndex = -1;
                    ComboBox2.Tag = tag.Count > 0 ? tag : null;
                    ComboBox2.Enabled = ((List<string>)ComboBox2.DataSource).Count > 0;
                }

                // 3
                Label3.Text = dataPattern.Length > 2 ? dataPattern[2].name : "";
                ComboBox3.Visible = materialSingleLineTextField3.Visible =
                    Label3.Text is not "";
                if (dataPattern.Length > 2)
                {
                    ComboBox3.DataSource = dataPattern[2].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox3.SelectedIndex = -1;
                    ComboBox3.Tag = tag.Count > 0 ? tag : null;
                    ComboBox3.Enabled = ((List<string>)ComboBox3.DataSource).Count > 0;
                }

                // 4
                Label4.Text = dataPattern.Length > 3 ? dataPattern[3].name : "";
                ComboBox4.Visible = materialSingleLineTextField4.Visible =
                    Label4.Text is not "";
                if (dataPattern.Length > 3)
                {
                    ComboBox4.DataSource = dataPattern[3].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox4.SelectedIndex = -1;
                    ComboBox4.Tag = tag.Count > 0 ? tag : null;
                    ComboBox4.Enabled = ((List<string>)ComboBox4.DataSource).Count > 0;
                }

                // 5
                Label5.Text = dataPattern.Length > 4 ? dataPattern[4].name : "";
                ComboBox5.Visible = materialSingleLineTextField5.Visible =
                    Label5.Text is not "";
                if (dataPattern.Length > 4)
                {
                    ComboBox5.DataSource = dataPattern[4].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox5.SelectedIndex = -1;
                    ComboBox5.Tag = tag.Count > 0 ? tag : null;
                    ComboBox5.Enabled = ((List<string>)ComboBox5.DataSource).Count > 0;
                }

                // 6
                Label6.Text = dataPattern.Length > 5 ? dataPattern[5].name : "";
                ComboBox6.Visible = materialSingleLineTextField6.Visible =
                    Label6.Text is not "";
                if (dataPattern.Length > 5)
                {
                    ComboBox6.DataSource = dataPattern[5].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox6.SelectedIndex = -1;
                    ComboBox6.Tag = tag.Count > 0 ? tag : null;
                    ComboBox6.Enabled = ((List<string>)ComboBox6.DataSource).Count > 0;
                }

                // 7
                Label7.Text = dataPattern.Length > 6 ? dataPattern[6].name : "";
                ComboBox7.Visible = materialSingleLineTextField7.Visible =
                    Label7.Text is not "";
                if (dataPattern.Length > 6)
                {
                    ComboBox7.DataSource = dataPattern[6].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox7.SelectedIndex = -1;
                    ComboBox7.Tag = tag.Count > 0 ? tag : null;
                    ComboBox7.Enabled = ((List<string>)ComboBox7.DataSource).Count > 0;
                }

                // 8
                Label8.Text = dataPattern.Length is 8 ? dataPattern[7].name : "";
                ComboBox8.Visible = materialSingleLineTextField8.Visible =
                    Label8.Text is not "";
                if (dataPattern.Length > 6)
                {
                    ComboBox8.DataSource = dataPattern[7].Type.GetDataSource(schema, out List<string> tag);
                    ComboBox8.SelectedIndex = -1;
                    ComboBox8.Tag = tag.Count > 0 ? tag : null;
                    ComboBox8.Enabled = ((List<string>)ComboBox8.DataSource).Count > 0;
                }
            }
        } 


        private void Block_Shown(object sender, EventArgs e)
        {
            if (visualBlock is not null)
            {
                int i = 0;
                foreach (var control in from Control control in groupBox2.Controls
                                        where (control
                                        is MaterialSingleLineTextField)
                                        select control)
                    control.Text = i < visualBlock.Essence.Arguments.Length ?
                        visualBlock.Essence.Arguments[i++] : "";
            }
            ComboBox1.SelectedIndex = ComboBox2.SelectedIndex = ComboBox3.SelectedIndex =
                ComboBox4.SelectedIndex = ComboBox5.SelectedIndex = -1;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex is not -1)
            {
                if (ComboBox1.Tag is not null)
                {
                    materialSingleLineTextField1.Text = ((List<string>)ComboBox1.Tag)[ComboBox1.SelectedIndex];
                    materialSingleLineTextField1.Select();
                }
                else
                {
                    materialSingleLineTextField1.Text = ((List<string>)ComboBox1.DataSource)[ComboBox1.SelectedIndex];
                    materialSingleLineTextField1.Select();
                }
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox2.SelectedIndex is not -1)
            {
                if (ComboBox2.Tag is not null)
                {
                    materialSingleLineTextField2.Text = ((List<string>)ComboBox2.Tag)[ComboBox2.SelectedIndex];
                    materialSingleLineTextField2.Select();
                }
                else
                {
                    materialSingleLineTextField2.Text = ((List<string>)ComboBox2.DataSource)[ComboBox2.SelectedIndex];
                    materialSingleLineTextField2.Select();
                }
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox3.SelectedIndex is not -1)
            {
                if (ComboBox3.Tag is not null)
                {
                    materialSingleLineTextField3.Text = ((List<string>)ComboBox3.Tag)[ComboBox3.SelectedIndex];
                    materialSingleLineTextField3.Select();
                }
                else
                {
                    materialSingleLineTextField3.Text = ((List<string>)ComboBox3.DataSource)[ComboBox3.SelectedIndex];
                    materialSingleLineTextField3.Select();
                }
            }
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox4.SelectedIndex is not -1)
            {
                if (ComboBox4.Tag is not null)
                {
                    materialSingleLineTextField4.Text = ((List<string>)ComboBox4.Tag)[ComboBox4.SelectedIndex];
                    materialSingleLineTextField4.Select();
                }
                else
                {
                    materialSingleLineTextField4.Text = ((List<string>)ComboBox4.DataSource)[ComboBox4.SelectedIndex];
                    materialSingleLineTextField4.Select();
                }
            }
        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox5.SelectedIndex is not -1)
            {
                if (ComboBox5.Tag is not null)
                {
                    materialSingleLineTextField5.Text = ((List<string>)ComboBox5.Tag)[ComboBox5.SelectedIndex];
                    materialSingleLineTextField5.Select();
                }
                else
                {
                    materialSingleLineTextField5.Text = ((List<string>)ComboBox5.DataSource)[ComboBox5.SelectedIndex];
                    materialSingleLineTextField5.Select();
                }
            }
        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox6.SelectedIndex is not -1)
            {
                if (ComboBox6.Tag is not null)
                {
                    materialSingleLineTextField6.Text = ((List<string>)ComboBox6.Tag)[ComboBox6.SelectedIndex];
                    materialSingleLineTextField6.Select();
                }
                else
                {
                    materialSingleLineTextField6.Text = ((List<string>)ComboBox6.DataSource)[ComboBox6.SelectedIndex];
                    materialSingleLineTextField6.Select();
                }
            }
        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox7.SelectedIndex is not -1)
            {
                if (ComboBox7.Tag is not null)
                {
                    materialSingleLineTextField7.Text = ((List<string>)ComboBox7.Tag)[ComboBox7.SelectedIndex];
                    materialSingleLineTextField7.Select();
                }
                else
                {
                    materialSingleLineTextField7.Text = ((List<string>)ComboBox7.DataSource)[ComboBox7.SelectedIndex];
                    materialSingleLineTextField7.Select();
                }
            }
        }

        private void ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox8.SelectedIndex is not -1)
            {
                if (ComboBox8.Tag is not null)
                {
                    materialSingleLineTextField8.Text = ((List<string>)ComboBox8.Tag)[ComboBox8.SelectedIndex];
                    materialSingleLineTextField8.Select();
                }
                else
                {
                    materialSingleLineTextField8.Text = ((List<string>)ComboBox8.DataSource)[ComboBox8.SelectedIndex];
                    materialSingleLineTextField8.Select();
                }
            }
        }
    }
}
