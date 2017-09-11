using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolProject {
    public partial class SpriteForm : Form {
        SpriteSheetInfo spriteSheet;
        SpriteInfo selected;
        Vector2 selectPos;
        public SpriteForm() {
            spriteSheet = new SpriteSheetInfo();
            InitializeComponent();
        }

        public void testBtn_Click(object sender, EventArgs e) {
            
            spriteSheet.Serialize();
            
        }

        private void gridButton_Click(object sender, EventArgs e) {
            
            //clear so no overloading 
            spriteSheet._information.Clear();
            for (int j = (int)yOffset.Value; j < spriteSheetBox.Size.Height - gridBoxY.Value; j += (int)gridBoxY.Value + (int)yOffset.Value) {
                for (int i = (int)xOffset.Value; i < spriteSheetBox.Size.Width - gridBoxX.Value; i += (int)gridBoxX.Value + (int)xOffset.Value ) {
               
                    SpriteInfo newSprite = new SpriteInfo();
                    newSprite._pos.x = i;
                    newSprite._pos.y = j;
                    newSprite._size.x = (int)gridBoxX.Value;
                    newSprite._size.y = (int)gridBoxY.Value;
                    if(spriteSheetText.Text != "")
                        newSprite._name = spriteSheetText.Text + "_"+ spriteSheet._information.Count;

                    else
                    newSprite._name = "Test_" + spriteSheet._information.Count;


                    spriteSheet._information.Add(newSprite);
                }
            }
            spriteSheetBox.Refresh();
            Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen = new Pen(Color.Red, 2);

            foreach (SpriteInfo s in spriteSheet._information) {
                // Create rectangle.
                
                Rectangle rect = new Rectangle(s._pos.x, s._pos.y, s._size.x, s._size.y);

                // Draw rectangle to screen.
                if (selected == s)
                    e.Graphics.DrawRectangle(redPen, rect);
                else
                    e.Graphics.DrawRectangle(blackPen, rect);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            Point click = new Point(0,0);
            

            if (e.GetType() == typeof(MouseEventArgs)) {
                MouseEventArgs me = e as MouseEventArgs;
                click = me.Location;
                
                foreach (SpriteInfo s in spriteSheet._information) {
                    if (s._pos.x < click.X && s._pos.y < click.Y && (s._pos.x + s._size.x) > click.X && (s._pos.y + s._size.y) > click.Y) {
                        if (selected == null) {
                            selected = s;
                            //Set on screen elements
                            currentPosX.Value = selected._pos.x;
                            currentPosY.Value = selected._pos.y;
                            currentSizeX.Value = selected._size.x;
                            currentSizeY.Value = selected._size.y;
                            spriteNameText.Text = selected._name;
                            //Pos
                            selectPos.x = click.X - selected._pos.x;
                            selectPos.y = click.Y - selected._pos.y;

                        }else if (selected == s) {
                            //Deselect
                            selected = null;
                        }
                       
                    }
                }

            }
            label1.Focus();//Force focus off buttons 
            //Refresh screen
            spriteSheetBox.Refresh();
            Invalidate();

        }

        private void SpriteForm_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void SpriteForm_KeyDown(object sender, KeyEventArgs e) {
            //Delete key press to delete
            if (e.KeyCode == Keys.Delete && selected != null) {
                spriteSheet._information.Remove(selected);
                selected = null;

            }
            //Space key press to select/deselect
            if(e.KeyCode == Keys.Space && !spriteNameText.Focused && selected != null) {
                selected = null;
            }


            spriteSheetBox.Refresh();

        }

        //Update current box 
        private void currentPosX_ValueChanged(object sender, EventArgs e) {
            if(selected != null) {
                selected._pos.x = (int)currentPosX.Value;
                spriteSheetBox.Refresh();
            }
        }

        private void currentPosY_ValueChanged(object sender, EventArgs e) {
            if (selected != null) {
                selected._pos.y = (int)currentPosY.Value;
                spriteSheetBox.Refresh();
            }
        }

        private void currentSizeX_ValueChanged(object sender, EventArgs e) {
            if (selected != null) {
                selected._size.x = (int)currentSizeX.Value;
                spriteSheetBox.Refresh();
            }
        }

        private void currentSizeY_ValueChanged(object sender, EventArgs e) {
            if (selected != null) {
                selected._size.y = (int)currentSizeY.Value;
                spriteSheetBox.Refresh();
            }
        }

        private void spriteSheetBox_MouseDown(object sender, MouseEventArgs e) {
            //Something selected and still within bounds reset offset
            if (selected != null && selected._pos.x < e.X && selected._pos.y < e.Y && (selected._pos.x + selected._size.x) > e.X && (selected._pos.y + selected._size.y) > e.Y) {
                //Set off set
                selectPos.x = e.X - selected._pos.x;
                selectPos.y = e.Y - selected._pos.y;
            } else {
                selected = null;
            }
        }

        private void spriteSheetBox_MouseMove(object sender, MouseEventArgs e) {
            //Something selected and mouse button is down
            if (selected != null && e.Button == MouseButtons.Left) {
                    //Move
                    selected._pos.x = e.X - selectPos.x;
                    selected._pos.y = e.Y - selectPos.y;
                    spriteSheetBox.Refresh();
            }
        }

        private void spriteNameText_TextChanged(object sender, EventArgs e) {
            if(selected != null) {
                selected._name = spriteNameText.Text;
            }
        }
    }
}
