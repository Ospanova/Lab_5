using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    [Serializable]
        public class Base
        {
            public List<Point> body = new List<Point>();
            public char sign;
            public ConsoleColor color;
            public Base()
            {

            }
            public void draw()
            {

                for (int i = 0; i < body.Count; ++i)
                {
                    Console.SetCursorPosition(body[i].x, body[i].y);//устанавлмвает положение курсора
                    Console.ForegroundColor = color;
                    Console.Write(sign);
                }
            }

            public void Load()
            {
                Base result = null;

                string fname = this.GetType().Name;
                BinaryFormatter xs = new BinaryFormatter();
                using (FileStream fs = new FileStream(string.Format("{0}.bin", fname), FileMode.Open, FileAccess.Read))
                {
                    result = xs.Deserialize(fs) as Base;
                }
                this.body = result.body;
                this.color = result.color;
                this.sign = result.sign;
            }

            public void Save()
            {
                string fname = this.GetType().Name;
                BinaryFormatter xs = new BinaryFormatter();
                using (FileStream fs = new FileStream(string.Format("{0}.bin", fname), FileMode.OpenOrCreate, FileAccess.Write))
                {
                    xs.Serialize(fs, this);
                }
            }
        }

    }
