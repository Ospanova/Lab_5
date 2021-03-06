﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    
        [Serializable]
        public class Wall : Base
        {
            public Wall()
            {

            }
            public Wall(int level)
            {
                string filename = string.Format(@"level{0}.txt", level);
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                color = ConsoleColor.DarkBlue;
                sign = '#';

                string line = "";

                int row = 0;

                while ((line = sr.ReadLine()) != null)
                {

                    for (int col = 0; col < line.Length; col++)
                    {
                        if (line[col] == '#')
                        {
                            body.Add(new Point(col, row));
                        }
                    }

                    row++;
                }
            }


        }
    }
