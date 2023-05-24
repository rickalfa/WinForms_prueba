using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_prueba.controllers
{
    abstract class Controller
    {

        abstract public ArrayList get(int _id = 0);

        abstract public void create(List<Object> ListDates);

        abstract public void delete(int _id);

        abstract public void update(int _id);





    }

}
