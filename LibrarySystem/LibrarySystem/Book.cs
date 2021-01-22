using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Book
    {

        int id;
        string name;
        string author;
        string link;


        public int ID
        {
            get { return id; }
            set { id = value; }
           
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }

        }
        public string AUTHOR
        {
            get { return author; }
            set { author = value; }

        }
        public string LINK
        {
            get { return link; }
            set { link = value; }

        }
    }
}
