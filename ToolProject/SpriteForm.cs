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
            for(int i = (int)xOffset.Value; i < pictureBox1.Size.Width - gridBoxX.Value; i += (int)gridBoxX.Value + (int)xOffset.Value ) {
                for(int j = (int)yOffset.Value; j < pictureBox1.Size.Height - gridBoxY.Value; j += (int)gridBoxY.Value +(int)yOffset.Value) {
                    SpriteInfo newSprite = new SpriteInfo();
                    newSprite._pos.x = i;
                    newSprite._pos.y = j;
                    newSprite._size.x = (int)gridBoxX.Value;
                    newSprite._size.y = (int)gridBoxY.Value;

                    spriteSheet._information.Add(newSprite);
                }
            }
            pictureBox1.Refresh();
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
            }
            foreach (SpriteInfo s in spriteSheet._information) {
                if(s._pos.x < click.X && s._pos.y < click.Y && (s._pos.x + s._size.x) > click.X  && (s._pos.y + s._size.y) > click.Y) {
                    selected = s;
                }
            }
            pictureBox1.Refresh();
            Invalidate();

        }
    }
}
