using GPSS.Visualiztion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        #region Создание операторов и обновление схемы

        private void ToolBoxItemClicked(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (creatingOperator is not null)
            {
                Cursor = Cursors.Default;
                LabelPictureBox.Focus();
                creatingOperator = null;
            }
            else
            {
                Cursor = Cursors.Cross;
                creatingOperator = control.Name switch
                {
                    "generateButton" => new(CreateBlock, "GENERATE"),
                    "terminateButton" => new(CreateBlock, "TERMINATE"),
                    "saveValueButton" => new(CreateBlock, "SaveValue"),
                    "uncertainButton" => new(CreateBlock, null),
                    "singleChannelDeviceButton" => new(CreateDevice, false),
                    "multiChannelDeviceButton" => new(CreateDevice, true),
                    _ => null
                };
            }
        }

        private void CreateBlock(object type, Point point)
        {
            Block block = new Block(schema, point, (string)type);
            block.Show();
            block.SaveButton.Click += graphicsRefresh;
        }

        private void CreateCommand(string type, Point point)
        {
            //Command command = new Command(schema, point, type);
            //command.Show();
        }

        private void EditElement(object sender, EventArgs e)
        {
            if (activeElement is not null)
            {
                if (activeElement is GPSS.Visualiztion.Device device)
                {
                    Device deviceForm = new Device(device, schema);
                    deviceForm.Show();
                    deviceForm.SaveButton.Click += graphicsRefresh;
                }
                else if (activeElement is VisualBlock block)
                {
                    Block blockForm = new Block(block, schema);
                    blockForm.Show();
                    blockForm.SaveButton.Click += graphicsRefresh;
                }
                else if (activeElement is VisualTransfer transfer)
                {
                    Transfer transferForm = new Transfer(transfer, schema, this);
                    transferForm.SaveButton.Click += graphicsRefresh;
                    transferForm.Show();
                }
                //else if (activeElement is VisualCommand command)
                //{

                //}
                else
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddTransfer(object sender, EventArgs e)
        {
            Transfer transferForm = new Transfer((VisualBlock)activeElement, schema);
            transferForm.Show();
            transferForm.SaveButton.Click += graphicsRefresh;
        }

        private void CreateDevice(object isMultichanell, Point point)
        {
            Device deviceForm = new Device(schema, point, (bool)isMultichanell);
            deviceForm.Show();
            deviceForm.SaveButton.Click += graphicsRefresh;
        }

        #endregion Создание операторов и обновление схемы
    }
}
