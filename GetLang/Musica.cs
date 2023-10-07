using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLang
{
  
public class Musica
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string nomeMusica { get; set; }
        public string letraMusica { get; set; }
    }

}


