using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaRegister_TE.Models
{
    class Movie : Media
    {
        private string _director;
        private int _length;

        public Movie(string title, string director, int lenght)
        {
            _director = director;
            _length = lenght;
            _title = title;           
        }

        public override string ToString()
        {
            return $"{_title} ({_director}, {_length} minuter)";
        }
    }
}
