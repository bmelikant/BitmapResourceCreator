using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapResourceCreator
{
    public partial class Form1 : Form
    {
        /** private member variables */
        private int fontPixelsX = 10;           // font is 8 pixels wide with 2 pixels of padding space
        private int fontPixelsY = 14;           // font is 12 pixels high with 2 pixels padding space
        private int characterSetSize = 128;     // there are 128 characters in the initial set (assumes ASCII)

        private List<CheckBox> cb_designerCheckBoxes;   // the checkbox controls for designing the font
        private List<int[]> characterValues;            // the bitmap data stored as a list of int ptrs

        public Form1()
        {
            InitializeComponent();
            createCheckBoxControls();
            resizePreviewBox();
            resizeFontMapPreviewBox();
            createCharacterValueArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /**
         * @fn createCheckBoxControls()
         * This function will create a series of button-style checkboxes in the design group box
         * 
         */
        private void createCheckBoxControls() {
            Point currentLocation = new Point(10,20);
            cb_designerCheckBoxes = new List<CheckBox>();

            // create combo box rows
            for (int i = 0; i < fontPixelsY; i++) {
                for (int j = 0; j < fontPixelsX; j++) {
                    CheckBox newBox = new CheckBox {
                        Size = new Size(10, 10),
                        Location = new Point(currentLocation.X, currentLocation.Y),
                        Appearance = Appearance.Button
                    };

                    newBox.CheckedChanged += gb_characterSelectBoxChanged;
                    gb_characterSelectBox.Controls.Add(newBox);
                    cb_designerCheckBoxes.Add(newBox);

                    currentLocation.X += 11;
                }

                currentLocation.X = 10;
                currentLocation.Y += 11;
            }

            // resize the group box
        }

        private void resizeSelectGroupBox() {
            // compute the number of pixels wide and high

        }

        private void resizeFontMapPreviewBox() {
            int widthMultiplier = 30;   // 30 chars wide
            int heightMultiplier = (characterSetSize / widthMultiplier) + 1;

            pb_fontMapPreview.Size = new Size {
                Width = (fontPixelsX * 2) * widthMultiplier,
                Height = (fontPixelsY * 2) * heightMultiplier
            };

            Bitmap b = new Bitmap(pb_fontMapPreview.Width, pb_fontMapPreview.Height);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.Black);

            pb_fontMapPreview.Image = b;
        }

        private void resizePreviewBox() {
            // compute the width and height of the preview and clear the bitmap
            pb_previewBox.Size = new Size {
                Width = fontPixelsX * 10,
                Height = fontPixelsY * 10
            };

            Bitmap testBmp = new Bitmap(pb_previewBox.Size.Width, pb_previewBox.Size.Height);
            Graphics g = Graphics.FromImage(testBmp);
            g.Clear(Color.Black);

            pb_previewBox.Image = testBmp;
        }

        private void drawPreviewBox() {
            Bitmap b = (Bitmap) pb_previewBox.Image;
            Graphics g = Graphics.FromImage(b);

            // read each line of the select boxes, set preview accordingly. Each preview 'pixel' is 10 pixels square
            for (int i = 0; i < fontPixelsY; i++) {
                for (int j = 0; j < fontPixelsX; j++) {
                    CheckBox currentElement = cb_designerCheckBoxes.ElementAt(i*fontPixelsX+j);
                    // draw a white square here!
                    Rectangle r = new Rectangle {
                        X = j*10,
                        Y = i*10,
                        Width = 10,
                        Height = 10
                    };

                    Pen p = Pens.Black;
                    if (currentElement.Checked) {
                        p = Pens.White;
                    }

                    g.FillRectangle(p.Brush, r);
                }
            }

            pb_previewBox.Image = b;
        }

        /**
         * @fn gb_characterSelectBoxChanged(object sender, EventArgs e)
         * This function will update the background color of the check box when selected
         */
        private void gb_characterSelectBoxChanged(object sender, EventArgs e) {
            CheckBox senderObject = (CheckBox) sender;
            if (senderObject.Checked) {
                senderObject.BackColor = Color.Black;
            } else {
                senderObject.BackColor = System.Drawing.SystemColors.Control;
            }

            /** draw the current preview */
            drawPreviewBox();
        }

        private void btn_clearSelectBoxes(object sender, EventArgs e) {
            foreach (CheckBox c in cb_designerCheckBoxes) {
                c.Checked = false;
            }
            drawPreviewBox();
        }

        private void btn_invertSelection(object sender, EventArgs e) {
            foreach (CheckBox c in cb_designerCheckBoxes) {
                if (c.Checked) {
                    c.Checked = false;
                } else {
                    c.Checked = true;
                }
            }
            drawPreviewBox();
        }

        private void btn_addCharacterClicked(object sender, EventArgs e) {
            int index = (int) nud_indexUpDown.Value;
            int [] charData = new int[fontPixelsY];
            // copy in each pixel from each row of the character
            for (int i = 0; i < fontPixelsY; i++) {
                int rowData = 0;
                int top = fontPixelsX - 1;

                for (int j = 0; j < fontPixelsX; j++) {
                    int cbIndex = (i*fontPixelsX)+top;
                    if (cb_designerCheckBoxes.ElementAt(cbIndex).Checked) {
                        rowData |= (1 << j);
                    }
                    top--;
                }
                charData[i] = rowData;
            }
            characterValues[index] = charData;
            drawFontMapPreviewBox();
        }

        private void createCharacterValueArray() {
            characterValues = new List<int[]>(characterSetSize);
            // initialize each array
            for (int i = 0; i < characterSetSize; i++) {
                characterValues.Insert(i, new int[fontPixelsY]);
            }
        }

        private void drawFontMapPreviewBox() {
            // draw each character in the current map
            Bitmap b = (Bitmap) pb_fontMapPreview.Image;
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.Black);

            Rectangle r = new Rectangle(0,0,4,4);

            /** draw each character */
            foreach (int[] charData in characterValues) {
                /** draw each row of character data */
                for (int i = 0; i < fontPixelsY; i++) {
                    int rowDefinition = charData[i];
                    /** draw each x pixel */
                    for (int j = fontPixelsX-1; j >= 0; j--) {
                        if ((rowDefinition & (1 << j)) > 0) {
                            g.FillRectangle(Pens.White.Brush, r);
                        }
                        r.X += 2;
                    }
                    r.X = 0;
                    r.Y += 2;
                }
            }

            pb_fontMapPreview.Image = b;
        }
    }
}
