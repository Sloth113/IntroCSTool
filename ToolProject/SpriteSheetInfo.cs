using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public struct Vector2 {
    public int x, y;
}

public struct CircleCollider {
    public Vector2 pos;
    public float radi;
}

namespace ToolProject {

    public class SpriteSheetInfo {
        public List<SpriteInfo> _information;//List of sprite objects 
        public string _sheetName;//Name of sheet "title"
        public string _sheetPath;//Name of file path
        
        public SpriteSheetInfo() {

            _sheetName = "SheetName";
            _sheetPath = "\\Path something.jpg";
            _information = new List<SpriteInfo>();
        }
        public void Serialize() {
            XmlSerializer mySerializer = new XmlSerializer(typeof(SpriteSheetInfo));
            StreamWriter streamWriter = new StreamWriter(_sheetName + ".xml");
            mySerializer.Serialize(streamWriter, this);
            streamWriter.Close();
        }
        public static SpriteSheetInfo Deserialize(string path) {
            //From file //Add checks to see if it exists and all that stuff
            XmlSerializer mySerializer = new XmlSerializer(typeof(SpriteSheetInfo));
            StreamReader streamReader = new StreamReader(path + ".xml");
            SpriteSheetInfo dataObj = mySerializer.Deserialize(streamReader) as SpriteSheetInfo;
            streamReader.Close();
            return dataObj;
        }
    }
    public class SpriteInfo {
        public string _name;
        public Vector2 _pos; //Top left position on the sprite sheet;
        public Vector2 _size; //Size of the sprite
        public CircleCollider largeCollider;//One that is over everything //Position will be relative to the sprites pos
        public List<CircleCollider> smallColliders;//Colliders that make up the object

        public SpriteInfo() {
            _name = "Test";
            _pos.x = 0;
            _pos.y = 0;
            _size.x = 0;
            _size.y = 0;
            largeCollider.pos.x = 0;
            largeCollider.pos.y = 0;
            largeCollider.radi = 0;
            smallColliders = new List<CircleCollider>();
            CircleCollider c = new CircleCollider();
            c.pos.x = 0;
            c.pos.y = 0;
            c.radi = 0;
            smallColliders.Add(c);
        }


    }
}
