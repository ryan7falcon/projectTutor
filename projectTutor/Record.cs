using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    //an abstract class for use in DBConnector
    abstract class Record
    {
        //used when updating and inserting records in DB
        public abstract string[] getParameters();
        public abstract string[] getParameterNames();
    }
}
