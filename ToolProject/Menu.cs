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
        private List<SpriteForm> forms;
        //private MapForm mapWind;
        //private CollisionForm colWind;

        public Menu() {
            InitializeComponent();

            //Set up inner windows 
            forms = new List<SpriteForm>();
            
        }

        private void quitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void spriteMenuBttn_Click(object sender, EventArgs e) {
            SpriteForm newForm = new SpriteForm();
         

            newForm.StartPosition = FormStartPosition.Manual;
            newForm.MdiParent = this;
            forms.Add(newForm);
            newForm.Show();
        }

        private void spriteThingToolStripMenuItem_Click(object sender, EventArgs e) {
            SpriteForm newForm = new SpriteForm();

            newForm.StartPosition = FormStartPosition.Manual;
            newForm.MdiParent = this;
            newForm.Show();
            forms.Add(newForm);
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

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            //DO LOAD BY FILE XML AND ALL THAT MAKE NEW WINDOW WITH FILE 
 //  //  // // // //SELECT FILE
            spriteMenuBttn_Click(sender, e);//Make new form
            SpriteForm activeNew = this.ActiveMdiChild as SpriteForm;
            if(activeNew != null) {
                activeNew.loadBtn("SheetName");
            }
        }

        private void windowToolStripMenuItem_DropDownOpening(object sender, EventArgs e) {
            //Updates names of drop down when clicked (Does do it after click
            //Starts at 4 due to existing menu items + space line thing
            for(int i = 4; i < windowToolStripMenuItem.DropDownItems.Count; i++) {
                if(i == 13) {
                    windowToolStripMenuItem.DropDownItems[i].Text = "Other Forms";
                } else if(forms[i-4].Text == "New Sprite Form") {
                    windowToolStripMenuItem.DropDownItems[i].Text = "New Sprite Form";
                } else {
                   windowToolStripMenuItem.DropDownItems[i].Text = forms[i-4].Text;
                }
                
            }
            
            
        }
    }
}
