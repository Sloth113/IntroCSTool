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
    public partial class Menu : Form {
        private SpriteForm spriteWind;
        //private MapForm mapWind;
        //private CollisionForm colWind;

        public Menu() {
            InitializeComponent();

            //Set up inner windows 
            spriteWind = new SpriteForm();

            spriteWind.MdiParent = this;
        }

        private void quitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void spriteMenuBttn_Click(object sender, EventArgs e) {

            spriteWind.Show();
        }

        private void spriteThingToolStripMenuItem_Click(object sender, EventArgs e) {

            spriteWind.Show();
        }

        private void mapMenuBttn_Click(object sender, EventArgs e) {

        }

        private void collisionMenuBttn_Click(object sender, EventArgs e) {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

        SpriteForm activeChild = this.ActiveMdiChild as SpriteForm;
            if (activeChild != null) {
                if (activeChild.GetType() == typeof(SpriteForm)) 
                    {
                    // Cast the activeChild and call the appropriate function here .
                    activeChild.testBtn_Click(sender, e);
                }
            }
           
                   
        }
    }
}
