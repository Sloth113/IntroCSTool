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
        public SpriteForm() {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e) {
            spriteSheet = new SpriteSheetInfo() ;
            spriteSheet.Serialize();
            
        }
    }
}
